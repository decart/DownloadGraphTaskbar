using System.ComponentModel;

namespace SimpleBarsGraph
{
    partial class SimpleBarsGraphControl
    {
        private readonly List<long> _items = new();
        private long _maxValue;
        private int _borderWidth = 1;
        private Color _borderColor = Color.DarkGray;
        private Color _graphColor = Color.DeepSkyBlue;
        private VerticalAlignType _verticalAlign = VerticalAlignType.Bottom;
        private bool _scalable = false;


        [Category("Appearance")]
        [DefaultValue(1)]
        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                _borderWidth = value;
                Refresh();
            }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DarkGray")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Refresh();
            }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DeepSkyBlue")]
        public Color GraphColor
        {
            get => _graphColor;
            set
            {
                _graphColor = value;
                Refresh();
            }
        }

        [Category("Appearance")]
        [DefaultValue(VerticalAlignType.Bottom)]
        public VerticalAlignType VerticalAlign
        {
            get => _verticalAlign;
            set
            {
                _verticalAlign = value;
                Refresh();
            }
        }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Scalable { get => _scalable; set => _scalable = value; }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 25);
            this.DoubleBuffered= true;
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.ContainerControl |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.SupportsTransparentBackColor,
                true
            );
        }

        #endregion
    }
}