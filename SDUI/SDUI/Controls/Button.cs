using SDUI.Animation;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SDUI.Controls;

public class Button : System.Windows.Forms.Button
{
    /// <summary>
    /// Button raised color (تم تعيين اللون الأحمر كلون افتراضي)
    /// </summary>
    public Color Color { get; set; } = Color.FromArgb(231, 76, 60); // لون أحمر حديث (Flat Red)

    /// <summary>
    /// Mouse state
    /// </summary>
    private int _mouseState = 0;

    private SizeF textSize;
    public override string Text
    {
        get { return base.Text; }
        set
        {
            base.Text = value;
            textSize = TextRenderer.MeasureText(value, Font);
            if (AutoSize)
                Size = GetPreferredSize();
            Invalidate();
        }
    }

    private float _shadowDepth = 6f;
    public float ShadowDepth
    {
        get => _shadowDepth;
        set
        {
            if (_shadowDepth == value)
                return;

            _shadowDepth = value;
            Invalidate();
        }
    }

    private int _radius = 12;
    public int Radius
    {
        get => _radius;
        set
        {
            if (_radius == value)
                return;

            _radius = value;
            Invalidate();
        }
    }

    // Gradient Background
    private bool _useGradient = false;
    public bool UseGradient
    {
        get => _useGradient;
        set
        {
            _useGradient = value;
            Invalidate();
        }
    }

    // لون الـ Gradient الثاني
    private Color _gradientColor = Color.Empty;
    public Color GradientColor
    {
        get => _gradientColor;
        set
        {
            _gradientColor = value;
            Invalidate();
        }
    }

    // زاوية الـ Gradient
    private float _gradientAngle = 45f;
    public float GradientAngle
    {
        get => _gradientAngle;
        set
        {
            _gradientAngle = value;
            Invalidate();
        }
    }

    // Border Width
    private float _borderWidth = 0f;
    public float BorderWidth
    {
        get => _borderWidth;
        set
        {
            _borderWidth = value;
            Invalidate();
        }
    }

    // Border Color مخصص
    private Color _customBorderColor = Color.Empty;
    public Color CustomBorderColor
    {
        get => _customBorderColor;
        set
        {
            _customBorderColor = value;
            Invalidate();
        }
    }

    private readonly Animation.AnimationEngine animationManager;
    private readonly Animation.AnimationEngine hoverAnimationManager;

