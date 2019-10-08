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
    public partial class QL_Nguoidung : Form
    {
        public QL_Nguoidung()
        {
            InitializeComponent();
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void qLNHOMNDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qLNHOMNDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void QL_Nguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.QLNHOMND' table. You can move, or remove it, as needed.
            this.qLNHOMNDTableAdapter.Fill(this.dataset_QLTV.QLNHOMND);

        }
    }
}
