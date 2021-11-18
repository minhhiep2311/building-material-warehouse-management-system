using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls.ListView
{
    internal class BmwListViewItemCollection : System.Windows.Forms.ListView.ListViewItemCollection
    {
        private readonly BmwListView _owner;

        public BmwListViewItemCollection(BmwListView owner) : base(owner)
        {
            _owner = owner;
        }

        public new ListViewItem Add(ListViewItem value)
        {
            value.BackColor = BmwListView.NormalBackColor;
            var item = base.Add(value);
            _owner.OnItemAdded(item);
            return item;
        }

        public new ListViewItem Add(string text, string imageKey)
        {
            var value = new ListViewItem(text, imageKey)
            {
                BackColor = BmwListView.NormalBackColor
            };
            var item = base.Add(value);
            _owner.OnItemAdded(item);
            return item;
        }

        public new ListViewItem Add(string key, string text, string imageKey)
        {
            var value = new ListViewItem(text, imageKey)
            {
                Name = key,
                BackColor = BmwListView.NormalBackColor
            };
            var item = base.Add(value);
            _owner.OnItemAdded(item);
            return item;
        }

        public new ListViewItem Add(string key, string text, int imageIndex)
        {
            var value = new ListViewItem(text, imageIndex)
            {
                Name = key,
                BackColor = BmwListView.NormalBackColor
            };
            var item = base.Add(value);
            _owner.OnItemAdded(item);
            return item;
        }

        public new void Remove(ListViewItem item)
        {
            base.Remove(item);
            _owner.OnItemRemoved(item);
        }
    }
}
