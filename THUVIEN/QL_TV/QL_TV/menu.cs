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
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();
           
        }
        int p = 70;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelEx1.Width != p)
            {
                panelEx1.Width = p;
                panel3.Hide();
                panel4.Show();
                bntthe.Enabled = !u;
                bntnv.Enabled = !u;
                bntmuontra.Enabled = !u;
                bnthe.Enabled = !u;
                bntdg.Enabled = !u;
                bntbienban.Enabled = !u;
                bntsach.Enabled =! u;   
            }
        }
       bool u = true;
       
        private void menu_Load(object sender, EventArgs e)
        {
            panelEx1.Width = p;
            panel3.Hide();
            bntthe.Enabled =!u;
            bntnv.Enabled = !u;
            bntmuontra.Enabled =!u;
            bnthe.Enabled =!u;
            bntdg.Enabled =!u;
            bntbienban.Enabled =!u;
            bntsach.Enabled =! u;   

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelEx1.Width == p)
            {
                panelEx1.Width = 280;
                panel4.Hide();
                panel3.Show();
                bntthe.Enabled =u;
                bntnv.Enabled = u;
                bntmuontra.Enabled = u;
                bnthe.Enabled = u;
                bntdg.Enabled = u;
                bntbienban.Enabled = u;
                bntsach.Enabled = u;   
            }
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không được chọn");
        }

        private void bntthe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không được chọn");
        }

        private void bntmuonsach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không được chọn");
        }

        private void bntmuontra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không được chọn");
        }

        private void bntnv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không được chọn");
        }

        private void bntbienban_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không được chọn");
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem20_Click(object sender, EventArgs e)
        {

        }
    }
}