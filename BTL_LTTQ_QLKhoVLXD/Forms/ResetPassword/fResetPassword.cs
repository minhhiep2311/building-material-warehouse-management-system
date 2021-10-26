using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Services;
using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Properties;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword
{
    public partial class fResetPassword : Form
    {
        private readonly User _user;

        public fResetPassword(User user)
        {
            InitializeComponent();
            _user = user;
        }

        #region Events

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryReset();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryReset();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TryReset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void TryReset()
        {
            if (!ValidInput() || !ValidAccount() || !ConfirmChange())
                return;

            Reset();
        }

        private bool ValidInput()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterUsername,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            if (txtPassword.Text == "")
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

        private bool ValidAccount()
        {
            var username = txtUsername.Text;

            if (username == _user.Account)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_CannotSelfResetPassword,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            if (!AccountService.CheckAccountExists(username))
            {
                MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_AccountNotExist, username), 
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }

        private bool ConfirmChange()
        {
            return MessageBox.Show(
                string.Format(Resources.MessageBox_Message_ConfirmResetPassword, txtUsername.Text),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private void Reset()
        {
            if (AccountService.ChangePassword(txtUsername.Text, txtPassword.Text))
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
