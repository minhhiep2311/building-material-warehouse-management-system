using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Models;

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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _parentParentForm.LoadData_Employee();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
