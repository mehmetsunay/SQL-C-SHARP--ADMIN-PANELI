
namespace FormDersleri_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_kadi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(167, 51);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(194, 27);
            this.txt_kadi.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(167, 154);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(194, 27);
            this.txt_sifre.TabIndex = 1;
            // 
            // lbl_kadi
            // 
            this.lbl_kadi.AutoSize = true;
            this.lbl_kadi.Location = new System.Drawing.Point(24, 54);
            this.lbl_kadi.Name = "lbl_kadi";
            this.lbl_kadi.Size = new System.Drawing.Size(116, 20);
            this.lbl_kadi.TabIndex = 2;
            this.lbl_kadi.Text = "KULLANICI ADI :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(24, 161);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(45, 20);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "ŞİFRE";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(167, 217);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(94, 29);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(267, 217);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(94, 29);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 280);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kadi);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "LOGİN FORMU";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_kadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
    }
}

