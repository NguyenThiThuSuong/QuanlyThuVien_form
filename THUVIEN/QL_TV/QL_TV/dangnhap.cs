using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TV
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            textBoxX1.ForeColor = Color.LightGray;
            textBoxX1.Text = "Tên đăng nhập";

            this.textBoxX1.Leave += new System.EventHandler(this.textBoxX1_Leaver);
            this.textBoxX1.Enter += new System.EventHandler(this.textBoxX1_Enter);

            textBoxX2.ForeColor = Color.LightGray;
            textBoxX2.Text = "Mật khẩu";
            this.textBoxX2.Leave += new System.EventHandler(this.textBoxX2_Leaver);
            this.textBoxX2.Enter += new System.EventHandler(this.textBoxX2_Enter);

        }

        private void textBoxX1_Leaver(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                textBoxX1.Text = "Tên đăng nhập";
                textBoxX1.ForeColor = Color.Gray;
            }
        }





     public void   textBoxX1_Enter (object sender, EventArgs e)
        {
            if (textBoxX1.Text == "Tên đăng nhập")
            {
                textBoxX1.Text = "";
                textBoxX1.ForeColor = Color.Black;
            }
        }


     public void textBoxX2_Enter(object sender, EventArgs e)
     {
         if (textBoxX2.Text == "Mật khẩu")
         {
             textBoxX2.Text = "";
             textBoxX2.ForeColor = Color.Black;
         }
     }

     public void textBoxX2_Leaver(object sender, EventArgs e)
     {
         if (textBoxX2.Text == "")
         {
             textBoxX2.Text = "Mật khẩu";
             textBoxX2.ForeColor = Color.Gray;
         }
     }
    }
}
