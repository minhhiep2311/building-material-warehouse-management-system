using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.MaterialDetails
{
    public partial class fMaterialDetail : Form
    {
        public fMaterialDetail()
        {
            InitializeComponent();
        }

        private void fMaterialDetail_Load(object sender, EventArgs e)
        {
            Init_MaterialDetail();
        }
        private void Init_MaterialDetail()
        {
            lvwWarehouse.Columns.Add("ID", 0);
            lvwWarehouse.Columns.Add("Tên kho", 100, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Số lượng", 100, HorizontalAlignment.Left);
 
        }

        
    }
}
