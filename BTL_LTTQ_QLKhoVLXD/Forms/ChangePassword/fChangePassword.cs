using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Services;
using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Properties;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ChangePassword
{
    public partial class fChangePassword : Form
    {
        private readonly User _user;

        public fChangePassword(User user)
        {
            InitializeComponent();
            _user = user;
        }

        #region Events

        private void txtOld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryChangePassword();
        }

        private void txtNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryChangePassword();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            txtOld.UseSystemPasswordChar = !txtOld.UseSystemPasswordChar;
            btnOld.Text = txtOld.UseSystemPasswordChar
                ? Resources.Checkbox_ShowPassword
                : Resources.Checkbox_HidePassword;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNew.UseSystemPasswordChar = !txtNew.UseSystemPasswordChar;
            btnNew.Text = txtNew.UseSystemPasswordChar
                ? Resources.Checkbox_ShowPassword
                : Resources.Checkbox_HidePassword;
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
            if (!ValidInput() || !CorrectOldPassword() || !ValidNewPassword() || !ConfirmChange())
                return;

            ChangePassword();
        }

        private bool ValidInput()
        {
            if (txtOld.Text == "")
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterOldPassword,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (txtNew.Text == "")
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterNewPassword,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }

        private bool CorrectOldPassword()
        {
            var accountExists = AccountService.CheckPassword(_user.Account, txtOld.Text);
            if (!accountExists)
                MessageBox.Show(
                    Resources.MessageBox_Message_WrongOldPassword,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            return accountExists;
        }

        private bool ValidNewPassword()
        {
            if (txtOld.Text != txtNew.Text)
                return true;

            MessageBox.Show(
                Resources.MessageBox_Message_DuplicatePassword,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return false;
        }

        private static bool ConfirmChange()
        {
            return MessageBox.Show(
                Resources.MessageBox_Message_ConfirmChangePassword,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private void ChangePassword()
        {
            var changeSuccessfully = AccountService.ChangePassword(_user.Account, txtNew.Text);
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