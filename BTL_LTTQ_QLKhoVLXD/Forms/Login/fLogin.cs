using BTL_LTTQ_QLKhoVLXD.Models;
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
            //ForceLogin();
            TryLogin();
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

            string query = "SELECT e.name, p.name AS position, a.username " +
                "FROM account AS a " +
                "JOIN employee AS e ON e.id=a.idEmployee " +
                "JOIN employeePosition AS p ON p.id = e.idPosition " +
                $"WHERE a.username = N'{userName}' AND a.password = N'{passWord}'";
            DataTable result = DatabaseProvider.Instance.ExecuteQuery(query);

            // If account exists
            if (result.Rows.Count == 1)
            {
                Hide();
                Login(result);

                // After close app form
                txbPassWord.Text = "";
                Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login(DataTable data)
        {
            var userInfo = data.Rows[0];
            User user = new User
            (
                Convert.ToString(userInfo["name"]),
                Convert.ToString(userInfo["position"]),
                Convert.ToString(userInfo["username"])
            );

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
            fTaskManager fTM = new fTaskManager(new User("Name", "Staff", "FooAccount"));

            Hide();
            fTM.ShowDialog();

            txbPassWord.Text = "";
            Show();
        }

        #endregion
    }
}
