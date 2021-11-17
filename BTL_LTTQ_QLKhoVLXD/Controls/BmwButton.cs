using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls
{
    internal sealed class BmwButton : Button
    {
        public BmwButton()
        {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            UseVisualStyleBackColor = false;
            EnabledChanged += BmwOnEnabledChanged;
        }

        private void BmwOnEnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                BackColor = Color.White;
            }
            else
            {
                BackColor = Color.DarkGray;
            }
        }
    }
}
