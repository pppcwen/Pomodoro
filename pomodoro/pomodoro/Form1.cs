using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;

namespace pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // TransparencyKey = this.BackColor;
            hr_textbar.Enabled = false;
            min_textbar.Enabled = false;
            sec_textbar.Enabled = false;

        }

        int hr, min, sec;

        private void button1_Click(object sender, EventArgs e)
        {
            if (start_stop_button.Text == "Start")
            {
                timer1.Start();
                start_stop_button.Text = "Stop";
            }
            else if (start_stop_button.Text == "Stop")
            {
                timer1.Stop();
                start_stop_button.Text = "Start";
            }
        }





        private void sec_textbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void SetTime_button_Click(object sender, EventArgs e)
        {
            if (SetTime_button.Text == "Set Time")
            {
                hr_textbar.Enabled = true;
                min_textbar.Enabled = true;
                sec_textbar.Enabled = true;
                SetTime_button.Text = "Ok";
            }
            else if (SetTime_button.Text == "Ok")
            {
                SetTime_button.Text = "Set Time";
                hr_textbar.Enabled = false;
                min_textbar.Enabled = false;
                sec_textbar.Enabled = false;
            }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hr = 0;
            min = 0;
            sec = 0;
            string hrstr = hr.ToString();
            string minstr = min.ToString();
            string secstr = sec.ToString();
            hr_textbar.Text = hrstr;
            min_textbar.Text = minstr;
            sec_textbar.Text = secstr;
        }

        private void hr_textbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                if (min == 0)
                {
                    if (hr == 0)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        hr -= 1;
                        min = 59;
                        sec = 59;
                    }
                }
                else
                {
                    min -= 1;
                    sec = 59;
                }
            }
            else
            {
                sec -= 1;
            }
            string hrstr = hr.ToString();
            string minstr = min.ToString();
            string secstr = sec.ToString();
            hr_textbar.Text = hrstr;
            min_textbar.Text = minstr;
            sec_textbar.Text = secstr;

            //§PÂ_Åã¥Ü¬Æ»ò¦r
            if (sec == 0 || min == 0 || hr == 0)
            {
                label1.Text = "Congratulations!";
            }
            else
            {
                label1.Text = "Keep going!";
            }
        }


    }
}