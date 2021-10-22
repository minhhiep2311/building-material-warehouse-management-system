namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class User
    {
        public string Name { get; }
        public string Position { get; }

        public User(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}
