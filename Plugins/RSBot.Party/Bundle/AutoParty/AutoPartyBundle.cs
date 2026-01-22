using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Party;
using RSBot.Core.Objects.Spawn;
using RSBot.Party.Bundle.PartyMatching.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RSBot.Party.Bundle.AutoParty;

internal class AutoPartyBundle
{
    #region Constants

    private const int TickIntervalMs = 5000;
    private const int PartyListRefreshMs = 60000;
    private const int MaxDistanceFromCenter = 50;
    private const int FullPartyLimit = 8;
    private const int NoSharePartyLimit = 4;
    private const int InitialCacheCapacity = 64;
    private const int MaxPages = 50;

    #endregion

    #region Fields

    private int _lastPartyListingCacheTick;
    private int _lastTick;
    private List<PartyEntry> _partyEntriesCache = new(InitialCacheCapacity);
    private bool _initialized;
    private string _lastCharacterName;  // ✅ لتتبع تغيير الشخصية

    #endregion

    #region Properties

    public AutoPartyConfig Config { get; private set; }

    #endregion

    #region Constructor

    public AutoPartyBundle()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        EventManager.SubscribeEvent("OnTick", OnTick);

        // أول دخول
        EventManager.SubscribeEvent("OnEnterGame", OnEnterGame);
        EventManager.SubscribeEvent("OnLoadCharacter", OnEnterGame);
        EventManager.SubscribeEvent("OnAgentServerConnected", OnEnterGame);

