using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;
using System;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ReceiptDetails
{
    public partial class fImportReceiptDetails : Form
    {
        private readonly ImportReceipt _importReceipt;

        public fImportReceiptDetails(ImportReceipt importReceipt)
        {
            InitializeComponent();
            _importReceipt = importReceipt;
        }

        #region Events
        private void fImportReceiptDetails_Load(object sender, EventArgs e)
        {
            Init();
            BindData();
        }
        

        #endregion

        #region Behavior
        private void BindData()
        {
            txtId.Text = _importReceipt.Id.ToString();
            txtEmployee.Text = _importReceipt.Employee.Name;
            txtSupplier.Text = _importReceipt.Supplier.Name;
            txtWarehouse.Text = _importReceipt.Warehouse.Name;
            txtDate.Text = Helper.Converter.ToString(_importReceipt.DateTime);
            txtTotalPrice.Text = Helper.Converter.ToString(_importReceipt.TotalPrice);

            _importReceipt.Materials = _importReceipt.GetMaterials();

            _importReceipt.Materials.ForEach(material =>
            {
                lvwMaterial.Items.Add(material.ToListViewItem(Models.Material.Type.Export));
            });
        }

        private void Init()
        {
            lvwMaterial.Columns.Add("ID", 0);
            lvwMaterial.Columns.Add("Tên vật liệu", 200, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Đơn giá", 100, HorizontalAlignment.Right);
            lvwMaterial.Columns.Add("Số lượng", 80, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Đơn vị", 70, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Quy cách", 150, HorizontalAlignment.Left);
        }

        #endregion
    }
}
