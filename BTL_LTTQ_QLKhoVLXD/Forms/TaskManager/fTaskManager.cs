﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.AddEmployee;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation;
using BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount;
using BTL_LTTQ_QLKhoVLXD.Forms.Employee;
using BTL_LTTQ_QLKhoVLXD.Forms.Customer;
using BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword;
using BTL_LTTQ_QLKhoVLXD.Forms.Supplier;
using BTL_LTTQ_QLKhoVLXD.Forms.Material;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using FormMode = BTL_LTTQ_QLKhoVLXD.Utils.Enum.FormMode;


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
        private List<Models.Material> _materials = new List<Models.Material>();

        #endregion

        #region Form Events

        private void fTaskManager_Load(object sender, EventArgs e)
        {
            DisplayComponentsAccordsPermission();
            Init_Buy();

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
            if (!User.Permissions.Contains(Resources.Permission_DeleteEmployee))
                btnRemoveEmployee_employee.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_EditSupplierInformation))
                btnEdit_supplier.Visible = false;
            if (!User.Permissions.Contains(Resources.Permission_DeleteSupplier))
                btnDelete_supplier.Visible = false;
        }

        private void DisplayUserInfo()
        {
            lblUser.Text = string.Format(Resources.TaskManager_Label_User, User.Name);
            lblPosition.Text = string.Format(Resources.TaskManager_Label_Position, User.Position);
        }

        #endregion

        #endregion

        #region Buy

        #region Buy Properties

        private List<Models.Material> _items_buy = new List<Models.Material>();

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
            lblAddress_Buy.Focus();
        }

        private void btnAddSupplier_buy_Click(object sender, EventArgs e)
        {
            new fSupplier(this).ShowDialog();
        }

        private void cboItem_buy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryEnableAddItem_Buy();
            if (!(cboItem_buy.SelectedItem is Models.Material selectedItem))
                return;

            txtSpecializtion_buy.Text = selectedItem.Specialization;
            nmrUnitPrice_buy.Value = Convert.ToDecimal(selectedItem.ImportUnitPrice);
            nmrMaterialAmount_Buy.Value = Convert.ToInt32(selectedItem.Numerous);
            lblSpecialization_buy.Focus();
        }

        private void btnAddMaterial_buy_Click(object sender, EventArgs e)
        {
            lvwSupplier_supplier.SelectedItems.Clear();
            new fSupplier(this).ShowDialog();
        }

        private void nmrMaterialAmount_Buy_ValueChanged(object sender, EventArgs e)
        {
            TryEnableAddItem_Buy();
        }

        private void btnAddItem_buy_Click(object sender, EventArgs e)
        {
            var material = (cboItem_buy.SelectedItem as Models.Material)?.Clone();
            if (material == null)
                return;

            material.ImportUnitPrice = Convert.ToDouble(nmrUnitPrice_buy.Value);
            material.Numerous = Convert.ToInt32(nmrMaterialAmount_Buy.Value);

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

            CalculateTotal_Buy();
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

        }

        private void btnPrintReceipt_Buy_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_buy_Click(object sender, EventArgs e)
        {
            lvwItem_buy.Items.Clear();
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
            cboItem_buy.DataSource = _materials;
            cboItem_buy.SelectedIndex = -1;
            nmrUnitPrice_buy.Value = 0;
        }

        private void TryEnableAddItem_Buy()
        {
            btnAddItem_buy.Enabled = cboItem_buy.SelectedIndex != -1 &&
                nmrMaterialAmount_Buy.Value != 0;
        }

        private void TryDeleteItem_Buy()
        {
            if (lvwItem_buy.SelectedIndices.Count <= 0)
                return;

            var shouldDeleteItemIds = lvwItem_buy.SelectedIndices.Cast<int>().ToList();
            var shouldDeleteSupplierNames = shouldDeleteItemIds.Select(x => _items_buy[x].Name);

            if (ConfirmDeleteItem_buy(shouldDeleteSupplierNames))
                DeleteItem_buy(shouldDeleteItemIds);
        }

        private static bool ConfirmDeleteItem_buy(IEnumerable<string> shouldDeleteSupplierNames)
        {
            var shouldDeleteStr = string.Join(", ", shouldDeleteSupplierNames);
            return MessageBox.Show(
                string.Format(Resources.MessageBox_Message_ConfirmDeleteItemFromImport, shouldDeleteStr),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private void DeleteItem_buy(List<int> shouldDeleteItemIds)
        {
            shouldDeleteItemIds.ForEach(idx =>
            {
                _items_buy.RemoveAt(idx);
                lvwItem_buy.Items.RemoveAt(idx);
            });

            CalculateTotal_Buy();
        }

        private void CalculateTotal_Buy()
        {
            var sum = _items_buy.Select(x => x.ImportUnitPrice * x.Numerous).Sum(x => x);
            txtTotalMoney_Buy.Text = Helper.Format.String(sum);
        }

        #endregion

        #endregion

        #region Sell

        private void txtCustomerName_sell_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Material
        #region Material Properties

        #endregion

        #region Material Events

        private void tpgMaterial_Enter(object sender, EventArgs e)
        {
            LoadData_Material();
        }
        private void btnAdd_Material_Click(object sender, EventArgs e)
        {
            lvwSupplier_supplier.SelectedItems.Clear();
            new fMaterial(this).ShowDialog();
        }

        private void btnEdit_Material_Click(object sender, EventArgs e)
        {
            EditMaterial_material();
        }
        private void btnDelete_Material_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Material_Click(object sender, EventArgs e)
        {

        }

        private void btnRefersh_Material_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Material Behaviors

        private void Init_Material()
        {
            lvwMaterial_material.Columns.Add("ID", 0);
            lvwMaterial_material.Columns.Add("Tên vật liệu", 300, HorizontalAlignment.Left);
            lvwMaterial_material.Columns.Add("Đơn giá nhập", 150, HorizontalAlignment.Left);
            lvwMaterial_material.Columns.Add("Đơn giá xuật", 150, HorizontalAlignment.Left);
            lvwMaterial_material.Columns.Add("Đơn vị", 150, HorizontalAlignment.Left);
            lvwMaterial_material.Columns.Add("Quy cách", 150, HorizontalAlignment.Left);
        }

        public void LoadData_Material(List<Models.Material> cache = null)
        {

            lvwMaterial_material.Items.Clear();

            if (cache == null)
            {
                _materials = MaterialService.GetAllMaterials();
                cache = _materials;
                cboItem_buy.DataSource = _materials;
            }

            // TODO 
            //cache.ForEach(material => lvwMaterial_material.Items.Add(material.ToListViewItem(FormMode.)));
        }

        private void EditMaterial_material()
        {
            /*var material = Helper.Control.FirstSelected(, lvwMaterial_material);
            if (material != null)
                new fMaterial(this, FormMode.Write, material , true).Show();*/
        }

        #endregion

        #endregion

        #region Customer

        #region Customer Properties

        private Helper.Debounce _debounce_customer;
        private List<Models.Customer> _customerList_customer;

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
            new fCustomer(this).ShowDialog();
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
                _customerList_customer = CustomerService.GetAllCustomers();
                cache = _customerList_customer;
            }

            cache.ForEach(supplier =>
                {
                    var row = new ListViewItem(supplier.Id.ToString());
                    row.SubItems.Add(supplier.Name);
                    row.SubItems.Add(supplier.Address);
                    lvwCustomer_customer.Items.Add(row);
                }
            );
        }

        private void Search_Customer()
        {
            var name = txtName_customer.Text;
            var address = txtAddress_customer.Text;
            var phone = txtPhone_customer.Text;

            var customers = _customerList_customer.FindAll(x =>
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
            var customer = Helper.Control.FirstSelected(_customerList_customer, lvwCustomer_customer);
            if (customer != null)
                new fCustomer(this, FormMode.Write, customer, true).Show();

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
            if (e.Button != MouseButtons.Right)
                return;

            var focusItem = lvwSupplier_supplier.FocusedItem;
            if (focusItem == null || !focusItem.Bounds.Contains(e.Location))
                return;

            tsmiShowInformation_supplier.Visible = true;
            tsmiDeleteSupplier_supplier.Visible = User.Permissions.Contains(Resources.Permission_DeleteSupplier);

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
            new fSupplier(this).ShowDialog();
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
                cboSupplier_buy.DataSource = _suppliers;
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
            var mode = editable ? FormMode.Write : FormMode.Read;

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
                new fSupplier(this, FormMode.Write, supplier, true).Show();
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
            if (e.Button != MouseButtons.Right)
                return;

            var focusItem = lvwEmployee_employee.FocusedItem;
            if (focusItem == null || !focusItem.Bounds.Contains(e.Location))
                return;

            tsmiShowInformation_employee.Visible = true;
            tsmiCreateAccount_employee.Visible = User.Permissions.Contains(Resources.Permission_CreateAccount);
            tsmiDeleteAccount_employee.Visible = User.Permissions.Contains(Resources.Permission_DeleteAccount);

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
            var mode = editable ? FormMode.Write : FormMode.Read;

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
                new fEmployee(this, FormMode.Write, employee, true).Show();
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
