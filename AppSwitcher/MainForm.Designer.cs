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
            this.label1 = new System.Windows.Forms.Label();
            this.pctRegular = new System.Windows.Forms.PictureBox();
            this.pctRift = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRift)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Standard Executable";
            // 
            // pctRegular
            // 
            this.pctRegular.BackColor = System.Drawing.Color.Transparent;
            this.pctRegular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctRegular.Location = new System.Drawing.Point(12, 18);
            this.pctRegular.Name = "pctRegular";
            this.pctRegular.Size = new System.Drawing.Size(164, 145);
            this.pctRegular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRegular.TabIndex = 1;
            this.pctRegular.TabStop = false;
            this.pctRegular.Click += new System.EventHandler(this.OnRegularExeLaunch);
            // 
            // pctRift
            // 
            this.pctRift.BackColor = System.Drawing.Color.Transparent;
            this.pctRift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctRift.Location = new System.Drawing.Point(200, 18);
            this.pctRift.Name = "pctRift";
            this.pctRift.Size = new System.Drawing.Size(151, 145);
            this.pctRift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRift.TabIndex = 0;
            this.pctRift.TabStop = false;
            this.pctRift.Click += new System.EventHandler(this.OnDirectRiftExeLaunch);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Launch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Launch Direct";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "to Rift Executable";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::AppSwitcher.Properties.Resources.Oculus;
            this.ClientSize = new System.Drawing.Size(363, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctRegular);
            this.Controls.Add(this.pctRift);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "MainForm";
            this.Text = "[Game Title String]";
            this.Load += new System.EventHandler(this.OnLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.pctRegular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctRift;
        private System.Windows.Forms.PictureBox pctRegular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

