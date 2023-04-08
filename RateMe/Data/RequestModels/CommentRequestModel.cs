using RateMe.Models;

namespace RateMe.Data.RequestModels
{
    public class CommentRequestModel
    {
        public string Value { get; set; }
        public int PictureId { get; set; }

        public Comment ToCreateComment(Picture picture)
        {
            return new Comment()
            {
                Value = Value,
                PictureId = picture.Id,
                Picture = picture
            };
        }
    }
}
