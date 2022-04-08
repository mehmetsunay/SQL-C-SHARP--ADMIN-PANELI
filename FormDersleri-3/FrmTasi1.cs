using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersleri_3
{
    public partial class FrmTasi1 : Form
    {
        public FrmTasi1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTasi2 frm = new FrmTasi2();
            frm.mesaj = txt_isim.Text;
            frm.Show();
            this.Hide();

        }
    }
}
