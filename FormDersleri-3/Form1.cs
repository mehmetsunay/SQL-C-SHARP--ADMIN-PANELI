using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormDersleri_3
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
      

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblUser where usr=@user AND psw=@pass";

            con = new SqlConnection("server=DESKTOP-H2G18BP\\SQLEXPRESS; Initial Catalog=dbLogin; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txt_kadi.Text);
            cmd.Parameters.AddWithValue("@pass", txt_sifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())

           {
                MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
             }

            else
            {

                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

            }


            con.Close();


        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
           
        }
    }
}
