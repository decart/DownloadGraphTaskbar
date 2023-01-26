using System.Net.NetworkInformation;

namespace GraphTestForm
{
    public partial class GraphTestForm : Form
    {
        private long _prevBytesRecived = 0;
        private readonly bool _networkAvailable = false;
        private readonly NetworkInterface[] _adapters;

        public GraphTestForm()
        {
            InitializeComponent();
            _networkAvailable = NetworkInterface.GetIsNetworkAvailable();
            _adapters = NetworkInterface.GetAllNetworkInterfaces();
        }

        private void addGraphValueTimer_Tick(object sender, EventArgs e)
        {
            if (!_networkAvailable) return;

            long bytesRecived = 0;
            foreach(var adapter in _adapters)
            {
                bytesRecived += adapter.GetIPv4Statistics().BytesReceived;
            }

            var speedBytes = _prevBytesRecived > 0 ? bytesRecived - _prevBytesRecived : 0;
            var speed = speedBytes / 1000.0;

            _prevBytesRecived = bytesRecived;
            testSimpleBarsGraphControl.AddValue((long)speed);

            speedLabel.Text = $"{speed:N} KB/s";
        }
    }
}