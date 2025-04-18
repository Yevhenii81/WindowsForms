﻿namespace hw_24_10_2024
{
    public partial class Form3 : Form
    {
        private int count = 0;
        private int max = 0;

        public Form3()
        {
            InitializeComponent();
            timer1.Interval = 20000;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (count > max)
            {
                max = count;
            }
            MessageBox.Show($"Clicks in 20 seconds: {count}\nMaximum record: {max}", "Result");
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                count = 0;
                timer1.Start();
            }
            count++;
        }
    }
}
