namespace DDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TXT_IP = new TextBox();
            IP_LABLE = new Label();
            ATTACK_BTN = new Button();
            STOP_BTN = new Button();
            TXT_CONFIRM = new TextBox();
            CONFIRM = new TextBox();
            label1 = new Label();
            floodTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // TXT_IP
            // 
            TXT_IP.BackColor = SystemColors.InfoText;
            TXT_IP.BorderStyle = BorderStyle.None;
            TXT_IP.ForeColor = Color.Lime;
            TXT_IP.Location = new Point(237, 54);
            TXT_IP.Margin = new Padding(0);
            TXT_IP.Multiline = true;
            TXT_IP.Name = "TXT_IP";
            TXT_IP.Size = new Size(133, 23);
            TXT_IP.TabIndex = 0;
            TXT_IP.TextChanged += TXT_IP_TextChanged;
            // 
            // IP_LABLE
            // 
            IP_LABLE.AutoSize = true;
            IP_LABLE.BackColor = SystemColors.ActiveCaptionText;
            IP_LABLE.Font = new Font("Matura MT Script Capitals", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IP_LABLE.ForeColor = Color.Lime;
            IP_LABLE.Location = new Point(139, 54);
            IP_LABLE.Name = "IP_LABLE";
            IP_LABLE.Size = new Size(69, 16);
            IP_LABLE.TabIndex = 1;
            IP_LABLE.Text = "Target IP";
            // 
            // ATTACK_BTN
            // 
            ATTACK_BTN.BackColor = SystemColors.InfoText;
            ATTACK_BTN.FlatAppearance.BorderSize = 0;
            ATTACK_BTN.FlatStyle = FlatStyle.Flat;
            ATTACK_BTN.Font = new Font("Matura MT Script Capitals", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ATTACK_BTN.ForeColor = Color.Lime;
            ATTACK_BTN.Location = new Point(139, 166);
            ATTACK_BTN.Name = "ATTACK_BTN";
            ATTACK_BTN.Size = new Size(102, 23);
            ATTACK_BTN.TabIndex = 2;
            ATTACK_BTN.Text = "ATTACK!!";
            ATTACK_BTN.UseVisualStyleBackColor = false;
            ATTACK_BTN.Click += ATTACK_BTN_Click;
            // 
            // STOP_BTN
            // 
            STOP_BTN.BackColor = SystemColors.InfoText;
            STOP_BTN.FlatAppearance.BorderSize = 0;
            STOP_BTN.FlatStyle = FlatStyle.Flat;
            STOP_BTN.Font = new Font("Matura MT Script Capitals", 9F, FontStyle.Regular, GraphicsUnit.Point);
            STOP_BTN.ForeColor = Color.Lime;
            STOP_BTN.Location = new Point(295, 166);
            STOP_BTN.Name = "STOP_BTN";
            STOP_BTN.Size = new Size(75, 23);
            STOP_BTN.TabIndex = 3;
            STOP_BTN.Text = "STOP";
            STOP_BTN.UseVisualStyleBackColor = false;
            STOP_BTN.Click += STOP_BTN_Click;
            // 
            // TXT_CONFIRM
            // 
            TXT_CONFIRM.BackColor = SystemColors.InfoText;
            TXT_CONFIRM.BorderStyle = BorderStyle.None;
            TXT_CONFIRM.ForeColor = Color.Lime;
            TXT_CONFIRM.Location = new Point(237, 92);
            TXT_CONFIRM.Multiline = true;
            TXT_CONFIRM.Name = "TXT_CONFIRM";
            TXT_CONFIRM.Size = new Size(133, 23);
            TXT_CONFIRM.TabIndex = 4;
            TXT_CONFIRM.TextChanged += TXT_CONFIRM_TextChanged;
            // 
            // CONFIRM
            // 
            CONFIRM.BackColor = SystemColors.InfoText;
            CONFIRM.BorderStyle = BorderStyle.None;
            CONFIRM.ForeColor = Color.Lime;
            CONFIRM.Location = new Point(139, 137);
            CONFIRM.Multiline = true;
            CONFIRM.Name = "CONFIRM";
            CONFIRM.ReadOnly = true;
            CONFIRM.Size = new Size(231, 23);
            CONFIRM.TabIndex = 5;
            CONFIRM.TextChanged += CONFIRM_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Matura MT Script Capitals", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(139, 92);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 6;
            label1.Text = "Message";
            // 
            // floodTimer
            // 
            floodTimer.Tick += FloodTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(376, 238);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 7;
            label2.Text = "DDOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(327, 270);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 8;
            label3.Text = "ATTACK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(511, 311);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CONFIRM);
            Controls.Add(TXT_CONFIRM);
            Controls.Add(STOP_BTN);
            Controls.Add(ATTACK_BTN);
            Controls.Add(IP_LABLE);
            Controls.Add(TXT_IP);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "DDOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_IP;
        private Label IP_LABLE;
        private Button ATTACK_BTN;
        private Button STOP_BTN;
        private TextBox TXT_CONFIRM;
        private TextBox CONFIRM;
        private Label label1;
        private System.Windows.Forms.Timer floodTimer;
        private Label label2;
        private Label label3;
    }
}