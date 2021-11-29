using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BTL_LTTQ_QLKhoVLXD.Forms.ReceiptDetails
{
    public partial class fExportReceiptDetails : Form
    {
        private readonly ExportReceipt _exportReceipt;
        private List<Models.Material> _materials;

        public fExportReceiptDetails(ExportReceipt exportReceipt)
        {
            InitializeComponent();
            _exportReceipt = exportReceipt;
        }

        #region Events
        private void fExportReceiptDetails_Load(object sender, EventArgs e)
        {
            Init();
            BindData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        
        #region Behaviors
        
        private void BindData()
        {
            txtId.Text = _exportReceipt.Id.ToString();
            txtEmployee.Text = _exportReceipt.Employee.Name;
            txtCustomer.Text = _exportReceipt.Customer.Name;
            txtWarehouse.Text = _exportReceipt.Warehouse.Name;
            txtVat.Text = Helper.Converter.ToString(_exportReceipt.Vat);
            txtDate.Text = Helper.Converter.ToString(_exportReceipt.DateTime);
            txtReason.Text = _exportReceipt.Reason;
            txtTotalPrice.Text = Helper.Converter.ToString(_exportReceipt.TotalPrice);

            _materials = _exportReceipt.GetMaterials();

            _materials.ForEach(material =>
            {
                lvwMaterial.Items.Add(material.ToListViewItem());
            });
        }

        private void Init()
        {
            lvwMaterial.Columns.Add("ID", 0);
            lvwMaterial.Columns.Add("Tên vật liệu", 300, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Đơn giá", 100, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Số lượng", 100, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Đơn vị", 75, HorizontalAlignment.Left);
            lvwMaterial.Columns.Add("Quy cách", 150, HorizontalAlignment.Left);
        }

        #endregion
    }
}
