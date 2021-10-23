using BTL_LTTQ_QLKhoVLXD.Models;
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

        private void btnOld_Click(object sender, EventArgs e)
        {
            txtOld.UseSystemPasswordChar = !txtOld.UseSystemPasswordChar;
            if (!txtOld.UseSystemPasswordChar)
                btnOld.Text = "Hiện mật khẩu";
            else
                btnOld.Text = "Ẩn mật khẩu";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNew.UseSystemPasswordChar = !txtNew.UseSystemPasswordChar;
            if (!txtNew.UseSystemPasswordChar)
                btnNew.Text = "Hiện mật khẩu";
            else
                btnNew.Text = "Ẩn mật khẩu";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
