namespace Spambot
{
    partial class SpamBot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpamBot));
            this.Fill = new System.Windows.Forms.RichTextBox();
            this.START = new System.Windows.Forms.Button();
            this.END = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.SystemColors.InfoText;
            this.Fill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fill.Font = new System.Drawing.Font("Bodoni MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Fill.Location = new System.Drawing.Point(40, 61);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(218, 191);
            this.Fill.TabIndex = 0;
            this.Fill.Text = "";
            this.Fill.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.ForeColor = System.Drawing.Color.Lime;
            this.START.Location = new System.Drawing.Point(319, 106);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(118, 57);
            this.START.TabIndex = 2;
            this.START.Text = "Start";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.button2_Click);
            // 
            // END
            // 
            this.END.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.END.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.END.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END.ForeColor = System.Drawing.Color.Lime;
            this.END.Location = new System.Drawing.Point(319, 195);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(118, 57);
            this.END.TabIndex = 3;
            this.END.Text = "End";
            this.END.UseVisualStyleBackColor = false;
            this.END.Click += new System.EventHandler(this.END_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Text here:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(316, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "MADE BY aND_hAcKz_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SpamBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spambot.Properties.Resources.pirates_of_the_caribbean_black_pearl_skeleton_crew_Cropped;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.END);
            this.Controls.Add(this.START);
            this.Controls.Add(this.Fill);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpamBot";
            this.Text = "SPAMBOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Fill;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button END;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

