using System.Diagnostics;

namespace hw_24_10_2024
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;

        private void TimerSettings()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            timer1.Interval = 100;
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
            TimerSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = $"M.Sec: {stopwatch.ElapsedMilliseconds}";
        }
    }
}

