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
            label2 = new Label();
            label4 = new Label();
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
            start_stop_button.Location = new Point(135, 462);
            start_stop_button.Margin = new Padding(2);
            start_stop_button.Name = "start_stop_button";
            start_stop_button.Size = new Size(125, 64);
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
            reset_button.Location = new Point(288, 462);
            reset_button.Margin = new Padding(2);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(119, 67);
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
            SetTime_button.Location = new Point(411, 457);
            SetTime_button.Margin = new Padding(2);
            SetTime_button.Name = "SetTime_button";
            SetTime_button.Size = new Size(170, 71);
            SetTime_button.TabIndex = 4;
            SetTime_button.Text = "Set Time";
            SetTime_button.UseVisualStyleBackColor = false;
            SetTime_button.Click += SetTime_button_Click;
            // 
            // hr_textbar
            // 
            hr_textbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hr_textbar.BackColor = Color.FromArgb(240, 64, 32);
            hr_textbar.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            hr_textbar.Location = new Point(126, 267);
            hr_textbar.Margin = new Padding(2);
            hr_textbar.MaxLength = 2;
            hr_textbar.Multiline = true;
            hr_textbar.Name = "hr_textbar";
            hr_textbar.Size = new Size(115, 81);
            hr_textbar.TabIndex = 7;
            hr_textbar.Text = "0";
            hr_textbar.TextAlign = HorizontalAlignment.Center;
            hr_textbar.TextChanged += hr_textbar_TextChanged;
            hr_textbar.KeyPress += hr_textbar_KeyPress;
            // 
            // min_textbar
            // 
            min_textbar.BackColor = Color.FromArgb(240, 64, 32);
            min_textbar.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            min_textbar.Location = new Point(275, 267);
            min_textbar.Margin = new Padding(2);
            min_textbar.MaxLength = 2;
            min_textbar.Multiline = true;
            min_textbar.Name = "min_textbar";
            min_textbar.Size = new Size(119, 81);
            min_textbar.TabIndex = 8;
            min_textbar.Text = "0";
            min_textbar.TextAlign = HorizontalAlignment.Center;
            min_textbar.TextChanged += min_textbar_TextChanged;
            min_textbar.KeyPress += min_textbar_KeyPress;
            // 
            // sec_textbar
            // 
            sec_textbar.BackColor = Color.FromArgb(240, 64, 32);
            sec_textbar.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            sec_textbar.Location = new Point(431, 267);
            sec_textbar.Margin = new Padding(2);
            sec_textbar.MaxLength = 2;
            sec_textbar.Multiline = true;
            sec_textbar.Name = "sec_textbar";
            sec_textbar.Size = new Size(111, 81);
            sec_textbar.TabIndex = 9;
            sec_textbar.Text = "0";
            sec_textbar.TextAlign = HorizontalAlignment.Center;
            sec_textbar.TextChanged += sec_textbar_TextChanged;
            sec_textbar.KeyPress += sec_textbar_KeyPress;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(146, 185);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 70);
            label1.TabIndex = 10;
            label1.Text = "Keep going!";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(246, 278);
            label2.Name = "label2";
            label2.Size = new Size(27, 43);
            label2.TabIndex = 11;
            label2.Text = ":";
            label2.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(399, 278);
            label4.Name = "label4";
            label4.Size = new Size(27, 43);
            label4.TabIndex = 13;
            label4.Text = ":";
            label4.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.pomodoro_photo6;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(671, 539);
            Controls.Add(label4);
            Controls.Add(label2);
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
            Margin = new Padding(2);
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
        private Label label2;
        private Label label4;
    }
}