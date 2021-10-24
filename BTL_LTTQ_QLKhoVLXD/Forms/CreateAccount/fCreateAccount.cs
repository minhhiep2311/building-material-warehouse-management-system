using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount
{
    public partial class fCreateAccount : Form
    {
        public fCreateAccount()
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
            bool valid = txtName.Text != "" &&
                txtAddress.Text != "" &&
                grbInfo.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked) != null &&
                txtPhone.Text != "" &&
                cboPosition.SelectedIndex != -1;

            if (!valid)
                MessageBox.Show("Hãy nhập đầy đủ thông tin cá nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Helper.RegexValidate.Name(txtName.Text))
            {
                MessageBox.Show("Định dạng họ tên không chính xác! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (!Helper.RegexValidate.PhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Định dạng số điện thoại không chính xác! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            return valid;
        }

        private bool ValidAccount()
        {
            bool valid = txtUsername.Text != "" &&
                txtPhone.Text != "";
            if (!valid)
                MessageBox.Show("Hãy nhập đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            bool accountExists = AccountService.CheckAccountExists(txtUsername.Text);
            if (accountExists)
                MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng chọn tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return valid && !accountExists;
        }

        private void CreateAccount()
        {
            User user = new User(
                txtName.Text,
                txtAddress.Text,
                rdoMale.Checked,
                dtpDob.Value,
                cboPosition.SelectedItem as EmployeePosition,
                txtUsername.Text
            );

            bool createSuccessfully = AccountService.CreateAccount(user, txtPassword.Text);
            if (createSuccessfully)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Lỗi hệ thống! Hãy thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
