using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangePassword;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation
{
    public partial class fChangeInformation : Form
    {
        private readonly User _user;

        public fChangeInformation(User user)
        {
            InitializeComponent();
            _user = user;
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
            {
                lvwPhone.Items.Add(new ListViewItem(phone));
            });
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            var item = lvwPhone.Items.Add("");
            item.BeginEdit();
        }

        private void btnModifyPhone_Click(object sender, EventArgs e)
        {
            lvwPhone.SelectedItems[0].BeginEdit();
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwPhone.SelectedItems)
                lvwPhone.Items.Remove(item);
        }

        private void lvwPhone_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Label))
                lvwPhone.Items.RemoveAt(e.Item);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new fChangePassword(_user).ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TryChangePassword();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void TryChangePassword()
        {
            if (_user.Equals(new User(
                _user.Name,
                txtAddress.Text,
                _user.IsMale,
                _user.Dob,
                _user.Position,
                _user.Account
            )))
            {
                Close();
            }

            if (!ValidInput() || !ConfirmChange())
                return;

            ChangeInformation();
        }

        private bool ValidInput()
        {
            if (txtAddress.Text != "") return true;

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

        private void ChangeInformation()
        {
            var changeSuccessfully = true;
            if (changeSuccessfully)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_ChangeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            else
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        #endregion
    }
}