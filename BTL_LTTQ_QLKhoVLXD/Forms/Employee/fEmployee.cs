using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Employee
{
    public partial class fEmployee : Form
    {
        private readonly bool _editable;
        private readonly User _user;
        private readonly fTaskManager _parentForm;

        public fEmployee(User user, bool editable, fTaskManager form)
        {
            InitializeComponent();
            _editable = editable;
            _user = user;
            _parentForm = form;
        }

        #region Events

        private void fEmployee_Load(object sender, EventArgs e)
        {
            InitControls();
            BindData();
            ConfigureAccessibility();
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
            txtName.Text = _user.Name;
            dtpDob.Text = _user.Dob.ToShortDateString();
            if (_user.IsMale)
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;
            txtAddress.Text = _user.Address;
            _user.PhoneNumber.ForEach(phone =>
                lvwPhone.Items.Add(new ListViewItem(phone))
            );
            var positions = EmployeeService.GetPositions();
            cboPosition.DataSource = positions;
            cboPosition.SelectedIndex = positions.FindIndex(x => x.Name.Equals(_user.Position.Name));
        }

        private void ConfigureAccessibility()
        {
            chkEdit.Visible = _editable && !_parentForm.User.Equals(_user);

            if (_editable)
                return;

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
        }
        private void TryChangeInformation()
        {
            var newUser = new User(
                _user.Id,
                txtName.Text,
                txtAddress.Text,
                rdoMale.Checked,
                DateTime.ParseExact(Regex.Replace(dtpDob.Text, @"\s+", ""),
                    Helper.DateTime.DateFormat,
                    CultureInfo.InvariantCulture),
                (EmployeePosition)cboPosition.SelectedItem,
                _user.Account,
                lvwPhone.Items
                   .Cast<ListViewItem>()
                   .Select(item => item.Text)
                   .ToList()
            );

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

            _parentForm.LoadData_Employee();
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

            if (Helper.RegexValidate.Name(txtName.Text))
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

            return EmployeeService.DeletePhoneNumbers(shouldDelete) &&
                EmployeeService.AddNewPhoneNumber(_user, shouldAdd);
        }

        #endregion
    }
}
