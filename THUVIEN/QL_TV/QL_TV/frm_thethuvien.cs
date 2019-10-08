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
    public partial class frm_thethuvien : Form
    {
        public frm_thethuvien()
        {
            InitializeComponent();
        }

        private void tHETHUVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHETHUVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void frm_thethuvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.THETHUVIEN' table. You can move, or remove it, as needed.
            this.tHETHUVIENTableAdapter.Fill(this.dataset_QLTV.THETHUVIEN);

        }
    }
}
