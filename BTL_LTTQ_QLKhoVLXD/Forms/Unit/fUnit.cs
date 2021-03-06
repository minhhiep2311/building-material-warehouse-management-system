using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.Material;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Unit
{
    public partial class fUnit : Form
    {
        private fMaterial _parentForm;

        public fUnit(fMaterial parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }

        #region Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var unitExists = UnitService.CheckUnitExists(txtUnit.Text);

            if (unitExists)
            {
                MessageBox.Show(Resources.MessageBox_Message_UnitExisted,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            
                var success = UnitService.AddUnit(txtUnit.Text);
                if (success)
                {
                    MessageBox.Show(Resources.MessageBox_Message_AddUnitSuccessfully,
                        Resources.MessageBox_Caption_Notification,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _parentForm.LoadUnits();
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.MessageBox_Message_SystemError,
                        Resources.MessageBox_Caption_Notification,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            
        }

        #endregion

        private void fUnit_Load(object sender, EventArgs e)
        {

        }
    }
}
