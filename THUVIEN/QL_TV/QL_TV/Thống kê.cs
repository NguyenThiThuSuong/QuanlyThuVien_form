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
    public partial class Thống_kê : Form
    {
        public Thống_kê()
        {
            InitializeComponent();
        }

        private void tHONGKEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHONGKEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void Thống_kê_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.THONGKE' table. You can move, or remove it, as needed.
            this.tHONGKETableAdapter.Fill(this.dataset_QLTV.THONGKE);

        }
    }
}
