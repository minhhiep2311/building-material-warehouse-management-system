using System.Drawing;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls.TabControl
{
    internal sealed class BmwTabControl : System.Windows.Forms.TabControl
    {
        public BmwTabControl()
        {
            Alignment = TabAlignment.Left;
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Multiline = true;
            SelectedIndex = 0;
            SizeMode = TabSizeMode.Fixed;
            DrawItem += OnDrawItem;
        }

        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            // No draw selected border
            var selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            e = new DrawItemEventArgs(
                e.Graphics,
                e.Font,
                e.Bounds,
                e.Index,
                e.State ^ DrawItemState.Selected,
                e.ForeColor,
                selected ? Color.White : Color.FromArgb(48, 128, 189)
            );

            e.DrawBackground();

            // Draw Text
            var g = e.Graphics;
            var text = TabPages[e.Index].Text;
            var textSize = g.MeasureString(text, Font);

            var x = e.Bounds.Left + 10;
            var y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            g.DrawString(text, Font, selected ? Brushes.Navy : Brushes.White, x, y);
        }
    }
}
