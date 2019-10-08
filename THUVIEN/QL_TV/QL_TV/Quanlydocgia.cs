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
    public partial class Quanlydocgia : Form
    {
        public Quanlydocgia()
        {
            InitializeComponent();
        }

        private void dOCGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCGIABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void Quanlydocgia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_QLTV.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.dataset_QLTV.DOCGIA);

        }
    }
}
