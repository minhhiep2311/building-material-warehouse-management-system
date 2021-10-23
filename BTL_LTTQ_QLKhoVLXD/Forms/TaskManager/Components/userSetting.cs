using BTL_LTTQ_QLKhoVLXD.Forms.ChangePassword;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD
{
    public partial class fTaskManager : Form
    {
        private void btnCreateAccount_userSetting_Click(object sender, System.EventArgs e)
        {
        }

        private void btnChangePassword_userSetting_Click(object sender, System.EventArgs e)
        {
            fChangePassword fCM = new fChangePassword(User);
            fCM.ShowDialog();
        }
    }
}
