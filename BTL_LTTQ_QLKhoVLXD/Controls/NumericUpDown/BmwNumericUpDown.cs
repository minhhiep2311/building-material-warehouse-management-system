namespace BTL_LTTQ_QLKhoVLXD.Controls.NumericUpDown
{
    public class BmwNumericUpDown : System.Windows.Forms.NumericUpDown
    {
        public BmwNumericUpDown()
        {
            Maximum = decimal.MaxValue;
            ThousandsSeparator = true;
        }
    }
}