        // ✅ لما اللعبة تقفل وتفتح تاني
        EventManager.SubscribeEvent("OnCharacterSpawn", OnEnterGame);
        EventManager.SubscribeEvent("OnStartBot", OnStartBot);
    }

    #endregion

    #region Event Handlers

    private void OnEnterGame()
    {
        ResetAndRefresh();
    }

    private void OnStartBot()
    {
        // ✅ لما البوت يبدأ، نعمل refresh
        ResetAndRefresh();
    }

    private void ResetAndRefresh()
    {
        _initialized = false;
        _lastTick = 0;
        _lastPartyListingCacheTick = 0;
        _partyEntriesCache.Clear();

        Refresh();

        _initialized = true;
    }

    public void OnTick()
    {
        // ✅ تحقق إضافي: لو الشخصية اتغيرت، اعمل refresh
        CheckCharacterChange();

        if (Config == null || !_initialized)
        {
            Refresh();
            _initialized = true;
        }

        var elapsed = Kernel.TickCount - _lastTick;
        if (elapsed <= TickIntervalMs)
            return;

        try
        {
            CheckForAutoPartyJoin();
            CheckForPlayers();
        }
        catch (Exception ex)
        {
            Log.Error($"[AutoParty] Error in OnTick: {ex.Message}");
        }
        finally
        {
            _lastTick = Kernel.TickCount;
        }
    }

    /// <summary>
    ///     تحقق لو الشخصية اتغيرت (اللعبة قفلت وفتحت)
    /// </summary>
    private void CheckCharacterChange()
    {
        try
        {
            if (Game.Player == null)
            {
                // اللعبة مش شغالة
                _lastCharacterName = null;
                _initialized = false;
                return;
            }

            var currentName = Game.Player.Name;

            // لو الاسم اتغير أو كان null وبقى في اسم
            if (_lastCharacterName != currentName)
            {
                if (!string.IsNullOrEmpty(currentName))
                {
                    Log.Debug($"[AutoParty] Character changed/loaded: {currentName}");
                    ResetAndRefresh();
                }
                _lastCharacterName = currentName;
            }
        }
        catch
        {
            // تجاهل الأخطاء
        }
    }

    #endregion

    #region Public Methods

    public void Refresh()
    {
        try
        {
            Config = new AutoPartyConfig
            {
                PlayerList = PlayerConfig.GetArray<string>("RSBot.Party.AutoPartyList")
                             ?? Array.Empty<string>(),
                InviteAll = PlayerConfig.Get<bool>("RSBot.Party.InviteAll"),
                AcceptAll = PlayerConfig.Get<bool>("RSBot.Party.AcceptAll"),
                AcceptFromList = PlayerConfig.Get<bool>("RSBot.Party.AcceptList"),
                InviteFromList = PlayerConfig.Get<bool>("RSBot.Party.InviteList"),
                OnlyAtTrainingPlace = PlayerConfig.Get<bool>("RSBot.Party.AtTrainingPlace"),
                ExperienceAutoShare = PlayerConfig.Get<bool>("RSBot.Party.EXPAutoShare", true),
                ItemAutoShare = PlayerConfig.Get<bool>("RSBot.Party.ItemAutoShare", true),
                AllowInvitations = PlayerConfig.Get<bool>("RSBot.Party.AllowInvitations", true),
                AcceptIfBotIsStopped = PlayerConfig.Get<bool>("RSBot.Party.AcceptIfBotStopped"),
                LeaveIfMasterNot = PlayerConfig.Get<bool>("RSBot.Party.LeaveIfMasterNot"),
                LeaveIfMasterNotName = PlayerConfig.Get<string>("RSBot.Party.LeaveIfMasterNotName")
                                       ?? string.Empty,
                CenterPosition = GetCenterPosition(),
                AutoJoinByName = PlayerConfig.Get("RSBot.Party.AutoJoin.ByName", false),
                AutoJoinByTitle = PlayerConfig.Get("RSBot.Party.AutoJoin.ByTitle", false),
                AutoJoinByNameContent = PlayerConfig.Get("RSBot.Party.AutoJoin.Name", string.Empty)
                                        ?? string.Empty,
                AutoJoinByTitleContent = PlayerConfig.Get("RSBot.Party.AutoJoin.Title", string.Empty)
                                         ?? string.Empty,
                AlwaysFollowThePartyMaster = PlayerConfig.Get("RSBot.Party.AlwaysFollowPartyMaster", false)
            };

            if (!Game.Party.IsInParty)
            {
                Game.Party.Settings = new PartySettings(
                    Config.ExperienceAutoShare,
                    Config.ItemAutoShare,
                    Config.AllowInvitations);
            }

            Log.Debug("[AutoParty] Configuration refreshed");
        }
        catch (Exception ex)
        {
            Log.Error($"[AutoParty] Failed to load configuration: {ex.Message}");
            Config = new AutoPartyConfig();
        }
    }

    private Position GetCenterPosition()
    {
        try
        {
            if (Kernel.Bot == null || Kernel.Bot.Botbase == null)
                return default;

            return Kernel.Bot.Botbase.Area.Position;
        }
        catch
        {
            return default;
        }
    }

    #endregion

    #region Auto Party Join

    private void CheckForAutoPartyJoin()
    {
        if (Game.Party.IsInParty)
            return;

        if (!Config.AutoJoinByName && !Config.AutoJoinByTitle)
            return;

        RefreshPartyListCacheIfNeeded();

        if (_partyEntriesCache == null || _partyEntriesCache.Count == 0)
            return;

        if (TryJoinByName())
            return;

        TryJoinByTitle();
    }

    private void RefreshPartyListCacheIfNeeded()
    {
        var elapsed = Kernel.TickCount - _lastPartyListingCacheTick;

        if (elapsed < PartyListRefreshMs && _partyEntriesCache.Count > 0)
            return;

        try
        {
            _partyEntriesCache = new List<PartyEntry>(InitialCacheCapacity);

            byte page = 0;
            while (page < MaxPages)
            {
                var currentPage = Container.PartyMatching.RequestPartyList(page);

                if (currentPage == null || currentPage.Parties == null || currentPage.Parties.Count == 0)
                    break;

                _partyEntriesCache.AddRange(currentPage.Parties);

                if (currentPage.Page >= currentPage.PageCount - 1)
                    break;

                page++;
            }
        }
        catch (Exception ex)
        {
            Log.Error($"[AutoParty] Failed to refresh party list: {ex.Message}");
        }
        finally
        {
            _lastPartyListingCacheTick = Kernel.TickCount;
        }
    }

    private bool TryJoinByName()
    {
        if (!Config.AutoJoinByName || string.IsNullOrWhiteSpace(Config.AutoJoinByNameContent))
            return false;

        var partyEntry = _partyEntriesCache.Find(p =>
            string.Equals(p.Leader, Config.AutoJoinByNameContent, StringComparison.OrdinalIgnoreCase));

        if (partyEntry == null)
            return false;

        return Container.PartyMatching.Join(partyEntry.Id);
    }

    private bool TryJoinByTitle()
    {
        if (!Config.AutoJoinByTitle || string.IsNullOrWhiteSpace(Config.AutoJoinByTitleContent))
            return false;

        var partyEntry = _partyEntriesCache.Find(p =>
            p.Title != null && p.Title.Contains(Config.AutoJoinByTitleContent, StringComparison.CurrentCultureIgnoreCase));

        if (partyEntry == null)
            return false;

        return Container.PartyMatching.Join(partyEntry.Id);
    }

    #endregion

    #region Player Invitation

    public void CheckForPlayers()
    {
        CheckAndLeaveIfNeeded();

        if (!CanInvitePlayers())
            return;

        if (!SpawnManager.TryGetEntities<SpawnedPlayer>(out var players) || players == null)
            return;

        InvitePlayers(players);
    }

    private void CheckAndLeaveIfNeeded()
    {
        if (!Game.Party.IsInParty)
            return;

        if (Game.Party.IsLeader)
            return;

        if (!Config.LeaveIfMasterNot)
            return;

        if (string.IsNullOrWhiteSpace(Config.LeaveIfMasterNotName))
            return;

        if (Game.Party.Leader == null)
            return;

        var leaderName = Game.Party.Leader.Name;
        if (string.IsNullOrWhiteSpace(leaderName))
            return;

        if (!string.Equals(Config.LeaveIfMasterNotName, leaderName, StringComparison.OrdinalIgnoreCase))
        {
            Game.Party.Leave();
        }
    }

    private bool CanInvitePlayers()
    {
        if (!Game.Party.CanInvite)
            return false;

        var limit = GetPartyLimit();

        var memberCount = Game.Party.Members?.Count ?? 0;
        if (memberCount >= limit)
            return false;

        if (!Config.OnlyAtTrainingPlace)
            return true;

        if (!IsValidPosition(Config.CenterPosition))
            return true;

        if (Game.Player == null)
            return false;

        try
        {
            var currentPosition = Game.Player.Movement.Source;
            var distance = currentPosition.DistanceTo(Config.CenterPosition);
            return distance <= MaxDistanceFromCenter;
        }
        catch
        {
            return false;
        }
    }

    private bool IsValidPosition(Position position)
    {
        return position.X != 0 || position.Y != 0;
    }

    private int GetPartyLimit()
    {
        var hasSharing = Game.Party.Settings.ExperienceAutoShare || Game.Party.Settings.ItemAutoShare;
        return hasSharing ? FullPartyLimit : NoSharePartyLimit;
    }

    private void InvitePlayers(IEnumerable<SpawnedPlayer> players)
    {
        if (!Config.InviteAll && !Config.InviteFromList)
            return;

        foreach (var player in players)
        {
            if (player == null)
                continue;

            if (string.IsNullOrWhiteSpace(player.Name))
                continue;

            if (Game.Party.IsInParty && Game.Party.GetMemberByName(player.Name) != null)
                continue;

            if (Config.InviteAll)
            {
                Game.Party.Invite(player.UniqueId);
                continue;
            }

            if (Config.InviteFromList && IsPlayerInList(player.Name))
            {
                Game.Party.Invite(player.UniqueId);
            }
        }
    }

    private bool IsPlayerInList(string playerName)
    {
        if (Config.PlayerList == null || Config.PlayerList.Length == 0)
            return false;

        return Config.PlayerList.Any(name =>
            string.Equals(name, playerName, StringComparison.OrdinalIgnoreCase));
    }

    #endregion
}
