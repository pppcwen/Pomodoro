namespace pomodoro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            start_stop_button = new Button();
            reset_button = new Button();
            SetTime_button = new Button();
            hr_textbar = new TextBox();
            min_textbar = new TextBox();
            sec_textbar = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // start_stop_button
            // 
            start_stop_button.BackColor = Color.Transparent;
            start_stop_button.BackgroundImage = Properties.Resources.pomodoro_photo7;
            start_stop_button.BackgroundImageLayout = ImageLayout.Zoom;
            start_stop_button.FlatAppearance.BorderSize = 0;
            start_stop_button.FlatStyle = FlatStyle.Flat;
            start_stop_button.Font = new Font("MV Boli", 13F, FontStyle.Bold, GraphicsUnit.Point);
            start_stop_button.Location = new Point(210, 731);
            start_stop_button.Name = "start_stop_button";
            start_stop_button.Size = new Size(162, 92);
            start_stop_button.TabIndex = 0;
            start_stop_button.Text = "Start";
            start_stop_button.UseVisualStyleBackColor = false;
            start_stop_button.Click += button1_Click;
            // 
            // reset_button
            // 
            reset_button.BackColor = Color.Transparent;
            reset_button.BackgroundImage = Properties.Resources.pomodoro_photo7;
            reset_button.BackgroundImageLayout = ImageLayout.Zoom;
            reset_button.FlatAppearance.BorderSize = 0;
            reset_button.FlatStyle = FlatStyle.Flat;
            reset_button.Font = new Font("MV Boli", 13F, FontStyle.Bold, GraphicsUnit.Point);
            reset_button.Location = new Point(434, 726);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(146, 101);
            reset_button.TabIndex = 3;
            reset_button.Text = "Reset";
            reset_button.UseVisualStyleBackColor = false;
            reset_button.Click += reset_button_Click;
            // 
            // SetTime_button
            // 
            SetTime_button.BackColor = Color.Transparent;
            SetTime_button.BackgroundImage = Properties.Resources.pomodoro_photo7;
            SetTime_button.BackgroundImageLayout = ImageLayout.Zoom;
            SetTime_button.FlatAppearance.BorderSize = 0;
            SetTime_button.FlatStyle = FlatStyle.Flat;
            SetTime_button.Font = new Font("MV Boli", 13F, FontStyle.Bold, GraphicsUnit.Point);
            SetTime_button.Location = new Point(636, 722);
            SetTime_button.Name = "SetTime_button";
            SetTime_button.Size = new Size(182, 101);
            SetTime_button.TabIndex = 4;
            SetTime_button.Text = "Set Time";
            SetTime_button.UseVisualStyleBackColor = false;
            SetTime_button.Click += SetTime_button_Click;
            // 
            // hr_textbar
            // 
            hr_textbar.BackColor = Color.FromArgb(240, 64, 32);
            hr_textbar.BorderStyle = BorderStyle.None;
            hr_textbar.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            hr_textbar.Location = new Point(258, 392);
            hr_textbar.Multiline = true;
            hr_textbar.Name = "hr_textbar";
            hr_textbar.Size = new Size(170, 112);
            hr_textbar.TabIndex = 7;
            hr_textbar.Text = "52";
            hr_textbar.TextAlign = HorizontalAlignment.Center;
            hr_textbar.TextChanged += hr_textbar_TextChanged;
            // 
            // min_textbar
            // 
            min_textbar.BackColor = Color.FromArgb(240, 64, 32);
            min_textbar.BorderStyle = BorderStyle.None;
            min_textbar.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            min_textbar.Location = new Point(434, 392);
            min_textbar.Multiline = true;
            min_textbar.Name = "min_textbar";
            min_textbar.Size = new Size(174, 96);
            min_textbar.TabIndex = 8;
            min_textbar.Text = "52";
            min_textbar.TextAlign = HorizontalAlignment.Center;
            // 
            // sec_textbar
            // 
            sec_textbar.BackColor = Color.FromArgb(240, 64, 32);
            sec_textbar.BorderStyle = BorderStyle.None;
            sec_textbar.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            sec_textbar.Location = new Point(614, 392);
            sec_textbar.Multiline = true;
            sec_textbar.Name = "sec_textbar";
            sec_textbar.Size = new Size(182, 96);
            sec_textbar.TabIndex = 9;
            sec_textbar.Text = "52";
            sec_textbar.TextAlign = HorizontalAlignment.Center;
            sec_textbar.TextChanged += sec_textbar_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(346, 288);
            label1.Name = "label1";
            label1.Size = new Size(387, 85);
            label1.TabIndex = 10;
            label1.Text = "Keep going!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.pomodoro_photo6;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1044, 851);
            Controls.Add(label1);
            Controls.Add(sec_textbar);
            Controls.Add(min_textbar);
            Controls.Add(hr_textbar);
            Controls.Add(SetTime_button);
            Controls.Add(reset_button);
            Controls.Add(start_stop_button);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(1200, 440);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_stop_button;
        private Button reset_button;
        private Button SetTime_button;
        private TextBox hr_textbar;
        private TextBox min_textbar;
        private TextBox sec_textbar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}