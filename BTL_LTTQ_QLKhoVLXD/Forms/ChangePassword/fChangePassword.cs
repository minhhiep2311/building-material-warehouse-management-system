using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Services;
using System;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ChangePassword
{
    public partial class fChangePassword : Form
    {
        private readonly User User;

        public fChangePassword(User user)
        {
            InitializeComponent();
            User = user;
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
            if (txtOld.UseSystemPasswordChar)
                btnOld.Text = "Hiện mật khẩu";
            else
                btnOld.Text = "Ẩn mật khẩu";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNew.UseSystemPasswordChar = !txtNew.UseSystemPasswordChar;
            if (txtNew.UseSystemPasswordChar)
                btnNew.Text = "Hiện mật khẩu";
            else
                btnNew.Text = "Ẩn mật khẩu";
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
                MessageBox.Show("Hãy nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNew.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CorrectOldPassword()
        {
            bool accountExists = AccountService.CheckPassword(User.Account, txtOld.Text);

            if (!accountExists)
                MessageBox.Show("Mật khảu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return accountExists;
        }

        private bool ValidNewPassword()
        {
            if (txtOld.Text == txtNew.Text)
            {
                MessageBox.Show("Mật khảu mới không được trùng mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ConfirmChange()
        {
            return MessageBox.Show(
                "Mật khảu của bạn sẽ được thay đổi. Vẫn tiếp tục?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.Yes;
        }

        private void ChangePassword()
        {
            bool changeSuccessfully = AccountService.ChangePassword(User.Account, txtNew.Text);
            if (changeSuccessfully)
            {
                MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Lỗi hệ thống! Hãy thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
