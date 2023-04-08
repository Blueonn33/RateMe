using RateMe.Models;

namespace RateMe.Data.RequestModels
{
    public class PictureRequestModel
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public Picture ToCreatePicture(string userId)
        {
            return new Picture()
            {
                Name = Name,
                Data = Data,
                UserId = userId,
            };
        }
    }
}
