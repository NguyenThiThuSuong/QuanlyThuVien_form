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
    public partial class muonsach : UserControl
    {
        public muonsach()
        {
            InitializeComponent();
        }

        private void mUONTRASACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mUONTRASACHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }

        private void mUONTRASACHBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mUONTRASACHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }
    }
}
