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
    public partial class bien_ban : Form
    {
        public bien_ban()
        {
            InitializeComponent();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bIENBAN_DGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bIENBAN_DGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void bien_ban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.BIENBAN_DG' table. You can move, or remove it, as needed.
            this.bIENBAN_DGTableAdapter.Fill(this.dataset_QLTV.BIENBAN_DG);

        }
    }
}
