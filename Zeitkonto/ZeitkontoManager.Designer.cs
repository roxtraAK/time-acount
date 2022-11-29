namespace Zeitkonto
{
    partial class ZeitkontoManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZeitkontoManager));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKommen = new System.Windows.Forms.Label();
            this.labelGehen = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.lblKommenText = new System.Windows.Forms.Label();
            this.lblGehenText = new System.Windows.Forms.Label();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.labelUsermanager = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(-1, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 27);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(110, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 31);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "22:22";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(117, 112);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(285, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 22);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome";
            // 
            // labelKommen
            // 
            this.labelKommen.Image = ((System.Drawing.Image)(resources.GetObject("labelKommen.Image")));
            this.labelKommen.Location = new System.Drawing.Point(12, 170);
            this.labelKommen.Name = "labelKommen";
            this.labelKommen.Size = new System.Drawing.Size(92, 59);
            this.labelKommen.TabIndex = 8;
            this.labelKommen.Click += new System.EventHandler(this.labelKommen_Click);
            // 
            // labelGehen
            // 
            this.labelGehen.Image = ((System.Drawing.Image)(resources.GetObject("labelGehen.Image")));
            this.labelGehen.Location = new System.Drawing.Point(131, 170);
            this.labelGehen.Name = "labelGehen";
            this.labelGehen.Size = new System.Drawing.Size(76, 59);
            this.labelGehen.TabIndex = 9;
            this.labelGehen.Click += new System.EventHandler(this.labelGehen_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Image = ((System.Drawing.Image)(resources.GetObject("labelInfo.Image")));
            this.labelInfo.Location = new System.Drawing.Point(239, 161);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(79, 68);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // lblKommenText
            // 
            this.lblKommenText.AutoSize = true;
            this.lblKommenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKommenText.Location = new System.Drawing.Point(36, 229);
            this.lblKommenText.Name = "lblKommenText";
            this.lblKommenText.Size = new System.Drawing.Size(51, 18);
            this.lblKommenText.TabIndex = 11;
            this.lblKommenText.Text = "Arrive";
            this.lblKommenText.Click += new System.EventHandler(this.lblKommenText_Click);
            // 
            // lblGehenText
            // 
            this.lblGehenText.AutoSize = true;
            this.lblGehenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGehenText.Location = new System.Drawing.Point(143, 229);
            this.lblGehenText.Name = "lblGehenText";
            this.lblGehenText.Size = new System.Drawing.Size(52, 18);
            this.lblGehenText.TabIndex = 12;
            this.lblGehenText.Text = "Leave";
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoText.Location = new System.Drawing.Point(260, 229);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(36, 18);
            this.lblInfoText.TabIndex = 13;
            this.lblInfoText.Text = "Info";
            // 
            // lblClose
            // 
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClose.Location = new System.Drawing.Point(324, 7);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 22);
            this.lblClose.TabIndex = 21;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // labelUsermanager
            // 
            this.labelUsermanager.Image = ((System.Drawing.Image)(resources.GetObject("labelUsermanager.Image")));
            this.labelUsermanager.Location = new System.Drawing.Point(263, 7);
            this.labelUsermanager.Name = "labelUsermanager";
            this.labelUsermanager.Size = new System.Drawing.Size(16, 22);
            this.labelUsermanager.TabIndex = 22;
            this.labelUsermanager.Click += new System.EventHandler(this.labelUsermanager_Click);
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(307, -5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 49);
            this.label12.TabIndex = 27;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // ZeitkontoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 268);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelUsermanager);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.lblGehenText);
            this.Controls.Add(this.lblKommenText);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelGehen);
            this.Controls.Add(this.labelKommen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ZeitkontoManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeitkonto Manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZeitkontoManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Label lblResult;
        private Label label1;
        private Label labelGehen;
        private Label labelInfo;
        private Label lblClose;
        internal Label labelKommen;
        internal Label label2;
        internal Label lblGehenText;
        internal Label lblKommenText;
        internal Label lblInfoText;
        internal Label lblDate;
        internal Label labelUsermanager;
        private Label label12;
    }
}