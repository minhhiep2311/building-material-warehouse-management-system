﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        #endregion

        #region Employee Properties

        private List<User> _employeeList_employee;
        private Helper.Debounce _debounce_employee;

        #endregion

        public fTaskManager(User user)
        {
            InitializeComponent();
            User = user;
        }

        #region Form
        #region Form Events

        private void fTaskManager_Load(object sender, EventArgs e)
        {
            DisplayComponentsAccordsPermission();
            Init_Employee();
        }

        private void tctlControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // No draw selected border
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(
                    e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    Color.YellowGreen
                );

            e.DrawBackground();

            // Draw Text
            var g = e.Graphics;
            var text = tctlControl.TabPages[e.Index].Text;
            var textSize = g.MeasureString(text, tctlControl.Font);

            var x = e.Bounds.Left + 10;
            var y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            g.DrawString(text, tctlControl.Font, Brushes.Black, x, y);
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

        #endregion

        #region Form Methods
        private void DisplayComponentsAccordsPermission()
        {
            if (!PermissionConstant.CreateAccount.Contains(User.Position.Id))
                btnCreateAccount_userSetting.Visible = false;
            if (!PermissionConstant.ResetPassword.Contains(User.Position.Id))
                btnResetPassword_userSetting.Visible = false;
            if (!PermissionConstant.AddEmployee.Contains(User.Position.Id))
                btnAdd_employee.Visible = false;
            if (!PermissionConstant.EditAccountInformation.Contains(User.Position.Id))
                btnEdit_employee.Visible = false;
            if (!PermissionConstant.DeleteAccount.Contains(User.Position.Id))
                btnRemoveAccount_employee.Visible = false;
            if (!PermissionConstant.DeleteEmployee.Contains(User.Position.Id))
                btnRemoveEmployee_employee.Visible = false;
        }

        private void DisplayUserInfo()
        {
            lblUser.Text = string.Format(Resources.TaskManager_Label_User, User.Name);
            lblPosition.Text = string.Format(Resources.TaskManager_Label_Position, User.Position);
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

        #region Employee
        #region Employee Events

        private void tpgEmployee_Enter(object sender, EventArgs e)
        {
            Reset_Employee();
            LoadData_Employee();
            _debounce_employee?.Continue();
        }
        private void tpgEmployee_Leave(object sender, EventArgs e)
        {
            _debounce_employee.Pause();
        }

        private void lvwEmployee_employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
                return;

            var employee = _employeeList_employee[lvwEmployee_employee.SelectedIndices[0]];
            var editable = PermissionConstant.EditAccountInformation.Contains(User.Position.Id);
            var mode = editable ? fEmployee.Mode.Write : fEmployee.Mode.Read;
            new fEmployee(this, mode, employee).Show();
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
            // ID column
            if (e.ColumnIndex != 0)
                return;

            e.NewWidth = 0;
            e.Cancel = true;
        }

        private void lvwEmployee_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEmployee_employee.SelectedIndices.Count <= 0)
            {
                ResetButtons_Employee();
            }
            else
            {
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
            var selectedIndices = lvwEmployee_employee.SelectedIndices;
            var firstIndex = selectedIndices[0];
            var firstEmployee = _employeeList_employee[firstIndex];
            if (string.IsNullOrEmpty(firstEmployee.Account))
            {
                new fCreateAccount(this, firstEmployee).ShowDialog();
            }
        }

        private void btnRemoveAccount_employee_Click(object sender, EventArgs e)
        {
            TryDeleteAccount_employee();
        }

        private void btnRemoveEmployee_employee_Click(object sender, EventArgs e)
        {
            TryDeleteEmployee_employee();
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
            var upArrow = $"{Resources.Character_ArrowUp}    ";
            var downArrow = $"{Resources.Character_ArrowDown}    ";

            foreach (ColumnHeader column in lvwEmployee_employee.Columns)
            {
                if (column.Text.Contains(upArrow))
                    column.Text = column.Text.Replace(upArrow, string.Empty);
                else if (column.Text.Contains(downArrow))
                    column.Text = column.Text.Replace(downArrow, string.Empty);
            }

            lvwEmployee_employee.Columns[colIdx].Text =
                lvwEmployee_employee.Columns[colIdx].Text.Insert(0,
                    order == SortOrder.Ascending
                        ? downArrow
                        : upArrow
                );
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
                    MessageBoxIcon.Information
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
                    MessageBoxIcon.Information
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
