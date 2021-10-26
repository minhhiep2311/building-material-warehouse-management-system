using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation;
using BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount;
using BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Forms.TaskManager
{
    public partial class fTaskManager : Form
    {
        private readonly User _user;

        public fTaskManager(User user)
        {
            InitializeComponent();
            _user = user;
            DisplayUserInfo();
        }

        #region Form
        #region Form Events

        private void fTaskManager_Load(object sender, EventArgs e)
        {
            DisplayComponentsAccordsPermission();
        }

        private void tctlControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // No draw selected border
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(
                    e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    Color.YellowGreen
                );

            e.DrawBackground();

            // Draw Text
            var g = e.Graphics;
            var text = tctlControl.TabPages[e.Index].Text;
            var textSize = g.MeasureString(text, tctlControl.Font);

            var x = e.Bounds.Left + 10;
            var y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            g.DrawString(text, tctlControl.Font, Brushes.Black, x, y);
        }
        private void fTaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                    Resources.MessageBox_Message_ConfirmExit, Resources.MessageBox_Caption_Notification, MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.No;
        }

        #endregion

        #region Form Methods
        private void DisplayComponentsAccordsPermission()
        {
            if (!PermissionConstant.CreateAccount.Contains(_user.Position.Id))
                btnCreateAccount_userSetting.Visible = false;
            if (!PermissionConstant.ResetPassword.Contains(_user.Position.Id))
                btnResetPassword_userSetting.Visible = false;
        }

        private void DisplayUserInfo()
        {
            var resources = new ResourceManager(typeof(fTaskManager));
            lblUser.Text = string.Format((string)resources.GetObject("Label_User") ?? string.Empty, _user.Name);
            lblPosition.Text = string.Format((string)resources.GetObject("Label_Position") ?? string.Empty, _user.Position);
        }

        #endregion
        #endregion

        #region Material
        #region Material Events

        private void tpgMaterial_Enter(object sender, EventArgs e)
        {
            LoadMaterialData();
        }

        #endregion

        #region Material Methods

        private void ConfigMaterialTable()
        {
            dgvMaterial.Columns[0].Width = 40;
            dgvMaterial.Columns[1].Width = 200;
            dgvMaterial.Columns[2].Width = 150;
            dgvMaterial.Columns[3].Width = 150;
            dgvMaterial.Columns[4].Width = 120;
            dgvMaterial.Columns[5].Width = 150;
        }

        private void LoadMaterialData()
        {
            dgvMaterial.DataSource = MaterialService.GetAll();
            ConfigMaterialTable();
        }

        #endregion
        #endregion

        #region UserSettings
        #region UserSettings Events

        private void btnCreateAccount_userSetting_Click(object sender, EventArgs e)
        {
            new fCreateAccount().ShowDialog();
        }

        private void btnChangeInformation_userSetting_Click(object sender, EventArgs e)
        {
            new fChangeInformation(_user).ShowDialog();
        }
        private void btnResetPassword_userSetting_Click(object sender, EventArgs e)
        {
            new fResetPassword(_user).ShowDialog();
        }

        #endregion
        #endregion
    }
}
