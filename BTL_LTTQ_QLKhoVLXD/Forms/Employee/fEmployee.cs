using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using FormMode = BTL_LTTQ_QLKhoVLXD.Utils.Enum.FormMode;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Employee
{
    public partial class fEmployee : Form
    {
        private readonly fTaskManager _parentForm;
        private readonly User _user;
        private readonly FormMode _mode;
        private readonly bool _startEdit;

        public fEmployee(fTaskManager form, FormMode mode = FormMode.Create, User user = null, bool startEdit = false)
        {
            InitializeComponent();
            _mode = mode;
            _user = user;
            _parentForm = form;
            _startEdit = startEdit;
        }

        #region Events

        private void fEmployee_Load(object sender, EventArgs e)
        {
            InitControls();
            BindData();
            ConfigureAccessibility();
        }

        private void fEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm.LoadData_Employee();
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked)
            {
                txtName.ReadOnly = false;
                dtpDob.Enabled = true;
                rdoMale.Enabled = true;
                rdoFemale.Enabled = true;
                txtAddress.ReadOnly = false;
                btnAddPhone.Enabled = true;
                btnModifyPhone.Enabled = true;
                btnRemovePhone.Enabled = true;
            }
            else
            {
                txtName.ReadOnly = true;
                dtpDob.Enabled = false;
                rdoMale.Enabled = false;
                rdoFemale.Enabled = false;
                txtAddress.ReadOnly = true;
                btnAddPhone.Enabled = false;
                btnModifyPhone.Enabled = false;
                btnRemovePhone.Enabled = false;
            }
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            lvwPhone.SelectedItems.Clear();
            var item = lvwPhone.Items.Add("");
            item.BeginEdit();
        }

        private void btnModifyPhone_Click(object sender, EventArgs e)
        {
            if (lvwPhone.SelectedItems.Count <= 0)
                return;

            var selectItem = lvwPhone.SelectedItems[0];
            lvwPhone.SelectedItems.Clear();
            selectItem.BeginEdit();
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwPhone.SelectedItems)
                lvwPhone.Items.Remove(item);
        }

        private void lvwPhone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwPhone.SelectedItems.Count <= 0)
                return;

            var item = lvwPhone.SelectedItems[0];
            if (item.Bounds.Contains(e.Location))
                item.BeginEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == FormMode.Create)
                TryCreate();
            else
                TryChangeInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void InitControls()
        {
            lvwPhone.Columns.Add("SDT", -2, HorizontalAlignment.Left);
        }

        private void BindData()
        {
            var positions = EmployeeService.GetPositions();
            cboPosition.DataSource = positions;
            cboPosition.SelectedIndex = -1;

            if (_mode == FormMode.Create)
                return;

            txtName.Text = _user.Name;
            dtpDob.Text = _user.Dob.ToShortDateString();
            if (_user.IsMale)
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;
            txtAddress.Text = _user.Address;
            _user.PhoneNumber.ForEach(phone =>lvwPhone.Items.Add(new ListViewItem(phone)));
            cboPosition.SelectedIndex = positions.FindIndex(x => x.Name.Equals(_user.Position.Name));
        }

        private void ConfigureAccessibility()
        {
            // Only allow edit if mode is write and user that edited is not himself
            chkEdit.Visible = _mode == FormMode.Write && !_parentForm.User.Equals(_user);

            switch (_mode)
            {
                case FormMode.Write:
                    if (_startEdit)
                        chkEdit.Checked = true;
                    return;
                case FormMode.Create:
                    chkEdit.Checked = true;
                    btnSave.Text = Resources.Form_ButtonSave;
                    Text = Resources.Form_Text_AddNewEmployee;
                    return;
                case FormMode.Read:
                    txtName.ReadOnly = true;
                    dtpDob.Enabled = false;
                    rdoMale.Enabled = false;
                    rdoFemale.Enabled = false;
                    txtAddress.ReadOnly = true;
                    btnAddPhone.Visible = false;
                    btnModifyPhone.Visible = false;
                    btnRemovePhone.Visible = false;
                    btnSave.Visible = false;
                    btnCancel.Visible = false;
                    return;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void TryCreate()
        {
            if (!ValidInput())
                return;

            var name = txtName.Text;
            var address = txtAddress.Text;
            var isMale = rdoMale.Checked;
            var dob = DateTime.ParseExact(Regex.Replace(dtpDob.Text, @"\s+", ""),
                Resources.Format_DateFormat,
                CultureInfo.InvariantCulture);
            var position = (EmployeePosition)cboPosition.SelectedItem;
            var phoneNumbers = lvwPhone.Items
               .Cast<ListViewItem>()
               .Select(item => item.Text)
               .ToList();

            var newUser = new User(name, address, isMale, dob, position, phoneNumbers);

            if (CreateUser(ref newUser) &&
                AddNewPhoneNumbers(phoneNumbers, newUser))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_AddEmployeeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            _parentForm.LoadData_Employee();
            Close();
        }

        private void TryChangeInformation()
        {
            var id = _user.Id;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var isMale = rdoMale.Checked;
            var dob = DateTime.ParseExact(Regex.Replace(dtpDob.Text, @"\s+", ""),
                Resources.Format_DateFormat,
                CultureInfo.InvariantCulture);
            var position = (EmployeePosition)cboPosition.SelectedItem;
            var account = _user.Account;
            var phoneNumbers = lvwPhone.Items
               .Cast<ListViewItem>()
               .Select(item => item.Text)
               .ToList();

            var newUser = new User(id, name, address, isMale, dob, position, account, phoneNumbers);

            if (_user.Equals(newUser))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_ChangeInfoNoChange,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
                return;
            }

            if (!ValidInput() || !ConfirmChange())
                return;

            if (ChangeInformation(newUser) &&
                ChangePhoneNumber(newUser))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_ChangeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            Close();
        }

        private bool ValidInput()
        {
            if (txtName.Text == "" ||
                txtAddress.Text == "")
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterFullPersonalInfo,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (Helper.Validate.Name(txtName.Text))
                return true;

            MessageBox.Show(
                Resources.MessageBox_Message_InvalidNameFormat,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return false;
        }

        private bool ConfirmChange()
        {
            return MessageBox.Show(
                string.Format(Resources.MessageBox_Message_ConfirmChangeEmployeeInfo, _user.Name),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool CreateUser(ref User newUser)
        {
            newUser.Id = EmployeeService.CreateEmployee(newUser);
            return newUser.Id != -1;
        }

        private static bool ChangeInformation(User newUser)
        {
            return EmployeeService.ChangeEmployeeInformation(newUser);
        }

        private bool ChangePhoneNumber(User newUser)
        {
            var (shouldDelete, shouldAdd) = Helper.List
               .Difference(
                    _user.PhoneNumber,
                    newUser.PhoneNumber
                );

            return DeletePhoneNumbers(shouldDelete) && AddNewPhoneNumbers(shouldAdd);
        }

        private static bool DeletePhoneNumbers(List<string> shouldDelete)
        {
            return EmployeeService.DeletePhoneNumbers(shouldDelete);
        }

        private bool AddNewPhoneNumbers(List<string> shouldAdd, User user = null)
        {
            return EmployeeService.AddNewPhoneNumbers(user ?? _user, shouldAdd);
        }

        #endregion
    }
}
