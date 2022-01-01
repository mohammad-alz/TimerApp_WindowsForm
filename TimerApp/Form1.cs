using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        Clock clock;
        bool started;
        int list_count;
        public Form1()
        {
            InitializeComponent();
            started = false;
            list_count = 0;
            clock = new Clock();
        }

        private void start_MouseEnter(object sender, EventArgs e)
        {
            start_hovered.Visible = true;
            start.Visible = false;
        }

        private void start_hovered_MouseLeave(object sender, EventArgs e)
        {
            if (!started) 
            { 
                start.Visible = true;
                start_hovered.Visible = false;
            }
        }

        private void start_hovered_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
            pause_hovered.Visible = true;
            start_hovered.Visible = false;
            flag.Visible = true;
            started = true;
        }

        private void stop_hovered_MouseLeave(object sender, EventArgs e)
        {
            stop.Visible = true;
            stop_hovered.Visible = false;
        }

        private void stop_MouseEnter(object sender, EventArgs e)
        {
            stop_hovered.Visible = true;
            stop.Visible = false;
        }

        private void stop_hovered_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            clock.Reset();
            ShowTime();
            Time_List.Controls.Clear();
            start.Visible = true;
            pause.Visible = false;
            flag.Visible = false;
        }

        private void pause_MouseEnter(object sender, EventArgs e)
        {
            pause_hovered.Visible = true;
            pause.Visible = false;
        }

        private void pause_hovored_MouseLeave(object sender, EventArgs e)
        {
            if (started)
            {
                pause.Visible = true;
                pause_hovered.Visible = false;
            }
        }

        private void pause_hovered_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            start_hovered.Visible = true;
            pause_hovered.Visible = false;
            flag.Visible = false;
            started = false;
        }

        private void flag_MouseEnter(object sender, EventArgs e)
        {
            flag_hovered.Visible = true;
            flag.Visible = false;
        }

        private void flag_hovered_MouseLeave(object sender, EventArgs e)
        {
            flag.Visible = true;
            flag_hovered.Visible = false;
        }

        private void flag_hovered_Click(object sender, EventArgs e)
        {
            if (Time_List.Controls.Count == 0)
            {
                Label new_stop = new Label()
                {
                    Text = (Time_List.Controls.Count + 1).ToString() + ".         " + clock.GetTime,
                    AutoSize = true,
                    Visible = true,
                    BackColor = System.Drawing.Color.Transparent,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.SystemColors.ButtonHighlight,
                    Location = new System.Drawing.Point(0, 0),
                };
                if (Time_List.Controls.Count % 2 == 1)
                    new_stop.ForeColor = SystemColors.ControlDark;
                Time_List.Controls.Add(new_stop);
                list_count = 1;
            }
            else
            {
                list_count++;
                Time_List.Controls[0].Text = list_count.ToString() + "." + SpaceMaker(10-2*NumLen(list_count)+1) +
                    clock.GetTime + "\n" + Time_List.Controls[0].Text;
            }
        }

        private int NumLen(int num)
        {
            int count = 0;
            while(num!=0)
            {
                count++;
                num/=10;
            }
            return count;
        }

        private string SpaceMaker(int len)
        {
            string result = "";
            for(int i=0; i<len; i++)
                result += " ";
            return result;
        }
        private void ShowTime()
        {
            hour_lbl.Text = clock.GetHour;
            minute_lbl.Text = clock.GetMinute;
            second_lbl.Text = clock.GetSecond;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Add();
            ShowTime();
        }
    }
}
