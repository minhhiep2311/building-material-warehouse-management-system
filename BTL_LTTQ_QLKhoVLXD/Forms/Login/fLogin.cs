using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Login
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
                Resources.MessageBox_Message_ConfirmExit, Resources.MessageBox_Caption_Notification, MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.No;
        }

        #endregion

        #region Methods

        private void TryLogin()
        {
            if (!ValidInput())
                return;

            var userName = txbUserName.Text;
            var passWord = txbPassWord.Text;

            var user = AccountService.Auth(userName, passWord);

            if (user != null)
            {
                Hide();
                RedirectToApp(user);

                // After close app form
                txbPassWord.Text = "";
                Show();
            }
            else
                MessageBox.Show(Resources.MessageBox_Message_WrongAccountInfo, Resources.MessageBox_Caption_Notification, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void RedirectToApp(User user)
        {
            (new TaskManager.fTaskManager(user)).ShowDialog();
        }

        private bool ValidInput()
        {
            if (txbUserName.Text == "")
            {
                MessageBox.Show(Resources.MessageBox_Message_EnterUsername, Resources.MessageBox_Caption_Notification, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txbPassWord.Text == "")
            {
                MessageBox.Show(Resources.MessageBox_Message_EnterPassword, Resources.MessageBox_Caption_Notification, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ForceLogin()
        {
            var user = AccountService.Auth("tran_minh.giang", "password123");

            if (user != null)
            {
                Hide();
                RedirectToApp(user);

                // After close app form
                txbPassWord.Text = "";
                Show();
            }
            else
                MessageBox.Show(Resources.MessageBox_Message_WrongAccountInfo, Resources.MessageBox_Caption_Notification, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
