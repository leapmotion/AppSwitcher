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
            this.pctRift = new System.Windows.Forms.PictureBox();
            this.pctRegular = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctRift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegular)).BeginInit();
            this.SuspendLayout();
            // 
            // pctRift
            // 
            this.pctRift.Image = global::AppSwitcher.Properties.Resources.smiley;
            this.pctRift.Location = new System.Drawing.Point(214, 97);
            this.pctRift.Name = "pctRift";
            this.pctRift.Size = new System.Drawing.Size(141, 124);
            this.pctRift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRift.TabIndex = 0;
            this.pctRift.TabStop = false;
            this.pctRift.Click += new System.EventHandler(this.OnDirectRiftExeLaunch);
            // 
            // pctRegular
            // 
            this.pctRegular.Image = global::AppSwitcher.Properties.Resources.smiley;
            this.pctRegular.Location = new System.Drawing.Point(33, 97);
            this.pctRegular.Name = "pctRegular";
            this.pctRegular.Size = new System.Drawing.Size(141, 124);
            this.pctRegular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRegular.TabIndex = 1;
            this.pctRegular.TabStop = false;
            this.pctRegular.Click += new System.EventHandler(this.OnRegularExeLaunch);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 318);
            this.Controls.Add(this.pctRegular);
            this.Controls.Add(this.pctRift);
            this.Name = "MainForm";
            this.Text = "[Game Title String]";
            this.Load += new System.EventHandler(this.OnLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.pctRift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctRift;
        private System.Windows.Forms.PictureBox pctRegular;
    }
}

