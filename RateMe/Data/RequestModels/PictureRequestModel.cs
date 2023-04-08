using RateMe.Models;

namespace RateMe.Data.RequestModels
{
    public class PictureRequestModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }

        public Picture ToCreatePicture(string userId)
        {
            return new Picture()
            {
                Name = Name,
                Type = Type,
                Data = Data,
                UserId = userId,
            };
        }
    }
}
