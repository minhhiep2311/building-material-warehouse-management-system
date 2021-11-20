using BTL_LTTQ_QLKhoVLXD.Controls.Button;
using BTL_LTTQ_QLKhoVLXD.Controls.GroupBox;
using BTL_LTTQ_QLKhoVLXD.Controls.ListView;
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
            this.tctlControl = new BTL_LTTQ_QLKhoVLXD.Controls.TabControl.BmwTabControl();
            this.tpgBuy = new System.Windows.Forms.TabPage();
            this.grbItemInfor_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lsvBuy_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.btnPrintReceipt_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnCancelReceipt_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnSaveReceipt_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnAddReceipt_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.txtTotalMoney_Buy = new System.Windows.Forms.TextBox();
            this.lblTotalMoney_Buy = new System.Windows.Forms.Label();
            this.txtMoney_Buy = new System.Windows.Forms.TextBox();
            this.txtMaterialUnitPrice_Buy = new System.Windows.Forms.TextBox();
            this.txtMaterialName_Buy = new System.Windows.Forms.TextBox();
            this.txtMaterialAmount_Buy = new System.Windows.Forms.TextBox();
            this.lstMaterialId_Buy = new System.Windows.Forms.ListBox();
            this.lblMoney_Buy = new System.Windows.Forms.Label();
            this.lblMaterialUnitPrice_Buy = new System.Windows.Forms.Label();
            this.lblMaterialName_Buy = new System.Windows.Forms.Label();
            this.lblMaterialAmount_Buy = new System.Windows.Forms.Label();
            this.lblMaterialId_Buy = new System.Windows.Forms.Label();
            this.grbGeneralInfor_Buy = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lstSupplierId_Buy = new System.Windows.Forms.ListBox();
            this.lstEmployeeId_Buy = new System.Windows.Forms.ListBox();
            this.dtpReceiptDate_Buy = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber_Buy = new System.Windows.Forms.TextBox();
            this.txtAddress_Buy = new System.Windows.Forms.TextBox();
            this.txtSupplierName_Buy = new System.Windows.Forms.TextBox();
            this.txtEmployeeName_Buy = new System.Windows.Forms.TextBox();
            this.txtReceiptId_Buy = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber_Buy = new System.Windows.Forms.Label();
            this.lblAddress_Buy = new System.Windows.Forms.Label();
            this.lblSupplierName_Buy = new System.Windows.Forms.Label();
            this.lblSupplierId_Buy = new System.Windows.Forms.Label();
            this.lblEmployeeName_Buy = new System.Windows.Forms.Label();
            this.lblEmployeeId_Buy = new System.Windows.Forms.Label();
            this.lblReceiptDate_Buy = new System.Windows.Forms.Label();
            this.lblReceiptId_Buy = new System.Windows.Forms.Label();
            this.panel1_Buy = new System.Windows.Forms.Panel();
            this.lblTitle_Buy = new System.Windows.Forms.Label();
            this.tpgSell = new System.Windows.Forms.TabPage();
            this.grbItemInfor_Sell = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lvwSell_sell = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.btnPrintReceipt_Sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnCancelReceipt_Sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnSaveReceipt_Sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnAddReceipt_Sell = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.txtTotalMoney_Sell = new System.Windows.Forms.TextBox();
            this.lblTotalMoney_Sell = new System.Windows.Forms.Label();
            this.txtMoney_Sell = new System.Windows.Forms.TextBox();
            this.txtMaterialUnitPrice_Sell = new System.Windows.Forms.TextBox();
            this.txtMaterialName_Sell = new System.Windows.Forms.TextBox();
            this.txtMaterialAmount_Sell = new System.Windows.Forms.TextBox();
            this.lstMaterialId_Sell = new System.Windows.Forms.ListBox();
            this.lblMoney_Sell = new System.Windows.Forms.Label();
            this.lblMaterialUnitPrice_Sell = new System.Windows.Forms.Label();
            this.lblMaterialName_Sell = new System.Windows.Forms.Label();
            this.lblMaterialAmount_Sell = new System.Windows.Forms.Label();
            this.lblMaterialId_Sell = new System.Windows.Forms.Label();
            this.grbGeneralInfor_Sell = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lstCustomerId_Sell = new System.Windows.Forms.ListBox();
            this.lstEmployeeId_Sell = new System.Windows.Forms.ListBox();
            this.dtpReceiptDate_Sell = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber_Sell = new System.Windows.Forms.TextBox();
            this.txtAddress_Sell = new System.Windows.Forms.TextBox();
            this.txtCustomerName_Sell = new System.Windows.Forms.TextBox();
            this.txtEmployeeName_Sell = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber_Sell = new System.Windows.Forms.Label();
            this.lblAddress_Sell = new System.Windows.Forms.Label();
            this.lblCustomerName_Sell = new System.Windows.Forms.Label();
            this.lblCustomerId_Sell = new System.Windows.Forms.Label();
            this.lblEmployeeName_Sell = new System.Windows.Forms.Label();
            this.lblEmployeeId_Sell = new System.Windows.Forms.Label();
            this.lblReceiptDate_Sell = new System.Windows.Forms.Label();
            this.lblReceiptId_Sell = new System.Windows.Forms.Label();
            this.panel1_sell = new System.Windows.Forms.Panel();
            this.lblTitle_Sell = new System.Windows.Forms.Label();
            this.tpgReceipt = new System.Windows.Forms.TabPage();
            this.panel1_Receipt = new System.Windows.Forms.Panel();
            this.lvwReceipt_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.panel2_Receipt = new System.Windows.Forms.Panel();
            this.btnDelete_receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnExport_receipt = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbInfor_Receipt = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpgMaterial = new System.Windows.Forms.TabPage();
            this.dgvMaterial_material = new System.Windows.Forms.DataGridView();
            this.tpgStatistic = new System.Windows.Forms.TabPage();
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
            this.tpgUserSetting = new System.Windows.Forms.TabPage();
            this.flp_userSetting = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateAccount_userSetting = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnChangeInformation_userSetting = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnResetPassword_userSetting = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.cms_employee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowInformation_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateAccount_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAccount_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteEmployee_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_supplier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowInformation_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSupplier_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.tctlControl.SuspendLayout();
            this.tpgBuy.SuspendLayout();
            this.grbItemInfor_Buy.SuspendLayout();
            this.grbGeneralInfor_Buy.SuspendLayout();
            this.panel1_Buy.SuspendLayout();
            this.tpgSell.SuspendLayout();
            this.grbItemInfor_Sell.SuspendLayout();
            this.grbGeneralInfor_Sell.SuspendLayout();
            this.panel1_sell.SuspendLayout();
            this.tpgReceipt.SuspendLayout();
            this.panel1_Receipt.SuspendLayout();
            this.panel2_Receipt.SuspendLayout();
            this.grbInfor_Receipt.SuspendLayout();
            this.tpgMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial_material)).BeginInit();
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
            this.tpgUserSetting.SuspendLayout();
            this.flp_userSetting.SuspendLayout();
            this.cms_employee.SuspendLayout();
            this.cms_supplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPosition);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 500);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 46);
            this.panel3.TabIndex = 3;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(317, 16);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(9, 16);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Người dùng:";
            // 
            // tctlControl
            // 
            this.tctlControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tctlControl.Controls.Add(this.tpgBuy);
            this.tctlControl.Controls.Add(this.tpgSell);
            this.tctlControl.Controls.Add(this.tpgReceipt);
            this.tctlControl.Controls.Add(this.tpgMaterial);
            this.tctlControl.Controls.Add(this.tpgStatistic);
            this.tctlControl.Controls.Add(this.tpgCustomer);
            this.tctlControl.Controls.Add(this.tpgSupplier);
            this.tctlControl.Controls.Add(this.tpgEmployee);
            this.tctlControl.Controls.Add(this.tpgUserSetting);
            this.tctlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tctlControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tctlControl.ItemSize = new System.Drawing.Size(55, 170);
            this.tctlControl.Location = new System.Drawing.Point(0, 0);
            this.tctlControl.Margin = new System.Windows.Forms.Padding(0);
            this.tctlControl.Multiline = true;
            this.tctlControl.Name = "tctlControl";
            this.tctlControl.Padding = new System.Drawing.Point(0, 0);
            this.tctlControl.SelectedIndex = 0;
            this.tctlControl.Size = new System.Drawing.Size(959, 500);
            this.tctlControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctlControl.TabIndex = 0;
            // 
            // tpgBuy
            // 
            this.tpgBuy.Controls.Add(this.grbItemInfor_Buy);
            this.tpgBuy.Controls.Add(this.grbGeneralInfor_Buy);
            this.tpgBuy.Controls.Add(this.panel1_Buy);
            this.tpgBuy.Location = new System.Drawing.Point(174, 4);
            this.tpgBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tpgBuy.Name = "tpgBuy";
            this.tpgBuy.Padding = new System.Windows.Forms.Padding(2);
            this.tpgBuy.Size = new System.Drawing.Size(781, 492);
            this.tpgBuy.TabIndex = 0;
            this.tpgBuy.Text = "Tạo Hóa Đơn Nhập ";
            this.tpgBuy.UseVisualStyleBackColor = true;
            // 
            // grbItemInfor_Buy
            // 
            this.grbItemInfor_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbItemInfor_Buy.Controls.Add(this.lsvBuy_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.btnPrintReceipt_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.btnCancelReceipt_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.btnSaveReceipt_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.btnAddReceipt_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.txtTotalMoney_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lblTotalMoney_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.txtMoney_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.txtMaterialUnitPrice_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.txtMaterialName_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.txtMaterialAmount_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lstMaterialId_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lblMoney_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lblMaterialUnitPrice_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lblMaterialName_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lblMaterialAmount_Buy);
            this.grbItemInfor_Buy.Controls.Add(this.lblMaterialId_Buy);
            this.grbItemInfor_Buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbItemInfor_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbItemInfor_Buy.ForeColor = System.Drawing.Color.White;
            this.grbItemInfor_Buy.Location = new System.Drawing.Point(2, 197);
            this.grbItemInfor_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.grbItemInfor_Buy.Name = "grbItemInfor_Buy";
            this.grbItemInfor_Buy.Padding = new System.Windows.Forms.Padding(2);
            this.grbItemInfor_Buy.Size = new System.Drawing.Size(777, 284);
            this.grbItemInfor_Buy.TabIndex = 2;
            this.grbItemInfor_Buy.TabStop = false;
            this.grbItemInfor_Buy.Text = "Thông tin các mặt hàng";
            // 
            // lsvBuy_Buy
            // 
            this.lsvBuy_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lsvBuy_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBuy_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsvBuy_Buy.ForeColor = System.Drawing.Color.White;
            this.lsvBuy_Buy.FullRowSelect = true;
            this.lsvBuy_Buy.GridLines = true;
            this.lsvBuy_Buy.HideSelection = false;
            this.lsvBuy_Buy.Location = new System.Drawing.Point(2, 18);
            this.lsvBuy_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBuy_Buy.Name = "lsvBuy_Buy";
            this.lsvBuy_Buy.OwnerDraw = true;
            this.lsvBuy_Buy.Size = new System.Drawing.Size(773, 264);
            this.lsvBuy_Buy.TabIndex = 18;
            this.lsvBuy_Buy.UseCompatibleStateImageBehavior = false;
            this.lsvBuy_Buy.View = System.Windows.Forms.View.Details;
            // 
            // btnPrintReceipt_Buy
            // 
            this.btnPrintReceipt_Buy.BackColor = System.Drawing.Color.White;
            this.btnPrintReceipt_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintReceipt_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnPrintReceipt_Buy.Location = new System.Drawing.Point(555, 256);
            this.btnPrintReceipt_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintReceipt_Buy.Name = "btnPrintReceipt_Buy";
            this.btnPrintReceipt_Buy.Size = new System.Drawing.Size(128, 23);
            this.btnPrintReceipt_Buy.TabIndex = 17;
            this.btnPrintReceipt_Buy.Text = "In hóa đơn";
            this.btnPrintReceipt_Buy.UseVisualStyleBackColor = false;
            // 
            // btnCancelReceipt_Buy
            // 
            this.btnCancelReceipt_Buy.BackColor = System.Drawing.Color.White;
            this.btnCancelReceipt_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReceipt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelReceipt_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancelReceipt_Buy.Location = new System.Drawing.Point(398, 256);
            this.btnCancelReceipt_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelReceipt_Buy.Name = "btnCancelReceipt_Buy";
            this.btnCancelReceipt_Buy.Size = new System.Drawing.Size(129, 23);
            this.btnCancelReceipt_Buy.TabIndex = 16;
            this.btnCancelReceipt_Buy.Text = "Hủy hóa đơn";
            this.btnCancelReceipt_Buy.UseVisualStyleBackColor = false;
            // 
            // btnSaveReceipt_Buy
            // 
            this.btnSaveReceipt_Buy.BackColor = System.Drawing.Color.White;
            this.btnSaveReceipt_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReceipt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveReceipt_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnSaveReceipt_Buy.Location = new System.Drawing.Point(236, 256);
            this.btnSaveReceipt_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveReceipt_Buy.Name = "btnSaveReceipt_Buy";
            this.btnSaveReceipt_Buy.Size = new System.Drawing.Size(129, 23);
            this.btnSaveReceipt_Buy.TabIndex = 15;
            this.btnSaveReceipt_Buy.Text = "Lưu";
            this.btnSaveReceipt_Buy.UseVisualStyleBackColor = false;
            // 
            // btnAddReceipt_Buy
            // 
            this.btnAddReceipt_Buy.BackColor = System.Drawing.Color.White;
            this.btnAddReceipt_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReceipt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddReceipt_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddReceipt_Buy.Location = new System.Drawing.Point(72, 256);
            this.btnAddReceipt_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddReceipt_Buy.Name = "btnAddReceipt_Buy";
            this.btnAddReceipt_Buy.Size = new System.Drawing.Size(129, 23);
            this.btnAddReceipt_Buy.TabIndex = 14;
            this.btnAddReceipt_Buy.Text = "Thêm hóa đơn";
            this.btnAddReceipt_Buy.UseVisualStyleBackColor = false;
            // 
            // txtTotalMoney_Buy
            // 
            this.txtTotalMoney_Buy.Location = new System.Drawing.Point(577, 218);
            this.txtTotalMoney_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalMoney_Buy.Name = "txtTotalMoney_Buy";
            this.txtTotalMoney_Buy.Size = new System.Drawing.Size(192, 23);
            this.txtTotalMoney_Buy.TabIndex = 13;
            // 
            // lblTotalMoney_Buy
            // 
            this.lblTotalMoney_Buy.AutoSize = true;
            this.lblTotalMoney_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalMoney_Buy.Location = new System.Drawing.Point(502, 223);
            this.lblTotalMoney_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMoney_Buy.Name = "lblTotalMoney_Buy";
            this.lblTotalMoney_Buy.Size = new System.Drawing.Size(72, 17);
            this.lblTotalMoney_Buy.TabIndex = 12;
            this.lblTotalMoney_Buy.Text = "Tổng tiền:";
            // 
            // txtMoney_Buy
            // 
            this.txtMoney_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMoney_Buy.Location = new System.Drawing.Point(638, 20);
            this.txtMoney_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoney_Buy.Name = "txtMoney_Buy";
            this.txtMoney_Buy.Size = new System.Drawing.Size(100, 23);
            this.txtMoney_Buy.TabIndex = 11;
            // 
            // txtMaterialUnitPrice_Buy
            // 
            this.txtMaterialUnitPrice_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaterialUnitPrice_Buy.Location = new System.Drawing.Point(375, 64);
            this.txtMaterialUnitPrice_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialUnitPrice_Buy.Name = "txtMaterialUnitPrice_Buy";
            this.txtMaterialUnitPrice_Buy.Size = new System.Drawing.Size(100, 23);
            this.txtMaterialUnitPrice_Buy.TabIndex = 10;
            // 
            // txtMaterialName_Buy
            // 
            this.txtMaterialName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaterialName_Buy.Location = new System.Drawing.Point(375, 23);
            this.txtMaterialName_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialName_Buy.Name = "txtMaterialName_Buy";
            this.txtMaterialName_Buy.Size = new System.Drawing.Size(100, 23);
            this.txtMaterialName_Buy.TabIndex = 9;
            // 
            // txtMaterialAmount_Buy
            // 
            this.txtMaterialAmount_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaterialAmount_Buy.Location = new System.Drawing.Point(114, 62);
            this.txtMaterialAmount_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialAmount_Buy.Name = "txtMaterialAmount_Buy";
            this.txtMaterialAmount_Buy.Size = new System.Drawing.Size(100, 23);
            this.txtMaterialAmount_Buy.TabIndex = 8;
            // 
            // lstMaterialId_Buy
            // 
            this.lstMaterialId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstMaterialId_Buy.FormattingEnabled = true;
            this.lstMaterialId_Buy.ItemHeight = 16;
            this.lstMaterialId_Buy.Location = new System.Drawing.Point(114, 29);
            this.lstMaterialId_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.lstMaterialId_Buy.Name = "lstMaterialId_Buy";
            this.lstMaterialId_Buy.Size = new System.Drawing.Size(100, 20);
            this.lstMaterialId_Buy.TabIndex = 7;
            // 
            // lblMoney_Buy
            // 
            this.lblMoney_Buy.AutoSize = true;
            this.lblMoney_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMoney_Buy.Location = new System.Drawing.Point(543, 25);
            this.lblMoney_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney_Buy.Name = "lblMoney_Buy";
            this.lblMoney_Buy.Size = new System.Drawing.Size(80, 17);
            this.lblMoney_Buy.TabIndex = 4;
            this.lblMoney_Buy.Text = "Thành tiền:";
            // 
            // lblMaterialUnitPrice_Buy
            // 
            this.lblMaterialUnitPrice_Buy.AutoSize = true;
            this.lblMaterialUnitPrice_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialUnitPrice_Buy.Location = new System.Drawing.Point(294, 62);
            this.lblMaterialUnitPrice_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialUnitPrice_Buy.Name = "lblMaterialUnitPrice_Buy";
            this.lblMaterialUnitPrice_Buy.Size = new System.Drawing.Size(61, 17);
            this.lblMaterialUnitPrice_Buy.TabIndex = 3;
            this.lblMaterialUnitPrice_Buy.Text = "Đơn giá:";
            // 
            // lblMaterialName_Buy
            // 
            this.lblMaterialName_Buy.AutoSize = true;
            this.lblMaterialName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialName_Buy.Location = new System.Drawing.Point(294, 29);
            this.lblMaterialName_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialName_Buy.Name = "lblMaterialName_Buy";
            this.lblMaterialName_Buy.Size = new System.Drawing.Size(73, 17);
            this.lblMaterialName_Buy.TabIndex = 2;
            this.lblMaterialName_Buy.Text = "Tên hàng:";
            // 
            // lblMaterialAmount_Buy
            // 
            this.lblMaterialAmount_Buy.AutoSize = true;
            this.lblMaterialAmount_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialAmount_Buy.Location = new System.Drawing.Point(39, 64);
            this.lblMaterialAmount_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialAmount_Buy.Name = "lblMaterialAmount_Buy";
            this.lblMaterialAmount_Buy.Size = new System.Drawing.Size(68, 17);
            this.lblMaterialAmount_Buy.TabIndex = 1;
            this.lblMaterialAmount_Buy.Text = "Số lượng:";
            // 
            // lblMaterialId_Buy
            // 
            this.lblMaterialId_Buy.AutoSize = true;
            this.lblMaterialId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialId_Buy.Location = new System.Drawing.Point(39, 32);
            this.lblMaterialId_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialId_Buy.Name = "lblMaterialId_Buy";
            this.lblMaterialId_Buy.Size = new System.Drawing.Size(67, 17);
            this.lblMaterialId_Buy.TabIndex = 0;
            this.lblMaterialId_Buy.Text = "Mã hàng:";
            // 
            // grbGeneralInfor_Buy
            // 
            this.grbGeneralInfor_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbGeneralInfor_Buy.Controls.Add(this.lstSupplierId_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lstEmployeeId_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.dtpReceiptDate_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.txtPhoneNumber_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.txtAddress_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.txtSupplierName_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.txtEmployeeName_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.txtReceiptId_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblPhoneNumber_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblAddress_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblSupplierName_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblSupplierId_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblEmployeeName_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblEmployeeId_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblReceiptDate_Buy);
            this.grbGeneralInfor_Buy.Controls.Add(this.lblReceiptId_Buy);
            this.grbGeneralInfor_Buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbGeneralInfor_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbGeneralInfor_Buy.ForeColor = System.Drawing.Color.White;
            this.grbGeneralInfor_Buy.Location = new System.Drawing.Point(2, 33);
            this.grbGeneralInfor_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.grbGeneralInfor_Buy.Name = "grbGeneralInfor_Buy";
            this.grbGeneralInfor_Buy.Padding = new System.Windows.Forms.Padding(2);
            this.grbGeneralInfor_Buy.Size = new System.Drawing.Size(777, 164);
            this.grbGeneralInfor_Buy.TabIndex = 1;
            this.grbGeneralInfor_Buy.TabStop = false;
            this.grbGeneralInfor_Buy.Text = "Thông tin chung";
            // 
            // lstSupplierId_Buy
            // 
            this.lstSupplierId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstSupplierId_Buy.FormattingEnabled = true;
            this.lstSupplierId_Buy.ItemHeight = 16;
            this.lstSupplierId_Buy.Location = new System.Drawing.Point(546, 24);
            this.lstSupplierId_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.lstSupplierId_Buy.Name = "lstSupplierId_Buy";
            this.lstSupplierId_Buy.Size = new System.Drawing.Size(213, 20);
            this.lstSupplierId_Buy.TabIndex = 15;
            // 
            // lstEmployeeId_Buy
            // 
            this.lstEmployeeId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstEmployeeId_Buy.FormattingEnabled = true;
            this.lstEmployeeId_Buy.ItemHeight = 16;
            this.lstEmployeeId_Buy.Location = new System.Drawing.Point(134, 93);
            this.lstEmployeeId_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmployeeId_Buy.Name = "lstEmployeeId_Buy";
            this.lstEmployeeId_Buy.Size = new System.Drawing.Size(213, 20);
            this.lstEmployeeId_Buy.TabIndex = 14;
            // 
            // dtpReceiptDate_Buy
            // 
            this.dtpReceiptDate_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpReceiptDate_Buy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate_Buy.Location = new System.Drawing.Point(135, 61);
            this.dtpReceiptDate_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReceiptDate_Buy.Name = "dtpReceiptDate_Buy";
            this.dtpReceiptDate_Buy.Size = new System.Drawing.Size(212, 23);
            this.dtpReceiptDate_Buy.TabIndex = 13;
            // 
            // txtPhoneNumber_Buy
            // 
            this.txtPhoneNumber_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhoneNumber_Buy.Location = new System.Drawing.Point(546, 132);
            this.txtPhoneNumber_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber_Buy.Name = "txtPhoneNumber_Buy";
            this.txtPhoneNumber_Buy.Size = new System.Drawing.Size(213, 23);
            this.txtPhoneNumber_Buy.TabIndex = 12;
            // 
            // txtAddress_Buy
            // 
            this.txtAddress_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_Buy.Location = new System.Drawing.Point(546, 92);
            this.txtAddress_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress_Buy.Name = "txtAddress_Buy";
            this.txtAddress_Buy.Size = new System.Drawing.Size(213, 23);
            this.txtAddress_Buy.TabIndex = 11;
            // 
            // txtSupplierName_Buy
            // 
            this.txtSupplierName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSupplierName_Buy.Location = new System.Drawing.Point(546, 56);
            this.txtSupplierName_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName_Buy.Name = "txtSupplierName_Buy";
            this.txtSupplierName_Buy.Size = new System.Drawing.Size(213, 23);
            this.txtSupplierName_Buy.TabIndex = 10;
            // 
            // txtEmployeeName_Buy
            // 
            this.txtEmployeeName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmployeeName_Buy.Location = new System.Drawing.Point(134, 123);
            this.txtEmployeeName_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeName_Buy.Name = "txtEmployeeName_Buy";
            this.txtEmployeeName_Buy.Size = new System.Drawing.Size(213, 23);
            this.txtEmployeeName_Buy.TabIndex = 9;
            // 
            // txtReceiptId_Buy
            // 
            this.txtReceiptId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReceiptId_Buy.Location = new System.Drawing.Point(135, 33);
            this.txtReceiptId_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiptId_Buy.Name = "txtReceiptId_Buy";
            this.txtReceiptId_Buy.Size = new System.Drawing.Size(213, 23);
            this.txtReceiptId_Buy.TabIndex = 8;
            // 
            // lblPhoneNumber_Buy
            // 
            this.lblPhoneNumber_Buy.AutoSize = true;
            this.lblPhoneNumber_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhoneNumber_Buy.Location = new System.Drawing.Point(407, 128);
            this.lblPhoneNumber_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber_Buy.Name = "lblPhoneNumber_Buy";
            this.lblPhoneNumber_Buy.Size = new System.Drawing.Size(76, 17);
            this.lblPhoneNumber_Buy.TabIndex = 7;
            this.lblPhoneNumber_Buy.Text = "Điện thoại:";
            // 
            // lblAddress_Buy
            // 
            this.lblAddress_Buy.AutoSize = true;
            this.lblAddress_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_Buy.Location = new System.Drawing.Point(407, 97);
            this.lblAddress_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress_Buy.Name = "lblAddress_Buy";
            this.lblAddress_Buy.Size = new System.Drawing.Size(55, 17);
            this.lblAddress_Buy.TabIndex = 6;
            this.lblAddress_Buy.Text = "Địa chỉ:";
            // 
            // lblSupplierName_Buy
            // 
            this.lblSupplierName_Buy.AutoSize = true;
            this.lblSupplierName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplierName_Buy.Location = new System.Drawing.Point(407, 61);
            this.lblSupplierName_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName_Buy.Name = "lblSupplierName_Buy";
            this.lblSupplierName_Buy.Size = new System.Drawing.Size(127, 17);
            this.lblSupplierName_Buy.TabIndex = 5;
            this.lblSupplierName_Buy.Text = "Tên nhà cung cấp:";
            // 
            // lblSupplierId_Buy
            // 
            this.lblSupplierId_Buy.AutoSize = true;
            this.lblSupplierId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplierId_Buy.Location = new System.Drawing.Point(407, 28);
            this.lblSupplierId_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierId_Buy.Name = "lblSupplierId_Buy";
            this.lblSupplierId_Buy.Size = new System.Drawing.Size(121, 17);
            this.lblSupplierId_Buy.TabIndex = 4;
            this.lblSupplierId_Buy.Text = "Mã nhà cung cấp:";
            // 
            // lblEmployeeName_Buy
            // 
            this.lblEmployeeName_Buy.AutoSize = true;
            this.lblEmployeeName_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmployeeName_Buy.Location = new System.Drawing.Point(22, 130);
            this.lblEmployeeName_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName_Buy.Name = "lblEmployeeName_Buy";
            this.lblEmployeeName_Buy.Size = new System.Drawing.Size(103, 17);
            this.lblEmployeeName_Buy.TabIndex = 3;
            this.lblEmployeeName_Buy.Text = "Tên nhân viên:";
            // 
            // lblEmployeeId_Buy
            // 
            this.lblEmployeeId_Buy.AutoSize = true;
            this.lblEmployeeId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmployeeId_Buy.Location = new System.Drawing.Point(22, 97);
            this.lblEmployeeId_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId_Buy.Name = "lblEmployeeId_Buy";
            this.lblEmployeeId_Buy.Size = new System.Drawing.Size(97, 17);
            this.lblEmployeeId_Buy.TabIndex = 2;
            this.lblEmployeeId_Buy.Text = "Mã nhân viên:";
            // 
            // lblReceiptDate_Buy
            // 
            this.lblReceiptDate_Buy.AutoSize = true;
            this.lblReceiptDate_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReceiptDate_Buy.Location = new System.Drawing.Point(22, 61);
            this.lblReceiptDate_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptDate_Buy.Name = "lblReceiptDate_Buy";
            this.lblReceiptDate_Buy.Size = new System.Drawing.Size(73, 17);
            this.lblReceiptDate_Buy.TabIndex = 1;
            this.lblReceiptDate_Buy.Text = "Ngày bán:";
            // 
            // lblReceiptId_Buy
            // 
            this.lblReceiptId_Buy.AutoSize = true;
            this.lblReceiptId_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReceiptId_Buy.Location = new System.Drawing.Point(22, 28);
            this.lblReceiptId_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptId_Buy.Name = "lblReceiptId_Buy";
            this.lblReceiptId_Buy.Size = new System.Drawing.Size(87, 17);
            this.lblReceiptId_Buy.TabIndex = 0;
            this.lblReceiptId_Buy.Text = "Mã hóa đơn:";
            // 
            // panel1_Buy
            // 
            this.panel1_Buy.Controls.Add(this.lblTitle_Buy);
            this.panel1_Buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_Buy.Location = new System.Drawing.Point(2, 2);
            this.panel1_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_Buy.Name = "panel1_Buy";
            this.panel1_Buy.Size = new System.Drawing.Size(777, 31);
            this.panel1_Buy.TabIndex = 0;
            // 
            // lblTitle_Buy
            // 
            this.lblTitle_Buy.AutoSize = true;
            this.lblTitle_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle_Buy.Location = new System.Drawing.Point(259, 2);
            this.lblTitle_Buy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_Buy.Name = "lblTitle_Buy";
            this.lblTitle_Buy.Size = new System.Drawing.Size(270, 26);
            this.lblTitle_Buy.TabIndex = 0;
            this.lblTitle_Buy.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // tpgSell
            // 
            this.tpgSell.Controls.Add(this.grbItemInfor_Sell);
            this.tpgSell.Controls.Add(this.grbGeneralInfor_Sell);
            this.tpgSell.Controls.Add(this.panel1_sell);
            this.tpgSell.Location = new System.Drawing.Point(174, 4);
            this.tpgSell.Margin = new System.Windows.Forms.Padding(2);
            this.tpgSell.Name = "tpgSell";
            this.tpgSell.Padding = new System.Windows.Forms.Padding(2);
            this.tpgSell.Size = new System.Drawing.Size(781, 492);
            this.tpgSell.TabIndex = 1;
            this.tpgSell.Text = "Tạo Hóa Đơn Bán";
            this.tpgSell.UseVisualStyleBackColor = true;
            // 
            // grbItemInfor_Sell
            // 
            this.grbItemInfor_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbItemInfor_Sell.Controls.Add(this.lvwSell_sell);
            this.grbItemInfor_Sell.Controls.Add(this.btnPrintReceipt_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.btnCancelReceipt_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.btnSaveReceipt_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.btnAddReceipt_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.txtTotalMoney_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lblTotalMoney_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.txtMoney_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.txtMaterialUnitPrice_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.txtMaterialName_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.txtMaterialAmount_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lstMaterialId_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lblMoney_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lblMaterialUnitPrice_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lblMaterialName_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lblMaterialAmount_Sell);
            this.grbItemInfor_Sell.Controls.Add(this.lblMaterialId_Sell);
            this.grbItemInfor_Sell.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbItemInfor_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbItemInfor_Sell.ForeColor = System.Drawing.Color.White;
            this.grbItemInfor_Sell.Location = new System.Drawing.Point(2, 197);
            this.grbItemInfor_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.grbItemInfor_Sell.Name = "grbItemInfor_Sell";
            this.grbItemInfor_Sell.Padding = new System.Windows.Forms.Padding(2);
            this.grbItemInfor_Sell.Size = new System.Drawing.Size(777, 284);
            this.grbItemInfor_Sell.TabIndex = 3;
            this.grbItemInfor_Sell.TabStop = false;
            this.grbItemInfor_Sell.Text = "Thông tin các mặt hàng";
            // 
            // lvwSell_sell
            // 
            this.lvwSell_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwSell_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSell_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwSell_sell.ForeColor = System.Drawing.Color.White;
            this.lvwSell_sell.FullRowSelect = true;
            this.lvwSell_sell.GridLines = true;
            this.lvwSell_sell.HideSelection = false;
            this.lvwSell_sell.Location = new System.Drawing.Point(2, 18);
            this.lvwSell_sell.Margin = new System.Windows.Forms.Padding(2);
            this.lvwSell_sell.Name = "lvwSell_sell";
            this.lvwSell_sell.OwnerDraw = true;
            this.lvwSell_sell.Size = new System.Drawing.Size(773, 264);
            this.lvwSell_sell.TabIndex = 18;
            this.lvwSell_sell.UseCompatibleStateImageBehavior = false;
            this.lvwSell_sell.View = System.Windows.Forms.View.Details;
            // 
            // btnPrintReceipt_Sell
            // 
            this.btnPrintReceipt_Sell.BackColor = System.Drawing.Color.White;
            this.btnPrintReceipt_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintReceipt_Sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnPrintReceipt_Sell.Location = new System.Drawing.Point(556, 256);
            this.btnPrintReceipt_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintReceipt_Sell.Name = "btnPrintReceipt_Sell";
            this.btnPrintReceipt_Sell.Size = new System.Drawing.Size(129, 23);
            this.btnPrintReceipt_Sell.TabIndex = 17;
            this.btnPrintReceipt_Sell.Text = "In hóa đơn";
            this.btnPrintReceipt_Sell.UseVisualStyleBackColor = false;
            // 
            // btnCancelReceipt_Sell
            // 
            this.btnCancelReceipt_Sell.BackColor = System.Drawing.Color.White;
            this.btnCancelReceipt_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReceipt_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelReceipt_Sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancelReceipt_Sell.Location = new System.Drawing.Point(398, 256);
            this.btnCancelReceipt_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelReceipt_Sell.Name = "btnCancelReceipt_Sell";
            this.btnCancelReceipt_Sell.Size = new System.Drawing.Size(129, 23);
            this.btnCancelReceipt_Sell.TabIndex = 16;
            this.btnCancelReceipt_Sell.Text = "Hủy hóa đơn";
            this.btnCancelReceipt_Sell.UseVisualStyleBackColor = false;
            // 
            // btnSaveReceipt_Sell
            // 
            this.btnSaveReceipt_Sell.BackColor = System.Drawing.Color.White;
            this.btnSaveReceipt_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReceipt_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveReceipt_Sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnSaveReceipt_Sell.Location = new System.Drawing.Point(236, 256);
            this.btnSaveReceipt_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveReceipt_Sell.Name = "btnSaveReceipt_Sell";
            this.btnSaveReceipt_Sell.Size = new System.Drawing.Size(129, 23);
            this.btnSaveReceipt_Sell.TabIndex = 15;
            this.btnSaveReceipt_Sell.Text = "Lưu";
            this.btnSaveReceipt_Sell.UseVisualStyleBackColor = false;
            // 
            // btnAddReceipt_Sell
            // 
            this.btnAddReceipt_Sell.BackColor = System.Drawing.Color.White;
            this.btnAddReceipt_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReceipt_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddReceipt_Sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddReceipt_Sell.Location = new System.Drawing.Point(72, 256);
            this.btnAddReceipt_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddReceipt_Sell.Name = "btnAddReceipt_Sell";
            this.btnAddReceipt_Sell.Size = new System.Drawing.Size(129, 23);
            this.btnAddReceipt_Sell.TabIndex = 14;
            this.btnAddReceipt_Sell.Text = "Thêm hóa đơn";
            this.btnAddReceipt_Sell.UseVisualStyleBackColor = false;
            // 
            // txtTotalMoney_Sell
            // 
            this.txtTotalMoney_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotalMoney_Sell.Location = new System.Drawing.Point(580, 218);
            this.txtTotalMoney_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalMoney_Sell.Name = "txtTotalMoney_Sell";
            this.txtTotalMoney_Sell.Size = new System.Drawing.Size(192, 23);
            this.txtTotalMoney_Sell.TabIndex = 13;
            // 
            // lblTotalMoney_Sell
            // 
            this.lblTotalMoney_Sell.AutoSize = true;
            this.lblTotalMoney_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalMoney_Sell.Location = new System.Drawing.Point(494, 223);
            this.lblTotalMoney_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMoney_Sell.Name = "lblTotalMoney_Sell";
            this.lblTotalMoney_Sell.Size = new System.Drawing.Size(72, 17);
            this.lblTotalMoney_Sell.TabIndex = 12;
            this.lblTotalMoney_Sell.Text = "Tổng tiền:";
            // 
            // txtMoney_Sell
            // 
            this.txtMoney_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMoney_Sell.Location = new System.Drawing.Point(634, 24);
            this.txtMoney_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoney_Sell.Name = "txtMoney_Sell";
            this.txtMoney_Sell.Size = new System.Drawing.Size(100, 23);
            this.txtMoney_Sell.TabIndex = 11;
            // 
            // txtMaterialUnitPrice_Sell
            // 
            this.txtMaterialUnitPrice_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaterialUnitPrice_Sell.Location = new System.Drawing.Point(389, 62);
            this.txtMaterialUnitPrice_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialUnitPrice_Sell.Name = "txtMaterialUnitPrice_Sell";
            this.txtMaterialUnitPrice_Sell.Size = new System.Drawing.Size(100, 23);
            this.txtMaterialUnitPrice_Sell.TabIndex = 10;
            // 
            // txtMaterialName_Sell
            // 
            this.txtMaterialName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaterialName_Sell.Location = new System.Drawing.Point(386, 27);
            this.txtMaterialName_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialName_Sell.Name = "txtMaterialName_Sell";
            this.txtMaterialName_Sell.Size = new System.Drawing.Size(100, 23);
            this.txtMaterialName_Sell.TabIndex = 9;
            // 
            // txtMaterialAmount_Sell
            // 
            this.txtMaterialAmount_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaterialAmount_Sell.Location = new System.Drawing.Point(114, 62);
            this.txtMaterialAmount_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialAmount_Sell.Name = "txtMaterialAmount_Sell";
            this.txtMaterialAmount_Sell.Size = new System.Drawing.Size(100, 23);
            this.txtMaterialAmount_Sell.TabIndex = 8;
            // 
            // lstMaterialId_Sell
            // 
            this.lstMaterialId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstMaterialId_Sell.FormattingEnabled = true;
            this.lstMaterialId_Sell.ItemHeight = 16;
            this.lstMaterialId_Sell.Location = new System.Drawing.Point(114, 29);
            this.lstMaterialId_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.lstMaterialId_Sell.Name = "lstMaterialId_Sell";
            this.lstMaterialId_Sell.Size = new System.Drawing.Size(100, 20);
            this.lstMaterialId_Sell.TabIndex = 7;
            // 
            // lblMoney_Sell
            // 
            this.lblMoney_Sell.AutoSize = true;
            this.lblMoney_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMoney_Sell.Location = new System.Drawing.Point(536, 29);
            this.lblMoney_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney_Sell.Name = "lblMoney_Sell";
            this.lblMoney_Sell.Size = new System.Drawing.Size(80, 17);
            this.lblMoney_Sell.TabIndex = 4;
            this.lblMoney_Sell.Text = "Thành tiền:";
            // 
            // lblMaterialUnitPrice_Sell
            // 
            this.lblMaterialUnitPrice_Sell.AutoSize = true;
            this.lblMaterialUnitPrice_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialUnitPrice_Sell.Location = new System.Drawing.Point(303, 64);
            this.lblMaterialUnitPrice_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialUnitPrice_Sell.Name = "lblMaterialUnitPrice_Sell";
            this.lblMaterialUnitPrice_Sell.Size = new System.Drawing.Size(61, 17);
            this.lblMaterialUnitPrice_Sell.TabIndex = 3;
            this.lblMaterialUnitPrice_Sell.Text = "Đơn giá:";
            // 
            // lblMaterialName_Sell
            // 
            this.lblMaterialName_Sell.AutoSize = true;
            this.lblMaterialName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialName_Sell.Location = new System.Drawing.Point(303, 32);
            this.lblMaterialName_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialName_Sell.Name = "lblMaterialName_Sell";
            this.lblMaterialName_Sell.Size = new System.Drawing.Size(73, 17);
            this.lblMaterialName_Sell.TabIndex = 2;
            this.lblMaterialName_Sell.Text = "Tên hàng:";
            // 
            // lblMaterialAmount_Sell
            // 
            this.lblMaterialAmount_Sell.AutoSize = true;
            this.lblMaterialAmount_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialAmount_Sell.Location = new System.Drawing.Point(39, 64);
            this.lblMaterialAmount_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialAmount_Sell.Name = "lblMaterialAmount_Sell";
            this.lblMaterialAmount_Sell.Size = new System.Drawing.Size(68, 17);
            this.lblMaterialAmount_Sell.TabIndex = 1;
            this.lblMaterialAmount_Sell.Text = "Số lượng:";
            // 
            // lblMaterialId_Sell
            // 
            this.lblMaterialId_Sell.AutoSize = true;
            this.lblMaterialId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaterialId_Sell.Location = new System.Drawing.Point(39, 32);
            this.lblMaterialId_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialId_Sell.Name = "lblMaterialId_Sell";
            this.lblMaterialId_Sell.Size = new System.Drawing.Size(67, 17);
            this.lblMaterialId_Sell.TabIndex = 0;
            this.lblMaterialId_Sell.Text = "Mã hàng:";
            // 
            // grbGeneralInfor_Sell
            // 
            this.grbGeneralInfor_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbGeneralInfor_Sell.Controls.Add(this.lstCustomerId_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lstEmployeeId_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.dtpReceiptDate_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.txtPhoneNumber_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.txtAddress_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.txtCustomerName_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.txtEmployeeName_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.textBox5);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblPhoneNumber_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblAddress_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblCustomerName_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblCustomerId_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblEmployeeName_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblEmployeeId_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblReceiptDate_Sell);
            this.grbGeneralInfor_Sell.Controls.Add(this.lblReceiptId_Sell);
            this.grbGeneralInfor_Sell.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbGeneralInfor_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbGeneralInfor_Sell.ForeColor = System.Drawing.Color.White;
            this.grbGeneralInfor_Sell.Location = new System.Drawing.Point(2, 33);
            this.grbGeneralInfor_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.grbGeneralInfor_Sell.Name = "grbGeneralInfor_Sell";
            this.grbGeneralInfor_Sell.Padding = new System.Windows.Forms.Padding(2);
            this.grbGeneralInfor_Sell.Size = new System.Drawing.Size(777, 164);
            this.grbGeneralInfor_Sell.TabIndex = 2;
            this.grbGeneralInfor_Sell.TabStop = false;
            this.grbGeneralInfor_Sell.Text = "Thông tin chung";
            // 
            // lstCustomerId_Sell
            // 
            this.lstCustomerId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstCustomerId_Sell.FormattingEnabled = true;
            this.lstCustomerId_Sell.ItemHeight = 16;
            this.lstCustomerId_Sell.Location = new System.Drawing.Point(549, 20);
            this.lstCustomerId_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.lstCustomerId_Sell.Name = "lstCustomerId_Sell";
            this.lstCustomerId_Sell.Size = new System.Drawing.Size(213, 20);
            this.lstCustomerId_Sell.TabIndex = 15;
            // 
            // lstEmployeeId_Sell
            // 
            this.lstEmployeeId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstEmployeeId_Sell.FormattingEnabled = true;
            this.lstEmployeeId_Sell.ItemHeight = 16;
            this.lstEmployeeId_Sell.Location = new System.Drawing.Point(152, 92);
            this.lstEmployeeId_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmployeeId_Sell.Name = "lstEmployeeId_Sell";
            this.lstEmployeeId_Sell.Size = new System.Drawing.Size(213, 20);
            this.lstEmployeeId_Sell.TabIndex = 14;
            // 
            // dtpReceiptDate_Sell
            // 
            this.dtpReceiptDate_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpReceiptDate_Sell.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate_Sell.Location = new System.Drawing.Point(152, 57);
            this.dtpReceiptDate_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReceiptDate_Sell.Name = "dtpReceiptDate_Sell";
            this.dtpReceiptDate_Sell.Size = new System.Drawing.Size(212, 23);
            this.dtpReceiptDate_Sell.TabIndex = 13;
            // 
            // txtPhoneNumber_Sell
            // 
            this.txtPhoneNumber_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhoneNumber_Sell.Location = new System.Drawing.Point(549, 128);
            this.txtPhoneNumber_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber_Sell.Name = "txtPhoneNumber_Sell";
            this.txtPhoneNumber_Sell.Size = new System.Drawing.Size(213, 23);
            this.txtPhoneNumber_Sell.TabIndex = 12;
            // 
            // txtAddress_Sell
            // 
            this.txtAddress_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_Sell.Location = new System.Drawing.Point(549, 92);
            this.txtAddress_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress_Sell.Name = "txtAddress_Sell";
            this.txtAddress_Sell.Size = new System.Drawing.Size(213, 23);
            this.txtAddress_Sell.TabIndex = 11;
            // 
            // txtCustomerName_Sell
            // 
            this.txtCustomerName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCustomerName_Sell.Location = new System.Drawing.Point(549, 56);
            this.txtCustomerName_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName_Sell.Name = "txtCustomerName_Sell";
            this.txtCustomerName_Sell.Size = new System.Drawing.Size(213, 23);
            this.txtCustomerName_Sell.TabIndex = 10;
            // 
            // txtEmployeeName_Sell
            // 
            this.txtEmployeeName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmployeeName_Sell.Location = new System.Drawing.Point(153, 123);
            this.txtEmployeeName_Sell.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeName_Sell.Name = "txtEmployeeName_Sell";
            this.txtEmployeeName_Sell.Size = new System.Drawing.Size(213, 23);
            this.txtEmployeeName_Sell.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(153, 28);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 23);
            this.textBox5.TabIndex = 8;
            // 
            // lblPhoneNumber_Sell
            // 
            this.lblPhoneNumber_Sell.AutoSize = true;
            this.lblPhoneNumber_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhoneNumber_Sell.Location = new System.Drawing.Point(418, 128);
            this.lblPhoneNumber_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber_Sell.Name = "lblPhoneNumber_Sell";
            this.lblPhoneNumber_Sell.Size = new System.Drawing.Size(76, 17);
            this.lblPhoneNumber_Sell.TabIndex = 7;
            this.lblPhoneNumber_Sell.Text = "Điện thoại:";
            // 
            // lblAddress_Sell
            // 
            this.lblAddress_Sell.AutoSize = true;
            this.lblAddress_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_Sell.Location = new System.Drawing.Point(418, 92);
            this.lblAddress_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress_Sell.Name = "lblAddress_Sell";
            this.lblAddress_Sell.Size = new System.Drawing.Size(55, 17);
            this.lblAddress_Sell.TabIndex = 6;
            this.lblAddress_Sell.Text = "Địa chỉ:";
            // 
            // lblCustomerName_Sell
            // 
            this.lblCustomerName_Sell.AutoSize = true;
            this.lblCustomerName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomerName_Sell.Location = new System.Drawing.Point(418, 56);
            this.lblCustomerName_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName_Sell.Name = "lblCustomerName_Sell";
            this.lblCustomerName_Sell.Size = new System.Drawing.Size(115, 17);
            this.lblCustomerName_Sell.TabIndex = 5;
            this.lblCustomerName_Sell.Text = "Tên khách hàng:";
            // 
            // lblCustomerId_Sell
            // 
            this.lblCustomerId_Sell.AutoSize = true;
            this.lblCustomerId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomerId_Sell.Location = new System.Drawing.Point(418, 28);
            this.lblCustomerId_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerId_Sell.Name = "lblCustomerId_Sell";
            this.lblCustomerId_Sell.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerId_Sell.TabIndex = 4;
            this.lblCustomerId_Sell.Text = "Mã khách hàng:";
            // 
            // lblEmployeeName_Sell
            // 
            this.lblEmployeeName_Sell.AutoSize = true;
            this.lblEmployeeName_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmployeeName_Sell.Location = new System.Drawing.Point(22, 128);
            this.lblEmployeeName_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName_Sell.Name = "lblEmployeeName_Sell";
            this.lblEmployeeName_Sell.Size = new System.Drawing.Size(103, 17);
            this.lblEmployeeName_Sell.TabIndex = 3;
            this.lblEmployeeName_Sell.Text = "Tên nhân viên:";
            // 
            // lblEmployeeId_Sell
            // 
            this.lblEmployeeId_Sell.AutoSize = true;
            this.lblEmployeeId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmployeeId_Sell.Location = new System.Drawing.Point(22, 94);
            this.lblEmployeeId_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId_Sell.Name = "lblEmployeeId_Sell";
            this.lblEmployeeId_Sell.Size = new System.Drawing.Size(97, 17);
            this.lblEmployeeId_Sell.TabIndex = 2;
            this.lblEmployeeId_Sell.Text = "Mã nhân viên:";
            // 
            // lblReceiptDate_Sell
            // 
            this.lblReceiptDate_Sell.AutoSize = true;
            this.lblReceiptDate_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReceiptDate_Sell.Location = new System.Drawing.Point(22, 57);
            this.lblReceiptDate_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptDate_Sell.Name = "lblReceiptDate_Sell";
            this.lblReceiptDate_Sell.Size = new System.Drawing.Size(73, 17);
            this.lblReceiptDate_Sell.TabIndex = 1;
            this.lblReceiptDate_Sell.Text = "Ngày bán:";
            // 
            // lblReceiptId_Sell
            // 
            this.lblReceiptId_Sell.AutoSize = true;
            this.lblReceiptId_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReceiptId_Sell.Location = new System.Drawing.Point(22, 28);
            this.lblReceiptId_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptId_Sell.Name = "lblReceiptId_Sell";
            this.lblReceiptId_Sell.Size = new System.Drawing.Size(87, 17);
            this.lblReceiptId_Sell.TabIndex = 0;
            this.lblReceiptId_Sell.Text = "Mã hóa đơn:";
            // 
            // panel1_sell
            // 
            this.panel1_sell.Controls.Add(this.lblTitle_Sell);
            this.panel1_sell.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_sell.Location = new System.Drawing.Point(2, 2);
            this.panel1_sell.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_sell.Name = "panel1_sell";
            this.panel1_sell.Size = new System.Drawing.Size(777, 31);
            this.panel1_sell.TabIndex = 1;
            // 
            // lblTitle_Sell
            // 
            this.lblTitle_Sell.AutoSize = true;
            this.lblTitle_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle_Sell.Location = new System.Drawing.Point(259, 2);
            this.lblTitle_Sell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_Sell.Name = "lblTitle_Sell";
            this.lblTitle_Sell.Size = new System.Drawing.Size(253, 26);
            this.lblTitle_Sell.TabIndex = 0;
            this.lblTitle_Sell.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // tpgReceipt
            // 
            this.tpgReceipt.Controls.Add(this.panel1_Receipt);
            this.tpgReceipt.Controls.Add(this.panel2_Receipt);
            this.tpgReceipt.Location = new System.Drawing.Point(174, 4);
            this.tpgReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.tpgReceipt.Name = "tpgReceipt";
            this.tpgReceipt.Size = new System.Drawing.Size(781, 492);
            this.tpgReceipt.TabIndex = 2;
            this.tpgReceipt.Text = "Quản Lý Hóa đơn";
            this.tpgReceipt.UseVisualStyleBackColor = true;
            // 
            // panel1_Receipt
            // 
            this.panel1_Receipt.Controls.Add(this.lvwReceipt_Receipt);
            this.panel1_Receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Receipt.Location = new System.Drawing.Point(0, 0);
            this.panel1_Receipt.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_Receipt.Name = "panel1_Receipt";
            this.panel1_Receipt.Size = new System.Drawing.Size(456, 492);
            this.panel1_Receipt.TabIndex = 4;
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
            this.lvwReceipt_Receipt.Margin = new System.Windows.Forms.Padding(2);
            this.lvwReceipt_Receipt.Name = "lvwReceipt_Receipt";
            this.lvwReceipt_Receipt.OwnerDraw = true;
            this.lvwReceipt_Receipt.Size = new System.Drawing.Size(456, 492);
            this.lvwReceipt_Receipt.TabIndex = 0;
            this.lvwReceipt_Receipt.UseCompatibleStateImageBehavior = false;
            this.lvwReceipt_Receipt.View = System.Windows.Forms.View.Details;
            // 
            // panel2_Receipt
            // 
            this.panel2_Receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.panel2_Receipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2_Receipt.Controls.Add(this.btnDelete_receipt);
            this.panel2_Receipt.Controls.Add(this.btnExport_receipt);
            this.panel2_Receipt.Controls.Add(this.grbInfor_Receipt);
            this.panel2_Receipt.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2_Receipt.ForeColor = System.Drawing.Color.White;
            this.panel2_Receipt.Location = new System.Drawing.Point(456, 0);
            this.panel2_Receipt.Margin = new System.Windows.Forms.Padding(2);
            this.panel2_Receipt.Name = "panel2_Receipt";
            this.panel2_Receipt.Size = new System.Drawing.Size(325, 492);
            this.panel2_Receipt.TabIndex = 3;
            // 
            // btnDelete_receipt
            // 
            this.btnDelete_receipt.BackColor = System.Drawing.Color.White;
            this.btnDelete_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete_receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnDelete_receipt.Location = new System.Drawing.Point(112, 242);
            this.btnDelete_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete_receipt.Name = "btnDelete_receipt";
            this.btnDelete_receipt.Size = new System.Drawing.Size(96, 29);
            this.btnDelete_receipt.TabIndex = 5;
            this.btnDelete_receipt.Text = "Xóa";
            this.btnDelete_receipt.UseVisualStyleBackColor = false;
            // 
            // btnExport_receipt
            // 
            this.btnExport_receipt.BackColor = System.Drawing.Color.White;
            this.btnExport_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport_receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport_receipt.Location = new System.Drawing.Point(212, 242);
            this.btnExport_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport_receipt.Name = "btnExport_receipt";
            this.btnExport_receipt.Size = new System.Drawing.Size(96, 29);
            this.btnExport_receipt.TabIndex = 6;
            this.btnExport_receipt.Text = "Xuất file";
            this.btnExport_receipt.UseVisualStyleBackColor = false;
            // 
            // grbInfor_Receipt
            // 
            this.grbInfor_Receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbInfor_Receipt.Controls.Add(this.dateTimePicker1);
            this.grbInfor_Receipt.Controls.Add(this.textBox1);
            this.grbInfor_Receipt.Controls.Add(this.textBox3);
            this.grbInfor_Receipt.Controls.Add(this.textBox4);
            this.grbInfor_Receipt.Controls.Add(this.label1);
            this.grbInfor_Receipt.Controls.Add(this.label2);
            this.grbInfor_Receipt.Controls.Add(this.label3);
            this.grbInfor_Receipt.Controls.Add(this.label4);
            this.grbInfor_Receipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfor_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbInfor_Receipt.ForeColor = System.Drawing.Color.White;
            this.grbInfor_Receipt.Location = new System.Drawing.Point(0, 0);
            this.grbInfor_Receipt.Margin = new System.Windows.Forms.Padding(2);
            this.grbInfor_Receipt.Name = "grbInfor_Receipt";
            this.grbInfor_Receipt.Padding = new System.Windows.Forms.Padding(2);
            this.grbInfor_Receipt.Size = new System.Drawing.Size(321, 208);
            this.grbInfor_Receipt.TabIndex = 0;
            this.grbInfor_Receipt.TabStop = false;
            this.grbInfor_Receipt.Text = "Thông tin hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(116, 149);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(116, 79);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(116, 36);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 23);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(4, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // tpgMaterial
            // 
            this.tpgMaterial.Controls.Add(this.dgvMaterial_material);
            this.tpgMaterial.Location = new System.Drawing.Point(174, 4);
            this.tpgMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tpgMaterial.Name = "tpgMaterial";
            this.tpgMaterial.Size = new System.Drawing.Size(781, 492);
            this.tpgMaterial.TabIndex = 3;
            this.tpgMaterial.Text = "Vật liệu";
            this.tpgMaterial.UseVisualStyleBackColor = true;
            this.tpgMaterial.Enter += new System.EventHandler(this.tpgMaterial_Enter);
            // 
            // dgvMaterial_material
            // 
            this.dgvMaterial_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial_material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial_material.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterial_material.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaterial_material.Name = "dgvMaterial_material";
            this.dgvMaterial_material.RowHeadersWidth = 51;
            this.dgvMaterial_material.RowTemplate.Height = 24;
            this.dgvMaterial_material.Size = new System.Drawing.Size(781, 492);
            this.dgvMaterial_material.TabIndex = 0;
            // 
            // tpgStatistic
            // 
            this.tpgStatistic.Location = new System.Drawing.Point(174, 4);
            this.tpgStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.tpgStatistic.Name = "tpgStatistic";
            this.tpgStatistic.Size = new System.Drawing.Size(781, 492);
            this.tpgStatistic.TabIndex = 4;
            this.tpgStatistic.Text = "Thống kê";
            this.tpgStatistic.UseVisualStyleBackColor = true;
            // 
            // tpgCustomer
            // 
            this.tpgCustomer.Controls.Add(this.panel1_Customer);
            this.tpgCustomer.Location = new System.Drawing.Point(174, 4);
            this.tpgCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tpgCustomer.Name = "tpgCustomer";
            this.tpgCustomer.Size = new System.Drawing.Size(781, 492);
            this.tpgCustomer.TabIndex = 5;
            this.tpgCustomer.Text = "Khách hàng";
            this.tpgCustomer.UseVisualStyleBackColor = true;
            // 
            // panel1_Customer
            // 
            this.panel1_Customer.Controls.Add(this.spc_customer);
            this.panel1_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Customer.Location = new System.Drawing.Point(0, 0);
            this.panel1_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_Customer.Name = "panel1_Customer";
            this.panel1_Customer.Size = new System.Drawing.Size(781, 492);
            this.panel1_Customer.TabIndex = 3;
            // 
            // spc_customer
            // 
            this.spc_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_customer.Location = new System.Drawing.Point(0, 0);
            this.spc_customer.Margin = new System.Windows.Forms.Padding(2);
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
            this.spc_customer.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.spc_customer.Panel2MinSize = 350;
            this.spc_customer.Size = new System.Drawing.Size(781, 492);
            this.spc_customer.SplitterDistance = 418;
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
            this.lvwCustomer_customer.Margin = new System.Windows.Forms.Padding(2);
            this.lvwCustomer_customer.Name = "lvwCustomer_customer";
            this.lvwCustomer_customer.OwnerDraw = true;
            this.lvwCustomer_customer.Size = new System.Drawing.Size(418, 492);
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
            this.flp_customer.Location = new System.Drawing.Point(4, 143);
            this.flp_customer.Margin = new System.Windows.Forms.Padding(2);
            this.flp_customer.Name = "flp_customer";
            this.flp_customer.Padding = new System.Windows.Forms.Padding(4);
            this.flp_customer.Size = new System.Drawing.Size(354, 345);
            this.flp_customer.TabIndex = 8;
            // 
            // btnAdd_Customer
            // 
            this.btnAdd_Customer.BackColor = System.Drawing.Color.White;
            this.btnAdd_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_Customer.Location = new System.Drawing.Point(6, 6);
            this.btnAdd_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_Customer.Name = "btnAdd_Customer";
            this.btnAdd_Customer.Size = new System.Drawing.Size(139, 51);
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
            this.btnEdit_Customer.Location = new System.Drawing.Point(149, 6);
            this.btnEdit_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit_Customer.Name = "btnEdit_Customer";
            this.btnEdit_Customer.Size = new System.Drawing.Size(139, 51);
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
            this.btnDelete_Customer.Location = new System.Drawing.Point(6, 61);
            this.btnDelete_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete_Customer.Name = "btnDelete_Customer";
            this.btnDelete_Customer.Size = new System.Drawing.Size(139, 51);
            this.btnDelete_Customer.TabIndex = 3;
            this.btnDelete_Customer.Text = "Xóa KH";
            this.btnDelete_Customer.UseVisualStyleBackColor = false;
            this.btnDelete_Customer.Click += new System.EventHandler(this.btnDelete_Customer_Click);
            // 
            // btnExport_Customer
            // 
            this.btnExport_Customer.BackColor = System.Drawing.Color.White;
            this.btnExport_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport_Customer.Location = new System.Drawing.Point(149, 61);
            this.btnExport_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport_Customer.Name = "btnExport_Customer";
            this.btnExport_Customer.Size = new System.Drawing.Size(139, 51);
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
            this.btnRefresh_Customer.Location = new System.Drawing.Point(6, 116);
            this.btnRefresh_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh_Customer.Name = "btnRefresh_Customer";
            this.btnRefresh_Customer.Size = new System.Drawing.Size(139, 51);
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
            this.grbSearch_Customer.Location = new System.Drawing.Point(4, 4);
            this.grbSearch_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.grbSearch_Customer.Name = "grbSearch_Customer";
            this.grbSearch_Customer.Padding = new System.Windows.Forms.Padding(2);
            this.grbSearch_Customer.Size = new System.Drawing.Size(354, 139);
            this.grbSearch_Customer.TabIndex = 0;
            this.grbSearch_Customer.TabStop = false;
            this.grbSearch_Customer.Text = "Tìm kiếm";
            // 
            // pnlPhone_customer
            // 
            this.pnlPhone_customer.Controls.Add(this.lblPhone_customer);
            this.pnlPhone_customer.Controls.Add(this.txtPhone_customer);
            this.pnlPhone_customer.Location = new System.Drawing.Point(4, 93);
            this.pnlPhone_customer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPhone_customer.Name = "pnlPhone_customer";
            this.pnlPhone_customer.Size = new System.Drawing.Size(346, 32);
            this.pnlPhone_customer.TabIndex = 7;
            // 
            // lblPhone_customer
            // 
            this.lblPhone_customer.AutoSize = true;
            this.lblPhone_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone_customer.Location = new System.Drawing.Point(2, 7);
            this.lblPhone_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone_customer.Name = "lblPhone_customer";
            this.lblPhone_customer.Size = new System.Drawing.Size(91, 17);
            this.lblPhone_customer.TabIndex = 0;
            this.lblPhone_customer.Text = "Số điện thoại";
            // 
            // txtPhone_customer
            // 
            this.txtPhone_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone_customer.Location = new System.Drawing.Point(117, 5);
            this.txtPhone_customer.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone_customer.Name = "txtPhone_customer";
            this.txtPhone_customer.Size = new System.Drawing.Size(222, 23);
            this.txtPhone_customer.TabIndex = 1;
            this.txtPhone_customer.TextChanged += new System.EventHandler(this.txtPhone_customer_TextChanged);
            // 
            // pnlAddress_customer
            // 
            this.pnlAddress_customer.Controls.Add(this.lblAddress_customer);
            this.pnlAddress_customer.Controls.Add(this.txtAddress_customer);
            this.pnlAddress_customer.Location = new System.Drawing.Point(4, 57);
            this.pnlAddress_customer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddress_customer.Name = "pnlAddress_customer";
            this.pnlAddress_customer.Size = new System.Drawing.Size(346, 32);
            this.pnlAddress_customer.TabIndex = 6;
            // 
            // lblAddress_customer
            // 
            this.lblAddress_customer.AutoSize = true;
            this.lblAddress_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_customer.Location = new System.Drawing.Point(2, 7);
            this.lblAddress_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress_customer.Name = "lblAddress_customer";
            this.lblAddress_customer.Size = new System.Drawing.Size(51, 17);
            this.lblAddress_customer.TabIndex = 0;
            this.lblAddress_customer.Text = "Địa chỉ";
            // 
            // txtAddress_customer
            // 
            this.txtAddress_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_customer.Location = new System.Drawing.Point(117, 5);
            this.txtAddress_customer.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress_customer.Name = "txtAddress_customer";
            this.txtAddress_customer.Size = new System.Drawing.Size(222, 23);
            this.txtAddress_customer.TabIndex = 1;
            this.txtAddress_customer.TextChanged += new System.EventHandler(this.txtAddress_customer_TextChanged);
            // 
            // pnlName_customer
            // 
            this.pnlName_customer.Controls.Add(this.lblName_customer);
            this.pnlName_customer.Controls.Add(this.txtName_customer);
            this.pnlName_customer.Location = new System.Drawing.Point(4, 20);
            this.pnlName_customer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlName_customer.Name = "pnlName_customer";
            this.pnlName_customer.Size = new System.Drawing.Size(346, 32);
            this.pnlName_customer.TabIndex = 5;
            // 
            // lblName_customer
            // 
            this.lblName_customer.AutoSize = true;
            this.lblName_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_customer.Location = new System.Drawing.Point(2, 7);
            this.lblName_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName_customer.Name = "lblName_customer";
            this.lblName_customer.Size = new System.Drawing.Size(111, 17);
            this.lblName_customer.TabIndex = 0;
            this.lblName_customer.Text = "Tên khách hàng";
            // 
            // txtName_customer
            // 
            this.txtName_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_customer.Location = new System.Drawing.Point(117, 5);
            this.txtName_customer.Margin = new System.Windows.Forms.Padding(2);
            this.txtName_customer.Name = "txtName_customer";
            this.txtName_customer.Size = new System.Drawing.Size(222, 23);
            this.txtName_customer.TabIndex = 1;
            this.txtName_customer.TextChanged += new System.EventHandler(this.txtName_customer_TextChanged);
            // 
            // tpgSupplier
            // 
            this.tpgSupplier.Controls.Add(this.spc_supplier);
            this.tpgSupplier.Location = new System.Drawing.Point(174, 4);
            this.tpgSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.tpgSupplier.Name = "tpgSupplier";
            this.tpgSupplier.Size = new System.Drawing.Size(781, 492);
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
            this.spc_supplier.Margin = new System.Windows.Forms.Padding(2);
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
            this.spc_supplier.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.spc_supplier.Panel2MinSize = 350;
            this.spc_supplier.Size = new System.Drawing.Size(781, 492);
            this.spc_supplier.SplitterDistance = 418;
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
            this.lvwSupplier_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.lvwSupplier_supplier.Name = "lvwSupplier_supplier";
            this.lvwSupplier_supplier.OwnerDraw = true;
            this.lvwSupplier_supplier.Size = new System.Drawing.Size(418, 492);
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
            this.flpFunction_supplier.Location = new System.Drawing.Point(5, 151);
            this.flpFunction_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.flpFunction_supplier.Name = "flpFunction_supplier";
            this.flpFunction_supplier.Padding = new System.Windows.Forms.Padding(4);
            this.flpFunction_supplier.Size = new System.Drawing.Size(352, 336);
            this.flpFunction_supplier.TabIndex = 6;
            // 
            // btnAdd_supplier
            // 
            this.btnAdd_supplier.BackColor = System.Drawing.Color.White;
            this.btnAdd_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_supplier.Location = new System.Drawing.Point(6, 6);
            this.btnAdd_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_supplier.Name = "btnAdd_supplier";
            this.btnAdd_supplier.Size = new System.Drawing.Size(139, 51);
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
            this.btnEdit_supplier.Location = new System.Drawing.Point(149, 6);
            this.btnEdit_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit_supplier.Name = "btnEdit_supplier";
            this.btnEdit_supplier.Size = new System.Drawing.Size(139, 51);
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
            this.btnDelete_supplier.Location = new System.Drawing.Point(6, 61);
            this.btnDelete_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete_supplier.Name = "btnDelete_supplier";
            this.btnDelete_supplier.Size = new System.Drawing.Size(139, 51);
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
            this.btnExport_supplier.Location = new System.Drawing.Point(149, 61);
            this.btnExport_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport_supplier.Name = "btnExport_supplier";
            this.btnExport_supplier.Size = new System.Drawing.Size(139, 51);
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
            this.btnRefresh_supplier.Location = new System.Drawing.Point(6, 116);
            this.btnRefresh_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh_supplier.Name = "btnRefresh_supplier";
            this.btnRefresh_supplier.Size = new System.Drawing.Size(139, 51);
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
            this.grbSearch_supplier.Location = new System.Drawing.Point(5, 5);
            this.grbSearch_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.grbSearch_supplier.Name = "grbSearch_supplier";
            this.grbSearch_supplier.Padding = new System.Windows.Forms.Padding(2);
            this.grbSearch_supplier.Size = new System.Drawing.Size(352, 146);
            this.grbSearch_supplier.TabIndex = 7;
            this.grbSearch_supplier.TabStop = false;
            this.grbSearch_supplier.Text = "Tìm kiếm";
            // 
            // pnlPhone_supplier
            // 
            this.pnlPhone_supplier.Controls.Add(this.lblPhone_supplier);
            this.pnlPhone_supplier.Controls.Add(this.txtPhone_supplier);
            this.pnlPhone_supplier.Location = new System.Drawing.Point(4, 93);
            this.pnlPhone_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPhone_supplier.Name = "pnlPhone_supplier";
            this.pnlPhone_supplier.Size = new System.Drawing.Size(344, 32);
            this.pnlPhone_supplier.TabIndex = 4;
            // 
            // lblPhone_supplier
            // 
            this.lblPhone_supplier.AutoSize = true;
            this.lblPhone_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone_supplier.Location = new System.Drawing.Point(2, 7);
            this.lblPhone_supplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone_supplier.Name = "lblPhone_supplier";
            this.lblPhone_supplier.Size = new System.Drawing.Size(91, 17);
            this.lblPhone_supplier.TabIndex = 0;
            this.lblPhone_supplier.Text = "Số điện thoại";
            // 
            // txtPhone_supplier
            // 
            this.txtPhone_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone_supplier.Location = new System.Drawing.Point(99, 5);
            this.txtPhone_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone_supplier.Name = "txtPhone_supplier";
            this.txtPhone_supplier.Size = new System.Drawing.Size(240, 23);
            this.txtPhone_supplier.TabIndex = 1;
            this.txtPhone_supplier.TextChanged += new System.EventHandler(this.txtPhone_supplier_TextChanged);
            // 
            // pnlAddress_supplier
            // 
            this.pnlAddress_supplier.Controls.Add(this.lblAddress_supplier);
            this.pnlAddress_supplier.Controls.Add(this.txtAddress_supplier);
            this.pnlAddress_supplier.Location = new System.Drawing.Point(4, 57);
            this.pnlAddress_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddress_supplier.Name = "pnlAddress_supplier";
            this.pnlAddress_supplier.Size = new System.Drawing.Size(344, 32);
            this.pnlAddress_supplier.TabIndex = 3;
            // 
            // lblAddress_supplier
            // 
            this.lblAddress_supplier.AutoSize = true;
            this.lblAddress_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_supplier.Location = new System.Drawing.Point(2, 7);
            this.lblAddress_supplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress_supplier.Name = "lblAddress_supplier";
            this.lblAddress_supplier.Size = new System.Drawing.Size(51, 17);
            this.lblAddress_supplier.TabIndex = 0;
            this.lblAddress_supplier.Text = "Địa chỉ";
            // 
            // txtAddress_supplier
            // 
            this.txtAddress_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_supplier.Location = new System.Drawing.Point(99, 5);
            this.txtAddress_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress_supplier.Name = "txtAddress_supplier";
            this.txtAddress_supplier.Size = new System.Drawing.Size(240, 23);
            this.txtAddress_supplier.TabIndex = 1;
            this.txtAddress_supplier.TextChanged += new System.EventHandler(this.txtAddress_supplier_TextChanged);
            // 
            // pnlName_supplier
            // 
            this.pnlName_supplier.Controls.Add(this.lblName_supplier);
            this.pnlName_supplier.Controls.Add(this.txtName_supplier);
            this.pnlName_supplier.Location = new System.Drawing.Point(4, 20);
            this.pnlName_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.pnlName_supplier.Name = "pnlName_supplier";
            this.pnlName_supplier.Size = new System.Drawing.Size(344, 32);
            this.pnlName_supplier.TabIndex = 2;
            // 
            // lblName_supplier
            // 
            this.lblName_supplier.AutoSize = true;
            this.lblName_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_supplier.Location = new System.Drawing.Point(2, 7);
            this.lblName_supplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName_supplier.Name = "lblName_supplier";
            this.lblName_supplier.Size = new System.Drawing.Size(65, 17);
            this.lblName_supplier.TabIndex = 0;
            this.lblName_supplier.Text = "Tên NCC";
            // 
            // txtName_supplier
            // 
            this.txtName_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_supplier.Location = new System.Drawing.Point(99, 5);
            this.txtName_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtName_supplier.Name = "txtName_supplier";
            this.txtName_supplier.Size = new System.Drawing.Size(240, 23);
            this.txtName_supplier.TabIndex = 1;
            this.txtName_supplier.TextChanged += new System.EventHandler(this.txtName_supplier_TextChanged);
            // 
            // tpgEmployee
            // 
            this.tpgEmployee.Controls.Add(this.spc_employee);
            this.tpgEmployee.Location = new System.Drawing.Point(174, 4);
            this.tpgEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Size = new System.Drawing.Size(781, 492);
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
            this.spc_employee.Margin = new System.Windows.Forms.Padding(2);
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
            this.spc_employee.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.spc_employee.Panel2MinSize = 350;
            this.spc_employee.Size = new System.Drawing.Size(781, 492);
            this.spc_employee.SplitterDistance = 418;
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
            this.lvwEmployee_employee.Margin = new System.Windows.Forms.Padding(2);
            this.lvwEmployee_employee.Name = "lvwEmployee_employee";
            this.lvwEmployee_employee.OwnerDraw = true;
            this.lvwEmployee_employee.Size = new System.Drawing.Size(418, 492);
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
            this.flpFunction_employee.Location = new System.Drawing.Point(5, 276);
            this.flpFunction_employee.Margin = new System.Windows.Forms.Padding(2);
            this.flpFunction_employee.Name = "flpFunction_employee";
            this.flpFunction_employee.Padding = new System.Windows.Forms.Padding(4);
            this.flpFunction_employee.Size = new System.Drawing.Size(352, 211);
            this.flpFunction_employee.TabIndex = 4;
            // 
            // btnAdd_employee
            // 
            this.btnAdd_employee.BackColor = System.Drawing.Color.White;
            this.btnAdd_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAdd_employee.Location = new System.Drawing.Point(6, 6);
            this.btnAdd_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_employee.Name = "btnAdd_employee";
            this.btnAdd_employee.Size = new System.Drawing.Size(139, 57);
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
            this.btnEdit_employee.Location = new System.Drawing.Point(149, 6);
            this.btnEdit_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit_employee.Name = "btnEdit_employee";
            this.btnEdit_employee.Size = new System.Drawing.Size(139, 57);
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
            this.btnCreateAccount_employee.Location = new System.Drawing.Point(6, 67);
            this.btnCreateAccount_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount_employee.Name = "btnCreateAccount_employee";
            this.btnCreateAccount_employee.Size = new System.Drawing.Size(139, 57);
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
            this.btnRemoveAccount_employee.Location = new System.Drawing.Point(149, 67);
            this.btnRemoveAccount_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAccount_employee.Name = "btnRemoveAccount_employee";
            this.btnRemoveAccount_employee.Size = new System.Drawing.Size(139, 57);
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
            this.btnRemoveEmployee_employee.Location = new System.Drawing.Point(6, 128);
            this.btnRemoveEmployee_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEmployee_employee.Name = "btnRemoveEmployee_employee";
            this.btnRemoveEmployee_employee.Size = new System.Drawing.Size(139, 57);
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
            this.btnRefresh_employee.Location = new System.Drawing.Point(149, 128);
            this.btnRefresh_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh_employee.Name = "btnRefresh_employee";
            this.btnRefresh_employee.Size = new System.Drawing.Size(139, 57);
            this.btnRefresh_employee.TabIndex = 5;
            this.btnRefresh_employee.Text = "Làm mới";
            this.btnRefresh_employee.UseVisualStyleBackColor = false;
            this.btnRefresh_employee.Click += new System.EventHandler(this.btnRefresh_employee_Click);
            // 
            // pnlSearch_employe
            // 
            this.pnlSearch_employe.Controls.Add(this.grbSearch_employee);
            this.pnlSearch_employe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch_employe.Location = new System.Drawing.Point(5, 5);
            this.pnlSearch_employe.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch_employe.Name = "pnlSearch_employe";
            this.pnlSearch_employe.Size = new System.Drawing.Size(352, 271);
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
            this.grbSearch_employee.Margin = new System.Windows.Forms.Padding(2);
            this.grbSearch_employee.Name = "grbSearch_employee";
            this.grbSearch_employee.Padding = new System.Windows.Forms.Padding(2);
            this.grbSearch_employee.Size = new System.Drawing.Size(352, 272);
            this.grbSearch_employee.TabIndex = 3;
            this.grbSearch_employee.TabStop = false;
            this.grbSearch_employee.Text = "Tìm kiếm";
            // 
            // pnlAccount_employee
            // 
            this.pnlAccount_employee.Controls.Add(this.lblAccount_employee);
            this.pnlAccount_employee.Controls.Add(this.txtAccount_employee);
            this.pnlAccount_employee.Location = new System.Drawing.Point(4, 57);
            this.pnlAccount_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAccount_employee.Name = "pnlAccount_employee";
            this.pnlAccount_employee.Size = new System.Drawing.Size(344, 32);
            this.pnlAccount_employee.TabIndex = 3;
            // 
            // lblAccount_employee
            // 
            this.lblAccount_employee.AutoSize = true;
            this.lblAccount_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAccount_employee.Location = new System.Drawing.Point(2, 7);
            this.lblAccount_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount_employee.Name = "lblAccount_employee";
            this.lblAccount_employee.Size = new System.Drawing.Size(71, 17);
            this.lblAccount_employee.TabIndex = 0;
            this.lblAccount_employee.Text = "Tài khoản";
            // 
            // txtAccount_employee
            // 
            this.txtAccount_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAccount_employee.Location = new System.Drawing.Point(99, 5);
            this.txtAccount_employee.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount_employee.Name = "txtAccount_employee";
            this.txtAccount_employee.Size = new System.Drawing.Size(240, 23);
            this.txtAccount_employee.TabIndex = 1;
            this.txtAccount_employee.TextChanged += new System.EventHandler(this.txtAccount_employee_TextChanged);
            // 
            // pnlPosition_employee
            // 
            this.pnlPosition_employee.AutoSize = true;
            this.pnlPosition_employee.Controls.Add(this.flpPosition_employee);
            this.pnlPosition_employee.Controls.Add(this.lblPosition_employee);
            this.pnlPosition_employee.Location = new System.Drawing.Point(6, 203);
            this.pnlPosition_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPosition_employee.Name = "pnlPosition_employee";
            this.pnlPosition_employee.Size = new System.Drawing.Size(342, 50);
            this.pnlPosition_employee.TabIndex = 6;
            // 
            // flpPosition_employee
            // 
            this.flpPosition_employee.Location = new System.Drawing.Point(99, 2);
            this.flpPosition_employee.Margin = new System.Windows.Forms.Padding(2);
            this.flpPosition_employee.Name = "flpPosition_employee";
            this.flpPosition_employee.Size = new System.Drawing.Size(238, 33);
            this.flpPosition_employee.TabIndex = 0;
            // 
            // lblPosition_employee
            // 
            this.lblPosition_employee.AutoSize = true;
            this.lblPosition_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPosition_employee.Location = new System.Drawing.Point(2, 8);
            this.lblPosition_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition_employee.Name = "lblPosition_employee";
            this.lblPosition_employee.Size = new System.Drawing.Size(59, 17);
            this.lblPosition_employee.TabIndex = 1;
            this.lblPosition_employee.Text = "Chức vụ";
            // 
            // pnlGender_employee
            // 
            this.pnlGender_employee.Controls.Add(this.rdoFemale_employee);
            this.pnlGender_employee.Controls.Add(this.rdoMale_employee);
            this.pnlGender_employee.Controls.Add(this.rdoAll_employee);
            this.pnlGender_employee.Controls.Add(this.lblGender_employee);
            this.pnlGender_employee.Location = new System.Drawing.Point(6, 167);
            this.pnlGender_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGender_employee.Name = "pnlGender_employee";
            this.pnlGender_employee.Size = new System.Drawing.Size(342, 32);
            this.pnlGender_employee.TabIndex = 5;
            // 
            // rdoFemale_employee
            // 
            this.rdoFemale_employee.AutoSize = true;
            this.rdoFemale_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoFemale_employee.Location = new System.Drawing.Point(252, 6);
            this.rdoFemale_employee.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFemale_employee.Name = "rdoFemale_employee";
            this.rdoFemale_employee.Size = new System.Drawing.Size(44, 21);
            this.rdoFemale_employee.TabIndex = 3;
            this.rdoFemale_employee.Text = "Nữ";
            this.rdoFemale_employee.UseVisualStyleBackColor = true;
            this.rdoFemale_employee.CheckedChanged += new System.EventHandler(this.rdoFemale_employee_CheckedChanged);
            // 
            // rdoMale_employee
            // 
            this.rdoMale_employee.AutoSize = true;
            this.rdoMale_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoMale_employee.Location = new System.Drawing.Point(178, 6);
            this.rdoMale_employee.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMale_employee.Name = "rdoMale_employee";
            this.rdoMale_employee.Size = new System.Drawing.Size(55, 21);
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
            this.rdoAll_employee.Location = new System.Drawing.Point(100, 6);
            this.rdoAll_employee.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAll_employee.Name = "rdoAll_employee";
            this.rdoAll_employee.Size = new System.Drawing.Size(66, 21);
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
            this.lblGender_employee.Location = new System.Drawing.Point(2, 7);
            this.lblGender_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender_employee.Name = "lblGender_employee";
            this.lblGender_employee.Size = new System.Drawing.Size(60, 17);
            this.lblGender_employee.TabIndex = 0;
            this.lblGender_employee.Text = "Giới tính";
            // 
            // pnlPhone_employee
            // 
            this.pnlPhone_employee.Controls.Add(this.lblPhone_employee);
            this.pnlPhone_employee.Controls.Add(this.txtPhone_employee);
            this.pnlPhone_employee.Location = new System.Drawing.Point(4, 130);
            this.pnlPhone_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPhone_employee.Name = "pnlPhone_employee";
            this.pnlPhone_employee.Size = new System.Drawing.Size(344, 32);
            this.pnlPhone_employee.TabIndex = 4;
            // 
            // lblPhone_employee
            // 
            this.lblPhone_employee.AutoSize = true;
            this.lblPhone_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone_employee.Location = new System.Drawing.Point(2, 7);
            this.lblPhone_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone_employee.Name = "lblPhone_employee";
            this.lblPhone_employee.Size = new System.Drawing.Size(91, 17);
            this.lblPhone_employee.TabIndex = 0;
            this.lblPhone_employee.Text = "Số điện thoại";
            // 
            // txtPhone_employee
            // 
            this.txtPhone_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone_employee.Location = new System.Drawing.Point(99, 5);
            this.txtPhone_employee.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone_employee.Name = "txtPhone_employee";
            this.txtPhone_employee.Size = new System.Drawing.Size(240, 23);
            this.txtPhone_employee.TabIndex = 1;
            this.txtPhone_employee.TextChanged += new System.EventHandler(this.txtPhone_employee_TextChanged);
            // 
            // pnlAddress_employee
            // 
            this.pnlAddress_employee.Controls.Add(this.lblAddress_employee);
            this.pnlAddress_employee.Controls.Add(this.txtAddress_employee);
            this.pnlAddress_employee.Location = new System.Drawing.Point(4, 93);
            this.pnlAddress_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddress_employee.Name = "pnlAddress_employee";
            this.pnlAddress_employee.Size = new System.Drawing.Size(344, 32);
            this.pnlAddress_employee.TabIndex = 3;
            // 
            // lblAddress_employee
            // 
            this.lblAddress_employee.AutoSize = true;
            this.lblAddress_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress_employee.Location = new System.Drawing.Point(2, 7);
            this.lblAddress_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress_employee.Name = "lblAddress_employee";
            this.lblAddress_employee.Size = new System.Drawing.Size(51, 17);
            this.lblAddress_employee.TabIndex = 0;
            this.lblAddress_employee.Text = "Địa chỉ";
            // 
            // txtAddress_employee
            // 
            this.txtAddress_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress_employee.Location = new System.Drawing.Point(99, 5);
            this.txtAddress_employee.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress_employee.Name = "txtAddress_employee";
            this.txtAddress_employee.Size = new System.Drawing.Size(240, 23);
            this.txtAddress_employee.TabIndex = 1;
            this.txtAddress_employee.TextChanged += new System.EventHandler(this.txtAddress_employee_TextChanged);
            // 
            // pnlName_employee
            // 
            this.pnlName_employee.Controls.Add(this.lblName_employee);
            this.pnlName_employee.Controls.Add(this.txtName_employee);
            this.pnlName_employee.Location = new System.Drawing.Point(4, 20);
            this.pnlName_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlName_employee.Name = "pnlName_employee";
            this.pnlName_employee.Size = new System.Drawing.Size(344, 32);
            this.pnlName_employee.TabIndex = 2;
            // 
            // lblName_employee
            // 
            this.lblName_employee.AutoSize = true;
            this.lblName_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName_employee.Location = new System.Drawing.Point(2, 7);
            this.lblName_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName_employee.Name = "lblName_employee";
            this.lblName_employee.Size = new System.Drawing.Size(50, 17);
            this.lblName_employee.TabIndex = 0;
            this.lblName_employee.Text = "Họ tên";
            // 
            // txtName_employee
            // 
            this.txtName_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName_employee.Location = new System.Drawing.Point(99, 5);
            this.txtName_employee.Margin = new System.Windows.Forms.Padding(2);
            this.txtName_employee.Name = "txtName_employee";
            this.txtName_employee.Size = new System.Drawing.Size(240, 23);
            this.txtName_employee.TabIndex = 1;
            this.txtName_employee.TextChanged += new System.EventHandler(this.txtName_employee_TextChanged);
            // 
            // tpgUserSetting
            // 
            this.tpgUserSetting.Controls.Add(this.flp_userSetting);
            this.tpgUserSetting.Location = new System.Drawing.Point(174, 4);
            this.tpgUserSetting.Margin = new System.Windows.Forms.Padding(2);
            this.tpgUserSetting.Name = "tpgUserSetting";
            this.tpgUserSetting.Size = new System.Drawing.Size(781, 492);
            this.tpgUserSetting.TabIndex = 8;
            this.tpgUserSetting.Text = "Quản lý người dùng";
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
            this.flp_userSetting.Margin = new System.Windows.Forms.Padding(2);
            this.flp_userSetting.Name = "flp_userSetting";
            this.flp_userSetting.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.flp_userSetting.Size = new System.Drawing.Size(781, 492);
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
            this.btnCreateAccount_userSetting.Location = new System.Drawing.Point(30, 32);
            this.btnCreateAccount_userSetting.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.btnCreateAccount_userSetting.Name = "btnCreateAccount_userSetting";
            this.btnCreateAccount_userSetting.Size = new System.Drawing.Size(154, 74);
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
            this.btnChangeInformation_userSetting.Location = new System.Drawing.Point(214, 32);
            this.btnChangeInformation_userSetting.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.btnChangeInformation_userSetting.Name = "btnChangeInformation_userSetting";
            this.btnChangeInformation_userSetting.Size = new System.Drawing.Size(154, 74);
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
            this.btnResetPassword_userSetting.Location = new System.Drawing.Point(398, 32);
            this.btnResetPassword_userSetting.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.btnResetPassword_userSetting.Name = "btnResetPassword_userSetting";
            this.btnResetPassword_userSetting.Size = new System.Drawing.Size(154, 74);
            this.btnResetPassword_userSetting.TabIndex = 2;
            this.btnResetPassword_userSetting.Text = "Đặt lại mật khẩu";
            this.btnResetPassword_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPassword_userSetting.UseVisualStyleBackColor = false;
            this.btnResetPassword_userSetting.Click += new System.EventHandler(this.btnResetPassword_userSetting_Click);
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
            this.cms_employee.Size = new System.Drawing.Size(151, 92);
            // 
            // tsmiShowInformation_employee
            // 
            this.tsmiShowInformation_employee.Name = "tsmiShowInformation_employee";
            this.tsmiShowInformation_employee.Size = new System.Drawing.Size(150, 22);
            this.tsmiShowInformation_employee.Text = "Xem thông tin";
            this.tsmiShowInformation_employee.Click += new System.EventHandler(this.tsmiShowInformation_employee_Click);
            // 
            // tsmiCreateAccount_employee
            // 
            this.tsmiCreateAccount_employee.Name = "tsmiCreateAccount_employee";
            this.tsmiCreateAccount_employee.Size = new System.Drawing.Size(150, 22);
            this.tsmiCreateAccount_employee.Text = "Tạo tài khoản";
            this.tsmiCreateAccount_employee.Click += new System.EventHandler(this.tsmiCreateAccount_employee_Click);
            // 
            // tsmiDeleteAccount_employee
            // 
            this.tsmiDeleteAccount_employee.Name = "tsmiDeleteAccount_employee";
            this.tsmiDeleteAccount_employee.Size = new System.Drawing.Size(150, 22);
            this.tsmiDeleteAccount_employee.Text = "Xóa tài khoản";
            this.tsmiDeleteAccount_employee.Click += new System.EventHandler(this.tsmiDeleteAccount_employee_Click);
            // 
            // tsmiDeleteEmployee_employee
            // 
            this.tsmiDeleteEmployee_employee.Name = "tsmiDeleteEmployee_employee";
            this.tsmiDeleteEmployee_employee.Size = new System.Drawing.Size(150, 22);
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
            this.cms_supplier.Size = new System.Drawing.Size(170, 48);
            // 
            // tsmiShowInformation_supplier
            // 
            this.tsmiShowInformation_supplier.Name = "tsmiShowInformation_supplier";
            this.tsmiShowInformation_supplier.Size = new System.Drawing.Size(169, 22);
            this.tsmiShowInformation_supplier.Text = "Thêm thông tin";
            this.tsmiShowInformation_supplier.Click += new System.EventHandler(this.tsmiShowInformation_supplier_Click);
            // 
            // tsmiDeleteSupplier_supplier
            // 
            this.tsmiDeleteSupplier_supplier.Name = "tsmiDeleteSupplier_supplier";
            this.tsmiDeleteSupplier_supplier.Size = new System.Drawing.Size(169, 22);
            this.tsmiDeleteSupplier_supplier.Text = "Xóa nhà cung cấp";
            this.tsmiDeleteSupplier_supplier.Click += new System.EventHandler(this.tsmiDeleteSupplier_supplier_Click);
            // 
            // fTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 546);
            this.Controls.Add(this.tctlControl);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(529, 585);
            this.Name = "fTaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Vật Liệu Xây Dựng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTaskManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTaskManager_FormClosed);
            this.Load += new System.EventHandler(this.fTaskManager_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tctlControl.ResumeLayout(false);
            this.tpgBuy.ResumeLayout(false);
            this.grbItemInfor_Buy.ResumeLayout(false);
            this.grbItemInfor_Buy.PerformLayout();
            this.grbGeneralInfor_Buy.ResumeLayout(false);
            this.grbGeneralInfor_Buy.PerformLayout();
            this.panel1_Buy.ResumeLayout(false);
            this.panel1_Buy.PerformLayout();
            this.tpgSell.ResumeLayout(false);
            this.grbItemInfor_Sell.ResumeLayout(false);
            this.grbItemInfor_Sell.PerformLayout();
            this.grbGeneralInfor_Sell.ResumeLayout(false);
            this.grbGeneralInfor_Sell.PerformLayout();
            this.panel1_sell.ResumeLayout(false);
            this.panel1_sell.PerformLayout();
            this.tpgReceipt.ResumeLayout(false);
            this.panel1_Receipt.ResumeLayout(false);
            this.panel2_Receipt.ResumeLayout(false);
            this.grbInfor_Receipt.ResumeLayout(false);
            this.grbInfor_Receipt.PerformLayout();
            this.tpgMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial_material)).EndInit();
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
            this.tpgUserSetting.ResumeLayout(false);
            this.flp_userSetting.ResumeLayout(false);
            this.cms_employee.ResumeLayout(false);
            this.cms_supplier.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUser;
        private BmwTabControl tctlControl;
        private System.Windows.Forms.TabPage tpgBuy;
        private System.Windows.Forms.TabPage tpgSell;
        private System.Windows.Forms.TabPage tpgReceipt;
        private System.Windows.Forms.TabPage tpgMaterial;
        private System.Windows.Forms.TabPage tpgStatistic;
        private System.Windows.Forms.TabPage tpgCustomer;
        private System.Windows.Forms.TabPage tpgSupplier;
        private System.Windows.Forms.TabPage tpgEmployee;
        private System.Windows.Forms.TabPage tpgUserSetting;
        private System.Windows.Forms.DataGridView dgvMaterial_material;
        private BmwButton btnChangeInformation_userSetting;
        private BmwButton btnCreateAccount_userSetting;
        private System.Windows.Forms.FlowLayoutPanel flp_userSetting;
        private BmwButton btnResetPassword_userSetting;
        private BmwGroupBox grbItemInfor_Buy;
        private BmwGroupBox grbGeneralInfor_Buy;
        private System.Windows.Forms.Panel panel1_Buy;
        private System.Windows.Forms.Label lblTitle_Buy;
        private System.Windows.Forms.ListBox lstSupplierId_Buy;
        private System.Windows.Forms.ListBox lstEmployeeId_Buy;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate_Buy;
        private System.Windows.Forms.TextBox txtPhoneNumber_Buy;
        private System.Windows.Forms.TextBox txtAddress_Buy;
        private System.Windows.Forms.TextBox txtSupplierName_Buy;
        private System.Windows.Forms.TextBox txtEmployeeName_Buy;
        private System.Windows.Forms.TextBox txtReceiptId_Buy;
        private System.Windows.Forms.Label lblPhoneNumber_Buy;
        private System.Windows.Forms.Label lblAddress_Buy;
        private System.Windows.Forms.Label lblSupplierName_Buy;
        private System.Windows.Forms.Label lblSupplierId_Buy;
        private System.Windows.Forms.Label lblEmployeeName_Buy;
        private System.Windows.Forms.Label lblEmployeeId_Buy;
        private System.Windows.Forms.Label lblReceiptDate_Buy;
        private System.Windows.Forms.Label lblReceiptId_Buy;
        private System.Windows.Forms.Label lblMoney_Buy;
        private System.Windows.Forms.Label lblMaterialUnitPrice_Buy;
        private System.Windows.Forms.Label lblMaterialName_Buy;
        private System.Windows.Forms.Label lblMaterialAmount_Buy;
        private System.Windows.Forms.Label lblMaterialId_Buy;
        private System.Windows.Forms.TextBox txtMoney_Buy;
        private System.Windows.Forms.TextBox txtMaterialUnitPrice_Buy;
        private System.Windows.Forms.TextBox txtMaterialName_Buy;
        private System.Windows.Forms.TextBox txtMaterialAmount_Buy;
        private System.Windows.Forms.ListBox lstMaterialId_Buy;
        private BmwButton btnPrintReceipt_Buy;
        private BmwButton btnCancelReceipt_Buy;
        private BmwButton btnSaveReceipt_Buy;
        private BmwButton btnAddReceipt_Buy;
        private System.Windows.Forms.TextBox txtTotalMoney_Buy;
        private System.Windows.Forms.Label lblTotalMoney_Buy;
        private BmwGroupBox grbItemInfor_Sell;
        private BmwButton btnPrintReceipt_Sell;
        private BmwButton btnCancelReceipt_Sell;
        private BmwButton btnSaveReceipt_Sell;
        private BmwButton btnAddReceipt_Sell;
        private System.Windows.Forms.TextBox txtTotalMoney_Sell;
        private System.Windows.Forms.Label lblTotalMoney_Sell;
        private System.Windows.Forms.TextBox txtMoney_Sell;
        private System.Windows.Forms.TextBox txtMaterialUnitPrice_Sell;
        private System.Windows.Forms.TextBox txtMaterialName_Sell;
        private System.Windows.Forms.TextBox txtMaterialAmount_Sell;
        private System.Windows.Forms.ListBox lstMaterialId_Sell;
        private System.Windows.Forms.Label lblMoney_Sell;
        private System.Windows.Forms.Label lblMaterialUnitPrice_Sell;
        private System.Windows.Forms.Label lblMaterialName_Sell;
        private System.Windows.Forms.Label lblMaterialAmount_Sell;
        private System.Windows.Forms.Label lblMaterialId_Sell;
        private BmwGroupBox grbGeneralInfor_Sell;
        private System.Windows.Forms.ListBox lstCustomerId_Sell;
        private System.Windows.Forms.ListBox lstEmployeeId_Sell;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate_Sell;
        private System.Windows.Forms.TextBox txtPhoneNumber_Sell;
        private System.Windows.Forms.TextBox txtAddress_Sell;
        private System.Windows.Forms.TextBox txtCustomerName_Sell;
        private System.Windows.Forms.TextBox txtEmployeeName_Sell;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblPhoneNumber_Sell;
        private System.Windows.Forms.Label lblAddress_Sell;
        private System.Windows.Forms.Label lblCustomerName_Sell;
        private System.Windows.Forms.Label lblCustomerId_Sell;
        private System.Windows.Forms.Label lblEmployeeName_Sell;
        private System.Windows.Forms.Label lblEmployeeId_Sell;
        private System.Windows.Forms.Label lblReceiptDate_Sell;
        private System.Windows.Forms.Label lblReceiptId_Sell;
        private System.Windows.Forms.Panel panel1_sell;
        private System.Windows.Forms.Label lblTitle_Sell;
        private System.Windows.Forms.TextBox txtName_employee;
        private System.Windows.Forms.Label lblName_employee;
        private BmwListView lvwEmployee_employee;
        private BmwGroupBox grbSearch_employee;
        private System.Windows.Forms.Panel pnlName_employee;
        private System.Windows.Forms.Panel pnlAddress_employee;
        private System.Windows.Forms.Label lblAddress_employee;
        private System.Windows.Forms.TextBox txtAddress_employee;
        private System.Windows.Forms.Panel pnlGender_employee;
        private System.Windows.Forms.Label lblGender_employee;
        private System.Windows.Forms.Panel pnlPhone_employee;
        private System.Windows.Forms.Label lblPhone_employee;
        private System.Windows.Forms.TextBox txtPhone_employee;
        private System.Windows.Forms.RadioButton rdoFemale_employee;
        private System.Windows.Forms.RadioButton rdoMale_employee;
        private System.Windows.Forms.RadioButton rdoAll_employee;
        private System.Windows.Forms.Panel pnlSearch_employe;
        private System.Windows.Forms.Panel pnlPosition_employee;
        private System.Windows.Forms.Label lblPosition_employee;
        private System.Windows.Forms.FlowLayoutPanel flpPosition_employee;
        private System.Windows.Forms.SplitContainer spc_employee;
        private System.Windows.Forms.Panel pnlAccount_employee;
        private System.Windows.Forms.Label lblAccount_employee;
        private System.Windows.Forms.TextBox txtAccount_employee;
        private System.Windows.Forms.FlowLayoutPanel flpFunction_employee;
        private BmwButton btnAdd_employee;
        private BmwButton btnRemoveEmployee_employee;
        private BmwButton btnEdit_employee;
        private BmwButton btnCreateAccount_employee;
        private System.Windows.Forms.ContextMenuStrip cms_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInformation_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateAccount_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAccount_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteEmployee_employee;
        private BmwListView lsvBuy_Buy;
        private BmwListView lvwSell_sell;
        private System.Windows.Forms.Panel panel1_Customer;
        private BmwListView lvwCustomer_customer;
        private BmwButton btnExport_Customer;
        private BmwButton btnRefresh_Customer;
        private BmwButton btnDelete_Customer;
        private BmwButton btnEdit_Customer;
        private BmwButton btnAdd_Customer;
        private BmwGroupBox grbSearch_Customer;
        private System.Windows.Forms.Panel panel1_Receipt;
        private System.Windows.Forms.Panel panel2_Receipt;
        private BmwButton btnExport_receipt;
        private BmwGroupBox grbInfor_Receipt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private BmwListView lvwReceipt_Receipt;
        private BmwButton btnDelete_receipt;
        private System.Windows.Forms.SplitContainer spc_supplier;
        private BmwListView lvwSupplier_supplier;
        private System.Windows.Forms.ContextMenuStrip cms_supplier;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInformation_supplier;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSupplier_supplier;
        private BmwButton btnRefresh_employee;
        private System.Windows.Forms.FlowLayoutPanel flpFunction_supplier;
        private BmwButton btnAdd_supplier;
        private BmwButton btnEdit_supplier;
        private BmwButton btnDelete_supplier;
        private BmwButton btnExport_supplier;
        private BmwButton btnRefresh_supplier;
        private BmwButton btnRemoveAccount_employee;
        private System.Windows.Forms.SplitContainer spc_customer;
        private System.Windows.Forms.FlowLayoutPanel flp_customer;
        private System.Windows.Forms.Panel pnlPhone_customer;
        private System.Windows.Forms.Label lblPhone_customer;
        private System.Windows.Forms.TextBox txtPhone_customer;
        private System.Windows.Forms.Panel pnlAddress_customer;
        private System.Windows.Forms.Label lblAddress_customer;
        private System.Windows.Forms.TextBox txtAddress_customer;
        private System.Windows.Forms.Panel pnlName_customer;
        private System.Windows.Forms.Label lblName_customer;
        private System.Windows.Forms.TextBox txtName_customer;
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
    }
}