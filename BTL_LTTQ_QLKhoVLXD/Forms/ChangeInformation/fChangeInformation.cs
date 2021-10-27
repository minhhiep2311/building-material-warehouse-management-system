using System;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangePassword;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation
{
    public partial class fChangeInformation : Form
    {
        private readonly User _user;
        private readonly fTaskManager _parentForm;
        private string _previousLabelValue = "";

        public fChangeInformation(fTaskManager parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _user = parentForm.User;
        }

        #region Events
        private void fChangeInformation_Load(object sender, EventArgs e)
        {
            txtName.Text = _user.Name;
            txtDob.Text = _user.Dob.ToShortDateString();
            if (_user.IsMale)
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;
            txtAddress.Text = _user.Address;
            lvwPhone.Columns.Add("SDT", -2, HorizontalAlignment.Left);
            _user.PhoneNumber.ForEach(phone =>
                lvwPhone.Items.Add(new ListViewItem(phone))
            );
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            var item = lvwPhone.Items.Add("");
            item.BeginEdit();
        }

        private void btnModifyPhone_Click(object sender, EventArgs e)
        {
            if (lvwPhone.SelectedItems.Count > 0)
                lvwPhone.SelectedItems[0].BeginEdit();
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwPhone.SelectedItems)
                lvwPhone.Items.Remove(item);
        }

        private void lvwPhone_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            _previousLabelValue = lvwPhone.Items[e.Item].Text;
        }

        private void lvwPhone_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Label))
            {
                e.CancelEdit = true;
                if (string.IsNullOrEmpty(_previousLabelValue))
                    lvwPhone.Items.RemoveAt(e.Item);
                else
                {
                    e.CancelEdit = true;
                    lvwPhone.Items[e.Item].Text = _previousLabelValue;
                }
            }
            else if (!Helper.RegexValidate.PhoneNumber(e.Label))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_InvalidPhoneNumberFormat,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                e.CancelEdit = true;
                if (string.IsNullOrEmpty(_previousLabelValue))
                    lvwPhone.Items.RemoveAt(e.Item);
                else
                    lvwPhone.Items[e.Item].Text = _previousLabelValue;
            }
        }

        private void lvwPhone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwPhone.SelectedItems.Count <= 0)
                return;

            var item = lvwPhone.SelectedItems[0];
            if (item.Bounds.Contains(e.Location))
                item.BeginEdit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new fChangePassword(_user).ShowDialog();
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

        private void TryChangeInformation()
        {
            var newUser = new User(
                _user.Id,
                _user.Name,
                txtAddress.Text,
                _user.IsMale,
                _user.Dob,
                _user.Position,
                _user.Account,
                lvwPhone.Items
                   .Cast<ListViewItem>()
                   .Select(item => item.Text)
                   .ToList()
            );

            if (_user.Equals(newUser))
            {
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

            _parentForm.User = newUser;
            Close();
        }

        private bool ValidInput()
        {
            if (txtAddress.Text != "")
                return true;

            MessageBox.Show(
                Resources.MessageBox_Message_EnterFullPersonalInfo,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return false;
        }

        private static bool ConfirmChange()
        {
            return MessageBox.Show(
                Resources.MessageBox_Message_ConfirmChangeInfo,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool ChangeInformation(User newUser)
        {
            return AccountService.ChangePersonalInformation(newUser);
        }

        private bool ChangePhoneNumber(User newUser)
        {
            var (shouldDelete, shouldAdd) = Helper.List
               .Difference(
                    _user.PhoneNumber,
                    newUser.PhoneNumber
                );

            return AccountService.DeletePhoneNumbers(shouldDelete) &&
                AccountService.AddNewPhoneNumber(_user, shouldAdd);
        }

        #endregion
    }
}