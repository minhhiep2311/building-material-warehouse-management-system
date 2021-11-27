using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Forms.MaterialDetails
{
    public partial class fMaterialDetails : Form
    {
        private readonly Models.Material _material;

        public fMaterialDetails(Models.Material material)
        {
            _material = material;
            InitializeComponent();
        }

        private void fMaterialDetail_Load(object sender, EventArgs e)
        {
            Init();
            BindData();
        }

        private void Init()
        {
            lvwWarehouse.Columns.Add("ID", 0);
            lvwWarehouse.Columns.Add("Tên kho", 100, HorizontalAlignment.Left);
            lvwWarehouse.Columns.Add("Số lượng", 100, HorizontalAlignment.Left);
            lblExport.Focus();
        }

        private void BindData()
        {
            txtId.Text = _material.Id.ToString();
            txtName.Text = _material.Name;
            txtUnit.Text = _material.Unit.Name;
            txtSpecialization.Text = _material.Specialization;
            txtImport.Text = Helper.Converter.ToString(_material.ImportUnitPrice);
            txtExport.Text = Helper.Converter.ToString(_material.ExportUnitPrice);

            var materialWarehouses = _material.GetMaterialInWarehouses();

            materialWarehouses.ForEach(materialWarehouse =>
                {
                    lvwWarehouse.Items.Add(materialWarehouse.ToListViewItem());
                }
            );
        }
    }
}
