using System;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls.ListView
{
    internal class BmwListViewItemEventArgs : EventArgs
    {
        public ListViewItem Item { get; set; }
        public ListViewItem[] Items { get; set; }

        public BmwListViewItemEventArgs(ListViewItem item)
        {
            Item = item;
        }

        public BmwListViewItemEventArgs(ListViewItem[] items)
        {
            Items = items;
        }
    }
}
