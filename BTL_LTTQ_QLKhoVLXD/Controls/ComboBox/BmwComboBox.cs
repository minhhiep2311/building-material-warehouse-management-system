using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls.ComboBox
{
    internal class BmwComboBox : System.Windows.Forms.ComboBox
    {
        public BmwComboBox()
        {
            AutoCompleteSource = AutoCompleteSource.ListItems;
            AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            DroppedDown = false;
        }
    }
}
