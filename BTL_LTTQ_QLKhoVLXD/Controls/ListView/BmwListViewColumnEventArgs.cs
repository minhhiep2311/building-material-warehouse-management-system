using System;

namespace BTL_LTTQ_QLKhoVLXD.Controls.ListView
{
    internal class BmwListViewColumnEventArgs : EventArgs
    {
        public int ColumnIndex { get; set; }
        public int[] ColumnIndexes { get; set; }

        public BmwListViewColumnEventArgs(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }

        public BmwListViewColumnEventArgs(int[] columnIndexes)
        {
            ColumnIndexes = columnIndexes;
        }
    }
}
