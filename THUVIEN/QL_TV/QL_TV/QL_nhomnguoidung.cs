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
    public partial class QL_nhomnguoidung : Form
    {
        public QL_nhomnguoidung()
        {
            InitializeComponent();
        }

        private void qLNDNHOMNDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qLNDNHOMNDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void QL_nhomnguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.QLNDNHOMND' table. You can move, or remove it, as needed.
            this.qLNDNHOMNDTableAdapter.Fill(this.dataset_QLTV.QLNDNHOMND);

        }
    }
}
