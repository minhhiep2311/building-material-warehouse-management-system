using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls.Button
{
    internal sealed class BmwButton : System.Windows.Forms.Button
    {
        public BmwButton()
        {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 10F);
            UseVisualStyleBackColor = false;
            EnabledChanged += BmwOnEnabledChanged;
            BackColor = Color.White;
            ForeColor = Color.FromArgb(48, 128, 189);
        }

        private void BmwOnEnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                BackColor = Color.White;
                ForeColor = Color.FromArgb(48, 128, 189);
            }
            else
            {
                BackColor = Color.DarkGray;
                ForeColor = Color.FromArgb(48, 128, 189);
            }
        }
    }
}
