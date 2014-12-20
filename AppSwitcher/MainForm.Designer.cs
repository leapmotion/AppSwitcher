namespace AppSwitcher
{
    partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.lblStandardExe = new System.Windows.Forms.Label();
      this.lblDirectRiftExe = new System.Windows.Forms.Label();
      this.pctRegular = new System.Windows.Forms.PictureBox();
      this.pctRift = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pctRegular)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctRift)).BeginInit();
      this.SuspendLayout();
      // 
      // lblStandardExe
      // 
      this.lblStandardExe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStandardExe.ForeColor = System.Drawing.Color.White;
      this.lblStandardExe.Location = new System.Drawing.Point(44, 168);
      this.lblStandardExe.Name = "lblStandardExe";
      this.lblStandardExe.Size = new System.Drawing.Size(132, 52);
      this.lblStandardExe.TabIndex = 3;
      this.lblStandardExe.Text = "Standard\r\nExecutable";
      this.lblStandardExe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblDirectRiftExe
      // 
      this.lblDirectRiftExe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDirectRiftExe.ForeColor = System.Drawing.Color.White;
      this.lblDirectRiftExe.Location = new System.Drawing.Point(228, 168);
      this.lblDirectRiftExe.Name = "lblDirectRiftExe";
      this.lblDirectRiftExe.Size = new System.Drawing.Size(132, 52);
      this.lblDirectRiftExe.TabIndex = 4;
      this.lblDirectRiftExe.Text = "Direct to HMD\r\nExecutable";
      this.lblDirectRiftExe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pctRegular
      // 
      this.pctRegular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.pctRegular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.pctRegular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pctRegular.Image = ((System.Drawing.Image)(resources.GetObject("pctRegular.Image")));
      this.pctRegular.Location = new System.Drawing.Point(46, 32);
      this.pctRegular.Name = "pctRegular";
      this.pctRegular.Size = new System.Drawing.Size(128, 128);
      this.pctRegular.TabIndex = 1;
      this.pctRegular.TabStop = false;
      this.pctRegular.Click += new System.EventHandler(this.OnRegularExeLaunch);
      // 
      // pctRift
      // 
      this.pctRift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.pctRift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.pctRift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pctRift.Image = global::AppSwitcher.Properties.Resources.hmd_icon;
      this.pctRift.Location = new System.Drawing.Point(230, 32);
      this.pctRift.Name = "pctRift";
      this.pctRift.Size = new System.Drawing.Size(128, 128);
      this.pctRift.TabIndex = 0;
      this.pctRift.TabStop = false;
      this.pctRift.Click += new System.EventHandler(this.OnDirectRiftExeLaunch);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(404, 241);
      this.Controls.Add(this.lblDirectRiftExe);
      this.Controls.Add(this.lblStandardExe);
      this.Controls.Add(this.pctRegular);
      this.Controls.Add(this.pctRift);
      this.MaximumSize = new System.Drawing.Size(420, 280);
      this.MinimumSize = new System.Drawing.Size(420, 280);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "[Game Title String]";
      this.Load += new System.EventHandler(this.OnLoaded);
      ((System.ComponentModel.ISupportInitialize)(this.pctRegular)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctRift)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctRift;
        private System.Windows.Forms.PictureBox pctRegular;
        private System.Windows.Forms.Label lblStandardExe;
        private System.Windows.Forms.Label lblDirectRiftExe;
    }
}

