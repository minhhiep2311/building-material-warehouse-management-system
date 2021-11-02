using System;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Forms.AddEmployee
{
    public partial class fAddEmployee : Form
    {
        public fAddEmployee()
        {
            InitializeComponent();
        }

        #region Events

        private void fCreateAccount_Load(object sender, EventArgs e)
        {
            LoadPositions();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidInformation() || !ValidAccount())
                return;

            CreateAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void LoadPositions()
        {
            cboPosition.DataSource = EmployeeService.GetPositions();
            cboPosition.SelectedIndex = -1;
        }

        private bool ValidInformation()
        {
            var valid = txtName.Text != "" &&
                txtAddress.Text != "" &&
                Helper.ControlFilter.GetRadioButtons(grbInfo).FirstOrDefault(x => x.Checked) != null &&
                txtPhone.Text != "" &&
                cboPosition.SelectedIndex != -1;

            if (!valid)
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterFullPersonalInfo,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            else if (!Helper.Validate.Name(txtName.Text))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_InvalidNameFormat,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                valid = false;
            }
            else if (!Helper.Validate.PhoneNumber(txtPhone.Text))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_InvalidPhoneNumberFormat,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                valid = false;
            }

            return valid;
        }

        private bool ValidAccount()
        {
            var valid = txtUsername.Text != "" &&
                        txtPhone.Text != "";
            if (!valid)
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterFullAccountInfo,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            var accountExists = AccountService.CheckAccountExists(txtUsername.Text);
            if (accountExists)
                MessageBox.Show(
                    Resources.MessageBox_Message_AccountExisted,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            return valid && !accountExists;
        }

        private void CreateAccount()
        {
            var user = new User(
                txtName.Text,
                txtAddress.Text,
                rdoMale.Checked,
                dtpDob.Value,
                cboPosition.SelectedItem as EmployeePosition,
                txtUsername.Text
            );

            var createSuccessfully = AccountService.CreateAccount(user, txtPassword.Text);
            if (createSuccessfully)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_CreateAccountSuccessfully,
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
