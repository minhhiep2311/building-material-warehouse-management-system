using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_LTTQ_QLKhoVLXD
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
                return;

            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            string query = $"SELECT COUNT(*) from dbo.account Where username = N'{userName}' AND password = N'{passWord}'";
            int recordCount = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));

            if (recordCount == 1)
            {
                fTaskManager fTM = new fTaskManager();
                Hide();
                fTM.ShowDialog();
                txbPassWord.Text = "";
                Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
                Close();
        }

        private bool ValidInput()
        {
            if (txbUserName.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txbPassWord.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
