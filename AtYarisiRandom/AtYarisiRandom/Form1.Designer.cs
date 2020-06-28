namespace AtYarisiRandom
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFiinish = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCanli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastFinishTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLastWinnerHorse = new System.Windows.Forms.Label();
            this.pbxHorse1 = new System.Windows.Forms.PictureBox();
            this.pbxHorse2 = new System.Windows.Forms.PictureBox();
            this.pbxHorse3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(-7, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(-7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(809, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(-7, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(809, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(-7, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(809, 23);
            this.label4.TabIndex = 0;
            // 
            // lblFiinish
            // 
            this.lblFiinish.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFiinish.Location = new System.Drawing.Point(798, -2);
            this.lblFiinish.Name = "lblFiinish";
            this.lblFiinish.Size = new System.Drawing.Size(22, 373);
            this.lblFiinish.TabIndex = 3;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBasla.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(25, 302);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(110, 63);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCanli
            // 
            this.lblCanli.AutoSize = true;
            this.lblCanli.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCanli.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCanli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCanli.Location = new System.Drawing.Point(220, 316);
            this.lblCanli.Name = "lblCanli";
            this.lblCanli.Size = new System.Drawing.Size(0, 39);
            this.lblCanli.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(680, 77);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(708, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 75);
            this.label6.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(744, 324);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(18, 23);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(333, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Son Yarış Süresi : ";
            // 
            // lblLastFinishTime
            // 
            this.lblLastFinishTime.AutoSize = true;
            this.lblLastFinishTime.BackColor = System.Drawing.Color.Honeydew;
            this.lblLastFinishTime.Location = new System.Drawing.Point(423, 4);
            this.lblLastFinishTime.Name = "lblLastFinishTime";
            this.lblLastFinishTime.Size = new System.Drawing.Size(13, 13);
            this.lblLastFinishTime.TabIndex = 11;
            this.lblLastFinishTime.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(466, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Son Kazanan Kişi : ";
            // 
            // lblLastWinnerHorse
            // 
            this.lblLastWinnerHorse.AutoSize = true;
            this.lblLastWinnerHorse.BackColor = System.Drawing.Color.MintCream;
            this.lblLastWinnerHorse.Location = new System.Drawing.Point(555, 3);
            this.lblLastWinnerHorse.Name = "lblLastWinnerHorse";
            this.lblLastWinnerHorse.Size = new System.Drawing.Size(13, 13);
            this.lblLastWinnerHorse.TabIndex = 13;
            this.lblLastWinnerHorse.Text = "--";
            // 
            // pbxHorse1
            // 
            this.pbxHorse1.BackColor = System.Drawing.Color.Transparent;
            this.pbxHorse1.Image = global::AtYarisiRandom.Properties.Resources.horse;
            this.pbxHorse1.Location = new System.Drawing.Point(3, 27);
            this.pbxHorse1.Name = "pbxHorse1";
            this.pbxHorse1.Size = new System.Drawing.Size(100, 50);
            this.pbxHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHorse1.TabIndex = 14;
            this.pbxHorse1.TabStop = false;
            // 
            // pbxHorse2
            // 
            this.pbxHorse2.BackColor = System.Drawing.Color.Transparent;
            this.pbxHorse2.Image = global::AtYarisiRandom.Properties.Resources.horse;
            this.pbxHorse2.Location = new System.Drawing.Point(3, 115);
            this.pbxHorse2.Name = "pbxHorse2";
            this.pbxHorse2.Size = new System.Drawing.Size(100, 50);
            this.pbxHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHorse2.TabIndex = 14;
            this.pbxHorse2.TabStop = false;
            // 
            // pbxHorse3
            // 
            this.pbxHorse3.BackColor = System.Drawing.Color.Transparent;
            this.pbxHorse3.Image = global::AtYarisiRandom.Properties.Resources.horse;
            this.pbxHorse3.Location = new System.Drawing.Point(3, 207);
            this.pbxHorse3.Name = "pbxHorse3";
            this.pbxHorse3.Size = new System.Drawing.Size(100, 50);
            this.pbxHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHorse3.TabIndex = 14;
            this.pbxHorse3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(839, 380);
            this.Controls.Add(this.pbxHorse3);
            this.Controls.Add(this.pbxHorse2);
            this.Controls.Add(this.pbxHorse1);
            this.Controls.Add(this.lblLastWinnerHorse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblLastFinishTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCanli);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblFiinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFiinish;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCanli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLastFinishTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLastWinnerHorse;
        private System.Windows.Forms.PictureBox pbxHorse1;
        private System.Windows.Forms.PictureBox pbxHorse2;
        private System.Windows.Forms.PictureBox pbxHorse3;
    }
}

