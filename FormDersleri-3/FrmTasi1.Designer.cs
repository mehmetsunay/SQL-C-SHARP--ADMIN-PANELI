
namespace FormDersleri_3
{
    partial class FrmTasi1
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
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.btn_isim = new System.Windows.Forms.Button();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(110, 70);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(125, 27);
            this.txt_isim.TabIndex = 0;
            // 
            // btn_isim
            // 
            this.btn_isim.Location = new System.Drawing.Point(124, 143);
            this.btn_isim.Name = "btn_isim";
            this.btn_isim.Size = new System.Drawing.Size(94, 29);
            this.btn_isim.TabIndex = 1;
            this.btn_isim.Text = "GİRİŞ";
            this.btn_isim.UseVisualStyleBackColor = true;
            this.btn_isim.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(22, 70);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(45, 20);
            this.lbl_isim.TabIndex = 2;
            this.lbl_isim.Text = "İSİM :";
            // 
            // FrmTasi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(306, 244);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.btn_isim);
            this.Controls.Add(this.txt_isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmTasi1";
            this.Text = "FrmTasi1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Button btn_isim;
        private System.Windows.Forms.Label lbl_isim;
    }
}