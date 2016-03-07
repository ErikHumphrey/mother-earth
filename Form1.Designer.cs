namespace mother_earth
{
    partial class frmLoader
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
            this.lblDev = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.prgFakeLoading = new System.Windows.Forms.ProgressBar();
            this.tmrPrithviSimulator = new System.Windows.Forms.Timer(this.components);
            this.lblLoadMessage = new System.Windows.Forms.Label();
            this.tmrHumor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.BackColor = System.Drawing.Color.Transparent;
            this.lblDev.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(56, 27);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(132, 31);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Microsoft";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Prithvi Simulator X";
            // 
            // prgFakeLoading
            // 
            this.prgFakeLoading.Location = new System.Drawing.Point(51, 95);
            this.prgFakeLoading.Maximum = 1450;
            this.prgFakeLoading.Name = "prgFakeLoading";
            this.prgFakeLoading.Size = new System.Drawing.Size(313, 14);
            this.prgFakeLoading.TabIndex = 3;
            // 
            // tmrPrithviSimulator
            // 
            this.tmrPrithviSimulator.Interval = 20;
            this.tmrPrithviSimulator.Tick += new System.EventHandler(this.tmrPrithviSimulator_Tick);
            // 
            // lblLoadMessage
            // 
            this.lblLoadMessage.AutoSize = true;
            this.lblLoadMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadMessage.ForeColor = System.Drawing.Color.White;
            this.lblLoadMessage.Location = new System.Drawing.Point(48, 113);
            this.lblLoadMessage.Name = "lblLoadMessage";
            this.lblLoadMessage.Size = new System.Drawing.Size(113, 13);
            this.lblLoadMessage.TabIndex = 4;
            this.lblLoadMessage.Text = "Loading the program...";
            // 
            // tmrHumor
            // 
            this.tmrHumor.Interval = 850;
            this.tmrHumor.Tick += new System.EventHandler(this.tmrHumor_Tick);
            // 
            // frmLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::mother_earth.Properties.Resources._1757527;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 135);
            this.Controls.Add(this.lblLoadMessage);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.prgFakeLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLoader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar prgFakeLoading;
        private System.Windows.Forms.Timer tmrPrithviSimulator;
        private System.Windows.Forms.Label lblLoadMessage;
        private System.Windows.Forms.Timer tmrHumor;
    }
}

