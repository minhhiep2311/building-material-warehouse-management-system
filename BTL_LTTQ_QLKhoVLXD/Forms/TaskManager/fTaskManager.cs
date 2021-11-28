using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.AddEmployee;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation;
using BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount;
using BTL_LTTQ_QLKhoVLXD.Forms.Customer;
using BTL_LTTQ_QLKhoVLXD.Forms.Employee;
using BTL_LTTQ_QLKhoVLXD.Forms.Material;
using BTL_LTTQ_QLKhoVLXD.Forms.MaterialDetails;
using BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword;
using BTL_LTTQ_QLKhoVLXD.Forms.Supplier;
using BTL_LTTQ_QLKhoVLXD.Forms.WareHouse;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using Enum = BTL_LTTQ_QLKhoVLXD.Utils.Enum;

namespace BTL_LTTQ_QLKhoVLXD.Forms.TaskManager
{
    public partial class fTaskManager : Form
    {
        public fTaskManager(User user)
        {
            InitializeComponent();
            User = user;
        }

        #region Form

        #region Form Properties

        private User _user;
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                DisplayUserInfo();
            }
        }

        private List<EmployeePosition> _positions = new List<EmployeePosition>();
        private List<Models.Supplier> _suppliers = new List<Models.Supplier>();
        private List<Models.Customer> _customers = new List<Models.Customer>();
        private List<Models.Material> _materials = new List<Models.Material>();
        private List<Warehouse> _warehouses = new List<Warehouse>();

        #endregion

        #region Form Events

        private void fTaskManager_Load(object sender, EventArgs e)
        {
            DisplayComponentsAccordsPermission();
            Init_Buy();

            Invoke((MethodInvoker)(() =>
            {
                LoadData_Warehouse();
            }));

            Invoke((MethodInvoker)(() =>
            {
                Init_Sell();
                nmrMaterialAmount_sell.TextChanged += nmrMaterialAmount_Sell_TextChanged;
            }));

            Invoke((MethodInvoker)(() =>
            {
                Init_Material();
                LoadData_Material();
            }));

            Invoke((MethodInvoker)(() =>
            {
                Init_Supplier();
                LoadData_Supplier();
            }));

            Invoke((MethodInvoker)(() =>
            {
                Init_Employee();
                LoadData_Employee();
            }));

            Invoke((MethodInvoker)(() =>
           {
               Init_Customer();
               LoadData_Customer();
           }));
        }

        private void fTaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                    Resources.MessageBox_Message_ConfirmExit,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.No;
        }

        private void fTaskManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            _debounce_employee.Dispose();
            _debounce_supplier.Dispose();
        }

        #endregion

        #region Form Behaviors

        private void DisplayComponentsAccordsPermission()
        {
            if (!User.Permissions.Contains(Resources.Permission_CreateAccount))
                btnCreateAccount_userSetting.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_ResetPassword))
                btnResetPassword_userSetting.Visible = false;

            if (!User.Permissions.Contains(Resources.Permission_AddEmployee))
                btnAdd_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_EditAccountInformation))
                btnEdit_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteAccount))
                btnRemoveAccount_employee.Visible = false;
            //if (!User.Permissions.Contains(Resources.Permission_CreateAccountEmployee))
               // btnCreateAccount_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteEmployee))
                btnRemoveEmployee_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_EditReceipt))
                btnEdit_Receipt.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_AddReceipt))
                btnAdd_Receipt.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteReceipt))
                btnDelete_Receipt.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_EditMaterial))
                btnEdit_material.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_AddMaterial))
                btnAdd_material.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteMaterial))
                btnDelete_material.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_WarehouseMaterial))
                btnWareHouse_material.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_EditCustomer))
                btnEdit_Customer.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_AddCustomer))
                btnAdd_Customer.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteCustomer))
                btnDelete_Customer.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_EditSupplierInformation))
                btnEdit_supplier.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteSupplier))
                btnDelete_supplier.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteSupplier))
                tsmiDeleteSupplier_supplier.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_CreateAccount))
                tsmiCreateAccount_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteAccount))
                tsmiDeleteAccount_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_AddSupplier))
                btnAdd_supplier.Visible = false;
        }

        private void DisplayUserInfo()
        {
            lblUser.Text = string.Format(Resources.TaskManager_Label_User, User.Name);
            lblPosition.Text = string.Format(Resources.TaskManager_Label_Position, User.Position);
        }

        private void LoadData_Warehouse()
        {
            _warehouses = WarehouseService.GetAllWarehouses();
        }

        private static bool ConfirmDeleteItemsFromReceipt(IEnumerable<string> shouldDeleteCustomerNames)
        {
            var shouldDeleteStr = string.Join(", ", shouldDeleteCustomerNames);
            return MessageBox.Show(
                string.Format(Resources.MessageBox_Message_ConfirmDeleteItemFromReceipt, shouldDeleteStr),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool ConfirmCreateReceipt()
        {
            return MessageBox.Show(
                Resources.MessageBox_Message_ConfirmCreateReceipt,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool ConfirmExportReceipt()
        {
            return MessageBox.Show(
                Resources.MessageBox_Message_CreateReceiptSuccessfully,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            ) == DialogResult.Yes;
        }

        private bool ShouldShowMenuContext(MouseEventArgs e, ListView listView)
        {
            if (e.Button != MouseButtons.Right)
                return false;

            var focusItem = listView.FocusedItem;
            return focusItem != null && focusItem.Bounds.Contains(e.Location);
        }

        #endregion

        #endregion

        #region Buy

        #region Buy Properties

        private readonly List<Models.Material> _items_buy = new List<Models.Material>();
        private ImportReceipt _receipt_buy;
        private bool _createdReceipt_buy;

        private bool CreatedReceipt_buy
        {
            get => _createdReceipt_buy;
            set
            {
                _createdReceipt_buy = value;
                if (_createdReceipt_buy)
                {
                    btnCreateReceipt_buy.Text = Resources.Form_ButtonNewReceipt;
                    btnExport_buy.Visible = true;
                    btnCancel_buy.Enabled = false;
                }
                else
                {
                    btnCreateReceipt_buy.Text = Resources.Form_ButtonCreateReceipt;
                    btnExport_buy.Visible = false;
                    btnCancel_buy.Enabled = true;
                }
            }
        }

        #endregion

        #region Buy Events

        private void tpgBuy_Enter(object sender, EventArgs e)
        {
            ResetButtons_Buy();
            BindData_Buy();
        }

        private void cboSupplier_buy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddress_buy.Text = (cboSupplier_buy.SelectedItem as Models.Supplier)?.Address;
            lblAddress_buy.Focus();
            TryEnableCreateReceipt_Buy();
        }

        private void btnAddSupplier_buy_Click(object sender, EventArgs e)
        {
            new fSupplier(() =>
            {
                LoadData_Supplier();
                cboSupplier_buy.DataSource = _suppliers;
                cboSupplier_buy.SelectedIndex = -1;
            }).ShowDialog();
        }

        private void cboWarehouse_buy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryEnableCreateReceipt_Buy();
            lvwItem_buy.Items.Clear();
            _items_buy.Clear();
            txtTotalMoney_buy.Text = "";
        }

        private void cboItem_buy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryEnableAddItem_Buy();
            nmrMaterialAmount_buy.Value = 0;
            if (!(cboItem_buy.SelectedItem is Models.Material selectedItem))
            {
                txtSpecialization_buy.Text = "";
                nmrUnitPrice_buy.Value = 0;
                return;
            }

            txtSpecialization_buy.Text = selectedItem.Specialization;
            nmrUnitPrice_buy.Value = Convert.ToDecimal(selectedItem.ImportUnitPrice);
            lblSpecialization_buy.Focus();
        }

        private void btnAddMaterial_buy_Click(object sender, EventArgs e)
        {
            lvwItem_buy.SelectedItems.Clear();
            new fMaterial(this).ShowDialog();
        }

        private void nmrMaterialAmount_buy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                btnAddItem_buy.PerformClick();
            else
                TryEnableAddItem_Buy();
        }

        private void btnAddItem_buy_Click(object sender, EventArgs e)
        {
            var material = (cboItem_buy.SelectedItem as Models.Material)?.Clone();
            if (material == null)
                return;

            material.ImportUnitPrice = Convert.ToDouble(nmrUnitPrice_buy.Value);
            material.Numerous = Convert.ToInt32(nmrMaterialAmount_buy.Value);

            var duplicatedItemIndex = _items_buy.FindIndex(x => x.Id == material.Id);
            if (duplicatedItemIndex == -1)
            {
                _items_buy.Add(material);
                lvwItem_buy.Items.Add(material.ToListViewItem(Models.Material.Type.Import));
            }
            else
            {
                _items_buy[duplicatedItemIndex].Numerous += material.Numerous;
                lvwItem_buy.Items[duplicatedItemIndex] = _items_buy[duplicatedItemIndex]
                   .ToListViewItem(Models.Material.Type.Import);
            }

            TryEnableCreateReceipt_Buy();
            BindTotal_Buy();
        }

        private void btnDeleteItem_buy_Click(object sender, EventArgs e)
        {
            TryDeleteItem_Buy();
        }

        private void lvwItem_buy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwItem_buy.SelectedItems.Count <= 0)
            {
                ResetButtons_Buy();
                return;
            }

            btnDeleteItem_buy.Enabled = true;
        }

        private void btnCreateReceipt_Buy_Click(object sender, EventArgs e)
        {
            if (CreatedReceipt_buy)
            {
                ResetForm_Buy();
                CreatedReceipt_buy = false;
                return;
            }

            if (!ConfirmCreateReceipt())
                return;

            CreateReceipt_Buy();

            if (_receipt_buy.Id != -1)
            {
                CreatedReceipt_buy = true;
                if (ConfirmExportReceipt())
                    ExportService.Export(_receipt_buy);
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_buy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.MessageBox_Message_AbortReceipt,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            ResetForm_Buy();
        }

        private void btnExport_buy_Click(object sender, EventArgs e)
        {
            ExportService.Export(_receipt_buy);
        }

        #endregion

        #region Behaviors

        private void Init_Buy()
        {
            lvwItem_buy.Columns.Add("ID", 0);
            lvwItem_buy.Columns.Add("Tên vật liệu", 300, HorizontalAlignment.Left);
            lvwItem_buy.Columns.Add("Đơn giá", 100, HorizontalAlignment.Left);
            lvwItem_buy.Columns.Add("Số lượng", 100, HorizontalAlignment.Left);
            lvwItem_buy.Columns.Add("Đơn vị", 75, HorizontalAlignment.Left);
            lvwItem_buy.Columns.Add("Quy cách", 150, HorizontalAlignment.Left);
            lvwItem_buy.Sortable = false;
        }

        private void ResetButtons_Buy()
        {
            btnDeleteItem_buy.Enabled = false;
        }

        private void BindData_Buy()
        {
            cboSupplier_buy.DataSource = _suppliers;
            cboSupplier_buy.SelectedIndex = -1;
            cboWarehouse_buy.DataSource = _warehouses;
            cboWarehouse_buy.SelectedIndex = -1;
            cboItem_buy.DataSource = _materials;
            cboItem_buy.SelectedIndex = -1;
            nmrUnitPrice_buy.Value = 0;
        }

        private void TryEnableAddItem_Buy()
        {
            btnAddItem_buy.Enabled = cboItem_buy.SelectedIndex != -1 &&
                nmrMaterialAmount_buy.Text != "" &&
                nmrMaterialAmount_buy.Value != 0;
        }

        private void TryDeleteItem_Buy()
        {
            if (lvwItem_buy.SelectedIndices.Count <= 0)
                return;

            var shouldDeleteItemIds = lvwItem_buy.SelectedIndices.Cast<int>().ToList();
            var shouldDeleteSupplierNames = shouldDeleteItemIds.Select(x => _items_buy[x].Name);

            if (!ConfirmDeleteItemsFromReceipt(shouldDeleteSupplierNames))
                return;

            DeleteItem_Buy(shouldDeleteItemIds);
            TryEnableCreateReceipt_Buy();
        }

        private void DeleteItem_Buy(List<int> shouldDeleteItemIds)
        {
            shouldDeleteItemIds.ForEach(idx =>
            {
                _items_buy.RemoveAt(idx);
                lvwItem_buy.Items.RemoveAt(idx);
            });

            BindTotal_Buy();
        }

        private void TryEnableCreateReceipt_Buy()
        {
            btnCreateReceipt_buy.Enabled = cboSupplier_buy.SelectedIndex != -1 &&
                cboWarehouse_buy.SelectedIndex != -1 &&
                lvwItem_buy.Items.Count > 0;
        }

        private void BindTotal_Buy()
        {
            var sum = CalculateTotal_Buy();
            txtTotalMoney_buy.Text = Helper.Converter.ToString(sum);
        }

        private double CalculateTotal_Buy()
        {
            return _items_buy
                .Select(x => x.ImportUnitPrice * x.Numerous)
                .Sum(x => x);
        }

        private void CreateReceipt_Buy()
        {
            var supplier = cboSupplier_buy.SelectedItem as Models.Supplier;
            var warehouse = cboWarehouse_buy.SelectedItem as Warehouse;
            var total = CalculateTotal_Buy();
            var receipt = new ImportReceipt(User, supplier, warehouse, _items_buy, total);
            receipt.Id = ReceiptService.CreateImportReceipt(receipt);
            _receipt_buy = receipt;
        }

        private void ResetForm_Buy()
        {
            cboSupplier_buy.SelectedIndex = -1;
            txtAddress_buy.Text = "";
            cboWarehouse_buy.SelectedIndex = -1;
            txtSpecialization_buy.Text = "";
            nmrUnitPrice_buy.Value = 0;
            nmrMaterialAmount_buy.Value = 0;
            _receipt_buy = null;
            lvwItem_buy.Items.Clear();
        }

        #endregion

        #endregion

        #region Sell

        #region Sell Properties

        private readonly List<Models.Material> _items_sell = new List<Models.Material>();
        private ExportReceipt _receipt_sell;
        private bool _createdReceipt_sell;

        private bool CreatedReceipt_sell
        {
            get => _createdReceipt_sell;
            set
            {
                _createdReceipt_sell = value;
                if (_createdReceipt_sell)
                {
                    btnCreateReceipt_sell.Text = Resources.Form_ButtonNewReceipt;
                    btnExport_sell.Visible = true;
                    btnCancelReceipt_sell.Enabled = false;
                }
                else
                {
                    btnCreateReceipt_sell.Text = Resources.Form_ButtonCreateReceipt;
                    btnExport_sell.Visible = false;
                    btnCancelReceipt_sell.Enabled = true;
                }
            }
        }

        #endregion

        #region Sell Events

        private void tpgSell_Enter(object sender, EventArgs e)
        {
            ResetButtons_Sell();
            BindData_Sell();
        }

        private void cboCustomer_sell_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddress_sell.Text = (cboCustomer_sell.SelectedItem as Models.Customer)?.Address;
            lblAddress_sell.Focus();
            TryEnableCreateReceipt_Sell();
        }

        private void btnAddCustomer_sell_Click(object sender, EventArgs e)
        {
            new fCustomer(() =>
            {
                LoadData_Customer();
                cboCustomer_sell.DataSource = _customers;
                cboCustomer_sell.SelectedIndex = -1;
            }).ShowDialog();
        }

        private void cboWarehouse_sell_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwItem_sell.Items.Clear();
            _items_sell.Clear();
            txtTotalMoney_sell.Text = "";
            txtValue_sell.Text = "";
            TryUpdateItem_Sell();
            TryEnableCreateReceipt_Sell();
        }

        private void cboItem_sell_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryEnableAddItem_Sell();
            nmrMaterialAmount_sell.Value = 0;
            if (!(cboItem_sell.SelectedItem is Models.Material selectedItem))
            {
                txtSpecialization_sell.Text = "";
                txtNumerous_sell.Text = "";
                nmrUnitPrice_sell.Value = 0;
                return;
            }

            var addedItems = _items_sell.FirstOrDefault(x => x.Id == selectedItem.Id)?.Numerous ?? 0;
            var itemsLeft = selectedItem.Numerous - addedItems;
            txtSpecialization_sell.Text = selectedItem.Specialization;
            txtNumerous_sell.Text = itemsLeft.ToString();
            nmrUnitPrice_sell.Value = Convert.ToDecimal(selectedItem.ExportUnitPrice);
            nmrMaterialAmount_sell.Maximum = itemsLeft;

            lblSpecialization_sell.Focus();
        }

        private void btnAddMaterial_sell_Click(object sender, EventArgs e)
        {
            lvwItem_sell.SelectedItems.Clear();
            new fMaterial(this).ShowDialog();
        }

        private void nmrMaterialAmount_sell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                btnAddItem_sell.PerformClick();
            else
                TryEnableAddItem_Sell();
        }

        private void nmrMaterialAmount_sell_ValueChanged(object sender, EventArgs e)
        {
            TryEnableAddItem_Sell();
        }

        private void nmrMaterialAmount_Sell_TextChanged(object sender, EventArgs e)
        {
            TryEnableAddItem_Sell();
        }

        private void btnAddItem_sell_Click(object sender, EventArgs e)
        {
            var material = (cboItem_sell.SelectedItem as Models.Material)?.Clone();
            if (material == null)
                return;

            material.ImportUnitPrice = Convert.ToDouble(nmrUnitPrice_sell.Value);
            material.Numerous = Convert.ToInt32(nmrMaterialAmount_sell.Value);

            var duplicatedItemIndex = _items_sell.FindIndex(x => x.Id == material.Id);
            if (duplicatedItemIndex == -1)
            {
                _items_sell.Add(material);
                lvwItem_sell.Items.Add(material.ToListViewItem(Models.Material.Type.Export));
            }
            else
            {
                _items_sell[duplicatedItemIndex].Numerous += material.Numerous;
                lvwItem_sell.Items[duplicatedItemIndex] = _items_sell[duplicatedItemIndex]
                   .ToListViewItem(Models.Material.Type.Import);
            }

            var itemsLeft = Convert.ToInt32(txtNumerous_sell.Text) - material.Numerous;
            nmrMaterialAmount_sell.Maximum = itemsLeft;
            nmrMaterialAmount_sell.Value = 0;
            txtNumerous_sell.Text = itemsLeft.ToString();

            TryEnableCreateReceipt_Sell();
            BindTotal_Sell();
        }

        private void btnDeleteItem_sell_Click(object sender, EventArgs e)
        {
            TryDeleteItem_Sell();
        }

        private void btnExport_sell_Click(object sender, EventArgs e)
        {
            ExportService.Export(_receipt_sell);
        }

        private void nmrVat_sell_ValueChanged(object sender, EventArgs e)
        {
            BindValue_Sell();
        }

        private void lvwItem_sell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwItem_sell.SelectedItems.Count <= 0)
            {
                ResetButtons_Sell();
                return;
            }

            btnDeleteItem_sell.Enabled = true;
        }

        private void btnCreateReceipt_sell_Click(object sender, EventArgs e)
        {
            if (CreatedReceipt_sell)
            {
                ResetForm_Sell();
                CreatedReceipt_sell = false;
                return;
            }

            if (!ConfirmCreateReceipt())
                return;

            CreateReceipt_Sell();

            if (_receipt_sell.Id != -1)
            {
                CreatedReceipt_sell = true;
                if (ConfirmExportReceipt())
                    ExportService.Export(_receipt_sell);
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelReceipt_sell_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.MessageBox_Message_AbortReceipt,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            ResetForm_Sell();
        }

        private void txtTotalMoney_sell_TextChanged(object sender, EventArgs e)
        {
            BindValue_Sell();
        }

        #endregion

        #region Sell Behaviors

        private void Init_Sell()
        {
            lvwItem_sell.Columns.Add("ID", 0);
            lvwItem_sell.Columns.Add("Tên vật liệu", 300, HorizontalAlignment.Left);
            lvwItem_sell.Columns.Add("Đơn giá", 100, HorizontalAlignment.Left);
            lvwItem_sell.Columns.Add("Số lượng", 100, HorizontalAlignment.Left);
            lvwItem_sell.Columns.Add("Đơn vị", 75, HorizontalAlignment.Left);
            lvwItem_sell.Columns.Add("Quy cách", 150, HorizontalAlignment.Left);
            lvwItem_sell.Sortable = false;
        }

        private void ResetButtons_Sell()
        {
            btnDeleteItem_sell.Enabled = false;
        }

        private void BindData_Sell()
        {
            cboCustomer_sell.DataSource = _customers;
            cboCustomer_sell.SelectedIndex = -1;
            cboWarehouse_sell.DataSource = _warehouses;
            cboWarehouse_sell.SelectedIndex = -1;
            cboItem_sell.DataSource = _materials;
            cboItem_sell.SelectedIndex = -1;
            nmrUnitPrice_sell.Value = 0;
        }

        private void TryEnableAddItem_Sell()
        {
            btnAddItem_sell.Enabled = cboItem_sell.SelectedIndex != -1 &&
                nmrMaterialAmount_sell.Text != "" &&
                nmrMaterialAmount_sell.Value != 0;
        }

        private void TryDeleteItem_Sell()
        {
            if (lvwItem_sell.SelectedIndices.Count <= 0)
                return;

            var shouldDeleteItemIds = lvwItem_sell.SelectedIndices.Cast<int>().ToList();
            var shouldDeleteCustomerNames = shouldDeleteItemIds.Select(x => _items_sell[x].Name);

            if (!ConfirmDeleteItemsFromReceipt(shouldDeleteCustomerNames))
                return;

            DeleteItem_Sell(shouldDeleteItemIds);
            TryEnableCreateReceipt_Sell();
        }

        private void TryEnableCreateReceipt_Sell()
        {
            btnCreateReceipt_sell.Enabled = cboCustomer_sell.SelectedIndex != -1 &&
                cboWarehouse_sell.SelectedIndex != -1 &&
                lvwItem_sell.Items.Count > 0;
        }

        private void DeleteItem_Sell(List<int> shouldDeleteItemIds)
        {
            shouldDeleteItemIds.ForEach(idx =>
            {
                _items_sell.RemoveAt(idx);
                lvwItem_sell.Items.RemoveAt(idx);
            });

            BindTotal_Sell();
        }

        private void TryUpdateItem_Sell()
        {
            if (cboWarehouse_sell.SelectedIndex == -1)
            {
                cboItem_sell.Enabled = false;
                return;
            }

            cboItem_sell.Enabled = true;
            var selectedWarehouse = (Warehouse)cboWarehouse_sell.SelectedItem;
            cboItem_sell.DataSource = selectedWarehouse.GetMaterials();
            cboItem_sell.SelectedIndex = -1;
        }

        private void BindTotal_Sell()
        {
            var sum = CalculateTotal_Sell();
            txtTotalMoney_sell.Text = Helper.Converter.ToString(sum);
        }

        private double CalculateTotal_Sell()
        {
            return _items_sell
                .Select(x => x.ImportUnitPrice * x.Numerous)
                .Sum(x => x);
        }

        private void BindValue_Sell()
        {
            if (string.IsNullOrEmpty(txtTotalMoney_sell.Text))
            {
                txtValue_sell.Text = "";
                return;
            }

            var sum = CalculateValue_Sell();
            txtValue_sell.Text = Helper.Converter.ToString(sum);
        }

        private double CalculateValue_Sell()
        {
            return Convert.ToDouble(txtTotalMoney_sell.Text) * (1 + Convert.ToDouble(nmrVat_sell.Value) / 100);
        }

        private void CreateReceipt_Sell()
        {
            var customer = cboCustomer_sell.SelectedItem as Models.Customer;
            var warehouse = cboWarehouse_sell.SelectedItem as Warehouse;
            var total = CalculateTotal_Sell();
            var vatPercent = Convert.ToDouble(nmrVat_sell.Value);
            var vat = total * vatPercent / 100;
            var totalAfterPercent = total + vat;
            var reason = txtReason_sell.Text;
            var receipt = new ExportReceipt(User, customer, warehouse, _items_sell, totalAfterPercent, vat, vatPercent, reason);
            receipt.Id = ReceiptService.CreateExportReceipt(receipt);
            _receipt_sell = receipt;
        }

        private void ResetForm_Sell()
        {
            cboItem_sell.SelectedIndex = -1;
            cboCustomer_sell.SelectedIndex = -1;
            txtAddress_sell.Text = "";
            cboWarehouse_sell.SelectedIndex = -1;
            txtSpecialization_sell.Text = "";
            txtNumerous_sell.Text = "";
            nmrUnitPrice_sell.Value = 0;
            nmrMaterialAmount_sell.Value = 0;
            lvwItem_sell.Items.Clear();
            txtReason_sell.Text = "";
            nmrVat_sell.Value = 0;
            txtTotalMoney_sell.Text = "";
            txtValue_sell.Text = "";
        }

        #endregion

        #endregion

        #region Material

        #region Material Properties

        private Helper.Debounce _debounce_material;

        #endregion

        #region Material Events

        private void tpgMaterial_Enter(object sender, EventArgs e)
        {
            ResetButtons_Material();
            _debounce_material?.Continue();
        }

        private void tpgMaterial_Leave(object sender, EventArgs e)
        {
            _debounce_material.Pause();
        }

        private void lvwMaterial_material_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ShouldShowMenuContext(e, lvwMaterial_material))
                return;
            // TODO: Add permission to menu context
            cms_material.Show(Cursor.Position);
        }

        private void lvwMaterial_material_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowDetails_Material();
        }

        private void lvwMaterial_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMaterial_material.SelectedIndices.Count <= 0)
            {
                ResetButtons_Material();
                return;
            }

            btnDetails_material.Enabled = true;
            btnEdit_material.Enabled = true;
            btnDelete_material.Enabled = true;
        }

        private void tsmiShowDetails_material_Click(object sender, EventArgs e)
        {
            ShowDetails_Material();
        }

        private void tsmiShowInformation_material_Click(object sender, EventArgs e)
        {
            EditMaterial_Material();
        }

        private void tsmiDelete_material_Click(object sender, EventArgs e)
        {
            TryDeleteMaterial_Material();
        }

        private void txtName_material_TextChanged(object sender, EventArgs e)
        {
            _debounce_material.HandleUpdate();
        }

        private void rdoAll_material_CheckedChanged(object sender, EventArgs e)
        {
            _debounce_material.HandleUpdate();
        }

        private void rdoAvailable_CheckedChanged(object sender, EventArgs e)
        {
            _debounce_material.HandleUpdate();
        }

        private void btnDetails_material_Click(object sender, EventArgs e)
        {
            ShowDetails_Material();
        }

        private void btnEdit_Material_Click(object sender, EventArgs e)
        {
            EditMaterial_Material();
        }

        private void btnAdd_Material_Click(object sender, EventArgs e)
        {
            lvwMaterial_material.SelectedItems.Clear();
            new fMaterial(this).ShowDialog();
        }

        private void btnDelete_Material_Click(object sender, EventArgs e)
        {
            TryDeleteMaterial_Material();
        }

        private void btnExport_Material_Click(object sender, EventArgs e)
        {
            ExportService.Export(_materials);
        }

        private void btnWareHouse_material_Click(object sender, EventArgs e)
        {
            new fWarehouse().ShowDialog();
        }

        private void btnRefresh_Material_Click(object sender, EventArgs e)
        {
            LoadData_Material();
        }

        #endregion

        #region Material Behaviors

        private void Init_Material()
        {
            _debounce_material = new Helper.Debounce(Search_Material);

            lvwMaterial_material.Columns.Add("ID", 0);
            lvwMaterial_material.Columns.Add("Tên vật liệu", 175, HorizontalAlignment.Left);
            lvwMaterial_material.Columns.Add("Giá nhập", 80, HorizontalAlignment.Right);
            lvwMaterial_material.Columns.Add("Giá xuất", 80, HorizontalAlignment.Right);
            lvwMaterial_material.Columns.Add("Đơn vị", 50, HorizontalAlignment.Left);
            lvwMaterial_material.Columns.Add("Quy cách", 120, HorizontalAlignment.Left);
        }

        public void LoadData_Material(List<Models.Material> cache = null)
        {

            lvwMaterial_material.Items.Clear();

            if (cache == null)
            {
                _materials = MaterialService.GetAllMaterials();
                cache = _materials;
            }

            cache.ForEach(material =>
            {
                lvwMaterial_material.Items.Add(material.ToListViewItem());
            });
        }

        private void ResetButtons_Material()
        {
            btnDetails_material.Enabled = false;
            btnEdit_material.Enabled = false;
            btnDelete_material.Enabled = false;
        }

        private void EditMaterial_Material()
        {
            var material = Helper.Control.FirstSelected(_materials, lvwMaterial_material);
            if (material != null)
                new fMaterial(this, Enum.FormMode.Write, material).Show();
        }

        private void Search_Material()
        {
            var name = txtName_material.Text;
            var status = Helper.Control.Filter.GetRadioButtons(pnlStatus_material)
               .FirstOrDefault(x => x.Checked)?.Text;

            var materials = _materials.FindAll(x =>
            {
                var matchName = Helper.Matcher.Match(x.Name, name);
                var matchGender = status == "Tất cả" || x.IsAvailable;

                return matchName && matchGender;
            });

            LoadData_Material(materials);
        }

        private void ShowDetails_Material()
        {
            var material = Helper.Control.FirstSelected(_materials, lvwMaterial_material);
            if (material == null)
                return;
            
            lvwMaterial_material.SelectedItems.Clear();
            new fMaterialDetails(material).ShowDialog();
        }

        private void TryDeleteMaterial_Material()
        {
            if (lvwMaterial_material.SelectedIndices.Count <= 0)
                return;

            var shouldDeleteSuppliers = lvwMaterial_material.SelectedIndices.Cast<int>()
               .Select(x => _suppliers[x]).ToList();
            var shouldDeleteSupplierNames = shouldDeleteSuppliers.Select(x => x.Name);
            var shouldDeleteSupplierIds = shouldDeleteSuppliers.Select(x => x.Id).ToList();

            if (ConfirmDeleteSupplier_supplier(shouldDeleteSupplierNames))
                DeleteSupplier_supplier(shouldDeleteSupplierIds);
        }

        #endregion

        #endregion

        #region Customer

        #region Customer Properties

        private Helper.Debounce _debounce_customer;

        #endregion

        #region Customer Events

        private void txtName_customer_TextChanged(object sender, EventArgs e)
        {
            _debounce_customer.HandleUpdate();
        }

        private void txtAddress_customer_TextChanged(object sender, EventArgs e)
        {
            _debounce_customer.HandleUpdate();
        }

        private void txtPhone_customer_TextChanged(object sender, EventArgs e)
        {
            _debounce_customer.HandleUpdate();
        }

        private void btnAdd_Customer_Click(object sender, EventArgs e)
        {
            lvwCustomer_customer.SelectedItems.Clear();
            new fCustomer(() => LoadData_Customer()).ShowDialog();
        }

        private void btnEdit_Customer_Click(object sender, EventArgs e)
        {
            EditCustomer_customer();
        }

        private void btnDelete_Customer_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Customer_Click(object sender, EventArgs e)
        {
            ExportService.Export(_customers);
        }

        private void btnRefresh_Customer_Click(object sender, EventArgs e)
        {
            LoadData_Customer();
        }

        #endregion

        #region Customer Behaviors

        private void Init_Customer()
        {
            _debounce_customer = new Helper.Debounce(Search_Customer);

            lvwCustomer_customer.Columns.Add("ID", 0);
            lvwCustomer_customer.Columns.Add("Tên khách hàng", 300, HorizontalAlignment.Left);
            lvwCustomer_customer.Columns.Add("Địa chỉ", 150, HorizontalAlignment.Left);
        }

        public void LoadData_Customer(List<Models.Customer> cache = null)
        {
            lvwCustomer_customer.Items.Clear();

            if (cache == null)
            {
                _customers = CustomerService.GetAllCustomers();
                cache = _customers;
                cboItem_buy.DataSource = _customers;
            }

            cache.ForEach(supplier =>
                {
                    lvwCustomer_customer.Items.Add(supplier.ToListViewItem());
                }
            );
        }

        private void Search_Customer()
        {
            var name = txtName_customer.Text;
            var address = txtAddress_customer.Text;
            var phone = txtPhone_customer.Text;

            var customers = _customers.FindAll(x =>
            {
                var matchName = Helper.Matcher.Match(x.Name, name);
                var matchAddress = Helper.Matcher.Match(x.Address, address);
                var matchPhone = Helper.Matcher.Match(x.PhoneNumber, phone);

                return matchName && matchAddress && matchPhone;
            });

            LoadData_Customer(customers);
        }

        private void EditCustomer_customer()
        {
            var customer = Helper.Control.FirstSelected(_customers, lvwCustomer_customer);
            if (customer != null)
                new fCustomer(
                    () => LoadData_Customer(),
                    Enum.FormMode.Write,
                    customer,
                    true
                ).Show();
        }

        #endregion

        #endregion

        #region Supplier

        #region Supplier Properties

        private Helper.Debounce _debounce_supplier;

        #endregion

        #region Supplier Events

        private void tpgSupplier_Enter(object sender, EventArgs e)
        {
            ResetButtons_Supplier();
            _debounce_supplier?.Continue();
        }

        private void tpgSupplier_Leave(object sender, EventArgs e)
        {
            _debounce_supplier.Pause();
        }

        private void lvwSupplier_supplier_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ShouldShowMenuContext(e, lvwSupplier_supplier))
                return;
            cms_supplier.Show(Cursor.Position);
        }

        private void lvwSupplier_supplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInformation_Supplier();
        }

        private void lvwSupplier_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSupplier_supplier.SelectedIndices.Count <= 0)
            {
                ResetButtons_Supplier();
                return;
            }

            btnEdit_supplier.Enabled = true;
            btnDelete_supplier.Enabled = true;
        }

        private void tsmiShowInformation_supplier_Click(object sender, EventArgs e)
        {
            ShowInformation_Supplier();
        }

        private void tsmiDeleteSupplier_supplier_Click(object sender, EventArgs e)
        {
            TryDeleteSupplier_supplier();
        }

        private void txtName_supplier_TextChanged(object sender, EventArgs e)
        {
            _debounce_supplier.HandleUpdate();
        }

        private void txtAddress_supplier_TextChanged(object sender, EventArgs e)
        {
            _debounce_supplier.HandleUpdate();
        }

        private void txtPhone_supplier_TextChanged(object sender, EventArgs e)
        {
            _debounce_supplier.HandleUpdate();
        }

        private void btnAdd_supplier_Click(object sender, EventArgs e)
        {
            lvwSupplier_supplier.SelectedItems.Clear();
            new fSupplier(() => LoadData_Supplier()).ShowDialog();
        }

        private void btnEdit_supplier_Click(object sender, EventArgs e)
        {
            EditSupplier_supplier();
        }

        private void btnDelete_supplier_Click(object sender, EventArgs e)
        {
            TryDeleteSupplier_supplier();
        }

        private void btnExport_supplier_Click(object sender, EventArgs e)
        {

            ExportService.Export(_suppliers);
        }


        private void btnRefresh_supplier_Click(object sender, EventArgs e)
        {
            LoadData_Supplier();
        }

        #endregion

        #region Supplier Behaviors

        private void Init_Supplier()
        {
            _debounce_supplier = new Helper.Debounce(Search_Supplier);

            lvwSupplier_supplier.Columns.Add("ID", 0);
            lvwSupplier_supplier.Columns.Add("Tên NCC", 300, HorizontalAlignment.Left);
            lvwSupplier_supplier.Columns.Add("Địa chỉ", 150, HorizontalAlignment.Left);
        }

        public void LoadData_Supplier(List<Models.Supplier> cache = null)
        {
            lvwSupplier_supplier.Items.Clear();

            if (cache == null)
            {
                _suppliers = SupplierService.GetAllSuppliers();
                cache = _suppliers;
            }

            cache.ForEach(supplier =>
                {
                    lvwSupplier_supplier.Items.Add(supplier.ToListViewItem());

                }
            );
        }

        private void ResetButtons_Supplier()
        {
            btnEdit_supplier.Enabled = false;
            btnDelete_supplier.Enabled = false;
        }

        private void Search_Supplier()
        {
            var name = txtName_supplier.Text;
            var address = txtAddress_supplier.Text;
            var phone = txtPhone_supplier.Text;

            var suppliers = _suppliers.FindAll(x =>
            {
                var matchName = Helper.Matcher.Match(x.Name, name);
                var matchAddress = Helper.Matcher.Match(x.Address, address);
                var matchPhone = Helper.Matcher.Match(x.PhoneNumber, phone);

                return matchName && matchAddress && matchPhone;
            });

            LoadData_Supplier(suppliers);
        }

        private void ShowInformation_Supplier()
        {
            if (lvwSupplier_supplier.SelectedIndices.Count <= 0)
                return;

            var supplier = _suppliers[lvwSupplier_supplier.SelectedIndices[0]];
            var editable = User.Permissions.Contains(Resources.Permission_EditSupplierInformation);
            var mode = editable ? Enum.FormMode.Write : Enum.FormMode.Read;

            lvwSupplier_supplier.SelectedItems.Clear();

            //new fSupplier(this, mode, supplier).Show();
        }

        private void TryDeleteSupplier_supplier()
        {
            if (lvwSupplier_supplier.SelectedIndices.Count <= 0)
                return;

            var shouldDeleteSuppliers = lvwSupplier_supplier.SelectedIndices.Cast<int>()
               .Select(x => _suppliers[x]).ToList();
            var shouldDeleteSupplierNames = shouldDeleteSuppliers.Select(x => x.Name);
            var shouldDeleteSupplierIds = shouldDeleteSuppliers.Select(x => x.Id).ToList();

            if (ConfirmDeleteSupplier_supplier(shouldDeleteSupplierNames))
                DeleteSupplier_supplier(shouldDeleteSupplierIds);
        }

        private static bool ConfirmDeleteSupplier_supplier(IEnumerable<string> shouldDeleteSupplierNames)
        {
            var shouldDeleteStr = string.Join(", ", shouldDeleteSupplierNames);
            return MessageBox.Show(
                string.Format(Resources.MessageBox_Message_ConfirmDeleteSupplier, shouldDeleteStr),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private void DeleteSupplier_supplier(List<int> shouldDeleteSupplierIds)
        {
            if (SupplierService.DeleteSupplier(shouldDeleteSupplierIds))
            {
                MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_DeleteSupplierSuccessfully, shouldDeleteSupplierIds.Count),
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            LoadData_Supplier();
        }

        private void EditSupplier_supplier()
        {
            var supplier = Helper.Control.FirstSelected(_suppliers, lvwSupplier_supplier);
            if (supplier != null)
                new fSupplier(() => LoadData_Supplier(), Enum.FormMode.Write, supplier, true).Show();
        }

        #endregion

        #endregion

        #region Employee

        #region Employee Properties

        private List<User> _employeeList_employee;
        private Helper.Debounce _debounce_employee;

        #endregion

        #region Employee Events

        private void tpgEmployee_Enter(object sender, EventArgs e)
        {
            ResetButtons_Employee();
            _debounce_employee?.Continue();
        }

        private void tpgEmployee_Leave(object sender, EventArgs e)
        {
            _debounce_employee.Pause();
        }

        private void lvwEmployee_employee_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ShouldShowMenuContext(e, lvwEmployee_employee))
                return;

            var selectedIndices = lvwEmployee_employee.SelectedIndices;
            var selectedEmployees = selectedIndices.Cast<int>()
               .Select(idx => _employeeList_employee[idx])
               .ToList();
            var noAccountEmployee = selectedEmployees.FirstOrDefault(x => string.IsNullOrEmpty(x.Account));
            var hadAccountEmployee = selectedEmployees.FirstOrDefault(x => !string.IsNullOrEmpty(x.Account));

            if (selectedEmployees.Count > 1)
            {
                tsmiShowInformation_employee.Visible = false;
            }

            // If everyone has had account, then hide button "Create account"
            if (noAccountEmployee == null)
            {
                tsmiCreateAccount_employee.Visible = false;
            }
            // If everyone hasn't had account yet, then hide button "Delete account"
            else if (hadAccountEmployee == null)
            {
                tsmiDeleteAccount_employee.Visible = false;
            }
            // If somebody has had account, and somebody hasn't,
            // then hide both buttons "Create account" and "Delete account"
            else
            {
                tsmiCreateAccount_employee.Visible = false;
                tsmiDeleteAccount_employee.Visible = false;
            }

            cms_employee.Show(Cursor.Position);
        }

        private void lvwEmployee_employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInformation_Employee();
        }

        private void lvwEmployee_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
            {
                ResetButtons_Employee();
                return;
            }

            var selectedIndices = lvwEmployee_employee.SelectedIndices;
            /*
             * If there is one employee is selected, and he is user, then disable edit button,
             * else if he is not user, then enable.
             */
            var firstIndex = selectedIndices[0];
            var firstEmployee = _employeeList_employee[firstIndex];
            btnEdit_employee.Enabled = !firstEmployee.Equals(_user);

            /*
             * Allow create account only if employee has no account
             */
            btnCreateAccount_employee.Enabled = string.IsNullOrEmpty(firstEmployee.Account);

            /*
             * From selected employees, only delete accounts of employees who has account,
             * and DO NOT self-delete account
             */
            var accounts = selectedIndices.Cast<int>()
               .Select(x => _employeeList_employee[x].Account)
               .Where(account => !string.IsNullOrEmpty(account) && account != _user.Account);
            btnRemoveAccount_employee.Enabled = accounts.Any();

            /*
             * Delete selected employees and DO NOT self-delete 
             */
            var employees = selectedIndices.Cast<int>()
               .Select(x => _employeeList_employee[x])
               .Where(employee => !employee.Equals(_user));
            btnRemoveEmployee_employee.Enabled = employees.Any();
        }

        private void txtName_employee_TextChanged(object sender, EventArgs e)
        {
            _debounce_employee.HandleUpdate();
        }

        private void txtAccount_employee_TextChanged(object sender, EventArgs e)
        {
            _debounce_employee.HandleUpdate();
        }

        private void txtAddress_employee_TextChanged(object sender, EventArgs e)
        {
            _debounce_employee.HandleUpdate();
        }

        private void txtPhone_employee_TextChanged(object sender, EventArgs e)
        {
            _debounce_employee.HandleUpdate();
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll_employee.Checked)
                _debounce_employee.HandleUpdate();
        }

        private void rdoMale_employee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMale_employee.Checked)
                _debounce_employee.HandleUpdate();
        }

        private void rdoFemale_employee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFemale_employee.Checked)
                _debounce_employee.HandleUpdate();
        }

        private void CheckboxAllChange_employee(object sender, EventArgs e)
        {
            var checkboxes = Helper.Control.Filter.GetCheckBoxes(flpPosition_employee);
            var shouldChecked = checkboxes[0].Checked;
            foreach (var checkBox in checkboxes.Skip(1))
                checkBox.Checked = shouldChecked;
            _debounce_employee.HandleUpdate();
        }

        private void CheckboxChange_employee(object sender, EventArgs e)
        {
            var checkboxes = Helper.Control.Filter.GetCheckBoxes(flpPosition_employee);
            var firstNotCheck = checkboxes.Skip(1).FirstOrDefault(x => !x.Checked);
            checkboxes.First().Checked = firstNotCheck == null;
            _debounce_employee.HandleUpdate();
        }

        private void btnAdd_employee_Click(object sender, EventArgs e)
        {
            lvwEmployee_employee.SelectedItems.Clear();
            new fEmployee(this).ShowDialog();
        }

        private void btnEdit_employee_Click(object sender, EventArgs e)
        {
            EditEmployee_employee();
        }

        private void btnCreateAccount_employee_Click(object sender, EventArgs e)
        {
            CreateAccount_employee();
        }

        private void btnRemoveAccount_employee_Click(object sender, EventArgs e)
        {
            TryDeleteAccount_employee();
        }

        private void btnRemoveEmployee_employee_Click(object sender, EventArgs e)
        {
            TryDeleteEmployee_employee();
        }

        private void tsmiShowInformation_employee_Click(object sender, EventArgs e)
        {
            ShowInformation_Employee();
        }

        private void tsmiCreateAccount_employee_Click(object sender, EventArgs e)
        {
            CreateAccount_employee();
        }

        private void tsmiDeleteAccount_employee_Click(object sender, EventArgs e)
        {
            TryDeleteAccount_employee();
        }

        private void tsmiDeleteEmployee_employee_Click(object sender, EventArgs e)
        {
            TryDeleteEmployee_employee();
        }

        private void btnRefresh_employee_Click(object sender, EventArgs e)
        {
            LoadData_Employee();
        }

        #endregion

        #region Employee Behaviors

        private void Init_Employee()
        {
            _debounce_employee = new Helper.Debounce(Search_Employee);

            lvwEmployee_employee.Columns.Add("ID", 0);
            lvwEmployee_employee.Columns.Add("Họ tên", -2, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Vị trí", -2, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Địa chỉ", 150, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Tài khoản", 100, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Giới tính", -2, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Ngày sinh", -2, HorizontalAlignment.Left);

            _positions = EmployeeService.GetPositions();

            // Load checkboxes
            var maxBottom = 0;
            var chkAll = new CheckBox
            {
                Text = Resources.Label_AllOption,
                Font = lblPosition_employee.Font
            };
            chkAll.Click += CheckboxAllChange_employee;
            flpPosition_employee.Controls.Add(chkAll);

            _positions.ForEach(position =>
            {
                var checkbox = new CheckBox
                {
                    Text = position.Name,
                    Font = lblPosition_employee.Font
                };
                checkbox.Click += CheckboxChange_employee;
                flpPosition_employee.Controls.Add(checkbox);
                maxBottom = Math.Max(maxBottom, checkbox.Bottom);
            });

            // Draw dynamic size
            flpPosition_employee.Height = maxBottom + 5;
            pnlPosition_employee.Height = flpPosition_employee.Bottom + 5;
            grbSearch_employee.Height = pnlPosition_employee.Bottom + 5;
        }

        private void ResetButtons_Employee()
        {
            btnEdit_employee.Enabled = false;
            btnCreateAccount_employee.Enabled = false;
            btnRemoveAccount_employee.Enabled = false;
            btnRemoveEmployee_employee.Enabled = false;
        }

        public void LoadData_Employee(List<User> cache = null)
        {
            lvwEmployee_employee.Items.Clear();

            if (cache == null)
            {
                _employeeList_employee = EmployeeService.GetAllEmployees();
                cache = _employeeList_employee;
            }

            cache.ForEach(employee =>
                {
                    var row = new ListViewItem(employee.Id.ToString());
                    row.SubItems.Add(employee.Name);
                    row.SubItems.Add(employee.Position.Name);
                    row.SubItems.Add(employee.Address);
                    row.SubItems.Add(employee.Account);
                    row.SubItems.Add(employee.IsMale ? "Nam" : "Nữ");
                    row.SubItems.Add(employee.Dob.ToString(Resources.Format_DateFormat));
                    lvwEmployee_employee.Items.Add(row);
                }
            );
        }

        private void ShowInformation_Employee()
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            var employee = _employeeList_employee[lvwEmployee_employee.SelectedIndices[0]];
            var editable = User.Permissions.Contains(Resources.Permission_EditAccountInformation);
            var mode = editable ? Enum.FormMode.Write : Enum.FormMode.Read;

            lvwEmployee_employee.SelectedItems.Clear();

            new fEmployee(this, mode, employee).Show();
        }

        private void Search_Employee()
        {
            var name = txtName_employee.Text;
            var account = txtAccount_employee.Text;
            var address = txtAddress_employee.Text;
            var phone = txtPhone_employee.Text;
            var gender = Helper.Control.Filter.GetRadioButtons(pnlGender_employee)
               .FirstOrDefault(x => x.Checked)?.Text;
            var positions = Helper.Control.Filter.GetCheckBoxes(flpPosition_employee)
               .Where(x => x.Checked)
               .Select(x => x.Text);

            var employees = _employeeList_employee.FindAll(x =>
            {
                var matchName = Helper.Matcher.Match(x.Name, name);
                var matchAccount = Helper.Matcher.Match(x.Account, account, false);
                var matchAddress = Helper.Matcher.Match(x.Address, address);
                var matchPhone = Helper.Matcher.Match(x.PhoneNumber, phone);
                var matchGender = gender == "Tất cả" || (gender == "Nam" && x.IsMale) || (gender == "Nữ" && !x.IsMale);
                var matchPosition = positions.Contains(x.Position.Name);

                return matchName && matchAccount && matchAddress && matchPhone && matchGender && matchPosition;
            });

            LoadData_Employee(employees);
        }

        private void EditEmployee_employee()
        {
            var employee = Helper.Control.FirstSelected(_employeeList_employee, lvwEmployee_employee);
            if (employee != null)
                new fEmployee(this, Enum.FormMode.Write, employee, true).Show();
        }

        private void CreateAccount_employee()
        {
            var selectedIndices = lvwEmployee_employee.SelectedIndices;
            var firstIndex = selectedIndices[0];
            var firstEmployee = _employeeList_employee[firstIndex];
            if (string.IsNullOrEmpty(firstEmployee.Account))
                new fCreateAccount(this, firstEmployee).ShowDialog();
        }

        private void TryDeleteAccount_employee()
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            if (lvwEmployee_employee.SelectedIndices.Count == 1)
            {
                var firstIndex = lvwEmployee_employee.SelectedIndices[0];
                if (_employeeList_employee[firstIndex].Equals(_user))
                {
                    MessageBox.Show(
                        Resources.MessageBox_Message_CannotSelfDeleteAccount,
                        Resources.MessageBox_Caption_Notification,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }
            }

            var shouldDeleteAccounts = lvwEmployee_employee.SelectedIndices.Cast<int>()
               .Select(x => _employeeList_employee[x].Account)
               .Where(account => !string.IsNullOrEmpty(account) && account != _user.Account)
               .ToList();

            if (ConfirmDeleteAccount_employee(shouldDeleteAccounts))
                DeleteAccount_employee(shouldDeleteAccounts);
        }

        private static bool ConfirmDeleteAccount_employee(IEnumerable<string> shouldDeleteAccounts)
        {
            var shouldDeleteStr = string.Join(", ", shouldDeleteAccounts);
            return MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_ConfirmDeleteAccount, shouldDeleteStr),
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) == DialogResult.Yes;
        }

        private void DeleteAccount_employee(List<string> shouldDeleteAccounts)
        {
            if (AccountService.DeleteAccount(shouldDeleteAccounts))
            {
                MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_DeleteAccountSuccessfully, shouldDeleteAccounts.Count),
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            LoadData_Employee();
        }

        private void TryDeleteEmployee_employee()
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            if (lvwEmployee_employee.SelectedIndices.Count == 1)
            {
                var firstIndex = lvwEmployee_employee.SelectedIndices[0];
                if (_employeeList_employee[firstIndex].Equals(_user))
                {
                    MessageBox.Show(
                        Resources.MessageBox_Message_CannotSelfDeleteAccount,
                        Resources.MessageBox_Caption_Notification,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }
            }

            var shouldDeleteEmployees = lvwEmployee_employee.SelectedIndices.Cast<int>()
               .Select(x => _employeeList_employee[x])
               .Where(employee => !employee.Equals(_user))
               .ToList();

            if (ConfirmDeleteEmployee_employee(shouldDeleteEmployees))
                DeleteEmployee_employee(shouldDeleteEmployees);
        }

        private static bool ConfirmDeleteEmployee_employee(IEnumerable<User> shouldDeleteEmployees)
        {
            var shouldDeleteName = shouldDeleteEmployees.Select(x => x.Name);
            var shouldDeleteStr = string.Join(", ", shouldDeleteName);
            return MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_ConfirmDeleteEmployee, shouldDeleteStr),
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) == DialogResult.Yes;
        }

        private void DeleteEmployee_employee(List<User> shouldDeleteEmployees)
        {
            if (EmployeeService.DeleteEmployee(shouldDeleteEmployees))
            {
                MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_DeleteAccountSuccessfully, shouldDeleteEmployees.Count),
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            LoadData_Employee();
        }

        #endregion

        #endregion

        #region UserSettings
        #region UserSettings Events

        private void btnCreateAccount_userSetting_Click(object sender, EventArgs e)
        {
            new fAddEmployee().ShowDialog();
        }

        private void btnChangeInformation_userSetting_Click(object sender, EventArgs e)
        {
            new fChangeInformation(this).ShowDialog();
        }
        private void btnResetPassword_userSetting_Click(object sender, EventArgs e)
        {
            new fResetPassword(User).ShowDialog();
        }






        #endregion

        #endregion
    }
}
