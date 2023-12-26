namespace Gazi.OkulAppSube2BLG
{
    partial class frmGiris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmOgr = new System.Windows.Forms.Button();
            this.frmOgrt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.frmOgr);
            this.groupBox1.Controls.Add(this.frmOgrt);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frmOgr
            // 
            this.frmOgr.Location = new System.Drawing.Point(27, 89);
            this.frmOgr.Name = "frmOgr";
            this.frmOgr.Size = new System.Drawing.Size(216, 23);
            this.frmOgr.TabIndex = 13;
            this.frmOgr.Text = "Öğrenci Kaydı İçin Tıklayınız";
            this.frmOgr.UseVisualStyleBackColor = true;
            this.frmOgr.Click += new System.EventHandler(this.frmOgr_Click);
            // 
            // frmOgrt
            // 
            this.frmOgrt.Location = new System.Drawing.Point(27, 137);
            this.frmOgrt.Name = "frmOgrt";
            this.frmOgrt.Size = new System.Drawing.Size(216, 23);
            this.frmOgrt.TabIndex = 12;
            this.frmOgrt.Text = "Ogretmen Kaydı İçin Tıklayınız";
            this.frmOgrt.UseVisualStyleBackColor = true;
            this.frmOgrt.Click += new System.EventHandler(this.frmOgrt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmOgr;
        private System.Windows.Forms.Button frmOgrt;
    }
}