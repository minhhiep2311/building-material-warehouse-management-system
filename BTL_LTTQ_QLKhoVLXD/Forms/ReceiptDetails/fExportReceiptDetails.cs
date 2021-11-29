using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;
using System;
using System.Windows.Forms;


namespace BTL_LTTQ_QLKhoVLXD.Forms.ReceiptDetails
{
    public partial class fExportReceiptDetails : Form
    {
        private readonly ExportReceipt exportReceipt;

        public fExportReceiptDetails(ExportReceipt exportReceipt)
        {
            InitializeComponent();
            this.exportReceipt = exportReceipt;
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
        #region Behavior
        private void BindData()
        {
            txtId.Text = exportReceipt.Id.ToString();
            txtEmployee.Text = exportReceipt.Employee.Name;
            txtCustomer.Text = exportReceipt.Customer.Name;
            txtWarehouse.Text = exportReceipt.Warehouse.Name;
            txtVat.Text = Helper.Converter.ToString(exportReceipt.Vat);
            txtVatPercent.Text = Helper.Converter.ToString(exportReceipt.VatPercent);
            txtDate.Text = Helper.Converter.ToString(exportReceipt.DateTime);
            txtReason.Text = exportReceipt.Reason;
            txtTotalPrice.Text = Helper.Converter.ToString(exportReceipt.TotalPrice);

            /*var materialWarehouses = exportReceipt.GetExportReceipts();

            materialWarehouses.ForEach(materialWarehouse =>
            {
                lvwMaterial.Items.Add(materialWarehouse.ToListViewItem());
            }
            );*/
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
