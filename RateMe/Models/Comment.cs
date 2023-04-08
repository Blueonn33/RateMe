namespace RateMe.Models
{
    public class Comment
    {
        public Comment()
        {
            Value = Guid.NewGuid().ToString();
        }

        public Comment(Picture? picture, string value) : this()
        {
            _picture = picture;
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }
        public int Id { get; set; }
        public int PictureId { get; set; }
        public Picture? _picture;
        public Picture Picture;
        public string Value { get; set; }
    }
}
