using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Services;
using System;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword
{
    public partial class fResetPassword : Form
    {
        private readonly User User;

        public fResetPassword(User user)
        {
            InitializeComponent();
            User = user;
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
                MessageBox.Show("Hãy nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidAccount()
        {
            string username = txtUsername.Text;

            if (username == User.Account)
            {
                MessageBox.Show("Không thể đặt lại mật khẩu cho chính mình! Hãy sử dụng chức năng \"Đổi mật khẩu\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!AccountService.CheckAccountExists(username))
            {
                MessageBox.Show($"Tài khoản {username} không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ConfirmChange()
        {
            return MessageBox.Show(
                $"Mật khảu của tài khoản {txtUsername.Text} sẽ được thay đổi. Vẫn tiếp tục?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.Yes;
        }

        private void Reset()
        {
            if (AccountService.ChangePassword(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Lỗi hệ thống! Hãy thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
