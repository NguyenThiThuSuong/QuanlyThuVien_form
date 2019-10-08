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
    public partial class phanquyen : Form
    {
        public phanquyen()
        {
            InitializeComponent();
        }

        private void qLPHANQUYENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qLPHANQUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void phanquyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.QLPHANQUYEN' table. You can move, or remove it, as needed.
            this.qLPHANQUYENTableAdapter.Fill(this.dataset_QLTV.QLPHANQUYEN);

        }
    }
}
