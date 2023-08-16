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

        //�w�q�ɶ�
        int hr, min, sec,ms;

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
            //Ū����J�r����ର�Ʀr
            int.TryParse(sec_textbar.Text, out sec);
            //����Ʀr�W�X�W��
            if (sec > 60)
            {
                sec = 60;
                string secstr = sec.ToString();
                sec_textbar.Text = secstr;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void SetTime_button_Click(object sender, EventArgs e)
        {
            //�]�m�ɶ�
            if (SetTime_button.Text == "Set Time")
            {
                hr_textbar.Enabled = true;
                min_textbar.Enabled = true;
                sec_textbar.Enabled = true;
                hr_textbar.Text = "";
                min_textbar.Text = "";
                sec_textbar.Text = "";
                start_stop_button.Enabled = false;
                reset_button.Enabled = false;
                SetTime_button.Text = "Ok";
            }
            else if (SetTime_button.Text == "Ok")
            {
                SetTime_button.Text = "Set Time";
                hr_textbar.Enabled = false;
                min_textbar.Enabled = false;
                sec_textbar.Enabled = false;
                start_stop_button.Enabled = true;
                reset_button.Enabled = true;
            }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //�N�Ҧ��Ʀr���m
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
            label1.Text = "";
        }

        private void hr_textbar_TextChanged(object sender, EventArgs e)
        {
            //Ū����J�r����ର�Ʀr
            int.TryParse(hr_textbar.Text, out hr);
            //����Ʀr�W�X�W��
            if (hr > 24)
            {
                hr = 24;
                string hrstr = hr.ToString();
                hr_textbar.Text = hrstr;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //��ܮɶ��B�@
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

            //�P�_��ܬƻ�r
            if (sec == 0 && min == 0 && hr == 0)
            {
                label1.Text = "Congratulations!";
            }
            else
            {
                label1.Text = "Keep going!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sec_textbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�u���\�b��Ʈ��J�Ʀr
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void hr_textbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�u���\�b�������J�Ʀr
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void min_textbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�u���\�b�p�ɮ��J�Ʀr
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void min_textbar_TextChanged(object sender, EventArgs e)
        {
            //Ū����J�r����ର�Ʀr
            int.TryParse(min_textbar.Text, out min);
            //����Ʀr�W�X�W��
            if (min > 60)
            {
                min = 60;
                string minstr = min.ToString();
                min_textbar.Text = minstr;
            }
        }
    }
}