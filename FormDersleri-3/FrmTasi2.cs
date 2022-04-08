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
    public partial class FrmTasi2 : Form
    {
        public FrmTasi2()
        {
            InitializeComponent();
        }

        public string mesaj;

        private void FrmTasi2_Load(object sender, EventArgs e)
        {
            lbl_msj.Text = mesaj;
        }
    }
}