    public Button()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);

        // جعل النص أبيض تلقائياً ليناسب الخلفية الحمراء
        ForeColor = Color.White;

        animationManager = new Animation.AnimationEngine(false)
        {
            Increment = 0.05,
            AnimationType = AnimationType.EaseOut
        };

        hoverAnimationManager = new Animation.AnimationEngine
        {
            Increment = 0.12,
            AnimationType = AnimationType.EaseInOut,
        };

        hoverAnimationManager.OnAnimationFinished += (sender) =>
        {
        };
        hoverAnimationManager.OnAnimationProgress += sender => Invalidate();

        animationManager.OnAnimationProgress += sender => Invalidate();
        UpdateStyles();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _mouseState = 2;
        animationManager.StartNewAnimation(AnimationDirection.In, e.Location);
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _mouseState = 1;
        Invalidate();
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _mouseState = 1;
        hoverAnimationManager.StartNewAnimation(AnimationDirection.In);
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);

        _mouseState = 0;
        hoverAnimationManager.StartNewAnimation(AnimationDirection.Out);
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        ButtonRenderer.DrawParentBackground(graphics, ClientRectangle, this);

        var rectf = ClientRectangle.ToRectangleF();

        if (ColorScheme.DrawDebugBorders)
        {
            var redPen = new Pen(Color.Red, 1);
            redPen.Alignment = PenAlignment.Outset;
            graphics.DrawRectangle(redPen, 0, 0, rectf.Width - 1, rectf.Height - 1);
        }

        var inflate = _shadowDepth / 4f;
        rectf.Inflate(-inflate, -inflate);

        var color = Color.Empty;
        // هنا سيعتمد على اللون الأحمر الافتراضي إذا لم يتم تغييره
        if (Color != Color.Transparent)
            color = Enabled ? Color : Color.Alpha(200);
        else
            color = ColorScheme.ForeColor.Alpha(20);

        using (var path = rectf.Radius(_radius))
        {
            // رسم الخلفية (عادي أو Gradient)
            if (_useGradient && _gradientColor != Color.Empty && Color != Color.Transparent)
            {
                var gradientRect = new Rectangle((int)rectf.X, (int)rectf.Y, (int)rectf.Width, (int)rectf.Height);
                using var gradientBrush = new LinearGradientBrush(
                    gradientRect,
                    color,
                    _gradientColor,
                    _gradientAngle
                );
                graphics.FillPath(gradientBrush, path);
            }
            else
            {
                using var brush = new SolidBrush(color);
                graphics.FillPath(brush, path);
            }

            // رسم الـ Border
            if (_borderWidth > 0)
            {
                var borderColor = _customBorderColor != Color.Empty ? _customBorderColor : ColorScheme.BorderColor;
                using var borderPen = new Pen(borderColor, _borderWidth);
                graphics.DrawPath(borderPen, path);
            }
            else if (Color == Color.Transparent)
            {
                using var outerPen = new Pen(ColorScheme.BorderColor);
                graphics.DrawPath(outerPen, path);
            }

            // Hover effect
            var animationColor = Color.Transparent;
            if (Color != Color.Transparent)
                // جعلنا الـ Hover أبيض شفاف ليقوم بتفتيح اللون الأحمر قليلاً عند المرور
                animationColor = Color.FromArgb((int)(hoverAnimationManager.GetProgress() * 60), Color.White);
            else
                animationColor = Color.FromArgb((int)(hoverAnimationManager.GetProgress() * color.A), color);

            using var hoverBrush = new SolidBrush(animationColor);
            graphics.FillPath(hoverBrush, path);

            // Shadow
            graphics.DrawShadow(rectf, _shadowDepth, _radius);

            // Ripple effect
            if (animationManager.IsAnimating())
            {
                var mode = graphics.SmoothingMode;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                for (int i = 0; i < animationManager.GetAnimationCount(); i++)
                {
                    var animationValue = animationManager.GetProgress(i);
                    var animationSource = animationManager.GetSource(i);

                    // Ripple أبيض شفاف
                    using var rippleBrush = new SolidBrush(Color.White.Alpha((int)(120 - (animationValue * 120))));
                    var rippleSize = (float)(animationValue * Width * 2.0);

                    var rippleRect = new RectangleF(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize);
                    path.AddEllipse(rippleRect);
                    graphics.FillPath(rippleBrush, path);
                }
                graphics.SmoothingMode = mode;
            }
        }

        // تحديد لون النص (أبيض إذا كان الزر ملوناً، ورمادي إذا كان معطلاً)
        var foreColor = ForeColor; 
        
        // إذا كان اللون شفاف نستخدم لون الثيم، غير ذلك نستخدم الـ ForeColor الأبيض اللي حددناه
        if (Color == Color.Transparent) foreColor = ColorScheme.ForeColor;

        if (!Enabled)
            foreColor = Color.Gray;

        var textRect = rectf.ToRectangle();
        if (Image != null)
        {
            Rectangle imageRect = new Rectangle(8, 6, 24, 24);

            if (string.IsNullOrEmpty(Text))
                imageRect.X += 2;

            if (Image != null)
                graphics.DrawImage(Image, imageRect);

            textRect.Width -= 8 + 24 + 4 + 8;
            textRect.X += 8 + 24 + 4;
        }

        this.DrawString(graphics, TextAlign, foreColor, textRect, AutoEllipsis, UseMnemonic);
    }

    private Size GetPreferredSize()
    {
        return GetPreferredSize(Size.Empty);
    }

    public override Size GetPreferredSize(Size proposedSize)
    {
        int extra = 20;

        if (Image != null)
            extra += 24 + 4;

        return new Size((int)Math.Ceiling(textSize.Width) + extra, 28);
    }
}