namespace URL_to_IP
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.URL_INPUT = new System.Windows.Forms.TextBox();
            this.BTN_CONVERT = new System.Windows.Forms.Button();
            this.TXT_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL_INPUT
            // 
            this.URL_INPUT.AcceptsReturn = true;
            this.URL_INPUT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.URL_INPUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URL_INPUT.ForeColor = System.Drawing.Color.Yellow;
            this.URL_INPUT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.URL_INPUT.Location = new System.Drawing.Point(73, 331);
            this.URL_INPUT.Name = "URL_INPUT";
            this.URL_INPUT.Size = new System.Drawing.Size(185, 20);
            this.URL_INPUT.TabIndex = 0;
            this.URL_INPUT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTN_CONVERT
            // 
            this.BTN_CONVERT.BackColor = System.Drawing.Color.Black;
            this.BTN_CONVERT.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_CONVERT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONVERT.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CONVERT.ForeColor = System.Drawing.Color.Lime;
            this.BTN_CONVERT.Location = new System.Drawing.Point(73, 447);
            this.BTN_CONVERT.Name = "BTN_CONVERT";
            this.BTN_CONVERT.Size = new System.Drawing.Size(185, 26);
            this.BTN_CONVERT.TabIndex = 2;
            this.BTN_CONVERT.Text = "Convert";
            this.BTN_CONVERT.UseVisualStyleBackColor = false;
            this.BTN_CONVERT.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXT_IP
            // 
            this.TXT_IP.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_IP.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_IP.Location = new System.Drawing.Point(73, 387);
            this.TXT_IP.Multiline = true;
            this.TXT_IP.Name = "TXT_IP";
            this.TXT_IP.ReadOnly = true;
            this.TXT_IP.Size = new System.Drawing.Size(185, 20);
            this.TXT_IP.TabIndex = 3;
            this.TXT_IP.TextChanged += new System.EventHandler(this.TXT_IP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(70, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(70, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(235, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(263, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(50, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 54);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(358, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_IP);
            this.Controls.Add(this.BTN_CONVERT);
            this.Controls.Add(this.URL_INPUT);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "URL to IP";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_INPUT;
        private System.Windows.Forms.Button BTN_CONVERT;
        private System.Windows.Forms.TextBox TXT_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

