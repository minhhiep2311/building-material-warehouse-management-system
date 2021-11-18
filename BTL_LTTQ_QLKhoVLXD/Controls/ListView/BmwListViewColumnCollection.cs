using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Controls.ListView
{
    internal class BmwListViewColumnCollection : System.Windows.Forms.ListView.ColumnHeaderCollection
    {
        private readonly BmwListView _owner;

        public BmwListViewColumnCollection(BmwListView owner) : base(owner)
        {
            _owner = owner;
        }

        public new ColumnHeader Add(string text, int width, HorizontalAlignment textAlign)
        {
            var ch = base.Add(text, width, textAlign);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new int Add(ColumnHeader value)
        {
            var count = Count;
            _owner.OnColumnAdded(count);
            return count;
        }

        public new ColumnHeader Add(string text)
        {
            var ch = base.Add(text);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new ColumnHeader Add(string text, int width)
        {
            var ch = base.Add(text, width);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new ColumnHeader Add(string key, string text)
        {
            var ch = base.Add(key, text);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new ColumnHeader Add(string key, string text, int width)
        {
            var ch = base.Add(key, text, width);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, string imageKey)
        {
            var ch = base.Add(key, text, width, textAlign, imageKey);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, int imageKey)
        {
            var ch = base.Add(key, text, width, textAlign, imageKey);
            _owner.OnColumnAdded(ch.Index);
            return ch;
        }

        public new void Remove(ColumnHeader column)
        {
            var index = column.Index;
            base.Remove(column);
            _owner.OnColumnRemoved(index);
        }

        public new void Clear()
        {
            base.Clear();
        }
    }
}
