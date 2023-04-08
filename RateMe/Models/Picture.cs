namespace RateMe.Models
{
    public class Picture
    {
        public Picture()
        {
            Name = Guid.NewGuid().ToString();
            Type = string.Empty;
            Comments = new List<Comment>();
        }
        public Picture(User? user, string name) : this()
        {
            _user = user;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public User? _user;
        public string? UserId { get; set; }
        public User User;
        public ICollection<Comment> Comments { get; set; }
    }
}
