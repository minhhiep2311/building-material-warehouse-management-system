using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        #region Events

        private void chkShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            txbPassWord.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ForceLogin();
            //TryLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryLogin();
        }

        private void txbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryLogin();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                    "Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.No;
        }

        #endregion

        #region Methods

        private void TryLogin()
        {
            if (!ValidInput())
                return;

            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            User user = AccountService.Auth(userName, passWord);

            if (user != null)
            {
                Hide();
                RedirectToApp(user);

                // After close app form
                txbPassWord.Text = "";
                Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RedirectToApp(User user)
        {
            fTaskManager fTM = new fTaskManager(user);
            fTM.ShowDialog();
        }

        private bool ValidInput()
        {
            if (txbUserName.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txbPassWord.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ForceLogin()
        {
            fTaskManager fTM = new fTaskManager(new User("Trần Minh Giang", "Quản lý", "tran_minh.giang"));

            Hide();
            fTM.ShowDialog();

            txbPassWord.Text = "";
            Show();
        }

        #endregion
    }
}
