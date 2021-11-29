using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ReceiptDetails
{
    public partial class fImportReceiptDetails : Form
    {
        private readonly ImportReceipt importReceipt;

        public fImportReceiptDetails(ImportReceipt importReceipt)
        {
            InitializeComponent();
            this.importReceipt = importReceipt;
        }

        #region Events
        private void fImportReceiptDetails_Load(object sender, EventArgs e)
        {
            Init();
            Binddata();
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
        private void Binddata()
        {
            txtId.Text = importReceipt.Id.ToString();
            txtEmployee.Text = importReceipt.Employee.Name;
            txtSupplier.Text = importReceipt.Supplier.Name;
            txtWarehouse.Text = importReceipt.Warehouse.Name;
            txtDate.Text = Helper.Converter.ToString(importReceipt.DateTime);
            txtTotalPrice.Text = Helper.Converter.ToString(importReceipt.TotalPrice);

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
