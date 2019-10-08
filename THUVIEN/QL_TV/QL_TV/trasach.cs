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
    public partial class trasach : UserControl
    {
        public trasach()
        {
            InitializeComponent();
        }

        private void mUONTRASACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mUONTRASACHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset_QLTV);

        }
    }
}
