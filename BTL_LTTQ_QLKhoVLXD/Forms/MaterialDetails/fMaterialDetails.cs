using System;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.MaterialDetails
{
    public partial class fMaterialDetails : Form
    {
        public fMaterialDetails()
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
