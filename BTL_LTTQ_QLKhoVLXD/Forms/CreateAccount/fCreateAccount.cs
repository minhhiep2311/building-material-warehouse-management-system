using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount
{
    public partial class fCreateAccount : Form
    {
        private readonly User _user;
        private readonly fTaskManager _parentParentForm;

        public fCreateAccount(fTaskManager parentForm, User user)
        {
            InitializeComponent();
            _user = user;
            _parentParentForm = parentForm;
        }

        #region Events

        private void fCreateAccount_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TryCreate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void BindData()
        {
            txtName.Text = _user.Name;
        }

        private void TryCreate()
        {
            if (!ValidInput() || AccountExisted() || !Create())
                return;

            MessageBox.Show(
                Resources.MessageBox_Message_CreateAccountSuccessfully,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            _parentParentForm.LoadData_Employee();
            Close();
        }

        private bool ValidInput()
        {
            var valid = !string.IsNullOrEmpty(txtAccount.Text) && !string.IsNullOrEmpty(txtPassword.Text);
            if (!valid)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterFullAccountInfo,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return valid;
        }

        private bool AccountExisted()
        {
            var existed = AccountService.CheckAccountExists(txtAccount.Text);
            if (existed)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_AccountExisted,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return existed;
        }

        private bool Create()
        {
            _user.Account = txtAccount.Text;
            var createSuccessfully = AccountService.CreateAccount(_user, txtPassword.Text);
            if (!createSuccessfully)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return createSuccessfully;
        }

        #endregion
    }
}
