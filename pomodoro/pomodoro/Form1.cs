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

        //定義時間
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
            //讀取輸入字串並轉為數字
            int.TryParse(sec_textbar.Text, out sec);
            //防止數字超出上限
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
            //設置時間
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
            //將所有數字重置
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
            //讀取輸入字串並轉為數字
            int.TryParse(hr_textbar.Text, out hr);
            //防止數字超出上限
            if (hr > 24)
            {
                hr = 24;
                string hrstr = hr.ToString();
                hr_textbar.Text = hrstr;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //顯示時間運作
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

            //判斷顯示甚麼字
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
            //只允許在秒數格輸入數字
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void hr_textbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允許在分鐘格輸入數字
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void min_textbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允許在小時格輸入數字
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void min_textbar_TextChanged(object sender, EventArgs e)
        {
            //讀取輸入字串並轉為數字
            int.TryParse(min_textbar.Text, out min);
            //防止數字超出上限
            if (min > 60)
            {
                min = 60;
                string minstr = min.ToString();
                min_textbar.Text = minstr;
            }
        }
    }
}