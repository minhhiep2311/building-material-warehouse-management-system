using System;
using System.Drawing;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Utils;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace BTL_LTTQ_QLKhoVLXD.Controls.ListView
{
    internal sealed class BmwListView : System.Windows.Forms.ListView
    {
        #region Public Properties

        public delegate void ItemAddedHandler(object sender, BmwListViewItemEventArgs e);
        public delegate void ItemRemovedHandler(object sender, BmwListViewItemEventArgs e);
        public event ItemAddedHandler ItemAdded;
        public event ItemRemovedHandler ItemRemoved;

        public delegate void ColumnAddedHandler(object sender, BmwListViewColumnEventArgs e);
        public delegate void ColumnRemovedHandler(object sender, BmwListViewColumnEventArgs e);
        public event ColumnAddedHandler ColumnAdded;
        public event ColumnRemovedHandler ColumnRemoved;

        public int[] SortableColumns { get; set; }
        public bool Sortable { get; set; }

        public new BmwListViewItemCollection Items { get; }
        public new BmwListViewColumnCollection Columns { get; }

        #endregion

        #region Private Properties

        internal static readonly Color NormalForeColor = Color.White;
        internal static readonly Color NormalBackColor = Color.FromArgb(48, 128, 189);
        internal static readonly Color SelectedForeColor = Color.Blue;
        internal static readonly Color SelectedBackColor = Color.AliceBlue;
        private static readonly SolidBrush SelectedBackColorBrush = new SolidBrush(SelectedBackColor);
        private static readonly string UpArrow = $"{Resources.Character_ArrowUp}    ";
        private static readonly string DownArrow = $"{Resources.Character_ArrowDown}    ";
        #endregion

        #region Constructor

        public BmwListView()
        {
            Items = new BmwListViewItemCollection(this);
            Columns = new BmwListViewColumnCollection(this);

            ForeColor = NormalForeColor;
            BackColor = NormalBackColor;
            Dock = DockStyle.Fill;
            Font = new Font("Microsoft Sans Serif", 10F);
            FullRowSelect = true;
            HideSelection = false;
            UseCompatibleStateImageBehavior = false;
            View = View.Details;
            OwnerDraw = true;
            GridLines = true;

            DrawSubItem += OnDrawSubItem;
            DrawColumnHeader += OnDrawColumnHeader;
            ColumnClick += OnColumnClick;
            ColumnWidthChanging += OnColumnWidthChanging;
            Sortable = true;
        }

        #endregion

        #region Events

        private void OnDrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var flags = GetTextAlignment(e.ColumnIndex);
            var textColor = e.Item.ForeColor;

            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(SelectedBackColorBrush, e.Bounds);
                textColor = SelectedForeColor;
            }
            else
            {
                e.DrawBackground();
            }

            TextRenderer.DrawText(
                e.Graphics,
                e.Item.SubItems[e.ColumnIndex].Text,
                e.Item.Font,
                e.Bounds,
                textColor,
                flags
            );
        }

        private static void OnDrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) =>
            e.DrawDefault = true;

        private void OnColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (!Sortable)
                return;

            if (SortableColumns != null &&
                Array.IndexOf(SortableColumns, e.Column) == -1)
                return;

            var sorter = (Helper.ItemComparer)ListViewItemSorter;
            if (sorter == null)
            {
                sorter = new Helper.ItemComparer(e.Column)
                {
                    Order = SortOrder.Ascending
                };
                ListViewItemSorter = sorter;
            }

            if (e.Column == sorter.Column)
                sorter.Order = 1 - sorter.Order;
            else
            {
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            Sort();
            DrawArrow(e.Column, sorter.Order);
        }

        private void OnColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            HandleChangeIdColumnWidth(e);
        }

        #endregion

        #region Behaviors

        internal void OnItemAdded(ListViewItem item)
        {
            ItemAdded?.Invoke(this, new BmwListViewItemEventArgs(item));
        }

        internal void OnItemRemoved(ListViewItem item)
        {
            ItemRemoved?.Invoke(this, new BmwListViewItemEventArgs(item));
        }

        internal void OnColumnAdded(int columnIndex)
        {
            ColumnAdded?.Invoke(this, new BmwListViewColumnEventArgs(columnIndex));
        }

        internal void OnColumnRemoved(int columnIndex)
        {
            ColumnRemoved?.Invoke(this, new BmwListViewColumnEventArgs(columnIndex));
        }

        private TextFormatFlags GetTextAlignment(int colIndex)
        {
            var flags = TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding;

            if (Columns[colIndex].TextAlign != HorizontalAlignment.Left)
                flags |= (TextFormatFlags)((int)Columns[colIndex].TextAlign ^ 3);

            return flags;
        }

        private void DrawArrow(int colIdx, SortOrder order)
        {
            foreach (ColumnHeader column in Columns)
            {
                if (column.Text.Contains(UpArrow))
                    column.Text = column.Text.Replace(UpArrow, string.Empty);
                else if (column.Text.Contains(DownArrow))
                    column.Text = column.Text.Replace(DownArrow, string.Empty);
            }

            Columns[colIdx].Text = Columns[colIdx].Text.Insert(0,
                    order == SortOrder.Ascending
                        ? DownArrow
                        : UpArrow
                );
        }

        private static void HandleChangeIdColumnWidth(ColumnWidthChangingEventArgs e)
        {
            // ID column
            if (e.ColumnIndex != 0)
                return;

            e.NewWidth = 0;
            e.Cancel = true;
        }

        #endregion
    }
}
