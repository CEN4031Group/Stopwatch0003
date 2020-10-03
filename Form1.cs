using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch0003
{
    public partial class Form1 : Form
    {
        int sec, min, hrs, elapsedTime;
        bool isRunning;
        public Form1()
        {
            InitializeComponent();
            sec = min = hrs = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sec++;
            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            if (min >= 60)
            {
                hrs++;
                min = 0;
            }

            lbSeconds.Text = formatter(sec);
            lbMinutes.Text = formatter(min);
            lbHours.Text = formatter(hrs);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            isRunning = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (isRunning)
            {
                elapsedTime = (hrs * 3600 + min * 60 + sec);

                lstBxElapsed.Items.Add(formatter(elapsedTime));

                lbElapsed.Text = formatter(elapsedTime);

                sec = min = hrs = 0;
                
                lbSeconds.Text = formatter(sec);
                lbMinutes.Text = formatter(min);
                lbMinutes.Text = formatter(hrs);
            }

            isRunning = false;
        }
        public string formatter(int num)
        {
            return String.Format("{0:00}", num); 
        }
    }
}

