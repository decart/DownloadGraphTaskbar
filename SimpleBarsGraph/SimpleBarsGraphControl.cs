using System.ComponentModel;

namespace SimpleBarsGraph
{
    public partial class SimpleBarsGraphControl : UserControl
    {
        public SimpleBarsGraphControl()
        {
            InitializeComponent();
        }

        public void AddValue(long value)
        {
            _items.Add(value);

            if (_scalable)
            {
                _maxValue = _items.Max();
            }
            else if (value > _maxValue)
            {
                _maxValue = value;
            }

            var maxCount = getBarsCount();
            if (_items.Count > maxCount)
                _items.RemoveAt(0);

            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RenderGraph(e.Graphics);
            RenderBorder(e.Graphics);
        }

        private int getBarsCount()
        {
            return ClientSize.Width - _borderWidth * 2;
        }

        private void RenderBorder(Graphics graphics)
        {
            if (_borderWidth < 1) return;

            using var pen = new Pen(_borderColor, _borderWidth);
            var border = new Rectangle(
                0 + _borderWidth / 2,
                0 + _borderWidth / 2,
                ClientSize.Width - _borderWidth,
                ClientSize.Height - _borderWidth
            );

            graphics.DrawRectangle(pen, border);
        }

        private void RenderGraph(Graphics graphics)
        {
            var idx = getBarsCount() - _items.Count;
            foreach (var item in _items)
            {
                RenderBar(graphics, item, idx);
                idx++;
            }
        }

        private void RenderBar(Graphics graphics, long value, int idx)
        {
            double maxValue = Math.Max(_maxValue, 1);
            var graphHeight = ClientSize.Height - _borderWidth * 2;
            var barHeight = (int)Math.Round(value * graphHeight / maxValue);

            var x = _borderWidth + idx;
            var y1 = (_verticalAlign == VerticalAlignType.Top) ? _borderWidth : ClientSize.Height - _borderWidth * 2;
            var y2 = (_verticalAlign == VerticalAlignType.Top) ? barHeight : ClientSize.Height - barHeight - BorderWidth;

            using var pen = new Pen(_graphColor, 1);

            graphics.DrawLine(pen, x, y1, x, y2);
        }
    }
}