using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls
{
    internal sealed class BmwButton : Button
    {
        public BmwButton()
        {
            BackColor = Color.White;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(48, 128, 189);
            UseVisualStyleBackColor = false;
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            BackColor = Enabled ? Color.White : Color.DarkGray;
        }
    }
}
