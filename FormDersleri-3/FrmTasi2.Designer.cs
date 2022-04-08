
namespace FormDersleri_3
{
    partial class FrmTasi2
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
            this.lbl_msj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_msj
            // 
            this.lbl_msj.AutoSize = true;
            this.lbl_msj.Location = new System.Drawing.Point(30, 28);
            this.lbl_msj.Name = "lbl_msj";
            this.lbl_msj.Size = new System.Drawing.Size(69, 20);
            this.lbl_msj.TabIndex = 0;
            this.lbl_msj.Text = "VERİ ÇEK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(182, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 137);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTasi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(525, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_msj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmTasi2";
            this.Text = "FrmTasi2";
            this.Load += new System.EventHandler(this.FrmTasi2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_msj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}