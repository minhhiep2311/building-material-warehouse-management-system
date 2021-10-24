namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class User
    {
        public string Name { get; }
        public string Position { get; }
        public string Account { get; }

        public User(string name, string position, string account)
        {
            Name = name;
            Position = position;
            Account = account;
        }
    }
}
