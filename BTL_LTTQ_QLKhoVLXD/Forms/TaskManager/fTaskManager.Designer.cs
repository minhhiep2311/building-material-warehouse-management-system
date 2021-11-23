using BTL_LTTQ_QLKhoVLXD.Controls.Button;
using BTL_LTTQ_QLKhoVLXD.Controls.GroupBox;
using BTL_LTTQ_QLKhoVLXD.Controls.ListView;
using BTL_LTTQ_QLKhoVLXD.Controls.NumericUpDown;
using BTL_LTTQ_QLKhoVLXD.Controls.TabControl;

namespace BTL_LTTQ_QLKhoVLXD.Forms.TaskManager
{
    partial class fTaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cms_employee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowInformation_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateAccount_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAccount_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteEmployee_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_supplier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowInformation_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSupplier_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tpgUserSetting = new System.Windows.Forms.TabPage();
            this.flp_userSetting = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateAccount_userSetting = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnChangeInformation_userSetting = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnResetPassword_userSetting = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.tpgEmployee = new System.Windows.Forms.TabPage();
            this.spc_employee = new System.Windows.Forms.SplitContainer();
            this.lvwEmployee_employee = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.flpFunction_employee = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd_employee = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnEdit_employee = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnCreateAccount_employee = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRemoveAccount_employee = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRemoveEmployee_employee = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRefresh_employee = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlSearch_employe = new System.Windows.Forms.Panel();
            this.grbSearch_employee = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.pnlAccount_employee = new System.Windows.Forms.Panel();
            this.lblAccount_employee = new System.Windows.Forms.Label();
            this.txtAccount_employee = new System.Windows.Forms.TextBox();
            this.pnlPosition_employee = new System.Windows.Forms.Panel();
            this.flpPosition_employee = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPosition_employee = new System.Windows.Forms.Label();
            this.pnlGender_employee = new System.Windows.Forms.Panel();
            this.rdoFemale_employee = new System.Windows.Forms.RadioButton();
            this.rdoMale_employee = new System.Windows.Forms.RadioButton();
            this.rdoAll_employee = new System.Windows.Forms.RadioButton();
            this.lblGender_employee = new System.Windows.Forms.Label();
            this.pnlPhone_employee = new System.Windows.Forms.Panel();
            this.lblPhone_employee = new System.Windows.Forms.Label();
            this.txtPhone_employee = new System.Windows.Forms.TextBox();
            this.pnlAddress_employee = new System.Windows.Forms.Panel();
            this.lblAddress_employee = new System.Windows.Forms.Label();
            this.txtAddress_employee = new System.Windows.Forms.TextBox();
            this.pnlName_employee = new System.Windows.Forms.Panel();
            this.lblName_employee = new System.Windows.Forms.Label();
            this.txtName_employee = new System.Windows.Forms.TextBox();
            this.tpgSupplier = new System.Windows.Forms.TabPage();
            this.spc_supplier = new System.Windows.Forms.SplitContainer();
            this.lvwSupplier_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.flpFunction_supplier = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnEdit_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnDelete_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnExport_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRefresh_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbSearch_supplier = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.pnlPhone_supplier = new System.Windows.Forms.Panel();
            this.lblPhone_supplier = new System.Windows.Forms.Label();
            this.txtPhone_supplier = new System.Windows.Forms.TextBox();
            this.pnlAddress_supplier = new System.Windows.Forms.Panel();
            this.lblAddress_supplier = new System.Windows.Forms.Label();
            this.txtAddress_supplier = new System.Windows.Forms.TextBox();
            this.pnlName_supplier = new System.Windows.Forms.Panel();
            this.lblName_supplier = new System.Windows.Forms.Label();
            this.txtName_supplier = new System.Windows.Forms.TextBox();
            this.tpgCustomer = new System.Windows.Forms.TabPage();
            this.panel1_Customer = new System.Windows.Forms.Panel();
            this.spc_customer = new System.Windows.Forms.SplitContainer();
            this.lvwCustomer_customer = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.flp_customer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd_Customer = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnEdit_Customer = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnDelete_Customer = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnExport_Customer = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRefresh_Customer = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbSearch_Customer = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.pnlPhone_customer = new System.Windows.Forms.Panel();
            this.lblPhone_customer = new System.Windows.Forms.Label();
            this.txtPhone_customer = new System.Windows.Forms.TextBox();
            this.pnlAddress_customer = new System.Windows.Forms.Panel();
            this.lblAddress_customer = new System.Windows.Forms.Label();
            this.txtAddress_customer = new System.Windows.Forms.TextBox();
            this.pnlName_customer = new System.Windows.Forms.Panel();
            this.lblName_customer = new System.Windows.Forms.Label();
            this.txtName_customer = new System.Windows.Forms.TextBox();
            this.tpgStatistic = new System.Windows.Forms.TabPage();
            this.tpgMaterial = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwMaterial_material = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.flpFunction_material = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd_material = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnEdit_material = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnDelete_material = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnExport_material = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRefersh_material = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbSearchMaterial_material = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.pnlSpecialization_material = new System.Windows.Forms.Panel();
            this.lblSpecialization_material = new System.Windows.Forms.Label();
            this.txtSpecialization_material = new System.Windows.Forms.TextBox();
            this.pnllblExportUnitPrice_material = new System.Windows.Forms.Panel();
            this.lblExportUnitPrice_material = new System.Windows.Forms.Label();
            this.txtlblExportUnitPrice_material = new System.Windows.Forms.TextBox();
            this.pnlImportUnitPrice_material = new System.Windows.Forms.Panel();
            this.lblImportUnitPrice_material = new System.Windows.Forms.Label();
            this.txtImportUnitPrice_material = new System.Windows.Forms.TextBox();
            this.pnlNameMaterial_material = new System.Windows.Forms.Panel();
            this.lblNameMaterial_material = new System.Windows.Forms.Label();
            this.txtNameMaterial_material = new System.Windows.Forms.TextBox();
            this.tpgReceipt = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwReceipt_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.flpFunction_receipt = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnEdit_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnDelete_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnExport_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnRefresh_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbSearch_receipt = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.pnlEmployeeReceipt_receipt = new System.Windows.Forms.Panel();
            this.txtEmployeeReceipt_receipt = new System.Windows.Forms.TextBox();
            this.lblEmployeeReceipt_receipt = new System.Windows.Forms.Label();
            this.pnlReceiptType_receipt = new System.Windows.Forms.Panel();
            this.rdbExport_receipt = new System.Windows.Forms.RadioButton();
            this.rdbImport_receipt = new System.Windows.Forms.RadioButton();
            this.lblReceiptType_receipt = new System.Windows.Forms.Label();
            this.pnlWareHouse_receipt = new System.Windows.Forms.Panel();
            this.cbbWareHouse_receipt = new BTL_LTTQ_QLKhoVLXD.Controls.ComboBox.BmwComboBox();
            this.lblWareHouse_receipt = new System.Windows.Forms.Label();
            this.pnlPartner_receipt = new System.Windows.Forms.Panel();
            this.lblPartner_receipt = new System.Windows.Forms.Label();
            this.txtPrice_Receipt = new System.Windows.Forms.TextBox();
            this.pnlDate_receipt = new System.Windows.Forms.Panel();
            this.dtpDateTo_receipt = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom_receipt = new System.Windows.Forms.DateTimePicker();
            this.lblDate_receipt = new System.Windows.Forms.Label();
            this.pnlID_receipt = new System.Windows.Forms.Panel();
            this.lblId_receipt = new System.Windows.Forms.Label();
            this.txtId_receipt = new System.Windows.Forms.TextBox();
            this.bmwListView1 = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bmwButton1 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton2 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton3 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton4 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton5 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbSearch_material = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlA = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pnlName_material = new System.Windows.Forms.Panel();
            this.lblName_material = new System.Windows.Forms.Label();
            this.txtName_material = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bmwButton6 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton7 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton8 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton9 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwButton10 = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.bmwGroupBox1 = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tpgSell = new System.Windows.Forms.TabPage();
            this.grbItemInfor_sell = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lvwItem_sell = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.pnlBottom_sell = new System.Windows.Forms.Panel();
            this.pnlTotalMoney_sell = new System.Windows.Forms.Panel();
            this.lblTotalMoney_sell = new System.Windows.Forms.Label();
            this.txtTotalMoney_sell = new System.Windows.Forms.TextBox();
            this.btnCreateReceipt_sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnPrintReceipt_sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddItem = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlItemName_sell = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblItemName_sell = new System.Windows.Forms.Label();
            this.pnlNumerous_sell = new System.Windows.Forms.Panel();
            this.nmrNumerouse_sell = new BTL_LTTQ_QLKhoVLXD.Controls.NumericUpDown.BmwNumericUpDown();
            this.lblNumerous_sell = new System.Windows.Forms.Label();
            this.pnlItemUnitPrice_sell = new System.Windows.Forms.Panel();
            this.lblItemUnitPrice_sell = new System.Windows.Forms.Label();
            this.txtItemUnitPrice_sell = new System.Windows.Forms.TextBox();
            this.grbGeneralInfor_sell = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.btnAddCustomer_sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.txtAddress_sell = new System.Windows.Forms.TextBox();
            this.txtCustomerName_sell = new System.Windows.Forms.TextBox();
            this.lblAddress_sell = new System.Windows.Forms.Label();
            this.lblCustomerName_sell = new System.Windows.Forms.Label();
            this.pnlTitle_sell = new System.Windows.Forms.Panel();
            this.lblTitle_sell = new System.Windows.Forms.Label();
            this.tpgBuy = new System.Windows.Forms.TabPage();
            this.grbItemInfor_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lvwItem_buy = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.pnlBottom_buy = new System.Windows.Forms.Panel();
            this.btnCancel_buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlTotalMoney = new System.Windows.Forms.Panel();
            this.lblTotalMoney_Buy = new System.Windows.Forms.Label();
            this.txtTotalMoney_Buy = new System.Windows.Forms.TextBox();
            this.btnCreateReceipt_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnPrintReceipt_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlItem_buy = new System.Windows.Forms.Panel();
            this.btnDeleteItem_buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlSpecialization_buy = new System.Windows.Forms.Panel();
            this.txtSpecializtion_buy = new System.Windows.Forms.TextBox();
            this.lblSpecialization_buy = new System.Windows.Forms.Label();
            this.btnAddItem_buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlItemName_buy = new System.Windows.Forms.Panel();
            this.btnAddMaterial_buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.cboItem_buy = new BTL_LTTQ_QLKhoVLXD.Controls.ComboBox.BmwComboBox();
            this.lblMaterialName_Buy = new System.Windows.Forms.Label();
            this.pnlNumerous_buy = new System.Windows.Forms.Panel();
            this.nmrMaterialAmount_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.NumericUpDown.BmwNumericUpDown();
            this.lblMaterialAmount_Buy = new System.Windows.Forms.Label();
            this.pnlItemUnitPrice_buy = new System.Windows.Forms.Panel();
            this.nmrUnitPrice_buy = new BTL_LTTQ_QLKhoVLXD.Controls.NumericUpDown.BmwNumericUpDown();
            this.lblMaterialUnitPrice_Buy = new System.Windows.Forms.Label();
            this.grbGeneralInfor_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.cboWarehouse_buy = new BTL_LTTQ_QLKhoVLXD.Controls.ComboBox.BmwComboBox();
            this.lblWarehouse_buy = new System.Windows.Forms.Label();
            this.cboSupplier_buy = new BTL_LTTQ_QLKhoVLXD.Controls.ComboBox.BmwComboBox();
            this.btnAddSupplier_buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.txtAddress_buy = new System.Windows.Forms.TextBox();
            this.lblAddress_Buy = new System.Windows.Forms.Label();
            this.lblSupplierName_Buy = new System.Windows.Forms.Label();
            this.pnlTitle_buy = new System.Windows.Forms.Panel();
            this.lblTitle_buy = new System.Windows.Forms.Label();
            this.tclMain = new BTL_LTTQ_QLKhoVLXD.Controls.TabControl.BmwTabControl();
            this.btnWareHouse_material = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.panel3.SuspendLayout();
            this.cms_employee.SuspendLayout();
            this.cms_supplier.SuspendLayout();
            this.tpgUserSetting.SuspendLayout();
            this.flp_userSetting.SuspendLayout();
            this.tpgEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_employee)).BeginInit();
            this.spc_employee.Panel1.SuspendLayout();
            this.spc_employee.Panel2.SuspendLayout();
            this.spc_employee.SuspendLayout();
            this.flpFunction_employee.SuspendLayout();
            this.pnlSearch_employe.SuspendLayout();
            this.grbSearch_employee.SuspendLayout();
            this.pnlAccount_employee.SuspendLayout();
            this.pnlPosition_employee.SuspendLayout();
            this.pnlGender_employee.SuspendLayout();
            this.pnlPhone_employee.SuspendLayout();
            this.pnlAddress_employee.SuspendLayout();
            this.pnlName_employee.SuspendLayout();
            this.tpgSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_supplier)).BeginInit();
            this.spc_supplier.Panel1.SuspendLayout();
            this.spc_supplier.Panel2.SuspendLayout();
            this.spc_supplier.SuspendLayout();
            this.flpFunction_supplier.SuspendLayout();
            this.grbSearch_supplier.SuspendLayout();
            this.pnlPhone_supplier.SuspendLayout();
            this.pnlAddress_supplier.SuspendLayout();
            this.pnlName_supplier.SuspendLayout();
            this.tpgCustomer.SuspendLayout();
            this.panel1_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_customer)).BeginInit();
            this.spc_customer.Panel1.SuspendLayout();
            this.spc_customer.Panel2.SuspendLayout();
            this.spc_customer.SuspendLayout();
            this.flp_customer.SuspendLayout();
            this.grbSearch_Customer.SuspendLayout();
            this.pnlPhone_customer.SuspendLayout();
            this.pnlAddress_customer.SuspendLayout();
            this.pnlName_customer.SuspendLayout();
            this.tpgMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpFunction_material.SuspendLayout();
            this.grbSearchMaterial_material.SuspendLayout();
            this.pnlSpecialization_material.SuspendLayout();
            this.pnllblExportUnitPrice_material.SuspendLayout();
            this.pnlImportUnitPrice_material.SuspendLayout();
            this.pnlNameMaterial_material.SuspendLayout();
            this.tpgReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flpFunction_receipt.SuspendLayout();
            this.grbSearch_receipt.SuspendLayout();
            this.pnlEmployeeReceipt_receipt.SuspendLayout();
            this.pnlReceiptType_receipt.SuspendLayout();
            this.pnlWareHouse_receipt.SuspendLayout();
            this.pnlPartner_receipt.SuspendLayout();
            this.pnlDate_receipt.SuspendLayout();
            this.pnlID_receipt.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbSearch_material.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.pnlName_material.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.bmwGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpgSell.SuspendLayout();
            this.grbItemInfor_sell.SuspendLayout();
            this.pnlBottom_sell.SuspendLayout();
            this.pnlTotalMoney_sell.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlItemName_sell.SuspendLayout();
            this.pnlNumerous_sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumerouse_sell)).BeginInit();
            this.pnlItemUnitPrice_sell.SuspendLayout();
            this.grbGeneralInfor_sell.SuspendLayout();
            this.pnlTitle_sell.SuspendLayout();
            this.tpgBuy.SuspendLayout();
            this.grbItemInfor_Buy.SuspendLayout();
            this.pnlBottom_buy.SuspendLayout();
            this.pnlTotalMoney.SuspendLayout();
            this.pnlItem_buy.SuspendLayout();
            this.pnlSpecialization_buy.SuspendLayout();
            this.pnlItemName_buy.SuspendLayout();
            this.pnlNumerous_buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaterialAmount_Buy)).BeginInit();
            this.pnlItemUnitPrice_buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice_buy)).BeginInit();
            this.grbGeneralInfor_Buy.SuspendLayout();
            this.pnlTitle_buy.SuspendLayout();
            this.tclMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPosition);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 615);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1279, 57);
            this.panel3.TabIndex = 3;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(423, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(71, 17);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Người dùng:";
            // 
            // cms_employee
            // 
            this.cms_employee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_employee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowInformation_employee,
            this.tsmiCreateAccount_employee,
            this.tsmiDeleteAccount_employee,
            this.tsmiDeleteEmployee_employee});
            this.cms_employee.Name = "cms_employee";
            this.cms_employee.Size = new System.Drawing.Size(173, 100);
            // 
            // tsmiShowInformation_employee
            // 
            this.tsmiShowInformation_employee.Name = "tsmiShowInformation_employee";
            this.tsmiShowInformation_employee.Size = new System.Drawing.Size(172, 24);
            this.tsmiShowInformation_employee.Text = "Xem thông tin";
            this.tsmiShowInformation_employee.Click += new System.EventHandler(this.tsmiShowInformation_employee_Click);
            // 
            // tsmiCreateAccount_employee
            // 
            this.tsmiCreateAccount_employee.Name = "tsmiCreateAccount_employee";
            this.tsmiCreateAccount_employee.Size = new System.Drawing.Size(172, 24);
            this.tsmiCreateAccount_employee.Text = "Tạo tài khoản";
            this.tsmiCreateAccount_employee.Click += new System.EventHandler(this.tsmiCreateAccount_employee_Click);
            // 
            // tsmiDeleteAccount_employee
            // 
            this.tsmiDeleteAccount_employee.Name = "tsmiDeleteAccount_employee";
            this.tsmiDeleteAccount_employee.Size = new System.Drawing.Size(172, 24);
            this.tsmiDeleteAccount_employee.Text = "Xóa tài khoản";
            this.tsmiDeleteAccount_employee.Click += new System.EventHandler(this.tsmiDeleteAccount_employee_Click);
            // 
            // tsmiDeleteEmployee_employee
            // 
            this.tsmiDeleteEmployee_employee.Name = "tsmiDeleteEmployee_employee";
            this.tsmiDeleteEmployee_employee.Size = new System.Drawing.Size(172, 24);
            this.tsmiDeleteEmployee_employee.Text = "Xóa nhân viên";
            this.tsmiDeleteEmployee_employee.Click += new System.EventHandler(this.tsmiDeleteEmployee_employee_Click);
            // 
            // cms_supplier
            // 
            this.cms_supplier.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_supplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowInformation_supplier,
            this.tsmiDeleteSupplier_supplier});
            this.cms_supplier.Name = "cms_supplier";
            this.cms_supplier.Size = new System.Drawing.Size(197, 52);
            // 
            // tsmiShowInformation_supplier
            // 
            this.tsmiShowInformation_supplier.Name = "tsmiShowInformation_supplier";
            this.tsmiShowInformation_supplier.Size = new System.Drawing.Size(196, 24);
            this.tsmiShowInformation_supplier.Text = "Thêm thông tin";
            this.tsmiShowInformation_supplier.Click += new System.EventHandler(this.tsmiShowInformation_supplier_Click);
            // 
            // tsmiDeleteSupplier_supplier
            // 
            this.tsmiDeleteSupplier_supplier.Name = "tsmiDeleteSupplier_supplier";
            this.tsmiDeleteSupplier_supplier.Size = new System.Drawing.Size(196, 24);
            this.tsmiDeleteSupplier_supplier.Text = "Xóa nhà cung cấp";
            this.tsmiDeleteSupplier_supplier.Click += new System.EventHandler(this.tsmiDeleteSupplier_supplier_Click);
            // 
            // tpgUserSetting
            // 
            this.tpgUserSetting.Controls.Add(this.flp_userSetting);
            this.tpgUserSetting.Location = new System.Drawing.Point(174, 4);
            this.tpgUserSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgUserSetting.Name = "tpgUserSetting";
            this.tpgUserSetting.Size = new System.Drawing.Size(1101, 607);
            this.tpgUserSetting.TabIndex = 8;
            this.tpgUserSetting.Text = "Cài đặt chung";
            this.tpgUserSetting.UseVisualStyleBackColor = true;
            // 
            // flp_userSetting
            // 
            this.flp_userSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flp_userSetting.Controls.Add(this.btnCreateAccount_userSetting);
            this.flp_userSetting.Controls.Add(this.btnChangeInformation_userSetting);
            this.flp_userSetting.Controls.Add(this.btnResetPassword_userSetting);
            this.flp_userSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_userSetting.ForeColor = System.Drawing.Color.White;
            this.flp_userSetting.Location = new System.Drawing.Point(0, 0);
            this.flp_userSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_userSetting.Name = "flp_userSetting";
            this.flp_userSetting.Padding = new System.Windows.Forms.Padding(20);
            this.flp_userSetting.Size = new System.Drawing.Size(1101, 607);
            this.flp_userSetting.TabIndex = 2;
            // 
            // btnCreateAccount_userSetting
            // 
            this.btnCreateAccount_userSetting.BackColor = System.Drawing.Color.White;
            this.btnCreateAccount_userSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount_userSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateAccount_userSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCreateAccount_userSetting.Image = global::BTL_LTTQ_QLKhoVLXD.Properties.Resources.user_add;
            this.btnCreateAccount_userSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount_userSetting.Location = new System.Drawing.Point(40, 40);
            this.btnCreateAccount_userSetting.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateAccount_userSetting.Name = "btnCreateAccount_userSetting";
            this.btnCreateAccount_userSetting.Size = new System.Drawing.Size(205, 91);
            this.btnCreateAccount_userSetting.TabIndex = 0;
            this.btnCreateAccount_userSetting.Text = "Tạo tài khoản";
            this.btnCreateAccount_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAccount_userSetting.UseVisualStyleBackColor = false;
            this.btnCreateAccount_userSetting.Click += new System.EventHandler(this.btnCreateAccount_userSetting_Click);
            // 
            // btnChangeInformation_userSetting
            // 
            this.btnChangeInformation_userSetting.BackColor = System.Drawing.Color.White;
            this.btnChangeInformation_userSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInformation_userSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangeInformation_userSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnChangeInformation_userSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeInformation_userSetting.Location = new System.Drawing.Point(285, 40);
            this.btnChangeInformation_userSetting.Margin = new System.Windows.Forms.Padding(20);
            this.btnChangeInformation_userSetting.Name = "btnChangeInformation_userSetting";
            this.btnChangeInformation_userSetting.Size = new System.Drawing.Size(205, 91);
            this.btnChangeInformation_userSetting.TabIndex = 1;
            this.btnChangeInformation_userSetting.Text = "Thay đổi thông tin cá nhân";
            this.btnChangeInformation_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeInformation_userSetting.UseVisualStyleBackColor = false;
            this.btnChangeInformation_userSetting.Click += new System.EventHandler(this.btnChangeInformation_userSetting_Click);
            // 
            // btnResetPassword_userSetting
            // 
            this.btnResetPassword_userSetting.BackColor = System.Drawing.Color.White;
            this.btnResetPassword_userSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword_userSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResetPassword_userSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnResetPassword_userSetting.Image = global::BTL_LTTQ_QLKhoVLXD.Properties.Resources.unlock;
            this.btnResetPassword_userSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPassword_userSetting.Location = new System.Drawing.Point(530, 40);
            this.btnResetPassword_userSetting.Margin = new System.Windows.Forms.Padding(20);
            this.btnResetPassword_userSetting.Name = "btnResetPassword_userSetting";
            this.btnResetPassword_userSetting.Size = new System.Drawing.Size(205, 91);
            this.btnResetPassword_userSetting.TabIndex = 2;
            this.btnResetPassword_userSetting.Text = "Đặt lại mật khẩu";
            this.btnResetPassword_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPassword_userSetting.UseVisualStyleBackColor = false;
            this.btnResetPassword_userSetting.Click += new System.EventHandler(this.btnResetPassword_userSetting_Click);
            // 
            // tpgEmployee
            // 
            this.tpgEmployee.Controls.Add(this.spc_employee);
            this.tpgEmployee.Location = new System.Drawing.Point(174, 4);
            this.tpgEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Size = new System.Drawing.Size(1101, 607);
            this.tpgEmployee.TabIndex = 7;
            this.tpgEmployee.Text = "Nhân viên";
            this.tpgEmployee.UseVisualStyleBackColor = true;
            this.tpgEmployee.Enter += new System.EventHandler(this.tpgEmployee_Enter);
            this.tpgEmployee.Leave += new System.EventHandler(this.tpgEmployee_Leave);
            // 
            // spc_employee
            // 
            this.spc_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_employee.Location = new System.Drawing.Point(0, 0);
            this.spc_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spc_employee.Name = "spc_employee";
            // 
            // spc_employee.Panel1
            // 
            this.spc_employee.Panel1.Controls.Add(this.lvwEmployee_employee);
            this.spc_employee.Panel1MinSize = 200;
            // 
            // spc_employee.Panel2
            // 
            this.spc_employee.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.spc_employee.Panel2.Controls.Add(this.flpFunction_employee);
            this.spc_employee.Panel2.Controls.Add(this.pnlSearch_employe);
            this.spc_employee.Panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.spc_employee.Panel2MinSize = 350;
            this.spc_employee.Size = new System.Drawing.Size(1101, 607);
            this.spc_employee.SplitterDistance = 589;
            this.spc_employee.SplitterWidth = 1;
            this.spc_employee.TabIndex = 5;
            // 
            // lvwEmployee_employee
            // 
            this.lvwEmployee_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwEmployee_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEmployee_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwEmployee_employee.ForeColor = System.Drawing.Color.White;
            this.lvwEmployee_employee.FullRowSelect = true;
            this.lvwEmployee_employee.GridLines = true;
            this.lvwEmployee_employee.HideSelection = false;
            this.lvwEmployee_employee.Location = new System.Drawing.Point(0, 0);
            this.lvwEmployee_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwEmployee_employee.Name = "lvwEmployee_employee";
            this.lvwEmployee_employee.OwnerDraw = true;
            this.lvwEmployee_employee.Size = new System.Drawing.Size(589, 607);
            this.lvwEmployee_employee.Sortable = true;
            this.lvwEmployee_employee.SortableColumns = null;
            this.lvwEmployee_employee.TabIndex = 2;
            this.lvwEmployee_employee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee_employee.View = System.Windows.Forms.View.Details;
            this.lvwEmployee_employee.SelectedIndexChanged += new System.EventHandler(this.lvwEmployee_employee_SelectedIndexChanged);
            this.lvwEmployee_employee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwEmployee_employee_MouseClick);
            this.lvwEmployee_employee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwEmployee_employee_MouseDoubleClick);
            // 
            // flpFunction_employee
            // 
            this.flpFunction_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flpFunction_employee.Controls.Add(this.btnAdd_employee);
            this.flpFunction_employee.Controls.Add(this.btnEdit_employee);
            this.flpFunction_employee.Controls.Add(this.btnCreateAccount_employee);
            this.flpFunction_employee.Controls.Add(this.btnRemoveAccount_employee);
            this.flpFunction_employee.Controls.Add(this.btnRemoveEmployee_employee);
            this.flpFunction_employee.Controls.Add(this.btnRefresh_employee);
            this.flpFunction_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFunction_employee.Location = new System.Drawing.Point(7, 340);
            this.flpFunction_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpFunction_employee.Name = "flpFunction_employee";
            this.flpFunction_employee.Padding = new System.Windows.Forms.Padding(5);
            this.flpFunction_employee.Size = new System.Drawing.Size(497, 261);
            this.flpFunction_employee.TabIndex = 4;
            // 
            // btnAdd_employee
            // 
            this.btnAdd_employee.BackColor = System.Drawing.Color.White;
            this.btnAdd_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_employee.Location = new System.Drawing.Point(8, 7);
            this.btnAdd_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_employee.Name = "btnAdd_employee";
            this.btnAdd_employee.Size = new System.Drawing.Size(185, 70);
            this.btnAdd_employee.TabIndex = 0;
            this.btnAdd_employee.Text = "Thêm nhân viên";
            this.btnAdd_employee.UseVisualStyleBackColor = false;
            this.btnAdd_employee.Click += new System.EventHandler(this.btnAdd_employee_Click);
            // 
            // btnEdit_employee
            // 
            this.btnEdit_employee.BackColor = System.Drawing.Color.White;
            this.btnEdit_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnEdit_employee.Location = new System.Drawing.Point(199, 7);
            this.btnEdit_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_employee.Name = "btnEdit_employee";
            this.btnEdit_employee.Size = new System.Drawing.Size(185, 70);
            this.btnEdit_employee.TabIndex = 2;
            this.btnEdit_employee.Text = "Chỉnh sửa \n thông tin";
            this.btnEdit_employee.UseVisualStyleBackColor = false;
            this.btnEdit_employee.Click += new System.EventHandler(this.btnEdit_employee_Click);
            // 
            // btnCreateAccount_employee
            // 
            this.btnCreateAccount_employee.BackColor = System.Drawing.Color.White;
            this.btnCreateAccount_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateAccount_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCreateAccount_employee.Location = new System.Drawing.Point(8, 81);
            this.btnCreateAccount_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount_employee.Name = "btnCreateAccount_employee";
            this.btnCreateAccount_employee.Size = new System.Drawing.Size(185, 70);
            this.btnCreateAccount_employee.TabIndex = 4;
            this.btnCreateAccount_employee.Text = "Tạo tài khoản";
            this.btnCreateAccount_employee.UseVisualStyleBackColor = false;
            this.btnCreateAccount_employee.Click += new System.EventHandler(this.btnCreateAccount_employee_Click);
            // 
            // btnRemoveAccount_employee
            // 
            this.btnRemoveAccount_employee.BackColor = System.Drawing.Color.White;
            this.btnRemoveAccount_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAccount_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveAccount_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRemoveAccount_employee.Location = new System.Drawing.Point(199, 81);
            this.btnRemoveAccount_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAccount_employee.Name = "btnRemoveAccount_employee";
            this.btnRemoveAccount_employee.Size = new System.Drawing.Size(185, 70);
            this.btnRemoveAccount_employee.TabIndex = 3;
            this.btnRemoveAccount_employee.Text = "Xóa tài khoản";
            this.btnRemoveAccount_employee.UseVisualStyleBackColor = false;
            this.btnRemoveAccount_employee.Click += new System.EventHandler(this.btnRemoveAccount_employee_Click);
            // 
            // btnRemoveEmployee_employee
            // 
            this.btnRemoveEmployee_employee.BackColor = System.Drawing.Color.White;
            this.btnRemoveEmployee_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveEmployee_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRemoveEmployee_employee.Location = new System.Drawing.Point(8, 155);
            this.btnRemoveEmployee_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee_employee.Name = "btnRemoveEmployee_employee";
            this.btnRemoveEmployee_employee.Size = new System.Drawing.Size(185, 70);
            this.btnRemoveEmployee_employee.TabIndex = 1;
            this.btnRemoveEmployee_employee.Text = "Xóa nhân viên";
            this.btnRemoveEmployee_employee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee_employee.Click += new System.EventHandler(this.btnRemoveEmployee_employee_Click);
            // 
            // btnRefresh_employee
            // 
            this.btnRefresh_employee.BackColor = System.Drawing.Color.White;
            this.btnRefresh_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRefresh_employee.Location = new System.Drawing.Point(199, 155);
            this.btnRefresh_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh_employee.Name = "btnRefresh_employee";
            this.btnRefresh_employee.Size = new System.Drawing.Size(185, 70);
            this.btnRefresh_employee.TabIndex = 5;
            this.btnRefresh_employee.Text = "Làm mới";
            this.btnRefresh_employee.UseVisualStyleBackColor = false;
            this.btnRefresh_employee.Click += new System.EventHandler(this.btnRefresh_employee_Click);
            // 
            // pnlSearch_employe
            // 
            this.pnlSearch_employe.Controls.Add(this.grbSearch_employee);
            this.pnlSearch_employe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch_employe.Location = new System.Drawing.Point(7, 6);
            this.pnlSearch_employe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch_employe.Name = "pnlSearch_employe";
            this.pnlSearch_employe.Size = new System.Drawing.Size(497, 334);
            this.pnlSearch_employe.TabIndex = 4;
            // 
            // grbSearch_employee
            // 
            this.grbSearch_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbSearch_employee.Controls.Add(this.pnlAccount_employee);
            this.grbSearch_employee.Controls.Add(this.pnlPosition_employee);
            this.grbSearch_employee.Controls.Add(this.pnlGender_employee);
            this.grbSearch_employee.Controls.Add(this.pnlPhone_employee);
            this.grbSearch_employee.Controls.Add(this.pnlAddress_employee);
            this.grbSearch_employee.Controls.Add(this.pnlName_employee);
            this.grbSearch_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearch_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearch_employee.ForeColor = System.Drawing.Color.White;
            this.grbSearch_employee.Location = new System.Drawing.Point(0, 0);
            this.grbSearch_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_employee.Name = "grbSearch_employee";
            this.grbSearch_employee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_employee.Size = new System.Drawing.Size(497, 330);
            this.grbSearch_employee.TabIndex = 3;
            this.grbSearch_employee.TabStop = false;
            this.grbSearch_employee.Text = "Tìm kiếm";
            // 
            // pnlAccount_employee
            // 
            this.pnlAccount_employee.Controls.Add(this.lblAccount_employee);
            this.pnlAccount_employee.Controls.Add(this.txtAccount_employee);
            this.pnlAccount_employee.Location = new System.Drawing.Point(5, 70);
            this.pnlAccount_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAccount_employee.Name = "pnlAccount_employee";
            this.pnlAccount_employee.Size = new System.Drawing.Size(421, 39);
            this.pnlAccount_employee.TabIndex = 3;
            // 
            // lblAccount_employee
            // 
            this.lblAccount_employee.AutoSize = true;
            this.lblAccount_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAccount_employee.Location = new System.Drawing.Point(3, 9);
            this.lblAccount_employee.Name = "lblAccount_employee";
            this.lblAccount_employee.Size = new System.Drawing.Size(81, 20);
            this.lblAccount_employee.TabIndex = 0;
            this.lblAccount_employee.Text = "Tài khoản";
            // 
            // txtAccount_employee
            // 
            this.txtAccount_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAccount_employee.Location = new System.Drawing.Point(132, 6);
            this.txtAccount_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccount_employee.Name = "txtAccount_employee";
            this.txtAccount_employee.Size = new System.Drawing.Size(289, 26);
            this.txtAccount_employee.TabIndex = 1;
            this.txtAccount_employee.TextChanged += new System.EventHandler(this.txtAccount_employee_TextChanged);
            // 
            // pnlPosition_employee
            // 
            this.pnlPosition_employee.AutoSize = true;
            this.pnlPosition_employee.Controls.Add(this.flpPosition_employee);
            this.pnlPosition_employee.Controls.Add(this.lblPosition_employee);
            this.pnlPosition_employee.Location = new System.Drawing.Point(8, 250);
            this.pnlPosition_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPosition_employee.Name = "pnlPosition_employee";
            this.pnlPosition_employee.Size = new System.Drawing.Size(421, 45);
            this.pnlPosition_employee.TabIndex = 6;
            // 
            // flpPosition_employee
            // 
            this.flpPosition_employee.Location = new System.Drawing.Point(132, 2);
            this.flpPosition_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpPosition_employee.Name = "flpPosition_employee";
            this.flpPosition_employee.Size = new System.Drawing.Size(286, 41);
            this.flpPosition_employee.TabIndex = 0;
            // 
            // lblPosition_employee
            // 
            this.lblPosition_employee.AutoSize = true;
            this.lblPosition_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPosition_employee.Location = new System.Drawing.Point(3, 10);
            this.lblPosition_employee.Name = "lblPosition_employee";
            this.lblPosition_employee.Size = new System.Drawing.Size(70, 20);
            this.lblPosition_employee.TabIndex = 1;
            this.lblPosition_employee.Text = "Chức vụ";
            // 
            // pnlGender_employee
            // 
            this.pnlGender_employee.Controls.Add(this.rdoFemale_employee);
            this.pnlGender_employee.Controls.Add(this.rdoMale_employee);
            this.pnlGender_employee.Controls.Add(this.rdoAll_employee);
            this.pnlGender_employee.Controls.Add(this.lblGender_employee);
            this.pnlGender_employee.Location = new System.Drawing.Point(8, 206);
            this.pnlGender_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGender_employee.Name = "pnlGender_employee";
            this.pnlGender_employee.Size = new System.Drawing.Size(418, 39);
            this.pnlGender_employee.TabIndex = 5;
            // 
            // rdoFemale_employee
            // 
            this.rdoFemale_employee.AutoSize = true;
            this.rdoFemale_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoFemale_employee.Location = new System.Drawing.Point(336, 7);
            this.rdoFemale_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFemale_employee.Name = "rdoFemale_employee";
            this.rdoFemale_employee.Size = new System.Drawing.Size(51, 24);
            this.rdoFemale_employee.TabIndex = 3;
            this.rdoFemale_employee.Text = "Nữ";
            this.rdoFemale_employee.UseVisualStyleBackColor = true;
            this.rdoFemale_employee.CheckedChanged += new System.EventHandler(this.rdoFemale_employee_CheckedChanged);
            // 
            // rdoMale_employee
            // 
            this.rdoMale_employee.AutoSize = true;
            this.rdoMale_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoMale_employee.Location = new System.Drawing.Point(237, 7);
            this.rdoMale_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMale_employee.Name = "rdoMale_employee";
            this.rdoMale_employee.Size = new System.Drawing.Size(65, 24);
            this.rdoMale_employee.TabIndex = 2;
            this.rdoMale_employee.Text = "Nam";
            this.rdoMale_employee.UseVisualStyleBackColor = true;
            this.rdoMale_employee.CheckedChanged += new System.EventHandler(this.rdoMale_employee_CheckedChanged);
            // 
            // rdoAll_employee
            // 
            this.rdoAll_employee.AutoSize = true;
            this.rdoAll_employee.Checked = true;
            this.rdoAll_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoAll_employee.Location = new System.Drawing.Point(133, 7);
            this.rdoAll_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoAll_employee.Name = "rdoAll_employee";
            this.rdoAll_employee.Size = new System.Drawing.Size(77, 24);
            this.rdoAll_employee.TabIndex = 1;
            this.rdoAll_employee.TabStop = true;
            this.rdoAll_employee.Text = "Tất cả";
            this.rdoAll_employee.UseVisualStyleBackColor = true;
            this.rdoAll_employee.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // lblGender_employee
            // 
            this.lblGender_employee.AutoSize = true;
            this.lblGender_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGender_employee.Location = new System.Drawing.Point(3, 9);
            this.lblGender_employee.Name = "lblGender_employee";
            this.lblGender_employee.Size = new System.Drawing.Size(71, 20);
            this.lblGender_employee.TabIndex = 0;
            this.lblGender_employee.Text = "Giới tính";
            // 
            // pnlPhone_employee
            // 
            this.pnlPhone_employee.Controls.Add(this.lblPhone_employee);
            this.pnlPhone_employee.Controls.Add(this.txtPhone_employee);
            this.pnlPhone_employee.Location = new System.Drawing.Point(5, 160);
            this.pnlPhone_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPhone_employee.Name = "pnlPhone_employee";
            this.pnlPhone_employee.Size = new System.Drawing.Size(421, 39);
            this.pnlPhone_employee.TabIndex = 4;
            // 
            // lblPhone_employee
            // 
            this.lblPhone_employee.AutoSize = true;
            this.lblPhone_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone_employee.Location = new System.Drawing.Point(3, 9);
            this.lblPhone_employee.Name = "lblPhone_employee";
            this.lblPhone_employee.Size = new System.Drawing.Size(106, 20);
            this.lblPhone_employee.TabIndex = 0;
            this.lblPhone_employee.Text = "Số điện thoại";
            // 
            // txtPhone_employee
            // 
            this.txtPhone_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone_employee.Location = new System.Drawing.Point(132, 4);
            this.txtPhone_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone_employee.Name = "txtPhone_employee";
            this.txtPhone_employee.Size = new System.Drawing.Size(289, 26);
            this.txtPhone_employee.TabIndex = 1;
            this.txtPhone_employee.TextChanged += new System.EventHandler(this.txtPhone_employee_TextChanged);
            // 
            // pnlAddress_employee
            // 
            this.pnlAddress_employee.Controls.Add(this.lblAddress_employee);
            this.pnlAddress_employee.Controls.Add(this.txtAddress_employee);
            this.pnlAddress_employee.Location = new System.Drawing.Point(5, 114);
            this.pnlAddress_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddress_employee.Name = "pnlAddress_employee";
            this.pnlAddress_employee.Size = new System.Drawing.Size(421, 39);
            this.pnlAddress_employee.TabIndex = 3;
            // 
            // lblAddress_employee
            // 
            this.lblAddress_employee.AutoSize = true;
            this.lblAddress_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_employee.Location = new System.Drawing.Point(3, 9);
            this.lblAddress_employee.Name = "lblAddress_employee";
            this.lblAddress_employee.Size = new System.Drawing.Size(61, 20);
            this.lblAddress_employee.TabIndex = 0;
            this.lblAddress_employee.Text = "Địa chỉ";
            // 
            // txtAddress_employee
            // 
            this.txtAddress_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_employee.Location = new System.Drawing.Point(132, 6);
            this.txtAddress_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress_employee.Name = "txtAddress_employee";
            this.txtAddress_employee.Size = new System.Drawing.Size(289, 26);
            this.txtAddress_employee.TabIndex = 1;
            this.txtAddress_employee.TextChanged += new System.EventHandler(this.txtAddress_employee_TextChanged);
            // 
            // pnlName_employee
            // 
            this.pnlName_employee.Controls.Add(this.lblName_employee);
            this.pnlName_employee.Controls.Add(this.txtName_employee);
            this.pnlName_employee.Location = new System.Drawing.Point(5, 25);
            this.pnlName_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlName_employee.Name = "pnlName_employee";
            this.pnlName_employee.Size = new System.Drawing.Size(421, 39);
            this.pnlName_employee.TabIndex = 2;
            // 
            // lblName_employee
            // 
            this.lblName_employee.AutoSize = true;
            this.lblName_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_employee.Location = new System.Drawing.Point(3, 9);
            this.lblName_employee.Name = "lblName_employee";
            this.lblName_employee.Size = new System.Drawing.Size(59, 20);
            this.lblName_employee.TabIndex = 0;
            this.lblName_employee.Text = "Họ tên";
            // 
            // txtName_employee
            // 
            this.txtName_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_employee.Location = new System.Drawing.Point(132, 6);
            this.txtName_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName_employee.Name = "txtName_employee";
            this.txtName_employee.Size = new System.Drawing.Size(289, 26);
            this.txtName_employee.TabIndex = 1;
            this.txtName_employee.TextChanged += new System.EventHandler(this.txtName_employee_TextChanged);
            // 
            // tpgSupplier
            // 
            this.tpgSupplier.Controls.Add(this.spc_supplier);
            this.tpgSupplier.Location = new System.Drawing.Point(174, 4);
            this.tpgSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgSupplier.Name = "tpgSupplier";
            this.tpgSupplier.Size = new System.Drawing.Size(1101, 607);
            this.tpgSupplier.TabIndex = 6;
            this.tpgSupplier.Text = "Nhà cung cấp";
            this.tpgSupplier.UseVisualStyleBackColor = true;
            this.tpgSupplier.Enter += new System.EventHandler(this.tpgSupplier_Enter);
            this.tpgSupplier.Leave += new System.EventHandler(this.tpgSupplier_Leave);
            // 
            // spc_supplier
            // 
            this.spc_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_supplier.Location = new System.Drawing.Point(0, 0);
            this.spc_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spc_supplier.Name = "spc_supplier";
            // 
            // spc_supplier.Panel1
            // 
            this.spc_supplier.Panel1.Controls.Add(this.lvwSupplier_supplier);
            this.spc_supplier.Panel1MinSize = 200;
            // 
            // spc_supplier.Panel2
            // 
            this.spc_supplier.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.spc_supplier.Panel2.Controls.Add(this.flpFunction_supplier);
            this.spc_supplier.Panel2.Controls.Add(this.grbSearch_supplier);
            this.spc_supplier.Panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.spc_supplier.Panel2MinSize = 350;
            this.spc_supplier.Size = new System.Drawing.Size(1101, 607);
            this.spc_supplier.SplitterDistance = 589;
            this.spc_supplier.SplitterWidth = 1;
            this.spc_supplier.TabIndex = 0;
            // 
            // lvwSupplier_supplier
            // 
            this.lvwSupplier_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwSupplier_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSupplier_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwSupplier_supplier.ForeColor = System.Drawing.Color.White;
            this.lvwSupplier_supplier.FullRowSelect = true;
            this.lvwSupplier_supplier.GridLines = true;
            this.lvwSupplier_supplier.HideSelection = false;
            this.lvwSupplier_supplier.Location = new System.Drawing.Point(0, 0);
            this.lvwSupplier_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwSupplier_supplier.Name = "lvwSupplier_supplier";
            this.lvwSupplier_supplier.OwnerDraw = true;
            this.lvwSupplier_supplier.Size = new System.Drawing.Size(589, 607);
            this.lvwSupplier_supplier.Sortable = true;
            this.lvwSupplier_supplier.SortableColumns = null;
            this.lvwSupplier_supplier.TabIndex = 0;
            this.lvwSupplier_supplier.UseCompatibleStateImageBehavior = false;
            this.lvwSupplier_supplier.View = System.Windows.Forms.View.Details;
            this.lvwSupplier_supplier.SelectedIndexChanged += new System.EventHandler(this.lvwSupplier_supplier_SelectedIndexChanged);
            this.lvwSupplier_supplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwSupplier_supplier_MouseClick);
            this.lvwSupplier_supplier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwSupplier_supplier_MouseDoubleClick);
            // 
            // flpFunction_supplier
            // 
            this.flpFunction_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flpFunction_supplier.Controls.Add(this.btnAdd_supplier);
            this.flpFunction_supplier.Controls.Add(this.btnEdit_supplier);
            this.flpFunction_supplier.Controls.Add(this.btnDelete_supplier);
            this.flpFunction_supplier.Controls.Add(this.btnExport_supplier);
            this.flpFunction_supplier.Controls.Add(this.btnRefresh_supplier);
            this.flpFunction_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFunction_supplier.Location = new System.Drawing.Point(7, 186);
            this.flpFunction_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpFunction_supplier.Name = "flpFunction_supplier";
            this.flpFunction_supplier.Padding = new System.Windows.Forms.Padding(5);
            this.flpFunction_supplier.Size = new System.Drawing.Size(497, 415);
            this.flpFunction_supplier.TabIndex = 6;
            // 
            // btnAdd_supplier
            // 
            this.btnAdd_supplier.BackColor = System.Drawing.Color.White;
            this.btnAdd_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_supplier.Location = new System.Drawing.Point(8, 7);
            this.btnAdd_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_supplier.Name = "btnAdd_supplier";
            this.btnAdd_supplier.Size = new System.Drawing.Size(185, 63);
            this.btnAdd_supplier.TabIndex = 1;
            this.btnAdd_supplier.Text = "Thêm NCC";
            this.btnAdd_supplier.UseVisualStyleBackColor = false;
            this.btnAdd_supplier.Click += new System.EventHandler(this.btnAdd_supplier_Click);
            // 
            // btnEdit_supplier
            // 
            this.btnEdit_supplier.BackColor = System.Drawing.Color.White;
            this.btnEdit_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnEdit_supplier.Location = new System.Drawing.Point(199, 7);
            this.btnEdit_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_supplier.Name = "btnEdit_supplier";
            this.btnEdit_supplier.Size = new System.Drawing.Size(185, 63);
            this.btnEdit_supplier.TabIndex = 2;
            this.btnEdit_supplier.Text = "Chỉnh sửa thông tin";
            this.btnEdit_supplier.UseVisualStyleBackColor = false;
            this.btnEdit_supplier.Click += new System.EventHandler(this.btnEdit_supplier_Click);
            // 
            // btnDelete_supplier
            // 
            this.btnDelete_supplier.BackColor = System.Drawing.Color.White;
            this.btnDelete_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnDelete_supplier.Location = new System.Drawing.Point(8, 74);
            this.btnDelete_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete_supplier.Name = "btnDelete_supplier";
            this.btnDelete_supplier.Size = new System.Drawing.Size(185, 63);
            this.btnDelete_supplier.TabIndex = 3;
            this.btnDelete_supplier.Text = "Xóa NCC";
            this.btnDelete_supplier.UseVisualStyleBackColor = false;
            this.btnDelete_supplier.Click += new System.EventHandler(this.btnDelete_supplier_Click);
            // 
            // btnExport_supplier
            // 
            this.btnExport_supplier.BackColor = System.Drawing.Color.White;
            this.btnExport_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport_supplier.Location = new System.Drawing.Point(199, 74);
            this.btnExport_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport_supplier.Name = "btnExport_supplier";
            this.btnExport_supplier.Size = new System.Drawing.Size(185, 63);
            this.btnExport_supplier.TabIndex = 5;
            this.btnExport_supplier.Text = "Xuất file danh sách NCC";
            this.btnExport_supplier.UseVisualStyleBackColor = false;
            this.btnExport_supplier.Click += new System.EventHandler(this.btnExport_supplier_Click);
            // 
            // btnRefresh_supplier
            // 
            this.btnRefresh_supplier.BackColor = System.Drawing.Color.White;
            this.btnRefresh_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRefresh_supplier.Location = new System.Drawing.Point(8, 141);
            this.btnRefresh_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh_supplier.Name = "btnRefresh_supplier";
            this.btnRefresh_supplier.Size = new System.Drawing.Size(185, 63);
            this.btnRefresh_supplier.TabIndex = 6;
            this.btnRefresh_supplier.Text = "Làm mới";
            this.btnRefresh_supplier.UseVisualStyleBackColor = false;
            this.btnRefresh_supplier.Click += new System.EventHandler(this.btnRefresh_supplier_Click);
            // 
            // grbSearch_supplier
            // 
            this.grbSearch_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbSearch_supplier.Controls.Add(this.pnlPhone_supplier);
            this.grbSearch_supplier.Controls.Add(this.pnlAddress_supplier);
            this.grbSearch_supplier.Controls.Add(this.pnlName_supplier);
            this.grbSearch_supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearch_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearch_supplier.ForeColor = System.Drawing.Color.White;
            this.grbSearch_supplier.Location = new System.Drawing.Point(7, 6);
            this.grbSearch_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_supplier.Name = "grbSearch_supplier";
            this.grbSearch_supplier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_supplier.Size = new System.Drawing.Size(497, 180);
            this.grbSearch_supplier.TabIndex = 7;
            this.grbSearch_supplier.TabStop = false;
            this.grbSearch_supplier.Text = "Tìm kiếm";
            // 
            // pnlPhone_supplier
            // 
            this.pnlPhone_supplier.Controls.Add(this.lblPhone_supplier);
            this.pnlPhone_supplier.Controls.Add(this.txtPhone_supplier);
            this.pnlPhone_supplier.Location = new System.Drawing.Point(5, 114);
            this.pnlPhone_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPhone_supplier.Name = "pnlPhone_supplier";
            this.pnlPhone_supplier.Size = new System.Drawing.Size(439, 39);
            this.pnlPhone_supplier.TabIndex = 4;
            // 
            // lblPhone_supplier
            // 
            this.lblPhone_supplier.AutoSize = true;
            this.lblPhone_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone_supplier.Location = new System.Drawing.Point(3, 9);
            this.lblPhone_supplier.Name = "lblPhone_supplier";
            this.lblPhone_supplier.Size = new System.Drawing.Size(106, 20);
            this.lblPhone_supplier.TabIndex = 0;
            this.lblPhone_supplier.Text = "Số điện thoại";
            // 
            // txtPhone_supplier
            // 
            this.txtPhone_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone_supplier.Location = new System.Drawing.Point(134, 6);
            this.txtPhone_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone_supplier.Name = "txtPhone_supplier";
            this.txtPhone_supplier.Size = new System.Drawing.Size(305, 26);
            this.txtPhone_supplier.TabIndex = 1;
            this.txtPhone_supplier.TextChanged += new System.EventHandler(this.txtPhone_supplier_TextChanged);
            // 
            // pnlAddress_supplier
            // 
            this.pnlAddress_supplier.Controls.Add(this.lblAddress_supplier);
            this.pnlAddress_supplier.Controls.Add(this.txtAddress_supplier);
            this.pnlAddress_supplier.Location = new System.Drawing.Point(5, 70);
            this.pnlAddress_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddress_supplier.Name = "pnlAddress_supplier";
            this.pnlAddress_supplier.Size = new System.Drawing.Size(439, 39);
            this.pnlAddress_supplier.TabIndex = 3;
            // 
            // lblAddress_supplier
            // 
            this.lblAddress_supplier.AutoSize = true;
            this.lblAddress_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_supplier.Location = new System.Drawing.Point(3, 9);
            this.lblAddress_supplier.Name = "lblAddress_supplier";
            this.lblAddress_supplier.Size = new System.Drawing.Size(61, 20);
            this.lblAddress_supplier.TabIndex = 0;
            this.lblAddress_supplier.Text = "Địa chỉ";
            // 
            // txtAddress_supplier
            // 
            this.txtAddress_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_supplier.Location = new System.Drawing.Point(134, 9);
            this.txtAddress_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress_supplier.Name = "txtAddress_supplier";
            this.txtAddress_supplier.Size = new System.Drawing.Size(305, 26);
            this.txtAddress_supplier.TabIndex = 1;
            this.txtAddress_supplier.TextChanged += new System.EventHandler(this.txtAddress_supplier_TextChanged);
            // 
            // pnlName_supplier
            // 
            this.pnlName_supplier.Controls.Add(this.lblName_supplier);
            this.pnlName_supplier.Controls.Add(this.txtName_supplier);
            this.pnlName_supplier.Location = new System.Drawing.Point(5, 25);
            this.pnlName_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlName_supplier.Name = "pnlName_supplier";
            this.pnlName_supplier.Size = new System.Drawing.Size(439, 39);
            this.pnlName_supplier.TabIndex = 2;
            // 
            // lblName_supplier
            // 
            this.lblName_supplier.AutoSize = true;
            this.lblName_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_supplier.Location = new System.Drawing.Point(3, 9);
            this.lblName_supplier.Name = "lblName_supplier";
            this.lblName_supplier.Size = new System.Drawing.Size(78, 20);
            this.lblName_supplier.TabIndex = 0;
            this.lblName_supplier.Text = "Tên NCC";
            // 
            // txtName_supplier
            // 
            this.txtName_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_supplier.Location = new System.Drawing.Point(134, 9);
            this.txtName_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName_supplier.Name = "txtName_supplier";
            this.txtName_supplier.Size = new System.Drawing.Size(305, 26);
            this.txtName_supplier.TabIndex = 1;
            this.txtName_supplier.TextChanged += new System.EventHandler(this.txtName_supplier_TextChanged);
            // 
            // tpgCustomer
            // 
            this.tpgCustomer.Controls.Add(this.panel1_Customer);
            this.tpgCustomer.Location = new System.Drawing.Point(174, 4);
            this.tpgCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgCustomer.Name = "tpgCustomer";
            this.tpgCustomer.Size = new System.Drawing.Size(1101, 607);
            this.tpgCustomer.TabIndex = 5;
            this.tpgCustomer.Text = "Khách hàng";
            this.tpgCustomer.UseVisualStyleBackColor = true;
            // 
            // panel1_Customer
            // 
            this.panel1_Customer.Controls.Add(this.spc_customer);
            this.panel1_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Customer.Location = new System.Drawing.Point(0, 0);
            this.panel1_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1_Customer.Name = "panel1_Customer";
            this.panel1_Customer.Size = new System.Drawing.Size(1101, 607);
            this.panel1_Customer.TabIndex = 3;
            // 
            // spc_customer
            // 
            this.spc_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_customer.Location = new System.Drawing.Point(0, 0);
            this.spc_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spc_customer.Name = "spc_customer";
            // 
            // spc_customer.Panel1
            // 
            this.spc_customer.Panel1.Controls.Add(this.lvwCustomer_customer);
            this.spc_customer.Panel1MinSize = 200;
            // 
            // spc_customer.Panel2
            // 
            this.spc_customer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.spc_customer.Panel2.Controls.Add(this.flp_customer);
            this.spc_customer.Panel2.Controls.Add(this.grbSearch_Customer);
            this.spc_customer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.spc_customer.Panel2MinSize = 350;
            this.spc_customer.Size = new System.Drawing.Size(1101, 607);
            this.spc_customer.SplitterDistance = 589;
            this.spc_customer.SplitterWidth = 1;
            this.spc_customer.TabIndex = 3;
            // 
            // lvwCustomer_customer
            // 
            this.lvwCustomer_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwCustomer_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCustomer_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwCustomer_customer.ForeColor = System.Drawing.Color.White;
            this.lvwCustomer_customer.FullRowSelect = true;
            this.lvwCustomer_customer.GridLines = true;
            this.lvwCustomer_customer.HideSelection = false;
            this.lvwCustomer_customer.Location = new System.Drawing.Point(0, 0);
            this.lvwCustomer_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwCustomer_customer.Name = "lvwCustomer_customer";
            this.lvwCustomer_customer.OwnerDraw = true;
            this.lvwCustomer_customer.Size = new System.Drawing.Size(589, 607);
            this.lvwCustomer_customer.Sortable = true;
            this.lvwCustomer_customer.SortableColumns = null;
            this.lvwCustomer_customer.TabIndex = 0;
            this.lvwCustomer_customer.UseCompatibleStateImageBehavior = false;
            this.lvwCustomer_customer.View = System.Windows.Forms.View.Details;
            // 
            // flp_customer
            // 
            this.flp_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flp_customer.Controls.Add(this.btnAdd_Customer);
            this.flp_customer.Controls.Add(this.btnEdit_Customer);
            this.flp_customer.Controls.Add(this.btnDelete_Customer);
            this.flp_customer.Controls.Add(this.btnExport_Customer);
            this.flp_customer.Controls.Add(this.btnRefresh_Customer);
            this.flp_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_customer.Location = new System.Drawing.Point(5, 176);
            this.flp_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_customer.Name = "flp_customer";
            this.flp_customer.Padding = new System.Windows.Forms.Padding(5);
            this.flp_customer.Size = new System.Drawing.Size(501, 426);
            this.flp_customer.TabIndex = 8;
            // 
            // btnAdd_Customer
            // 
            this.btnAdd_Customer.BackColor = System.Drawing.Color.White;
            this.btnAdd_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_Customer.Location = new System.Drawing.Point(8, 7);
            this.btnAdd_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_Customer.Name = "btnAdd_Customer";
            this.btnAdd_Customer.Size = new System.Drawing.Size(185, 63);
            this.btnAdd_Customer.TabIndex = 1;
            this.btnAdd_Customer.Text = "Thêm khách hàng";
            this.btnAdd_Customer.UseVisualStyleBackColor = false;
            this.btnAdd_Customer.Click += new System.EventHandler(this.btnAdd_Customer_Click);
            // 
            // btnEdit_Customer
            // 
            this.btnEdit_Customer.BackColor = System.Drawing.Color.White;
            this.btnEdit_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnEdit_Customer.Location = new System.Drawing.Point(199, 7);
            this.btnEdit_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_Customer.Name = "btnEdit_Customer";
            this.btnEdit_Customer.Size = new System.Drawing.Size(185, 63);
            this.btnEdit_Customer.TabIndex = 2;
            this.btnEdit_Customer.Text = "Chỉnh sửa thông tin";
            this.btnEdit_Customer.UseVisualStyleBackColor = false;
            this.btnEdit_Customer.Click += new System.EventHandler(this.btnEdit_Customer_Click);
            // 
            // btnDelete_Customer
            // 
            this.btnDelete_Customer.BackColor = System.Drawing.Color.White;
            this.btnDelete_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnDelete_Customer.Location = new System.Drawing.Point(8, 74);
            this.btnDelete_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete_Customer.Name = "btnDelete_Customer";
            this.btnDelete_Customer.Size = new System.Drawing.Size(185, 63);
            this.btnDelete_Customer.TabIndex = 3;
            this.btnDelete_Customer.Text = "Xóa khách hàng";
            this.btnDelete_Customer.UseVisualStyleBackColor = false;
            this.btnDelete_Customer.Click += new System.EventHandler(this.btnDelete_Customer_Click);
            // 
            // btnExport_Customer
            // 
            this.btnExport_Customer.BackColor = System.Drawing.Color.White;
            this.btnExport_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport_Customer.Location = new System.Drawing.Point(199, 74);
            this.btnExport_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport_Customer.Name = "btnExport_Customer";
            this.btnExport_Customer.Size = new System.Drawing.Size(185, 63);
            this.btnExport_Customer.TabIndex = 5;
            this.btnExport_Customer.Text = "Xuất file danh sách khách hàng";
            this.btnExport_Customer.UseVisualStyleBackColor = false;
            this.btnExport_Customer.Click += new System.EventHandler(this.btnExport_Customer_Click);
            // 
            // btnRefresh_Customer
            // 
            this.btnRefresh_Customer.BackColor = System.Drawing.Color.White;
            this.btnRefresh_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRefresh_Customer.Location = new System.Drawing.Point(8, 141);
            this.btnRefresh_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh_Customer.Name = "btnRefresh_Customer";
            this.btnRefresh_Customer.Size = new System.Drawing.Size(185, 63);
            this.btnRefresh_Customer.TabIndex = 4;
            this.btnRefresh_Customer.Text = "Làm mới";
            this.btnRefresh_Customer.UseVisualStyleBackColor = false;
            this.btnRefresh_Customer.Click += new System.EventHandler(this.btnRefresh_Customer_Click);
            // 
            // grbSearch_Customer
            // 
            this.grbSearch_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbSearch_Customer.Controls.Add(this.pnlPhone_customer);
            this.grbSearch_Customer.Controls.Add(this.pnlAddress_customer);
            this.grbSearch_Customer.Controls.Add(this.pnlName_customer);
            this.grbSearch_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearch_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearch_Customer.ForeColor = System.Drawing.Color.White;
            this.grbSearch_Customer.Location = new System.Drawing.Point(5, 5);
            this.grbSearch_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_Customer.Name = "grbSearch_Customer";
            this.grbSearch_Customer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_Customer.Size = new System.Drawing.Size(501, 171);
            this.grbSearch_Customer.TabIndex = 0;
            this.grbSearch_Customer.TabStop = false;
            this.grbSearch_Customer.Text = "Tìm kiếm";
            // 
            // pnlPhone_customer
            // 
            this.pnlPhone_customer.Controls.Add(this.lblPhone_customer);
            this.pnlPhone_customer.Controls.Add(this.txtPhone_customer);
            this.pnlPhone_customer.Location = new System.Drawing.Point(5, 114);
            this.pnlPhone_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPhone_customer.Name = "pnlPhone_customer";
            this.pnlPhone_customer.Size = new System.Drawing.Size(431, 39);
            this.pnlPhone_customer.TabIndex = 7;
            // 
            // lblPhone_customer
            // 
            this.lblPhone_customer.AutoSize = true;
            this.lblPhone_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone_customer.Location = new System.Drawing.Point(3, 9);
            this.lblPhone_customer.Name = "lblPhone_customer";
            this.lblPhone_customer.Size = new System.Drawing.Size(106, 20);
            this.lblPhone_customer.TabIndex = 0;
            this.lblPhone_customer.Text = "Số điện thoại";
            // 
            // txtPhone_customer
            // 
            this.txtPhone_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone_customer.Location = new System.Drawing.Point(157, 4);
            this.txtPhone_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone_customer.Name = "txtPhone_customer";
            this.txtPhone_customer.Size = new System.Drawing.Size(274, 26);
            this.txtPhone_customer.TabIndex = 1;
            this.txtPhone_customer.TextChanged += new System.EventHandler(this.txtPhone_customer_TextChanged);
            // 
            // pnlAddress_customer
            // 
            this.pnlAddress_customer.Controls.Add(this.lblAddress_customer);
            this.pnlAddress_customer.Controls.Add(this.txtAddress_customer);
            this.pnlAddress_customer.Location = new System.Drawing.Point(5, 70);
            this.pnlAddress_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddress_customer.Name = "pnlAddress_customer";
            this.pnlAddress_customer.Size = new System.Drawing.Size(431, 39);
            this.pnlAddress_customer.TabIndex = 6;
            // 
            // lblAddress_customer
            // 
            this.lblAddress_customer.AutoSize = true;
            this.lblAddress_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_customer.Location = new System.Drawing.Point(3, 9);
            this.lblAddress_customer.Name = "lblAddress_customer";
            this.lblAddress_customer.Size = new System.Drawing.Size(61, 20);
            this.lblAddress_customer.TabIndex = 0;
            this.lblAddress_customer.Text = "Địa chỉ";
            // 
            // txtAddress_customer
            // 
            this.txtAddress_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_customer.Location = new System.Drawing.Point(157, 6);
            this.txtAddress_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress_customer.Name = "txtAddress_customer";
            this.txtAddress_customer.Size = new System.Drawing.Size(274, 26);
            this.txtAddress_customer.TabIndex = 1;
            this.txtAddress_customer.TextChanged += new System.EventHandler(this.txtAddress_customer_TextChanged);
            // 
            // pnlName_customer
            // 
            this.pnlName_customer.Controls.Add(this.lblName_customer);
            this.pnlName_customer.Controls.Add(this.txtName_customer);
            this.pnlName_customer.Location = new System.Drawing.Point(5, 25);
            this.pnlName_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlName_customer.Name = "pnlName_customer";
            this.pnlName_customer.Size = new System.Drawing.Size(431, 39);
            this.pnlName_customer.TabIndex = 5;
            // 
            // lblName_customer
            // 
            this.lblName_customer.AutoSize = true;
            this.lblName_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_customer.Location = new System.Drawing.Point(3, 9);
            this.lblName_customer.Name = "lblName_customer";
            this.lblName_customer.Size = new System.Drawing.Size(127, 20);
            this.lblName_customer.TabIndex = 0;
            this.lblName_customer.Text = "Tên khách hàng";
            // 
            // txtName_customer
            // 
            this.txtName_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_customer.Location = new System.Drawing.Point(157, 6);
            this.txtName_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName_customer.Name = "txtName_customer";
            this.txtName_customer.Size = new System.Drawing.Size(274, 26);
            this.txtName_customer.TabIndex = 1;
            this.txtName_customer.TextChanged += new System.EventHandler(this.txtName_customer_TextChanged);
            // 
            // tpgStatistic
            // 
            this.tpgStatistic.Location = new System.Drawing.Point(174, 4);
            this.tpgStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgStatistic.Name = "tpgStatistic";
            this.tpgStatistic.Size = new System.Drawing.Size(1101, 607);
            this.tpgStatistic.TabIndex = 4;
            this.tpgStatistic.Text = "Thống kê";
            this.tpgStatistic.UseVisualStyleBackColor = true;
            // 
            // tpgMaterial
            // 
            this.tpgMaterial.Controls.Add(this.splitContainer2);
            this.tpgMaterial.Location = new System.Drawing.Point(174, 4);
            this.tpgMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgMaterial.Name = "tpgMaterial";
            this.tpgMaterial.Size = new System.Drawing.Size(1101, 607);
            this.tpgMaterial.TabIndex = 3;
            this.tpgMaterial.Text = "Vật liệu";
            this.tpgMaterial.UseVisualStyleBackColor = true;
            this.tpgMaterial.Enter += new System.EventHandler(this.tpgMaterial_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwMaterial_material);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.splitContainer2.Panel2.Controls.Add(this.flpFunction_material);
            this.splitContainer2.Panel2.Controls.Add(this.grbSearchMaterial_material);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Panel2MinSize = 350;
            this.splitContainer2.Size = new System.Drawing.Size(1101, 607);
            this.splitContainer2.SplitterDistance = 589;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 4;
            // 
            // lvwMaterial_material
            // 
            this.lvwMaterial_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwMaterial_material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMaterial_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwMaterial_material.ForeColor = System.Drawing.Color.White;
            this.lvwMaterial_material.FullRowSelect = true;
            this.lvwMaterial_material.GridLines = true;
            this.lvwMaterial_material.HideSelection = false;
            this.lvwMaterial_material.Location = new System.Drawing.Point(0, 0);
            this.lvwMaterial_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwMaterial_material.Name = "lvwMaterial_material";
            this.lvwMaterial_material.OwnerDraw = true;
            this.lvwMaterial_material.Size = new System.Drawing.Size(589, 607);
            this.lvwMaterial_material.Sortable = true;
            this.lvwMaterial_material.SortableColumns = null;
            this.lvwMaterial_material.TabIndex = 0;
            this.lvwMaterial_material.UseCompatibleStateImageBehavior = false;
            this.lvwMaterial_material.View = System.Windows.Forms.View.Details;
            // 
            // flpFunction_material
            // 
            this.flpFunction_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flpFunction_material.Controls.Add(this.btnAdd_material);
            this.flpFunction_material.Controls.Add(this.btnEdit_material);
            this.flpFunction_material.Controls.Add(this.btnDelete_material);
            this.flpFunction_material.Controls.Add(this.btnExport_material);
            this.flpFunction_material.Controls.Add(this.btnWareHouse_material);
            this.flpFunction_material.Controls.Add(this.btnRefersh_material);
            this.flpFunction_material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFunction_material.Location = new System.Drawing.Point(5, 230);
            this.flpFunction_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpFunction_material.Name = "flpFunction_material";
            this.flpFunction_material.Padding = new System.Windows.Forms.Padding(5);
            this.flpFunction_material.Size = new System.Drawing.Size(501, 372);
            this.flpFunction_material.TabIndex = 8;
            // 
            // btnAdd_material
            // 
            this.btnAdd_material.BackColor = System.Drawing.Color.White;
            this.btnAdd_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_material.Location = new System.Drawing.Point(8, 7);
            this.btnAdd_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_material.Name = "btnAdd_material";
            this.btnAdd_material.Size = new System.Drawing.Size(185, 63);
            this.btnAdd_material.TabIndex = 1;
            this.btnAdd_material.Text = "Thêm vật liệu";
            this.btnAdd_material.UseVisualStyleBackColor = false;
            this.btnAdd_material.Click += new System.EventHandler(this.btnAdd_Material_Click);
            // 
            // btnEdit_material
            // 
            this.btnEdit_material.BackColor = System.Drawing.Color.White;
            this.btnEdit_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnEdit_material.Location = new System.Drawing.Point(199, 7);
            this.btnEdit_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_material.Name = "btnEdit_material";
            this.btnEdit_material.Size = new System.Drawing.Size(185, 63);
            this.btnEdit_material.TabIndex = 2;
            this.btnEdit_material.Text = "Chỉnh sửa thông tin";
            this.btnEdit_material.UseVisualStyleBackColor = false;
            this.btnEdit_material.Click += new System.EventHandler(this.btnEdit_Material_Click);
            // 
            // btnDelete_material
            // 
            this.btnDelete_material.BackColor = System.Drawing.Color.White;
            this.btnDelete_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnDelete_material.Location = new System.Drawing.Point(8, 74);
            this.btnDelete_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete_material.Name = "btnDelete_material";
            this.btnDelete_material.Size = new System.Drawing.Size(185, 63);
            this.btnDelete_material.TabIndex = 3;
            this.btnDelete_material.Text = "Xóa vật liệu";
            this.btnDelete_material.UseVisualStyleBackColor = false;
            this.btnDelete_material.Click += new System.EventHandler(this.btnDelete_Material_Click);
            // 
            // btnExport_material
            // 
            this.btnExport_material.BackColor = System.Drawing.Color.White;
            this.btnExport_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport_material.Location = new System.Drawing.Point(199, 74);
            this.btnExport_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport_material.Name = "btnExport_material";
            this.btnExport_material.Size = new System.Drawing.Size(185, 63);
            this.btnExport_material.TabIndex = 5;
            this.btnExport_material.Text = "Xuất file danh sách vật liệu";
            this.btnExport_material.UseVisualStyleBackColor = false;
            this.btnExport_material.Click += new System.EventHandler(this.btnExport_Material_Click);
            // 
            // btnRefersh_material
            // 
            this.btnRefersh_material.BackColor = System.Drawing.Color.White;
            this.btnRefersh_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefersh_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefersh_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRefersh_material.Location = new System.Drawing.Point(199, 141);
            this.btnRefersh_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefersh_material.Name = "btnRefersh_material";
            this.btnRefersh_material.Size = new System.Drawing.Size(185, 63);
            this.btnRefersh_material.TabIndex = 4;
            this.btnRefersh_material.Text = "Làm mới";
            this.btnRefersh_material.UseVisualStyleBackColor = false;
            this.btnRefersh_material.Click += new System.EventHandler(this.btnRefersh_Material_Click);
            // 
            // grbSearchMaterial_material
            // 
            this.grbSearchMaterial_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbSearchMaterial_material.Controls.Add(this.pnlSpecialization_material);
            this.grbSearchMaterial_material.Controls.Add(this.pnllblExportUnitPrice_material);
            this.grbSearchMaterial_material.Controls.Add(this.pnlImportUnitPrice_material);
            this.grbSearchMaterial_material.Controls.Add(this.pnlNameMaterial_material);
            this.grbSearchMaterial_material.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearchMaterial_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearchMaterial_material.ForeColor = System.Drawing.Color.White;
            this.grbSearchMaterial_material.Location = new System.Drawing.Point(5, 5);
            this.grbSearchMaterial_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearchMaterial_material.Name = "grbSearchMaterial_material";
            this.grbSearchMaterial_material.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearchMaterial_material.Size = new System.Drawing.Size(501, 225);
            this.grbSearchMaterial_material.TabIndex = 0;
            this.grbSearchMaterial_material.TabStop = false;
            this.grbSearchMaterial_material.Text = "Tìm kiếm";
            // 
            // pnlSpecialization_material
            // 
            this.pnlSpecialization_material.Controls.Add(this.lblSpecialization_material);
            this.pnlSpecialization_material.Controls.Add(this.txtSpecialization_material);
            this.pnlSpecialization_material.Location = new System.Drawing.Point(6, 162);
            this.pnlSpecialization_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSpecialization_material.Name = "pnlSpecialization_material";
            this.pnlSpecialization_material.Size = new System.Drawing.Size(430, 39);
            this.pnlSpecialization_material.TabIndex = 8;
            // 
            // lblSpecialization_material
            // 
            this.lblSpecialization_material.AutoSize = true;
            this.lblSpecialization_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpecialization_material.Location = new System.Drawing.Point(3, 9);
            this.lblSpecialization_material.Name = "lblSpecialization_material";
            this.lblSpecialization_material.Size = new System.Drawing.Size(80, 20);
            this.lblSpecialization_material.TabIndex = 0;
            this.lblSpecialization_material.Text = "Quy cách";
            // 
            // txtSpecialization_material
            // 
            this.txtSpecialization_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSpecialization_material.Location = new System.Drawing.Point(116, 6);
            this.txtSpecialization_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialization_material.Name = "txtSpecialization_material";
            this.txtSpecialization_material.Size = new System.Drawing.Size(295, 26);
            this.txtSpecialization_material.TabIndex = 1;
            // 
            // pnllblExportUnitPrice_material
            // 
            this.pnllblExportUnitPrice_material.Controls.Add(this.lblExportUnitPrice_material);
            this.pnllblExportUnitPrice_material.Controls.Add(this.txtlblExportUnitPrice_material);
            this.pnllblExportUnitPrice_material.Location = new System.Drawing.Point(5, 114);
            this.pnllblExportUnitPrice_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnllblExportUnitPrice_material.Name = "pnllblExportUnitPrice_material";
            this.pnllblExportUnitPrice_material.Size = new System.Drawing.Size(431, 39);
            this.pnllblExportUnitPrice_material.TabIndex = 7;
            // 
            // lblExportUnitPrice_material
            // 
            this.lblExportUnitPrice_material.AutoSize = true;
            this.lblExportUnitPrice_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExportUnitPrice_material.Location = new System.Drawing.Point(3, 9);
            this.lblExportUnitPrice_material.Name = "lblExportUnitPrice_material";
            this.lblExportUnitPrice_material.Size = new System.Drawing.Size(67, 20);
            this.lblExportUnitPrice_material.TabIndex = 0;
            this.lblExportUnitPrice_material.Text = "Giá bán";
            // 
            // txtlblExportUnitPrice_material
            // 
            this.txtlblExportUnitPrice_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtlblExportUnitPrice_material.Location = new System.Drawing.Point(117, 6);
            this.txtlblExportUnitPrice_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlblExportUnitPrice_material.Name = "txtlblExportUnitPrice_material";
            this.txtlblExportUnitPrice_material.Size = new System.Drawing.Size(295, 26);
            this.txtlblExportUnitPrice_material.TabIndex = 1;
            // 
            // pnlImportUnitPrice_material
            // 
            this.pnlImportUnitPrice_material.Controls.Add(this.lblImportUnitPrice_material);
            this.pnlImportUnitPrice_material.Controls.Add(this.txtImportUnitPrice_material);
            this.pnlImportUnitPrice_material.Location = new System.Drawing.Point(5, 70);
            this.pnlImportUnitPrice_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlImportUnitPrice_material.Name = "pnlImportUnitPrice_material";
            this.pnlImportUnitPrice_material.Size = new System.Drawing.Size(431, 39);
            this.pnlImportUnitPrice_material.TabIndex = 6;
            // 
            // lblImportUnitPrice_material
            // 
            this.lblImportUnitPrice_material.AutoSize = true;
            this.lblImportUnitPrice_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImportUnitPrice_material.Location = new System.Drawing.Point(3, 9);
            this.lblImportUnitPrice_material.Name = "lblImportUnitPrice_material";
            this.lblImportUnitPrice_material.Size = new System.Drawing.Size(76, 20);
            this.lblImportUnitPrice_material.TabIndex = 0;
            this.lblImportUnitPrice_material.Text = "Giá nhập";
            // 
            // txtImportUnitPrice_material
            // 
            this.txtImportUnitPrice_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImportUnitPrice_material.Location = new System.Drawing.Point(117, 6);
            this.txtImportUnitPrice_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImportUnitPrice_material.Name = "txtImportUnitPrice_material";
            this.txtImportUnitPrice_material.Size = new System.Drawing.Size(295, 26);
            this.txtImportUnitPrice_material.TabIndex = 1;
            // 
            // pnlNameMaterial_material
            // 
            this.pnlNameMaterial_material.Controls.Add(this.lblNameMaterial_material);
            this.pnlNameMaterial_material.Controls.Add(this.txtNameMaterial_material);
            this.pnlNameMaterial_material.Location = new System.Drawing.Point(5, 25);
            this.pnlNameMaterial_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNameMaterial_material.Name = "pnlNameMaterial_material";
            this.pnlNameMaterial_material.Size = new System.Drawing.Size(431, 39);
            this.pnlNameMaterial_material.TabIndex = 5;
            // 
            // lblNameMaterial_material
            // 
            this.lblNameMaterial_material.AutoSize = true;
            this.lblNameMaterial_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameMaterial_material.Location = new System.Drawing.Point(3, 9);
            this.lblNameMaterial_material.Name = "lblNameMaterial_material";
            this.lblNameMaterial_material.Size = new System.Drawing.Size(95, 20);
            this.lblNameMaterial_material.TabIndex = 0;
            this.lblNameMaterial_material.Text = "Tên vật liệu";
            // 
            // txtNameMaterial_material
            // 
            this.txtNameMaterial_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNameMaterial_material.Location = new System.Drawing.Point(117, 6);
            this.txtNameMaterial_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameMaterial_material.Name = "txtNameMaterial_material";
            this.txtNameMaterial_material.Size = new System.Drawing.Size(295, 26);
            this.txtNameMaterial_material.TabIndex = 1;
            // 
            // tpgReceipt
            // 
            this.tpgReceipt.Controls.Add(this.splitContainer1);
            this.tpgReceipt.Location = new System.Drawing.Point(174, 4);
            this.tpgReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.tpgReceipt.Name = "tpgReceipt";
            this.tpgReceipt.Size = new System.Drawing.Size(1101, 607);
            this.tpgReceipt.TabIndex = 2;
            this.tpgReceipt.Text = "Quản lý hóa đơn";
            this.tpgReceipt.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwReceipt_Receipt);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.splitContainer1.Panel2.Controls.Add(this.flpFunction_receipt);
            this.splitContainer1.Panel2.Controls.Add(this.grbSearch_receipt);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1101, 607);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // lvwReceipt_Receipt
            // 
            this.lvwReceipt_Receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwReceipt_Receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwReceipt_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwReceipt_Receipt.ForeColor = System.Drawing.Color.White;
            this.lvwReceipt_Receipt.FullRowSelect = true;
            this.lvwReceipt_Receipt.GridLines = true;
            this.lvwReceipt_Receipt.HideSelection = false;
            this.lvwReceipt_Receipt.Location = new System.Drawing.Point(0, 0);
            this.lvwReceipt_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwReceipt_Receipt.Name = "lvwReceipt_Receipt";
            this.lvwReceipt_Receipt.OwnerDraw = true;
            this.lvwReceipt_Receipt.Size = new System.Drawing.Size(589, 607);
            this.lvwReceipt_Receipt.Sortable = true;
            this.lvwReceipt_Receipt.SortableColumns = null;
            this.lvwReceipt_Receipt.TabIndex = 0;
            this.lvwReceipt_Receipt.UseCompatibleStateImageBehavior = false;
            this.lvwReceipt_Receipt.View = System.Windows.Forms.View.Details;
            // 
            // flpFunction_receipt
            // 
            this.flpFunction_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flpFunction_receipt.Controls.Add(this.btnAdd_Receipt);
            this.flpFunction_receipt.Controls.Add(this.btnEdit_Receipt);
            this.flpFunction_receipt.Controls.Add(this.btnDelete_Receipt);
            this.flpFunction_receipt.Controls.Add(this.btnExport_Receipt);
            this.flpFunction_receipt.Controls.Add(this.btnRefresh_Receipt);
            this.flpFunction_receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFunction_receipt.Location = new System.Drawing.Point(5, 306);
            this.flpFunction_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpFunction_receipt.Name = "flpFunction_receipt";
            this.flpFunction_receipt.Padding = new System.Windows.Forms.Padding(5);
            this.flpFunction_receipt.Size = new System.Drawing.Size(501, 296);
            this.flpFunction_receipt.TabIndex = 8;
            // 
            // btnAdd_Receipt
            // 
            this.btnAdd_Receipt.BackColor = System.Drawing.Color.White;
            this.btnAdd_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_Receipt.Location = new System.Drawing.Point(8, 7);
            this.btnAdd_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_Receipt.Name = "btnAdd_Receipt";
            this.btnAdd_Receipt.Size = new System.Drawing.Size(185, 63);
            this.btnAdd_Receipt.TabIndex = 1;
            this.btnAdd_Receipt.Text = "Thêm hóa đơn";
            this.btnAdd_Receipt.UseVisualStyleBackColor = false;
            // 
            // btnEdit_Receipt
            // 
            this.btnEdit_Receipt.BackColor = System.Drawing.Color.White;
            this.btnEdit_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnEdit_Receipt.Location = new System.Drawing.Point(199, 7);
            this.btnEdit_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_Receipt.Name = "btnEdit_Receipt";
            this.btnEdit_Receipt.Size = new System.Drawing.Size(185, 63);
            this.btnEdit_Receipt.TabIndex = 2;
            this.btnEdit_Receipt.Text = "Chỉnh sửa thông tin";
            this.btnEdit_Receipt.UseVisualStyleBackColor = false;
            // 
            // btnDelete_Receipt
            // 
            this.btnDelete_Receipt.BackColor = System.Drawing.Color.White;
            this.btnDelete_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnDelete_Receipt.Location = new System.Drawing.Point(8, 74);
            this.btnDelete_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete_Receipt.Name = "btnDelete_Receipt";
            this.btnDelete_Receipt.Size = new System.Drawing.Size(185, 63);
            this.btnDelete_Receipt.TabIndex = 3;
            this.btnDelete_Receipt.Text = "Xóa hóa đơn";
            this.btnDelete_Receipt.UseVisualStyleBackColor = false;
            // 
            // btnExport_Receipt
            // 
            this.btnExport_Receipt.BackColor = System.Drawing.Color.White;
            this.btnExport_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport_Receipt.Location = new System.Drawing.Point(199, 74);
            this.btnExport_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport_Receipt.Name = "btnExport_Receipt";
            this.btnExport_Receipt.Size = new System.Drawing.Size(185, 63);
            this.btnExport_Receipt.TabIndex = 5;
            this.btnExport_Receipt.Text = "Xuất file danh sách hóa đơn";
            this.btnExport_Receipt.UseVisualStyleBackColor = false;
            // 
            // btnRefresh_Receipt
            // 
            this.btnRefresh_Receipt.BackColor = System.Drawing.Color.White;
            this.btnRefresh_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRefresh_Receipt.Location = new System.Drawing.Point(8, 141);
            this.btnRefresh_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh_Receipt.Name = "btnRefresh_Receipt";
            this.btnRefresh_Receipt.Size = new System.Drawing.Size(185, 63);
            this.btnRefresh_Receipt.TabIndex = 4;
            this.btnRefresh_Receipt.Text = "Làm mới";
            this.btnRefresh_Receipt.UseVisualStyleBackColor = false;
            // 
            // grbSearch_receipt
            // 
            this.grbSearch_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbSearch_receipt.Controls.Add(this.pnlEmployeeReceipt_receipt);
            this.grbSearch_receipt.Controls.Add(this.pnlReceiptType_receipt);
            this.grbSearch_receipt.Controls.Add(this.pnlWareHouse_receipt);
            this.grbSearch_receipt.Controls.Add(this.pnlPartner_receipt);
            this.grbSearch_receipt.Controls.Add(this.pnlDate_receipt);
            this.grbSearch_receipt.Controls.Add(this.pnlID_receipt);
            this.grbSearch_receipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearch_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearch_receipt.ForeColor = System.Drawing.Color.White;
            this.grbSearch_receipt.Location = new System.Drawing.Point(5, 5);
            this.grbSearch_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_receipt.Name = "grbSearch_receipt";
            this.grbSearch_receipt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_receipt.Size = new System.Drawing.Size(501, 301);
            this.grbSearch_receipt.TabIndex = 0;
            this.grbSearch_receipt.TabStop = false;
            this.grbSearch_receipt.Text = "Tìm kiếm";
            // 
            // pnlEmployeeReceipt_receipt
            // 
            this.pnlEmployeeReceipt_receipt.Controls.Add(this.txtEmployeeReceipt_receipt);
            this.pnlEmployeeReceipt_receipt.Controls.Add(this.lblEmployeeReceipt_receipt);
            this.pnlEmployeeReceipt_receipt.Location = new System.Drawing.Point(8, 244);
            this.pnlEmployeeReceipt_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmployeeReceipt_receipt.Name = "pnlEmployeeReceipt_receipt";
            this.pnlEmployeeReceipt_receipt.Size = new System.Drawing.Size(440, 39);
            this.pnlEmployeeReceipt_receipt.TabIndex = 9;
            // 
            // txtEmployeeReceipt_receipt
            // 
            this.txtEmployeeReceipt_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmployeeReceipt_receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtEmployeeReceipt_receipt.Location = new System.Drawing.Point(164, 6);
            this.txtEmployeeReceipt_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeReceipt_receipt.Name = "txtEmployeeReceipt_receipt";
            this.txtEmployeeReceipt_receipt.Size = new System.Drawing.Size(267, 26);
            this.txtEmployeeReceipt_receipt.TabIndex = 2;
            // 
            // lblEmployeeReceipt_receipt
            // 
            this.lblEmployeeReceipt_receipt.AutoSize = true;
            this.lblEmployeeReceipt_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmployeeReceipt_receipt.Location = new System.Drawing.Point(1, 9);
            this.lblEmployeeReceipt_receipt.Name = "lblEmployeeReceipt_receipt";
            this.lblEmployeeReceipt_receipt.Size = new System.Drawing.Size(143, 20);
            this.lblEmployeeReceipt_receipt.TabIndex = 0;
            this.lblEmployeeReceipt_receipt.Text = "Người lập hóa đơn";
            // 
            // pnlReceiptType_receipt
            // 
            this.pnlReceiptType_receipt.Controls.Add(this.rdbExport_receipt);
            this.pnlReceiptType_receipt.Controls.Add(this.rdbImport_receipt);
            this.pnlReceiptType_receipt.Controls.Add(this.lblReceiptType_receipt);
            this.pnlReceiptType_receipt.Location = new System.Drawing.Point(8, 199);
            this.pnlReceiptType_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReceiptType_receipt.Name = "pnlReceiptType_receipt";
            this.pnlReceiptType_receipt.Size = new System.Drawing.Size(437, 39);
            this.pnlReceiptType_receipt.TabIndex = 8;
            // 
            // rdbExport_receipt
            // 
            this.rdbExport_receipt.AutoSize = true;
            this.rdbExport_receipt.Location = new System.Drawing.Point(300, 8);
            this.rdbExport_receipt.Name = "rdbExport_receipt";
            this.rdbExport_receipt.Size = new System.Drawing.Size(94, 24);
            this.rdbExport_receipt.TabIndex = 2;
            this.rdbExport_receipt.TabStop = true;
            this.rdbExport_receipt.Text = "HĐ Xuất";
            this.rdbExport_receipt.UseVisualStyleBackColor = true;
            // 
            // rdbImport_receipt
            // 
            this.rdbImport_receipt.AutoSize = true;
            this.rdbImport_receipt.Location = new System.Drawing.Point(164, 8);
            this.rdbImport_receipt.Name = "rdbImport_receipt";
            this.rdbImport_receipt.Size = new System.Drawing.Size(99, 24);
            this.rdbImport_receipt.TabIndex = 1;
            this.rdbImport_receipt.TabStop = true;
            this.rdbImport_receipt.Text = "HĐ Nhập";
            this.rdbImport_receipt.UseVisualStyleBackColor = true;
            // 
            // lblReceiptType_receipt
            // 
            this.lblReceiptType_receipt.AutoSize = true;
            this.lblReceiptType_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReceiptType_receipt.Location = new System.Drawing.Point(1, 10);
            this.lblReceiptType_receipt.Name = "lblReceiptType_receipt";
            this.lblReceiptType_receipt.Size = new System.Drawing.Size(106, 20);
            this.lblReceiptType_receipt.TabIndex = 0;
            this.lblReceiptType_receipt.Text = "Kiểu hóa đơn";
            // 
            // pnlWareHouse_receipt
            // 
            this.pnlWareHouse_receipt.Controls.Add(this.cbbWareHouse_receipt);
            this.pnlWareHouse_receipt.Controls.Add(this.lblWareHouse_receipt);
            this.pnlWareHouse_receipt.Location = new System.Drawing.Point(8, 156);
            this.pnlWareHouse_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlWareHouse_receipt.Name = "pnlWareHouse_receipt";
            this.pnlWareHouse_receipt.Size = new System.Drawing.Size(437, 39);
            this.pnlWareHouse_receipt.TabIndex = 8;
            // 
            // cbbWareHouse_receipt
            // 
            this.cbbWareHouse_receipt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbWareHouse_receipt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbWareHouse_receipt.FormattingEnabled = true;
            this.cbbWareHouse_receipt.Location = new System.Drawing.Point(164, 6);
            this.cbbWareHouse_receipt.Name = "cbbWareHouse_receipt";
            this.cbbWareHouse_receipt.Size = new System.Drawing.Size(267, 28);
            this.cbbWareHouse_receipt.TabIndex = 1;
            // 
            // lblWareHouse_receipt
            // 
            this.lblWareHouse_receipt.AutoSize = true;
            this.lblWareHouse_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWareHouse_receipt.Location = new System.Drawing.Point(3, 9);
            this.lblWareHouse_receipt.Name = "lblWareHouse_receipt";
            this.lblWareHouse_receipt.Size = new System.Drawing.Size(38, 20);
            this.lblWareHouse_receipt.TabIndex = 0;
            this.lblWareHouse_receipt.Text = "Kho";
            // 
            // pnlPartner_receipt
            // 
            this.pnlPartner_receipt.Controls.Add(this.lblPartner_receipt);
            this.pnlPartner_receipt.Controls.Add(this.txtPrice_Receipt);
            this.pnlPartner_receipt.Location = new System.Drawing.Point(8, 113);
            this.pnlPartner_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPartner_receipt.Name = "pnlPartner_receipt";
            this.pnlPartner_receipt.Size = new System.Drawing.Size(437, 39);
            this.pnlPartner_receipt.TabIndex = 7;
            // 
            // lblPartner_receipt
            // 
            this.lblPartner_receipt.AutoSize = true;
            this.lblPartner_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPartner_receipt.Location = new System.Drawing.Point(1, 8);
            this.lblPartner_receipt.Name = "lblPartner_receipt";
            this.lblPartner_receipt.Size = new System.Drawing.Size(56, 20);
            this.lblPartner_receipt.TabIndex = 0;
            this.lblPartner_receipt.Text = "Đơn vị";
            // 
            // txtPrice_Receipt
            // 
            this.txtPrice_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtPrice_Receipt.Location = new System.Drawing.Point(164, 5);
            this.txtPrice_Receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice_Receipt.Name = "txtPrice_Receipt";
            this.txtPrice_Receipt.Size = new System.Drawing.Size(267, 26);
            this.txtPrice_Receipt.TabIndex = 1;
            // 
            // pnlDate_receipt
            // 
            this.pnlDate_receipt.Controls.Add(this.dtpDateTo_receipt);
            this.pnlDate_receipt.Controls.Add(this.dtpDateFrom_receipt);
            this.pnlDate_receipt.Controls.Add(this.lblDate_receipt);
            this.pnlDate_receipt.Location = new System.Drawing.Point(8, 70);
            this.pnlDate_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDate_receipt.Name = "pnlDate_receipt";
            this.pnlDate_receipt.Size = new System.Drawing.Size(437, 39);
            this.pnlDate_receipt.TabIndex = 6;
            // 
            // dtpDateTo_receipt
            // 
            this.dtpDateTo_receipt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo_receipt.Location = new System.Drawing.Point(317, 7);
            this.dtpDateTo_receipt.Name = "dtpDateTo_receipt";
            this.dtpDateTo_receipt.Size = new System.Drawing.Size(114, 26);
            this.dtpDateTo_receipt.TabIndex = 2;
            // 
            // dtpDateFrom_receipt
            // 
            this.dtpDateFrom_receipt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom_receipt.Location = new System.Drawing.Point(164, 7);
            this.dtpDateFrom_receipt.Name = "dtpDateFrom_receipt";
            this.dtpDateFrom_receipt.Size = new System.Drawing.Size(121, 26);
            this.dtpDateFrom_receipt.TabIndex = 1;
            // 
            // lblDate_receipt
            // 
            this.lblDate_receipt.AutoSize = true;
            this.lblDate_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate_receipt.Location = new System.Drawing.Point(1, 12);
            this.lblDate_receipt.Name = "lblDate_receipt";
            this.lblDate_receipt.Size = new System.Drawing.Size(74, 20);
            this.lblDate_receipt.TabIndex = 0;
            this.lblDate_receipt.Text = "Ngày lập";
            // 
            // pnlID_receipt
            // 
            this.pnlID_receipt.Controls.Add(this.lblId_receipt);
            this.pnlID_receipt.Controls.Add(this.txtId_receipt);
            this.pnlID_receipt.Location = new System.Drawing.Point(8, 27);
            this.pnlID_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlID_receipt.Name = "pnlID_receipt";
            this.pnlID_receipt.Size = new System.Drawing.Size(437, 39);
            this.pnlID_receipt.TabIndex = 5;
            // 
            // lblId_receipt
            // 
            this.lblId_receipt.AutoSize = true;
            this.lblId_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblId_receipt.Location = new System.Drawing.Point(3, 6);
            this.lblId_receipt.Name = "lblId_receipt";
            this.lblId_receipt.Size = new System.Drawing.Size(96, 20);
            this.lblId_receipt.TabIndex = 0;
            this.lblId_receipt.Text = "Mã hóa đơn";
            // 
            // txtId_receipt
            // 
            this.txtId_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtId_receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtId_receipt.Location = new System.Drawing.Point(164, 6);
            this.txtId_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_receipt.Name = "txtId_receipt";
            this.txtId_receipt.Size = new System.Drawing.Size(267, 26);
            this.txtId_receipt.TabIndex = 1;
            // 
            // bmwListView1
            // 
            this.bmwListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmwListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwListView1.ForeColor = System.Drawing.Color.White;
            this.bmwListView1.FullRowSelect = true;
            this.bmwListView1.GridLines = true;
            this.bmwListView1.HideSelection = false;
            this.bmwListView1.Location = new System.Drawing.Point(0, 0);
            this.bmwListView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwListView1.Name = "bmwListView1";
            this.bmwListView1.OwnerDraw = true;
            this.bmwListView1.Size = new System.Drawing.Size(589, 607);
            this.bmwListView1.Sortable = true;
            this.bmwListView1.SortableColumns = null;
            this.bmwListView1.TabIndex = 0;
            this.bmwListView1.UseCompatibleStateImageBehavior = false;
            this.bmwListView1.View = System.Windows.Forms.View.Details;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flowLayoutPanel1.Controls.Add(this.bmwButton1);
            this.flowLayoutPanel1.Controls.Add(this.bmwButton2);
            this.flowLayoutPanel1.Controls.Add(this.bmwButton3);
            this.flowLayoutPanel1.Controls.Add(this.bmwButton4);
            this.flowLayoutPanel1.Controls.Add(this.bmwButton5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 357);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 244);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // bmwButton1
            // 
            this.bmwButton1.BackColor = System.Drawing.Color.White;
            this.bmwButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton1.Location = new System.Drawing.Point(8, 7);
            this.bmwButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton1.Name = "bmwButton1";
            this.bmwButton1.Size = new System.Drawing.Size(185, 63);
            this.bmwButton1.TabIndex = 1;
            this.bmwButton1.Text = "Thêm khách hàng";
            this.bmwButton1.UseVisualStyleBackColor = false;
            // 
            // bmwButton2
            // 
            this.bmwButton2.BackColor = System.Drawing.Color.White;
            this.bmwButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton2.Location = new System.Drawing.Point(199, 7);
            this.bmwButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton2.Name = "bmwButton2";
            this.bmwButton2.Size = new System.Drawing.Size(185, 63);
            this.bmwButton2.TabIndex = 2;
            this.bmwButton2.Text = "Chỉnh sửa thông tin";
            this.bmwButton2.UseVisualStyleBackColor = false;
            // 
            // bmwButton3
            // 
            this.bmwButton3.BackColor = System.Drawing.Color.White;
            this.bmwButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton3.Location = new System.Drawing.Point(8, 74);
            this.bmwButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton3.Name = "bmwButton3";
            this.bmwButton3.Size = new System.Drawing.Size(185, 63);
            this.bmwButton3.TabIndex = 3;
            this.bmwButton3.Text = "Xóa KH";
            this.bmwButton3.UseVisualStyleBackColor = false;
            // 
            // bmwButton4
            // 
            this.bmwButton4.BackColor = System.Drawing.Color.White;
            this.bmwButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton4.Location = new System.Drawing.Point(199, 74);
            this.bmwButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton4.Name = "bmwButton4";
            this.bmwButton4.Size = new System.Drawing.Size(185, 63);
            this.bmwButton4.TabIndex = 5;
            this.bmwButton4.Text = "Xuất file danh sách khách hàng";
            this.bmwButton4.UseVisualStyleBackColor = false;
            // 
            // bmwButton5
            // 
            this.bmwButton5.BackColor = System.Drawing.Color.White;
            this.bmwButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton5.Location = new System.Drawing.Point(8, 141);
            this.bmwButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton5.Name = "bmwButton5";
            this.bmwButton5.Size = new System.Drawing.Size(185, 63);
            this.bmwButton5.TabIndex = 4;
            this.bmwButton5.Text = "Làm mới";
            this.bmwButton5.UseVisualStyleBackColor = false;
            // 
            // grbSearch_material
            // 
            this.grbSearch_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbSearch_material.Controls.Add(this.panel1);
            this.grbSearch_material.Controls.Add(this.pnlA);
            this.grbSearch_material.Controls.Add(this.pnlName_material);
            this.grbSearch_material.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearch_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearch_material.ForeColor = System.Drawing.Color.White;
            this.grbSearch_material.Location = new System.Drawing.Point(7, 186);
            this.grbSearch_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_material.Name = "grbSearch_material";
            this.grbSearch_material.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSearch_material.Size = new System.Drawing.Size(497, 171);
            this.grbSearch_material.TabIndex = 0;
            this.grbSearch_material.TabStop = false;
            this.grbSearch_material.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(5, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 39);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(156, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 26);
            this.textBox2.TabIndex = 1;
            // 
            // pnlA
            // 
            this.pnlA.Controls.Add(this.label6);
            this.pnlA.Controls.Add(this.textBox5);
            this.pnlA.Location = new System.Drawing.Point(5, 70);
            this.pnlA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(461, 39);
            this.pnlA.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(156, 6);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(295, 26);
            this.textBox5.TabIndex = 1;
            // 
            // pnlName_material
            // 
            this.pnlName_material.Controls.Add(this.lblName_material);
            this.pnlName_material.Controls.Add(this.txtName_material);
            this.pnlName_material.Location = new System.Drawing.Point(5, 25);
            this.pnlName_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlName_material.Name = "pnlName_material";
            this.pnlName_material.Size = new System.Drawing.Size(461, 39);
            this.pnlName_material.TabIndex = 5;
            // 
            // lblName_material
            // 
            this.lblName_material.AutoSize = true;
            this.lblName_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_material.Location = new System.Drawing.Point(3, 9);
            this.lblName_material.Name = "lblName_material";
            this.lblName_material.Size = new System.Drawing.Size(127, 20);
            this.lblName_material.TabIndex = 0;
            this.lblName_material.Text = "Tên khách hàng";
            // 
            // txtName_material
            // 
            this.txtName_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_material.Location = new System.Drawing.Point(156, 6);
            this.txtName_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName_material.Name = "txtName_material";
            this.txtName_material.Size = new System.Drawing.Size(295, 26);
            this.txtName_material.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.flowLayoutPanel2.Controls.Add(this.bmwButton6);
            this.flowLayoutPanel2.Controls.Add(this.bmwButton7);
            this.flowLayoutPanel2.Controls.Add(this.bmwButton8);
            this.flowLayoutPanel2.Controls.Add(this.bmwButton9);
            this.flowLayoutPanel2.Controls.Add(this.bmwButton10);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 186);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(497, 415);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // bmwButton6
            // 
            this.bmwButton6.BackColor = System.Drawing.Color.White;
            this.bmwButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton6.Location = new System.Drawing.Point(8, 7);
            this.bmwButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton6.Name = "bmwButton6";
            this.bmwButton6.Size = new System.Drawing.Size(185, 63);
            this.bmwButton6.TabIndex = 1;
            this.bmwButton6.Text = "Thêm NCC";
            this.bmwButton6.UseVisualStyleBackColor = false;
            // 
            // bmwButton7
            // 
            this.bmwButton7.BackColor = System.Drawing.Color.White;
            this.bmwButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton7.Location = new System.Drawing.Point(199, 7);
            this.bmwButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton7.Name = "bmwButton7";
            this.bmwButton7.Size = new System.Drawing.Size(185, 63);
            this.bmwButton7.TabIndex = 2;
            this.bmwButton7.Text = "Chỉnh sửa thông tin";
            this.bmwButton7.UseVisualStyleBackColor = false;
            // 
            // bmwButton8
            // 
            this.bmwButton8.BackColor = System.Drawing.Color.White;
            this.bmwButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton8.Location = new System.Drawing.Point(8, 74);
            this.bmwButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton8.Name = "bmwButton8";
            this.bmwButton8.Size = new System.Drawing.Size(185, 63);
            this.bmwButton8.TabIndex = 3;
            this.bmwButton8.Text = "Xóa NCC";
            this.bmwButton8.UseVisualStyleBackColor = false;
            // 
            // bmwButton9
            // 
            this.bmwButton9.BackColor = System.Drawing.Color.White;
            this.bmwButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton9.Location = new System.Drawing.Point(199, 74);
            this.bmwButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton9.Name = "bmwButton9";
            this.bmwButton9.Size = new System.Drawing.Size(185, 63);
            this.bmwButton9.TabIndex = 5;
            this.bmwButton9.Text = "Xuất file danh sách NCC";
            this.bmwButton9.UseVisualStyleBackColor = false;
            // 
            // bmwButton10
            // 
            this.bmwButton10.BackColor = System.Drawing.Color.White;
            this.bmwButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwButton10.Location = new System.Drawing.Point(8, 141);
            this.bmwButton10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwButton10.Name = "bmwButton10";
            this.bmwButton10.Size = new System.Drawing.Size(185, 63);
            this.bmwButton10.TabIndex = 6;
            this.bmwButton10.Text = "Làm mới";
            this.bmwButton10.UseVisualStyleBackColor = false;
            // 
            // bmwGroupBox1
            // 
            this.bmwGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.bmwGroupBox1.Controls.Add(this.panel2);
            this.bmwGroupBox1.Controls.Add(this.panel5);
            this.bmwGroupBox1.Controls.Add(this.panel6);
            this.bmwGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bmwGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bmwGroupBox1.ForeColor = System.Drawing.Color.White;
            this.bmwGroupBox1.Location = new System.Drawing.Point(7, 6);
            this.bmwGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwGroupBox1.Name = "bmwGroupBox1";
            this.bmwGroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmwGroupBox1.Size = new System.Drawing.Size(497, 180);
            this.bmwGroupBox1.TabIndex = 7;
            this.bmwGroupBox1.TabStop = false;
            this.bmwGroupBox1.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(5, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 39);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(132, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 26);
            this.textBox1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Location = new System.Drawing.Point(5, 70);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 39);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(132, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 26);
            this.textBox3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Location = new System.Drawing.Point(5, 25);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 39);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NCC";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(132, 6);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(319, 26);
            this.textBox4.TabIndex = 1;
            // 
            // tpgSell
            // 
            this.tpgSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.tpgSell.Controls.Add(this.grbItemInfor_sell);
            this.tpgSell.Controls.Add(this.grbGeneralInfor_sell);
            this.tpgSell.Controls.Add(this.pnlTitle_sell);
            this.tpgSell.Location = new System.Drawing.Point(174, 4);
            this.tpgSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgSell.Name = "tpgSell";
            this.tpgSell.Padding = new System.Windows.Forms.Padding(5);
            this.tpgSell.Size = new System.Drawing.Size(1101, 607);
            this.tpgSell.TabIndex = 1;
            this.tpgSell.Text = "Tạo hóa đơn bán";
            // 
            // grbItemInfor_sell
            // 
            this.grbItemInfor_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbItemInfor_sell.Controls.Add(this.lvwItem_sell);
            this.grbItemInfor_sell.Controls.Add(this.pnlBottom_sell);
            this.grbItemInfor_sell.Controls.Add(this.panel4);
            this.grbItemInfor_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbItemInfor_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbItemInfor_sell.ForeColor = System.Drawing.Color.White;
            this.grbItemInfor_sell.Location = new System.Drawing.Point(5, 162);
            this.grbItemInfor_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbItemInfor_sell.Name = "grbItemInfor_sell";
            this.grbItemInfor_sell.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbItemInfor_sell.Size = new System.Drawing.Size(1091, 440);
            this.grbItemInfor_sell.TabIndex = 3;
            this.grbItemInfor_sell.TabStop = false;
            this.grbItemInfor_sell.Text = "Thông tin các mặt hàng";
            // 
            // lvwItem_sell
            // 
            this.lvwItem_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwItem_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwItem_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwItem_sell.ForeColor = System.Drawing.Color.White;
            this.lvwItem_sell.FullRowSelect = true;
            this.lvwItem_sell.GridLines = true;
            this.lvwItem_sell.HideSelection = false;
            this.lvwItem_sell.Location = new System.Drawing.Point(3, 148);
            this.lvwItem_sell.Name = "lvwItem_sell";
            this.lvwItem_sell.OwnerDraw = true;
            this.lvwItem_sell.Size = new System.Drawing.Size(1085, 241);
            this.lvwItem_sell.Sortable = true;
            this.lvwItem_sell.SortableColumns = null;
            this.lvwItem_sell.TabIndex = 19;
            this.lvwItem_sell.UseCompatibleStateImageBehavior = false;
            this.lvwItem_sell.View = System.Windows.Forms.View.Details;
            // 
            // pnlBottom_sell
            // 
            this.pnlBottom_sell.Controls.Add(this.pnlTotalMoney_sell);
            this.pnlBottom_sell.Controls.Add(this.btnCreateReceipt_sell);
            this.pnlBottom_sell.Controls.Add(this.btnPrintReceipt_sell);
            this.pnlBottom_sell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom_sell.Location = new System.Drawing.Point(3, 389);
            this.pnlBottom_sell.Name = "pnlBottom_sell";
            this.pnlBottom_sell.Size = new System.Drawing.Size(1085, 49);
            this.pnlBottom_sell.TabIndex = 18;
            // 
            // pnlTotalMoney_sell
            // 
            this.pnlTotalMoney_sell.Controls.Add(this.lblTotalMoney_sell);
            this.pnlTotalMoney_sell.Controls.Add(this.txtTotalMoney_sell);
            this.pnlTotalMoney_sell.Location = new System.Drawing.Point(686, 7);
            this.pnlTotalMoney_sell.Name = "pnlTotalMoney_sell";
            this.pnlTotalMoney_sell.Size = new System.Drawing.Size(396, 35);
            this.pnlTotalMoney_sell.TabIndex = 19;
            // 
            // lblTotalMoney_sell
            // 
            this.lblTotalMoney_sell.AutoSize = true;
            this.lblTotalMoney_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalMoney_sell.Location = new System.Drawing.Point(16, 7);
            this.lblTotalMoney_sell.Name = "lblTotalMoney_sell";
            this.lblTotalMoney_sell.Size = new System.Drawing.Size(83, 20);
            this.lblTotalMoney_sell.TabIndex = 12;
            this.lblTotalMoney_sell.Text = "Tổng tiền:";
            // 
            // txtTotalMoney_sell
            // 
            this.txtTotalMoney_sell.Location = new System.Drawing.Point(116, 4);
            this.txtTotalMoney_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMoney_sell.Name = "txtTotalMoney_sell";
            this.txtTotalMoney_sell.ReadOnly = true;
            this.txtTotalMoney_sell.Size = new System.Drawing.Size(255, 26);
            this.txtTotalMoney_sell.TabIndex = 13;
            // 
            // btnCreateReceipt_sell
            // 
            this.btnCreateReceipt_sell.BackColor = System.Drawing.Color.White;
            this.btnCreateReceipt_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReceipt_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateReceipt_sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCreateReceipt_sell.Location = new System.Drawing.Point(12, 7);
            this.btnCreateReceipt_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateReceipt_sell.Name = "btnCreateReceipt_sell";
            this.btnCreateReceipt_sell.Size = new System.Drawing.Size(172, 35);
            this.btnCreateReceipt_sell.TabIndex = 14;
            this.btnCreateReceipt_sell.Text = "Tạo hóa đơn";
            this.btnCreateReceipt_sell.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt_sell
            // 
            this.btnPrintReceipt_sell.BackColor = System.Drawing.Color.White;
            this.btnPrintReceipt_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintReceipt_sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnPrintReceipt_sell.Location = new System.Drawing.Point(203, 7);
            this.btnPrintReceipt_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt_sell.Name = "btnPrintReceipt_sell";
            this.btnPrintReceipt_sell.Size = new System.Drawing.Size(172, 35);
            this.btnPrintReceipt_sell.TabIndex = 17;
            this.btnPrintReceipt_sell.Text = "In hóa đơn";
            this.btnPrintReceipt_sell.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddItem);
            this.panel4.Controls.Add(this.pnlItemName_sell);
            this.panel4.Controls.Add(this.pnlNumerous_sell);
            this.panel4.Controls.Add(this.pnlItemUnitPrice_sell);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 127);
            this.panel4.TabIndex = 11;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.White;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddItem.Location = new System.Drawing.Point(633, 76);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(136, 32);
            this.btnAddItem.TabIndex = 21;
            this.btnAddItem.Text = "Thêm mặt hàng";
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // pnlItemName_sell
            // 
            this.pnlItemName_sell.Controls.Add(this.textBox7);
            this.pnlItemName_sell.Controls.Add(this.lblItemName_sell);
            this.pnlItemName_sell.Location = new System.Drawing.Point(12, 13);
            this.pnlItemName_sell.Name = "pnlItemName_sell";
            this.pnlItemName_sell.Size = new System.Drawing.Size(803, 51);
            this.pnlItemName_sell.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox7.Location = new System.Drawing.Point(116, 12);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(668, 26);
            this.textBox7.TabIndex = 9;
            // 
            // lblItemName_sell
            // 
            this.lblItemName_sell.AutoSize = true;
            this.lblItemName_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItemName_sell.Location = new System.Drawing.Point(23, 15);
            this.lblItemName_sell.Name = "lblItemName_sell";
            this.lblItemName_sell.Size = new System.Drawing.Size(83, 20);
            this.lblItemName_sell.TabIndex = 2;
            this.lblItemName_sell.Text = "Tên hàng:";
            // 
            // pnlNumerous_sell
            // 
            this.pnlNumerous_sell.Controls.Add(this.nmrNumerouse_sell);
            this.pnlNumerous_sell.Controls.Add(this.lblNumerous_sell);
            this.pnlNumerous_sell.Location = new System.Drawing.Point(357, 71);
            this.pnlNumerous_sell.Name = "pnlNumerous_sell";
            this.pnlNumerous_sell.Size = new System.Drawing.Size(260, 44);
            this.pnlNumerous_sell.TabIndex = 19;
            // 
            // nmrNumerouse_sell
            // 
            this.nmrNumerouse_sell.Location = new System.Drawing.Point(114, 8);
            this.nmrNumerouse_sell.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nmrNumerouse_sell.Name = "nmrNumerouse_sell";
            this.nmrNumerouse_sell.Size = new System.Drawing.Size(120, 26);
            this.nmrNumerouse_sell.TabIndex = 9;
            this.nmrNumerouse_sell.ThousandsSeparator = true;
            // 
            // lblNumerous_sell
            // 
            this.lblNumerous_sell.AutoSize = true;
            this.lblNumerous_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumerous_sell.Location = new System.Drawing.Point(3, 13);
            this.lblNumerous_sell.Name = "lblNumerous_sell";
            this.lblNumerous_sell.Size = new System.Drawing.Size(79, 20);
            this.lblNumerous_sell.TabIndex = 1;
            this.lblNumerous_sell.Text = "Số lượng:";
            // 
            // pnlItemUnitPrice_sell
            // 
            this.pnlItemUnitPrice_sell.Controls.Add(this.lblItemUnitPrice_sell);
            this.pnlItemUnitPrice_sell.Controls.Add(this.txtItemUnitPrice_sell);
            this.pnlItemUnitPrice_sell.Location = new System.Drawing.Point(12, 70);
            this.pnlItemUnitPrice_sell.Name = "pnlItemUnitPrice_sell";
            this.pnlItemUnitPrice_sell.Size = new System.Drawing.Size(339, 45);
            this.pnlItemUnitPrice_sell.TabIndex = 20;
            // 
            // lblItemUnitPrice_sell
            // 
            this.lblItemUnitPrice_sell.AutoSize = true;
            this.lblItemUnitPrice_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItemUnitPrice_sell.Location = new System.Drawing.Point(23, 14);
            this.lblItemUnitPrice_sell.Name = "lblItemUnitPrice_sell";
            this.lblItemUnitPrice_sell.Size = new System.Drawing.Size(71, 20);
            this.lblItemUnitPrice_sell.TabIndex = 3;
            this.lblItemUnitPrice_sell.Text = "Đơn giá:";
            // 
            // txtItemUnitPrice_sell
            // 
            this.txtItemUnitPrice_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtItemUnitPrice_sell.Location = new System.Drawing.Point(116, 11);
            this.txtItemUnitPrice_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemUnitPrice_sell.Name = "txtItemUnitPrice_sell";
            this.txtItemUnitPrice_sell.Size = new System.Drawing.Size(203, 26);
            this.txtItemUnitPrice_sell.TabIndex = 10;
            // 
            // grbGeneralInfor_sell
            // 
            this.grbGeneralInfor_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbGeneralInfor_sell.Controls.Add(this.btnAddCustomer_sell);
            this.grbGeneralInfor_sell.Controls.Add(this.txtAddress_sell);
            this.grbGeneralInfor_sell.Controls.Add(this.txtCustomerName_sell);
            this.grbGeneralInfor_sell.Controls.Add(this.lblAddress_sell);
            this.grbGeneralInfor_sell.Controls.Add(this.lblCustomerName_sell);
            this.grbGeneralInfor_sell.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbGeneralInfor_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbGeneralInfor_sell.ForeColor = System.Drawing.Color.White;
            this.grbGeneralInfor_sell.Location = new System.Drawing.Point(5, 43);
            this.grbGeneralInfor_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGeneralInfor_sell.Name = "grbGeneralInfor_sell";
            this.grbGeneralInfor_sell.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGeneralInfor_sell.Size = new System.Drawing.Size(1091, 119);
            this.grbGeneralInfor_sell.TabIndex = 2;
            this.grbGeneralInfor_sell.TabStop = false;
            this.grbGeneralInfor_sell.Text = "Thông tin chung";
            // 
            // btnAddCustomer_sell
            // 
            this.btnAddCustomer_sell.BackColor = System.Drawing.Color.White;
            this.btnAddCustomer_sell.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddCustomer_sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddCustomer_sell.Location = new System.Drawing.Point(817, 32);
            this.btnAddCustomer_sell.Name = "btnAddCustomer_sell";
            this.btnAddCustomer_sell.Size = new System.Drawing.Size(32, 26);
            this.btnAddCustomer_sell.TabIndex = 13;
            this.btnAddCustomer_sell.Text = "+";
            this.btnAddCustomer_sell.UseVisualStyleBackColor = false;
            // 
            // txtAddress_sell
            // 
            this.txtAddress_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_sell.Location = new System.Drawing.Point(217, 71);
            this.txtAddress_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress_sell.Name = "txtAddress_sell";
            this.txtAddress_sell.ReadOnly = true;
            this.txtAddress_sell.Size = new System.Drawing.Size(582, 26);
            this.txtAddress_sell.TabIndex = 11;
            // 
            // txtCustomerName_sell
            // 
            this.txtCustomerName_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCustomerName_sell.Location = new System.Drawing.Point(217, 32);
            this.txtCustomerName_sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName_sell.Name = "txtCustomerName_sell";
            this.txtCustomerName_sell.Size = new System.Drawing.Size(582, 26);
            this.txtCustomerName_sell.TabIndex = 10;
            this.txtCustomerName_sell.TextChanged += new System.EventHandler(this.txtCustomerName_sell_TextChanged);
            // 
            // lblAddress_sell
            // 
            this.lblAddress_sell.AutoSize = true;
            this.lblAddress_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_sell.Location = new System.Drawing.Point(32, 74);
            this.lblAddress_sell.Name = "lblAddress_sell";
            this.lblAddress_sell.Size = new System.Drawing.Size(66, 20);
            this.lblAddress_sell.TabIndex = 6;
            this.lblAddress_sell.Text = "Địa chỉ:";
            // 
            // lblCustomerName_sell
            // 
            this.lblCustomerName_sell.AutoSize = true;
            this.lblCustomerName_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomerName_sell.Location = new System.Drawing.Point(32, 35);
            this.lblCustomerName_sell.Name = "lblCustomerName_sell";
            this.lblCustomerName_sell.Size = new System.Drawing.Size(147, 20);
            this.lblCustomerName_sell.TabIndex = 5;
            this.lblCustomerName_sell.Text = "Tên nhà cung cấp:";
            // 
            // pnlTitle_sell
            // 
            this.pnlTitle_sell.Controls.Add(this.lblTitle_sell);
            this.pnlTitle_sell.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle_sell.Location = new System.Drawing.Point(5, 5);
            this.pnlTitle_sell.Name = "pnlTitle_sell";
            this.pnlTitle_sell.Size = new System.Drawing.Size(1091, 38);
            this.pnlTitle_sell.TabIndex = 0;
            // 
            // lblTitle_sell
            // 
            this.lblTitle_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lblTitle_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle_sell.ForeColor = System.Drawing.Color.White;
            this.lblTitle_sell.Location = new System.Drawing.Point(0, 0);
            this.lblTitle_sell.Name = "lblTitle_sell";
            this.lblTitle_sell.Size = new System.Drawing.Size(1091, 38);
            this.lblTitle_sell.TabIndex = 1;
            this.lblTitle_sell.Text = "HÓA ĐƠN BÁN HÀNG";
            this.lblTitle_sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpgBuy
            // 
            this.tpgBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.tpgBuy.Controls.Add(this.grbItemInfor_Buy);
            this.tpgBuy.Controls.Add(this.grbGeneralInfor_Buy);
            this.tpgBuy.Controls.Add(this.pnlTitle_buy);
            this.tpgBuy.Location = new System.Drawing.Point(174, 4);
            this.tpgBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgBuy.Name = "tpgBuy";
            this.tpgBuy.Padding = new System.Windows.Forms.Padding(5);
            this.tpgBuy.Size = new System.Drawing.Size(1101, 607);
            this.tpgBuy.TabIndex = 0;
            this.tpgBuy.Text = "Tạo hóa đơn nhập ";
            this.tpgBuy.Enter += new System.EventHandler(this.tpgBuy_Enter);
            // 
            // grbItemInfor_Buy
            // 
            this.grbItemInfor_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbItemInfor_Buy.Controls.Add(this.lvwItem_buy);
            this.grbItemInfor_Buy.Controls.Add(this.pnlBottom_buy);
            this.grbItemInfor_Buy.Controls.Add(this.pnlItem_buy);
            this.grbItemInfor_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbItemInfor_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbItemInfor_Buy.ForeColor = System.Drawing.Color.White;
            this.grbItemInfor_Buy.Location = new System.Drawing.Point(5, 203);
            this.grbItemInfor_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbItemInfor_Buy.Name = "grbItemInfor_Buy";
            this.grbItemInfor_Buy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbItemInfor_Buy.Size = new System.Drawing.Size(1091, 399);
            this.grbItemInfor_Buy.TabIndex = 2;
            this.grbItemInfor_Buy.TabStop = false;
            this.grbItemInfor_Buy.Text = "Thông tin các mặt hàng";
            // 
            // lvwItem_buy
            // 
            this.lvwItem_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwItem_buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwItem_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwItem_buy.ForeColor = System.Drawing.Color.White;
            this.lvwItem_buy.FullRowSelect = true;
            this.lvwItem_buy.GridLines = true;
            this.lvwItem_buy.HideSelection = false;
            this.lvwItem_buy.Location = new System.Drawing.Point(3, 148);
            this.lvwItem_buy.Name = "lvwItem_buy";
            this.lvwItem_buy.OwnerDraw = true;
            this.lvwItem_buy.Size = new System.Drawing.Size(1085, 200);
            this.lvwItem_buy.Sortable = true;
            this.lvwItem_buy.SortableColumns = null;
            this.lvwItem_buy.TabIndex = 19;
            this.lvwItem_buy.UseCompatibleStateImageBehavior = false;
            this.lvwItem_buy.View = System.Windows.Forms.View.Details;
            this.lvwItem_buy.SelectedIndexChanged += new System.EventHandler(this.lvwItem_buy_SelectedIndexChanged);
            // 
            // pnlBottom_buy
            // 
            this.pnlBottom_buy.Controls.Add(this.btnCancel_buy);
            this.pnlBottom_buy.Controls.Add(this.pnlTotalMoney);
            this.pnlBottom_buy.Controls.Add(this.btnCreateReceipt_Buy);
            this.pnlBottom_buy.Controls.Add(this.btnPrintReceipt_Buy);
            this.pnlBottom_buy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom_buy.Location = new System.Drawing.Point(3, 348);
            this.pnlBottom_buy.Name = "pnlBottom_buy";
            this.pnlBottom_buy.Size = new System.Drawing.Size(1085, 49);
            this.pnlBottom_buy.TabIndex = 18;
            // 
            // btnCancel_buy
            // 
            this.btnCancel_buy.BackColor = System.Drawing.Color.White;
            this.btnCancel_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancel_buy.Location = new System.Drawing.Point(393, 7);
            this.btnCancel_buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel_buy.Name = "btnCancel_buy";
            this.btnCancel_buy.Size = new System.Drawing.Size(172, 35);
            this.btnCancel_buy.TabIndex = 20;
            this.btnCancel_buy.Text = "Hủy hóa đơn";
            this.btnCancel_buy.UseVisualStyleBackColor = false;
            this.btnCancel_buy.Click += new System.EventHandler(this.btnCancel_buy_Click);
            // 
            // pnlTotalMoney
            // 
            this.pnlTotalMoney.Controls.Add(this.lblTotalMoney_Buy);
            this.pnlTotalMoney.Controls.Add(this.txtTotalMoney_Buy);
            this.pnlTotalMoney.Location = new System.Drawing.Point(686, 7);
            this.pnlTotalMoney.Name = "pnlTotalMoney";
            this.pnlTotalMoney.Size = new System.Drawing.Size(396, 35);
            this.pnlTotalMoney.TabIndex = 19;
            // 
            // lblTotalMoney_Buy
            // 
            this.lblTotalMoney_Buy.AutoSize = true;
            this.lblTotalMoney_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalMoney_Buy.Location = new System.Drawing.Point(16, 7);
            this.lblTotalMoney_Buy.Name = "lblTotalMoney_Buy";
            this.lblTotalMoney_Buy.Size = new System.Drawing.Size(83, 20);
            this.lblTotalMoney_Buy.TabIndex = 12;
            this.lblTotalMoney_Buy.Text = "Tổng tiền:";
            // 
            // txtTotalMoney_Buy
            // 
            this.txtTotalMoney_Buy.Location = new System.Drawing.Point(116, 4);
            this.txtTotalMoney_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMoney_Buy.Name = "txtTotalMoney_Buy";
            this.txtTotalMoney_Buy.ReadOnly = true;
            this.txtTotalMoney_Buy.Size = new System.Drawing.Size(255, 26);
            this.txtTotalMoney_Buy.TabIndex = 13;
            // 
            // btnCreateReceipt_Buy
            // 
            this.btnCreateReceipt_Buy.BackColor = System.Drawing.Color.White;
            this.btnCreateReceipt_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReceipt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateReceipt_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCreateReceipt_Buy.Location = new System.Drawing.Point(12, 7);
            this.btnCreateReceipt_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateReceipt_Buy.Name = "btnCreateReceipt_Buy";
            this.btnCreateReceipt_Buy.Size = new System.Drawing.Size(172, 35);
            this.btnCreateReceipt_Buy.TabIndex = 14;
            this.btnCreateReceipt_Buy.Text = "Tạo hóa đơn";
            this.btnCreateReceipt_Buy.UseVisualStyleBackColor = false;
            this.btnCreateReceipt_Buy.Click += new System.EventHandler(this.btnCreateReceipt_Buy_Click);
            // 
            // btnPrintReceipt_Buy
            // 
            this.btnPrintReceipt_Buy.BackColor = System.Drawing.Color.White;
            this.btnPrintReceipt_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintReceipt_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnPrintReceipt_Buy.Location = new System.Drawing.Point(203, 7);
            this.btnPrintReceipt_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt_Buy.Name = "btnPrintReceipt_Buy";
            this.btnPrintReceipt_Buy.Size = new System.Drawing.Size(172, 35);
            this.btnPrintReceipt_Buy.TabIndex = 17;
            this.btnPrintReceipt_Buy.Text = "In hóa đơn";
            this.btnPrintReceipt_Buy.UseVisualStyleBackColor = false;
            this.btnPrintReceipt_Buy.Click += new System.EventHandler(this.btnPrintReceipt_Buy_Click);
            // 
            // pnlItem_buy
            // 
            this.pnlItem_buy.Controls.Add(this.btnDeleteItem_buy);
            this.pnlItem_buy.Controls.Add(this.pnlSpecialization_buy);
            this.pnlItem_buy.Controls.Add(this.btnAddItem_buy);
            this.pnlItem_buy.Controls.Add(this.pnlItemName_buy);
            this.pnlItem_buy.Controls.Add(this.pnlNumerous_buy);
            this.pnlItem_buy.Controls.Add(this.pnlItemUnitPrice_buy);
            this.pnlItem_buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItem_buy.Location = new System.Drawing.Point(3, 21);
            this.pnlItem_buy.Name = "pnlItem_buy";
            this.pnlItem_buy.Size = new System.Drawing.Size(1085, 127);
            this.pnlItem_buy.TabIndex = 11;
            // 
            // btnDeleteItem_buy
            // 
            this.btnDeleteItem_buy.BackColor = System.Drawing.Color.White;
            this.btnDeleteItem_buy.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteItem_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnDeleteItem_buy.Location = new System.Drawing.Point(799, 74);
            this.btnDeleteItem_buy.Name = "btnDeleteItem_buy";
            this.btnDeleteItem_buy.Size = new System.Drawing.Size(81, 32);
            this.btnDeleteItem_buy.TabIndex = 24;
            this.btnDeleteItem_buy.Text = "Xóa";
            this.btnDeleteItem_buy.UseVisualStyleBackColor = false;
            this.btnDeleteItem_buy.Click += new System.EventHandler(this.btnDeleteItem_buy_Click);
            // 
            // pnlSpecialization_buy
            // 
            this.pnlSpecialization_buy.Controls.Add(this.txtSpecializtion_buy);
            this.pnlSpecialization_buy.Controls.Add(this.lblSpecialization_buy);
            this.pnlSpecialization_buy.Location = new System.Drawing.Point(601, 15);
            this.pnlSpecialization_buy.Name = "pnlSpecialization_buy";
            this.pnlSpecialization_buy.Size = new System.Drawing.Size(293, 49);
            this.pnlSpecialization_buy.TabIndex = 22;
            // 
            // txtSpecializtion_buy
            // 
            this.txtSpecializtion_buy.Location = new System.Drawing.Point(105, 10);
            this.txtSpecializtion_buy.Name = "txtSpecializtion_buy";
            this.txtSpecializtion_buy.ReadOnly = true;
            this.txtSpecializtion_buy.Size = new System.Drawing.Size(174, 26);
            this.txtSpecializtion_buy.TabIndex = 1;
            // 
            // lblSpecialization_buy
            // 
            this.lblSpecialization_buy.AutoSize = true;
            this.lblSpecialization_buy.Location = new System.Drawing.Point(12, 13);
            this.lblSpecialization_buy.Name = "lblSpecialization_buy";
            this.lblSpecialization_buy.Size = new System.Drawing.Size(80, 20);
            this.lblSpecialization_buy.TabIndex = 0;
            this.lblSpecialization_buy.Text = "Quy cách";
            // 
            // btnAddItem_buy
            // 
            this.btnAddItem_buy.BackColor = System.Drawing.Color.White;
            this.btnAddItem_buy.FlatAppearance.BorderSize = 0;
            this.btnAddItem_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddItem_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddItem_buy.Location = new System.Drawing.Point(706, 74);
            this.btnAddItem_buy.Name = "btnAddItem_buy";
            this.btnAddItem_buy.Size = new System.Drawing.Size(81, 32);
            this.btnAddItem_buy.TabIndex = 21;
            this.btnAddItem_buy.Text = "Thêm";
            this.btnAddItem_buy.UseVisualStyleBackColor = false;
            this.btnAddItem_buy.Click += new System.EventHandler(this.btnAddItem_buy_Click);
            // 
            // pnlItemName_buy
            // 
            this.pnlItemName_buy.Controls.Add(this.btnAddMaterial_buy);
            this.pnlItemName_buy.Controls.Add(this.cboItem_buy);
            this.pnlItemName_buy.Controls.Add(this.lblMaterialName_Buy);
            this.pnlItemName_buy.Location = new System.Drawing.Point(12, 13);
            this.pnlItemName_buy.Name = "pnlItemName_buy";
            this.pnlItemName_buy.Size = new System.Drawing.Size(583, 51);
            this.pnlItemName_buy.TabIndex = 18;
            // 
            // btnAddMaterial_buy
            // 
            this.btnAddMaterial_buy.BackColor = System.Drawing.Color.White;
            this.btnAddMaterial_buy.FlatAppearance.BorderSize = 0;
            this.btnAddMaterial_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterial_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddMaterial_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddMaterial_buy.Location = new System.Drawing.Point(541, 12);
            this.btnAddMaterial_buy.Name = "btnAddMaterial_buy";
            this.btnAddMaterial_buy.Size = new System.Drawing.Size(32, 28);
            this.btnAddMaterial_buy.TabIndex = 14;
            this.btnAddMaterial_buy.Text = "+";
            this.btnAddMaterial_buy.UseVisualStyleBackColor = false;
            this.btnAddMaterial_buy.Click += new System.EventHandler(this.btnAddMaterial_buy_Click);
            // 
            // cboItem_buy
            // 
            this.cboItem_buy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItem_buy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItem_buy.FormattingEnabled = true;
            this.cboItem_buy.Location = new System.Drawing.Point(116, 12);
            this.cboItem_buy.Name = "cboItem_buy";
            this.cboItem_buy.Size = new System.Drawing.Size(409, 28);
            this.cboItem_buy.TabIndex = 3;
            this.cboItem_buy.SelectedIndexChanged += new System.EventHandler(this.cboItem_buy_SelectedIndexChanged);
            // 
            // lblMaterialName_Buy
            // 
            this.lblMaterialName_Buy.AutoSize = true;
            this.lblMaterialName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialName_Buy.Location = new System.Drawing.Point(23, 15);
            this.lblMaterialName_Buy.Name = "lblMaterialName_Buy";
            this.lblMaterialName_Buy.Size = new System.Drawing.Size(83, 20);
            this.lblMaterialName_Buy.TabIndex = 2;
            this.lblMaterialName_Buy.Text = "Tên hàng:";
            // 
            // pnlNumerous_buy
            // 
            this.pnlNumerous_buy.Controls.Add(this.nmrMaterialAmount_Buy);
            this.pnlNumerous_buy.Controls.Add(this.lblMaterialAmount_Buy);
            this.pnlNumerous_buy.Location = new System.Drawing.Point(393, 66);
            this.pnlNumerous_buy.Name = "pnlNumerous_buy";
            this.pnlNumerous_buy.Size = new System.Drawing.Size(202, 45);
            this.pnlNumerous_buy.TabIndex = 19;
            // 
            // nmrMaterialAmount_Buy
            // 
            this.nmrMaterialAmount_Buy.Location = new System.Drawing.Point(88, 9);
            this.nmrMaterialAmount_Buy.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nmrMaterialAmount_Buy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMaterialAmount_Buy.Name = "nmrMaterialAmount_Buy";
            this.nmrMaterialAmount_Buy.Size = new System.Drawing.Size(104, 26);
            this.nmrMaterialAmount_Buy.TabIndex = 9;
            this.nmrMaterialAmount_Buy.ThousandsSeparator = true;
            this.nmrMaterialAmount_Buy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMaterialAmount_Buy.ValueChanged += new System.EventHandler(this.nmrMaterialAmount_Buy_ValueChanged);
            // 
            // lblMaterialAmount_Buy
            // 
            this.lblMaterialAmount_Buy.AutoSize = true;
            this.lblMaterialAmount_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialAmount_Buy.Location = new System.Drawing.Point(3, 11);
            this.lblMaterialAmount_Buy.Name = "lblMaterialAmount_Buy";
            this.lblMaterialAmount_Buy.Size = new System.Drawing.Size(79, 20);
            this.lblMaterialAmount_Buy.TabIndex = 1;
            this.lblMaterialAmount_Buy.Text = "Số lượng:";
            // 
            // pnlItemUnitPrice_buy
            // 
            this.pnlItemUnitPrice_buy.Controls.Add(this.nmrUnitPrice_buy);
            this.pnlItemUnitPrice_buy.Controls.Add(this.lblMaterialUnitPrice_Buy);
            this.pnlItemUnitPrice_buy.Location = new System.Drawing.Point(12, 66);
            this.pnlItemUnitPrice_buy.Name = "pnlItemUnitPrice_buy";
            this.pnlItemUnitPrice_buy.Size = new System.Drawing.Size(378, 45);
            this.pnlItemUnitPrice_buy.TabIndex = 20;
            // 
            // nmrUnitPrice_buy
            // 
            this.nmrUnitPrice_buy.DecimalPlaces = 4;
            this.nmrUnitPrice_buy.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrUnitPrice_buy.Location = new System.Drawing.Point(116, 9);
            this.nmrUnitPrice_buy.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nmrUnitPrice_buy.Name = "nmrUnitPrice_buy";
            this.nmrUnitPrice_buy.Size = new System.Drawing.Size(247, 26);
            this.nmrUnitPrice_buy.TabIndex = 10;
            this.nmrUnitPrice_buy.ThousandsSeparator = true;
            // 
            // lblMaterialUnitPrice_Buy
            // 
            this.lblMaterialUnitPrice_Buy.AutoSize = true;
            this.lblMaterialUnitPrice_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialUnitPrice_Buy.Location = new System.Drawing.Point(23, 11);
            this.lblMaterialUnitPrice_Buy.Name = "lblMaterialUnitPrice_Buy";
            this.lblMaterialUnitPrice_Buy.Size = new System.Drawing.Size(71, 20);
            this.lblMaterialUnitPrice_Buy.TabIndex = 3;
            this.lblMaterialUnitPrice_Buy.Text = "Đơn giá:";
            // 
            // grbGeneralInfor_Buy
            // 
            this.grbGeneralInfor_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbGeneralInfor_Buy.Controls.Add(this.cboWarehouse_buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblWarehouse_buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.cboSupplier_buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.btnAddSupplier_buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.txtAddress_buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblAddress_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblSupplierName_Buy);
            this.grbGeneralInfor_Buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbGeneralInfor_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbGeneralInfor_Buy.ForeColor = System.Drawing.Color.White;
            this.grbGeneralInfor_Buy.Location = new System.Drawing.Point(5, 43);
            this.grbGeneralInfor_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGeneralInfor_Buy.Name = "grbGeneralInfor_Buy";
            this.grbGeneralInfor_Buy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGeneralInfor_Buy.Size = new System.Drawing.Size(1091, 160);
            this.grbGeneralInfor_Buy.TabIndex = 1;
            this.grbGeneralInfor_Buy.TabStop = false;
            this.grbGeneralInfor_Buy.Text = "Thông tin chung";
            // 
            // cboWarehouse_buy
            // 
            this.cboWarehouse_buy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboWarehouse_buy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboWarehouse_buy.FormattingEnabled = true;
            this.cboWarehouse_buy.Location = new System.Drawing.Point(217, 109);
            this.cboWarehouse_buy.Name = "cboWarehouse_buy";
            this.cboWarehouse_buy.Size = new System.Drawing.Size(669, 28);
            this.cboWarehouse_buy.TabIndex = 4;
            // 
            // lblWarehouse_buy
            // 
            this.lblWarehouse_buy.AutoSize = true;
            this.lblWarehouse_buy.Location = new System.Drawing.Point(32, 112);
            this.lblWarehouse_buy.Name = "lblWarehouse_buy";
            this.lblWarehouse_buy.Size = new System.Drawing.Size(43, 20);
            this.lblWarehouse_buy.TabIndex = 0;
            this.lblWarehouse_buy.Text = "Kho:";
            // 
            // cboSupplier_buy
            // 
            this.cboSupplier_buy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSupplier_buy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSupplier_buy.FormattingEnabled = true;
            this.cboSupplier_buy.Location = new System.Drawing.Point(217, 32);
            this.cboSupplier_buy.Name = "cboSupplier_buy";
            this.cboSupplier_buy.Size = new System.Drawing.Size(669, 28);
            this.cboSupplier_buy.TabIndex = 13;
            this.cboSupplier_buy.SelectedIndexChanged += new System.EventHandler(this.cboSupplier_buy_SelectedIndexChanged);
            // 
            // btnAddSupplier_buy
            // 
            this.btnAddSupplier_buy.BackColor = System.Drawing.Color.White;
            this.btnAddSupplier_buy.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddSupplier_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddSupplier_buy.Location = new System.Drawing.Point(902, 32);
            this.btnAddSupplier_buy.Name = "btnAddSupplier_buy";
            this.btnAddSupplier_buy.Size = new System.Drawing.Size(32, 28);
            this.btnAddSupplier_buy.TabIndex = 12;
            this.btnAddSupplier_buy.Text = "+";
            this.btnAddSupplier_buy.UseVisualStyleBackColor = false;
            this.btnAddSupplier_buy.Click += new System.EventHandler(this.btnAddSupplier_buy_Click);
            // 
            // txtAddress_buy
            // 
            this.txtAddress_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_buy.Location = new System.Drawing.Point(217, 71);
            this.txtAddress_buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress_buy.Name = "txtAddress_buy";
            this.txtAddress_buy.ReadOnly = true;
            this.txtAddress_buy.Size = new System.Drawing.Size(669, 26);
            this.txtAddress_buy.TabIndex = 11;
            // 
            // lblAddress_Buy
            // 
            this.lblAddress_Buy.AutoSize = true;
            this.lblAddress_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_Buy.Location = new System.Drawing.Point(32, 74);
            this.lblAddress_Buy.Name = "lblAddress_Buy";
            this.lblAddress_Buy.Size = new System.Drawing.Size(66, 20);
            this.lblAddress_Buy.TabIndex = 6;
            this.lblAddress_Buy.Text = "Địa chỉ:";
            // 
            // lblSupplierName_Buy
            // 
            this.lblSupplierName_Buy.AutoSize = true;
            this.lblSupplierName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplierName_Buy.Location = new System.Drawing.Point(32, 35);
            this.lblSupplierName_Buy.Name = "lblSupplierName_Buy";
            this.lblSupplierName_Buy.Size = new System.Drawing.Size(147, 20);
            this.lblSupplierName_Buy.TabIndex = 5;
            this.lblSupplierName_Buy.Text = "Tên nhà cung cấp:";
            // 
            // pnlTitle_buy
            // 
            this.pnlTitle_buy.Controls.Add(this.lblTitle_buy);
            this.pnlTitle_buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle_buy.Location = new System.Drawing.Point(5, 5);
            this.pnlTitle_buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitle_buy.Name = "pnlTitle_buy";
            this.pnlTitle_buy.Size = new System.Drawing.Size(1091, 38);
            this.pnlTitle_buy.TabIndex = 0;
            // 
            // lblTitle_buy
            // 
            this.lblTitle_buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle_buy.ForeColor = System.Drawing.Color.White;
            this.lblTitle_buy.Location = new System.Drawing.Point(0, 0);
            this.lblTitle_buy.Name = "lblTitle_buy";
            this.lblTitle_buy.Size = new System.Drawing.Size(1091, 38);
            this.lblTitle_buy.TabIndex = 0;
            this.lblTitle_buy.Text = "HÓA ĐƠN NHẬP HÀNG";
            this.lblTitle_buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tclMain
            // 
            this.tclMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tclMain.Controls.Add(this.tpgBuy);
            this.tclMain.Controls.Add(this.tpgSell);
            this.tclMain.Controls.Add(this.tpgReceipt);
            this.tclMain.Controls.Add(this.tpgMaterial);
            this.tclMain.Controls.Add(this.tpgStatistic);
            this.tclMain.Controls.Add(this.tpgCustomer);
            this.tclMain.Controls.Add(this.tpgSupplier);
            this.tclMain.Controls.Add(this.tpgEmployee);
            this.tclMain.Controls.Add(this.tpgUserSetting);
            this.tclMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tclMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tclMain.ItemSize = new System.Drawing.Size(55, 170);
            this.tclMain.Location = new System.Drawing.Point(0, 0);
            this.tclMain.Margin = new System.Windows.Forms.Padding(0);
            this.tclMain.Multiline = true;
            this.tclMain.Name = "tclMain";
            this.tclMain.Padding = new System.Drawing.Point(0, 0);
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(1279, 615);
            this.tclMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tclMain.TabIndex = 0;
            // 
            // btnWareHouse_material
            // 
            this.btnWareHouse_material.BackColor = System.Drawing.Color.White;
            this.btnWareHouse_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWareHouse_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWareHouse_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnWareHouse_material.Location = new System.Drawing.Point(8, 141);
            this.btnWareHouse_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWareHouse_material.Name = "btnWareHouse_material";
            this.btnWareHouse_material.Size = new System.Drawing.Size(185, 63);
            this.btnWareHouse_material.TabIndex = 6;
            this.btnWareHouse_material.Text = "Quản lý kho";
            this.btnWareHouse_material.UseVisualStyleBackColor = false;
            this.btnWareHouse_material.Click += new System.EventHandler(this.btnWareHouse_material_Click);
            // 
            // fTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 672);
            this.Controls.Add(this.tclMain);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(699, 715);
            this.Name = "fTaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Vật Liệu Xây Dựng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTaskManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTaskManager_FormClosed);
            this.Load += new System.EventHandler(this.fTaskManager_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.cms_employee.ResumeLayout(false);
            this.cms_supplier.ResumeLayout(false);
            this.tpgUserSetting.ResumeLayout(false);
            this.flp_userSetting.ResumeLayout(false);
            this.tpgEmployee.ResumeLayout(false);
            this.spc_employee.Panel1.ResumeLayout(false);
            this.spc_employee.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_employee)).EndInit();
            this.spc_employee.ResumeLayout(false);
            this.flpFunction_employee.ResumeLayout(false);
            this.pnlSearch_employe.ResumeLayout(false);
            this.grbSearch_employee.ResumeLayout(false);
            this.grbSearch_employee.PerformLayout();
            this.pnlAccount_employee.ResumeLayout(false);
            this.pnlAccount_employee.PerformLayout();
            this.pnlPosition_employee.ResumeLayout(false);
            this.pnlPosition_employee.PerformLayout();
            this.pnlGender_employee.ResumeLayout(false);
            this.pnlGender_employee.PerformLayout();
            this.pnlPhone_employee.ResumeLayout(false);
            this.pnlPhone_employee.PerformLayout();
            this.pnlAddress_employee.ResumeLayout(false);
            this.pnlAddress_employee.PerformLayout();
            this.pnlName_employee.ResumeLayout(false);
            this.pnlName_employee.PerformLayout();
            this.tpgSupplier.ResumeLayout(false);
            this.spc_supplier.Panel1.ResumeLayout(false);
            this.spc_supplier.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_supplier)).EndInit();
            this.spc_supplier.ResumeLayout(false);
            this.flpFunction_supplier.ResumeLayout(false);
            this.grbSearch_supplier.ResumeLayout(false);
            this.pnlPhone_supplier.ResumeLayout(false);
            this.pnlPhone_supplier.PerformLayout();
            this.pnlAddress_supplier.ResumeLayout(false);
            this.pnlAddress_supplier.PerformLayout();
            this.pnlName_supplier.ResumeLayout(false);
            this.pnlName_supplier.PerformLayout();
            this.tpgCustomer.ResumeLayout(false);
            this.panel1_Customer.ResumeLayout(false);
            this.spc_customer.Panel1.ResumeLayout(false);
            this.spc_customer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_customer)).EndInit();
            this.spc_customer.ResumeLayout(false);
            this.flp_customer.ResumeLayout(false);
            this.grbSearch_Customer.ResumeLayout(false);
            this.pnlPhone_customer.ResumeLayout(false);
            this.pnlPhone_customer.PerformLayout();
            this.pnlAddress_customer.ResumeLayout(false);
            this.pnlAddress_customer.PerformLayout();
            this.pnlName_customer.ResumeLayout(false);
            this.pnlName_customer.PerformLayout();
            this.tpgMaterial.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpFunction_material.ResumeLayout(false);
            this.grbSearchMaterial_material.ResumeLayout(false);
            this.pnlSpecialization_material.ResumeLayout(false);
            this.pnlSpecialization_material.PerformLayout();
            this.pnllblExportUnitPrice_material.ResumeLayout(false);
            this.pnllblExportUnitPrice_material.PerformLayout();
            this.pnlImportUnitPrice_material.ResumeLayout(false);
            this.pnlImportUnitPrice_material.PerformLayout();
            this.pnlNameMaterial_material.ResumeLayout(false);
            this.pnlNameMaterial_material.PerformLayout();
            this.tpgReceipt.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flpFunction_receipt.ResumeLayout(false);
            this.grbSearch_receipt.ResumeLayout(false);
            this.pnlEmployeeReceipt_receipt.ResumeLayout(false);
            this.pnlEmployeeReceipt_receipt.PerformLayout();
            this.pnlReceiptType_receipt.ResumeLayout(false);
            this.pnlReceiptType_receipt.PerformLayout();
            this.pnlWareHouse_receipt.ResumeLayout(false);
            this.pnlWareHouse_receipt.PerformLayout();
            this.pnlPartner_receipt.ResumeLayout(false);
            this.pnlPartner_receipt.PerformLayout();
            this.pnlDate_receipt.ResumeLayout(false);
            this.pnlDate_receipt.PerformLayout();
            this.pnlID_receipt.ResumeLayout(false);
            this.pnlID_receipt.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbSearch_material.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlA.ResumeLayout(false);
            this.pnlA.PerformLayout();
            this.pnlName_material.ResumeLayout(false);
            this.pnlName_material.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.bmwGroupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpgSell.ResumeLayout(false);
            this.grbItemInfor_sell.ResumeLayout(false);
            this.pnlBottom_sell.ResumeLayout(false);
            this.pnlTotalMoney_sell.ResumeLayout(false);
            this.pnlTotalMoney_sell.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlItemName_sell.ResumeLayout(false);
            this.pnlItemName_sell.PerformLayout();
            this.pnlNumerous_sell.ResumeLayout(false);
            this.pnlNumerous_sell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumerouse_sell)).EndInit();
            this.pnlItemUnitPrice_sell.ResumeLayout(false);
            this.pnlItemUnitPrice_sell.PerformLayout();
            this.grbGeneralInfor_sell.ResumeLayout(false);
            this.grbGeneralInfor_sell.PerformLayout();
            this.pnlTitle_sell.ResumeLayout(false);
            this.tpgBuy.ResumeLayout(false);
            this.grbItemInfor_Buy.ResumeLayout(false);
            this.pnlBottom_buy.ResumeLayout(false);
            this.pnlTotalMoney.ResumeLayout(false);
            this.pnlTotalMoney.PerformLayout();
            this.pnlItem_buy.ResumeLayout(false);
            this.pnlSpecialization_buy.ResumeLayout(false);
            this.pnlSpecialization_buy.PerformLayout();
            this.pnlItemName_buy.ResumeLayout(false);
            this.pnlItemName_buy.PerformLayout();
            this.pnlNumerous_buy.ResumeLayout(false);
            this.pnlNumerous_buy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaterialAmount_Buy)).EndInit();
            this.pnlItemUnitPrice_buy.ResumeLayout(false);
            this.pnlItemUnitPrice_buy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice_buy)).EndInit();
            this.grbGeneralInfor_Buy.ResumeLayout(false);
            this.grbGeneralInfor_Buy.PerformLayout();
            this.pnlTitle_buy.ResumeLayout(false);
            this.tclMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ContextMenuStrip cms_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInformation_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateAccount_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAccount_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteEmployee_employee;
        private System.Windows.Forms.ContextMenuStrip cms_supplier;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInformation_supplier;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSupplier_supplier;
        private System.Windows.Forms.TabPage tpgUserSetting;
        private System.Windows.Forms.FlowLayoutPanel flp_userSetting;
        private BmwButton btnCreateAccount_userSetting;
        private BmwButton btnChangeInformation_userSetting;
        private BmwButton btnResetPassword_userSetting;
        private System.Windows.Forms.TabPage tpgEmployee;
        private System.Windows.Forms.SplitContainer spc_employee;
        private BmwListView lvwEmployee_employee;
        private System.Windows.Forms.FlowLayoutPanel flpFunction_employee;
        private BmwButton btnAdd_employee;
        private BmwButton btnEdit_employee;
        private BmwButton btnCreateAccount_employee;
        private BmwButton btnRemoveAccount_employee;
        private BmwButton btnRemoveEmployee_employee;
        private BmwButton btnRefresh_employee;
        private System.Windows.Forms.Panel pnlSearch_employe;
        private BmwGroupBox grbSearch_employee;
        private System.Windows.Forms.Panel pnlAccount_employee;
        private System.Windows.Forms.Label lblAccount_employee;
        private System.Windows.Forms.TextBox txtAccount_employee;
        private System.Windows.Forms.Panel pnlPosition_employee;
        private System.Windows.Forms.FlowLayoutPanel flpPosition_employee;
        private System.Windows.Forms.Label lblPosition_employee;
        private System.Windows.Forms.Panel pnlGender_employee;
        private System.Windows.Forms.RadioButton rdoFemale_employee;
        private System.Windows.Forms.RadioButton rdoMale_employee;
        private System.Windows.Forms.RadioButton rdoAll_employee;
        private System.Windows.Forms.Label lblGender_employee;
        private System.Windows.Forms.Panel pnlPhone_employee;
        private System.Windows.Forms.Label lblPhone_employee;
        private System.Windows.Forms.TextBox txtPhone_employee;
        private System.Windows.Forms.Panel pnlAddress_employee;
        private System.Windows.Forms.Label lblAddress_employee;
        private System.Windows.Forms.TextBox txtAddress_employee;
        private System.Windows.Forms.Panel pnlName_employee;
        private System.Windows.Forms.Label lblName_employee;
        private System.Windows.Forms.TextBox txtName_employee;
        private System.Windows.Forms.TabPage tpgSupplier;
        private System.Windows.Forms.SplitContainer spc_supplier;
        private BmwListView lvwSupplier_supplier;
        private System.Windows.Forms.FlowLayoutPanel flpFunction_supplier;
        private BmwButton btnAdd_supplier;
        private BmwButton btnEdit_supplier;
        private BmwButton btnDelete_supplier;
        private BmwButton btnExport_supplier;
        private BmwButton btnRefresh_supplier;
        private BmwGroupBox grbSearch_supplier;
        private System.Windows.Forms.Panel pnlPhone_supplier;
        private System.Windows.Forms.Label lblPhone_supplier;
        private System.Windows.Forms.TextBox txtPhone_supplier;
        private System.Windows.Forms.Panel pnlAddress_supplier;
        private System.Windows.Forms.Label lblAddress_supplier;
        private System.Windows.Forms.TextBox txtAddress_supplier;
        private System.Windows.Forms.Panel pnlName_supplier;
        private System.Windows.Forms.Label lblName_supplier;
        private System.Windows.Forms.TextBox txtName_supplier;
        private System.Windows.Forms.TabPage tpgCustomer;
        private System.Windows.Forms.Panel panel1_Customer;
        private System.Windows.Forms.SplitContainer spc_customer;
        private BmwListView lvwCustomer_customer;
        private System.Windows.Forms.FlowLayoutPanel flp_customer;
        private BmwButton btnAdd_Customer;
        private BmwButton btnEdit_Customer;
        private BmwButton btnDelete_Customer;
        private BmwButton btnExport_Customer;
        private BmwButton btnRefresh_Customer;
        private BmwGroupBox grbSearch_Customer;
        private System.Windows.Forms.Panel pnlPhone_customer;
        private System.Windows.Forms.Label lblPhone_customer;
        private System.Windows.Forms.TextBox txtPhone_customer;
        private System.Windows.Forms.Panel pnlAddress_customer;
        private System.Windows.Forms.Label lblAddress_customer;
        private System.Windows.Forms.TextBox txtAddress_customer;
        private System.Windows.Forms.Panel pnlName_customer;
        private System.Windows.Forms.Label lblName_customer;
        private System.Windows.Forms.TextBox txtName_customer;
        private System.Windows.Forms.TabPage tpgStatistic;
        private System.Windows.Forms.TabPage tpgMaterial;
        private System.Windows.Forms.TabPage tpgReceipt;
        private BmwListView bmwListView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BmwButton bmwButton1;
        private BmwButton bmwButton2;
        private BmwButton bmwButton3;
        private BmwButton bmwButton4;
        private BmwButton bmwButton5;
        private BmwGroupBox grbSearch_material;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel pnlName_material;
        private System.Windows.Forms.Label lblName_material;
        private System.Windows.Forms.TextBox txtName_material;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private BmwButton bmwButton6;
        private BmwButton bmwButton7;
        private BmwButton bmwButton8;
        private BmwButton bmwButton9;
        private BmwButton bmwButton10;
        private BmwGroupBox bmwGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tpgSell;
        private BmwGroupBox grbItemInfor_sell;
        private BmwListView lvwItem_sell;
        private System.Windows.Forms.Panel pnlBottom_sell;
        private System.Windows.Forms.Panel pnlTotalMoney_sell;
        private System.Windows.Forms.Label lblTotalMoney_sell;
        private System.Windows.Forms.TextBox txtTotalMoney_sell;
        private BmwButton btnCreateReceipt_sell;
        private BmwButton btnPrintReceipt_sell;
        private System.Windows.Forms.Panel panel4;
        private BmwButton btnAddItem;
        private System.Windows.Forms.Panel pnlItemName_sell;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblItemName_sell;
        private System.Windows.Forms.Panel pnlNumerous_sell;
        private BmwNumericUpDown nmrNumerouse_sell;
        private System.Windows.Forms.Label lblNumerous_sell;
        private System.Windows.Forms.Panel pnlItemUnitPrice_sell;
        private System.Windows.Forms.Label lblItemUnitPrice_sell;
        private System.Windows.Forms.TextBox txtItemUnitPrice_sell;
        private BmwGroupBox grbGeneralInfor_sell;
        private BmwButton btnAddCustomer_sell;
        private System.Windows.Forms.TextBox txtAddress_sell;
        private System.Windows.Forms.TextBox txtCustomerName_sell;
        private System.Windows.Forms.Label lblAddress_sell;
        private System.Windows.Forms.Label lblCustomerName_sell;
        private System.Windows.Forms.Panel pnlTitle_sell;
        private System.Windows.Forms.Label lblTitle_sell;
        private System.Windows.Forms.TabPage tpgBuy;
        private BmwGroupBox grbItemInfor_Buy;
        private BmwListView lvwItem_buy;
        private System.Windows.Forms.Panel pnlBottom_buy;
        private BmwButton btnCancel_buy;
        private System.Windows.Forms.Panel pnlTotalMoney;
        private System.Windows.Forms.Label lblTotalMoney_Buy;
        private System.Windows.Forms.TextBox txtTotalMoney_Buy;
        private BmwButton btnCreateReceipt_Buy;
        private BmwButton btnPrintReceipt_Buy;
        private System.Windows.Forms.Panel pnlItem_buy;
        private BmwButton btnDeleteItem_buy;
        private System.Windows.Forms.Panel pnlSpecialization_buy;
        private System.Windows.Forms.TextBox txtSpecializtion_buy;
        private System.Windows.Forms.Label lblSpecialization_buy;
        private BmwButton btnAddItem_buy;
        private System.Windows.Forms.Panel pnlItemName_buy;
        private BmwButton btnAddMaterial_buy;
        private Controls.ComboBox.BmwComboBox cboItem_buy;
        private System.Windows.Forms.Label lblMaterialName_Buy;
        private System.Windows.Forms.Panel pnlNumerous_buy;
        private BmwNumericUpDown nmrMaterialAmount_Buy;
        private System.Windows.Forms.Label lblMaterialAmount_Buy;
        private System.Windows.Forms.Panel pnlItemUnitPrice_buy;
        private BmwNumericUpDown nmrUnitPrice_buy;
        private System.Windows.Forms.Label lblMaterialUnitPrice_Buy;
        private BmwGroupBox grbGeneralInfor_Buy;
        private Controls.ComboBox.BmwComboBox cboSupplier_buy;
        private BmwButton btnAddSupplier_buy;
        private System.Windows.Forms.TextBox txtAddress_buy;
        private System.Windows.Forms.Label lblAddress_Buy;
        private System.Windows.Forms.Label lblSupplierName_Buy;
        private System.Windows.Forms.Panel pnlTitle_buy;
        private System.Windows.Forms.Label lblTitle_buy;
        private BmwTabControl tclMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BmwListView lvwReceipt_Receipt;
        private System.Windows.Forms.FlowLayoutPanel flpFunction_receipt;
        private BmwButton btnAdd_Receipt;
        private BmwButton btnEdit_Receipt;
        private BmwButton btnDelete_Receipt;
        private BmwButton btnExport_Receipt;
        private BmwButton btnRefresh_Receipt;
        private BmwGroupBox grbSearch_receipt;
        private System.Windows.Forms.Panel pnlPartner_receipt;
        private System.Windows.Forms.Label lblPartner_receipt;
        private System.Windows.Forms.TextBox txtPrice_Receipt;
        private System.Windows.Forms.Panel pnlDate_receipt;
        private System.Windows.Forms.Label lblDate_receipt;
        private System.Windows.Forms.Panel pnlID_receipt;
        private System.Windows.Forms.Label lblId_receipt;
        private System.Windows.Forms.TextBox txtId_receipt;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.ComboBox.BmwComboBox cboWarehouse_buy;
        private System.Windows.Forms.Label lblWarehouse_buy;
        private BmwListView lvwMaterial_material;
        private System.Windows.Forms.FlowLayoutPanel flpFunction_material;
        private BmwButton btnAdd_material;
        private BmwButton btnEdit_material;
        private BmwButton btnDelete_material;
        private BmwButton btnExport_material;
        private BmwButton btnRefersh_material;
        private BmwGroupBox grbSearchMaterial_material;
        private System.Windows.Forms.Panel pnllblExportUnitPrice_material;
        private System.Windows.Forms.Label lblExportUnitPrice_material;
        private System.Windows.Forms.TextBox txtlblExportUnitPrice_material;
        private System.Windows.Forms.Panel pnlImportUnitPrice_material;
        private System.Windows.Forms.Label lblImportUnitPrice_material;
        private System.Windows.Forms.TextBox txtImportUnitPrice_material;
        private System.Windows.Forms.Panel pnlNameMaterial_material;
        private System.Windows.Forms.Label lblNameMaterial_material;
        private System.Windows.Forms.TextBox txtNameMaterial_material;
        private System.Windows.Forms.Panel pnlSpecialization_material;
        private System.Windows.Forms.Label lblSpecialization_material;
        private System.Windows.Forms.TextBox txtSpecialization_material;
        private System.Windows.Forms.DateTimePicker dtpDateFrom_receipt;
        private System.Windows.Forms.DateTimePicker dtpDateTo_receipt;
        private System.Windows.Forms.Panel pnlWareHouse_receipt;
        private System.Windows.Forms.Label lblWareHouse_receipt;
        private Controls.ComboBox.BmwComboBox cbbWareHouse_receipt;
        private System.Windows.Forms.Panel pnlReceiptType_receipt;
        private System.Windows.Forms.Label lblReceiptType_receipt;
        private System.Windows.Forms.RadioButton rdbImport_receipt;
        private System.Windows.Forms.Panel pnlEmployeeReceipt_receipt;
        private System.Windows.Forms.TextBox txtEmployeeReceipt_receipt;
        private System.Windows.Forms.Label lblEmployeeReceipt_receipt;
        private System.Windows.Forms.RadioButton rdbExport_receipt;
        private BmwButton btnWareHouse_material;
    }
}