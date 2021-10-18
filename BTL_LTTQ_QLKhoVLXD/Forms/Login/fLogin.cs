using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            if (userName == "")
            {
                MessageBox.Show("Hãy nhập tài khoản!");
                return;
            }
            else if (passWord == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu!");
                return;
            }

            string query = $"SELECT COUNT(*) from dbo.account Where username = N'{userName}' AND password = N'{passWord}'";
            SqlCommand sqlCommand = new SqlCommand(query, DatabaseProvider.Connection);

            int recordCount = Convert.ToInt32(sqlCommand.ExecuteScalar());

            if (recordCount == 1)
            {
                fTaskManager fTM = new fTaskManager();
                Hide();
                fTM.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
    }
}
