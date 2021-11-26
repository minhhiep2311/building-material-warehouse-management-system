using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Forms.WareHouse
{
    public partial class fWarehouse : Form
    {
        public fWarehouse()
        {
            InitializeComponent();
        }

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            TryCreate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Behaviors

        private void TryCreate()
        {
            if (!ValidInput())
                return;

            var name = txtName.Text;
            var area = Convert.ToDouble(txtArea.Text);
            var newWareHouse = new Models.Warehouse(-1, name, area);

            if (WarehouseExisted(newWareHouse))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_DuplicateWarehouse,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (CreateWarehouse(newWareHouse))
            {
                MessageBox.Show(
                    string.Format(Resources.MessageBox_Message_AddWarehouseSuccessfully, newWareHouse.Name),
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            Close();
        }

        private bool ValidInput()
        {
            var valid = txtName.Text != "" && txtArea.Text != "";
            if (!valid)
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterFulllInfo,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return valid;
        }

        private static bool WarehouseExisted(Models.Warehouse warehouse)
        {
            return WarehouseService.CheckExists(warehouse);
        }

        private static bool CreateWarehouse(Models.Warehouse warehouse)
        {
            return WarehouseService.Create(warehouse);
        }

        #endregion
    }
}
