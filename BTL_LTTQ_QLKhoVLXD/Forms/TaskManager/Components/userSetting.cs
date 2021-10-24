using BTL_LTTQ_QLKhoVLXD.Forms.ChangePassword;
using BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount;
using BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD
{
    public partial class fTaskManager : Form
    {
        private void btnCreateAccount_userSetting_Click(object sender, System.EventArgs e)
        {
            fCreateAccount fCA = new fCreateAccount();
            fCA.ShowDialog();
        }

        private void btnChangePassword_userSetting_Click(object sender, System.EventArgs e)
        {
            fChangePassword fCM = new fChangePassword(User);
            fCM.ShowDialog();
        }
        private void btnResetPassword_userSetting_Click(object sender, System.EventArgs e)
        {
            fResetPassword fRP = new fResetPassword(User);
            fRP.ShowDialog();
        }
    }
}
