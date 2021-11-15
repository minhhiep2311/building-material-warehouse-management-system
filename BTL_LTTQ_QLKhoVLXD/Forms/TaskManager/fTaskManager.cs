using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.AddEmployee;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation;
using BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount;
using BTL_LTTQ_QLKhoVLXD.Forms.Employee;
using BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using SortOrder = System.Data.SqlClient.SortOrder;

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

        private static readonly string UpArrow = $"{Resources.Character_ArrowUp}    ";
        private static readonly string DownArrow = $"{Resources.Character_ArrowDown}    ";

        #endregion

        #region Form Events

        private void fTaskManager_Load(object sender, EventArgs e)
        {
            DisplayComponentsAccordsPermission();

            new Thread(() =>
            {
                Init_Supplier();
                LoadData_Supplier();
            }).Start();
            new Thread(() =>
            {
                Init_Employee();
                LoadData_Employee();
            }).Start();
        }

        private void tctlControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // No draw selected border
            var selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            e = new DrawItemEventArgs(
                e.Graphics,
                e.Font,
                e.Bounds,
                e.Index,
                e.State ^ DrawItemState.Selected,
                e.ForeColor,
                selected ? Color.White : Color.FromArgb(48, 128, 189));


            e.DrawBackground();

            // Draw Text
            var g = e.Graphics;
            var text = tctlControl.TabPages[e.Index].Text;
            var textSize = g.MeasureString(text, tctlControl.Font);

            var x = e.Bounds.Left + 10;
            var y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            g.DrawString(text, tctlControl.Font, selected ? Brushes.Navy : Brushes.White, x, y);
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

        #region Form Methods
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

        private static void HandleChangeIdColumnWidth(ColumnWidthChangingEventArgs e)
        {
            // ID column
            if (e.ColumnIndex != 0)
                return;

            e.NewWidth = 0;
            e.Cancel = true;
        }

        #endregion

        #endregion

        #region Material

        #region Material Events

        private void tpgMaterial_Enter(object sender, EventArgs e)
        {
            LoadMaterialData();
        }

        #endregion

        #region Material Methods

        private void LoadMaterialData()
        {
            dgvMaterial_material.DataSource = MaterialService.GetAll();
            ConfigMaterialTable();
        }

        private void ConfigMaterialTable()
        {
            dgvMaterial_material.Columns[0].Width = 40;
            dgvMaterial_material.Columns[1].Width = 200;
            dgvMaterial_material.Columns[2].Width = 150;
            dgvMaterial_material.Columns[3].Width = 150;
            dgvMaterial_material.Columns[4].Width = 120;
            dgvMaterial_material.Columns[5].Width = 150;
        }

        #endregion

        #endregion

        #region Supplier

        #region Supplier Properties

        private Helper.Debounce _debounce_supplier;
        private List<Supplier> _supplierList_supplier;

        #endregion

        #region Supplier Events

        private void tpgSupplier_Enter(object sender, EventArgs e)
        {
            Reset_Supplier();
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

        private void lvwSupplier_supplier_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var sorter = (Helper.ItemComparer)lvwSupplier_supplier.ListViewItemSorter;
            if (sorter == null)
            {
                sorter = new Helper.ItemComparer(e.Column)
                {
                    Order = SortOrder.Ascending
                };
                lvwSupplier_supplier.ListViewItemSorter = sorter;
            }

            if (e.Column == sorter.Column)
                sorter.Order = 1 - sorter.Order;
            else
            {
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            lvwSupplier_supplier.Sort();
            DrawArrow_Supplier(e.Column, sorter.Order);
        }

        private void lvwSupplier_supplier_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            HandleChangeIdColumnWidth(e);
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

        }

        private void btnEdit_supplier_Click(object sender, EventArgs e)
        {

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

        #region Supplier Methods
        private void Init_Supplier()
        {
            _debounce_supplier = new Helper.Debounce(Search_Supplier, 300);

            lvwSupplier_supplier.Columns.Add("ID", 0);
            lvwSupplier_supplier.Columns.Add("Tên NCC", 300, HorizontalAlignment.Left);
            lvwSupplier_supplier.Columns.Add("Địa chỉ", 150, HorizontalAlignment.Left);
        }

        public void LoadData_Supplier(List<Supplier> cache = null)
        {
            lvwSupplier_supplier.Items.Clear();

            if (cache == null)
            {
                _supplierList_supplier = SupplierService.GetAllSuppliers();
                cache = _supplierList_supplier;
            }

            cache.ForEach(supplier =>
                {
                    var row = new ListViewItem(supplier.Id.ToString());
                    row.SubItems.Add(supplier.Name);
                    row.SubItems.Add(supplier.Address);
                    lvwSupplier_supplier.Items.Add(row);
                }
            );
        }

        private void Reset_Supplier()
        {
            txtName_supplier.Text = string.Empty;
            txtPhone_supplier.Text = string.Empty;
            txtAddress_supplier.Text = string.Empty;
            ResetButtons_Supplier();
        }

        private void ResetButtons_Supplier()
        {
            btnEdit_supplier.Enabled = false;
            btnDelete_supplier.Enabled = false;
        }

        private void DrawArrow_Supplier(int colIdx, SortOrder order)
        {
            foreach (ColumnHeader column in lvwSupplier_supplier.Columns)
            {
                if (column.Text.Contains(UpArrow))
                    column.Text = column.Text.Replace(UpArrow, string.Empty);
                else if (column.Text.Contains(DownArrow))
                    column.Text = column.Text.Replace(DownArrow, string.Empty);
            }

            lvwSupplier_supplier.Columns[colIdx].Text =
                lvwSupplier_supplier.Columns[colIdx].Text.Insert(0,
                    order == SortOrder.Ascending
                        ? DownArrow
                        : UpArrow
                );
        }

        private void Search_Supplier()
        {
            var name = txtName_supplier.Text;
            var address = txtAddress_supplier.Text;
            var phone = txtPhone_supplier.Text;

            var suppliers = _supplierList_supplier.FindAll(x =>
            {
                var matchName = string.IsNullOrEmpty(name) ||
                    Helper.Normalize.ToLatinText(x.Name).ToLower()
                       .Contains(Helper.Normalize.ToLatinText(name).ToLower());
                var matchAddress = string.IsNullOrEmpty(address) ||
                    Helper.Normalize.ToLatinText(x.Address).ToLower()
                       .Contains(Helper.Normalize.ToLatinText(address).ToLower());
                var matchPhone = string.IsNullOrEmpty(phone) ||
                    x.PhoneNumber.FirstOrDefault(p => Helper.Normalize.ToNumericPhoneNumber(p)
                       .Contains(Helper.Normalize.ToNumericPhoneNumber(phone)))
                    != null;

                return matchName && matchAddress && matchPhone;
            });

            LoadData_Supplier(suppliers);
        }

        private void ShowInformation_Supplier()
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            var supplier = _supplierList_supplier[lvwSupplier_supplier.SelectedIndices[0]];
            var editable = User.Permissions.Contains(Resources.Permission_EditSupplierInformation);
            var mode = editable ? fEmployee.Mode.Write : fEmployee.Mode.Read;

            lvwEmployee_employee.SelectedItems.Clear();

            //new fEmployee(this, mode, supplier).Show();
        }

        private void TryDeleteSupplier_supplier()
        {
            if (lvwSupplier_supplier.SelectedIndices.Count <= 0)
                return;

            var shouldDeleteSuppliers = lvwSupplier_supplier.SelectedIndices.Cast<int>()
               .Select(x => _supplierList_supplier[x]).ToList();
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
            Reset_Employee();
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

        private void lvwEmployee_employee_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var sorter = (Helper.ItemComparer)lvwEmployee_employee.ListViewItemSorter;
            if (sorter == null)
            {
                sorter = new Helper.ItemComparer(e.Column)
                {
                    Order = SortOrder.Ascending
                };
                lvwEmployee_employee.ListViewItemSorter = sorter;
            }

            if (e.Column == sorter.Column)
                sorter.Order = 1 - sorter.Order;
            else
            {
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            lvwEmployee_employee.Sort();
            DrawArrow_Employee(e.Column, sorter.Order);
        }

        private void lvwEmployee_employee_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            HandleChangeIdColumnWidth(e);
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
            var checkboxes = Helper.ControlFilter.GetCheckBoxes(flpPosition_employee);
            var shouldChecked = checkboxes[0].Checked;
            foreach (var checkBox in checkboxes.Skip(1))
                checkBox.Checked = shouldChecked;
            _debounce_employee.HandleUpdate();
        }

        private void CheckboxChange_employee(object sender, EventArgs e)
        {
            var checkboxes = Helper.ControlFilter.GetCheckBoxes(flpPosition_employee);
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

        #region Employee Methods

        private void Init_Employee()
        {
            _debounce_employee = new Helper.Debounce(Search_Employee, 300);

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
            pnlPosition_employee.Height = flpPosition_employee.Bottom;
            grbSearch_employee.Height = pnlPosition_employee.Bottom + 5;
        }

        private void Reset_Employee()
        {
            txtName_employee.Text = string.Empty;
            txtAddress_employee.Text = string.Empty;
            txtPhone_employee.Text = string.Empty;
            rdoAll_employee.Checked = true;
            Helper.ControlFilter.GetCheckBoxes(flpPosition_employee).ForEach(x => x.Checked = true);
            ResetButtons_Employee();
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

        private void DrawArrow_Employee(int colIdx, SortOrder order)
        {
            foreach (ColumnHeader column in lvwEmployee_employee.Columns)
            {
                if (column.Text.Contains(UpArrow))
                    column.Text = column.Text.Replace(UpArrow, string.Empty);
                else if (column.Text.Contains(DownArrow))
                    column.Text = column.Text.Replace(DownArrow, string.Empty);
            }

            lvwEmployee_employee.Columns[colIdx].Text =
                lvwEmployee_employee.Columns[colIdx].Text.Insert(0,
                    order == SortOrder.Ascending
                        ? DownArrow
                        : UpArrow
                );
        }

        private void ShowInformation_Employee()
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            var employee = _employeeList_employee[lvwEmployee_employee.SelectedIndices[0]];
            var editable = User.Permissions.Contains(Resources.Permission_EditAccountInformation);
            var mode = editable ? fEmployee.Mode.Write : fEmployee.Mode.Read;

            lvwEmployee_employee.SelectedItems.Clear();

            new fEmployee(this, mode, employee).Show();
        }

        private void Search_Employee()
        {
            var name = txtName_employee.Text;
            var account = txtAccount_employee.Text;
            var address = txtAddress_employee.Text;
            var phone = txtPhone_employee.Text;
            var gender = Helper.ControlFilter.GetRadioButtons(pnlGender_employee)
               .FirstOrDefault(x => x.Checked)?.Text;
            var positions = Helper.ControlFilter.GetCheckBoxes(flpPosition_employee)
               .Where(x => x.Checked)
               .Select(x => x.Text);

            var employees = _employeeList_employee.FindAll(x =>
            {
                var matchName = string.IsNullOrEmpty(name) ||
                    Helper.Normalize.ToLatinText(x.Name).ToLower()
                       .Contains(Helper.Normalize.ToLatinText(name).ToLower());
                var matchAccount = string.IsNullOrEmpty(account) ||
                    x.Account.ToLower()
                       .Contains(account.ToLower());
                var matchAddress = string.IsNullOrEmpty(address) ||
                    Helper.Normalize.ToLatinText(x.Address).ToLower()
                       .Contains(Helper.Normalize.ToLatinText(address).ToLower());
                var matchPhone = string.IsNullOrEmpty(phone) ||
                    x.PhoneNumber.FirstOrDefault(p => Helper.Normalize.ToNumericPhoneNumber(p)
                       .Contains(Helper.Normalize.ToNumericPhoneNumber(phone)))
                    != null;
                var matchGender = gender == "Tất cả" || (gender == "Nam" && x.IsMale) || (gender == "Nữ" && !x.IsMale);
                var matchPosition = positions.Contains(x.Position.Name);

                return matchName && matchAccount && matchAddress && matchPhone && matchGender && matchPosition;
            });

            LoadData_Employee(employees);
        }

        private void EditEmployee_employee()
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            // Edit only first selected item
            var firstIndex = lvwEmployee_employee.SelectedIndices[0];
            var employee = _employeeList_employee[firstIndex];
            new fEmployee(this, fEmployee.Mode.Write, employee, true).Show();
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
