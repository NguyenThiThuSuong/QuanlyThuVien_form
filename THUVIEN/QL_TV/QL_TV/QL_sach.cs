using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TV
{
    public partial class QL_sach : UserControl
    {
        public QL_sach()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sACHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }
    }
}
