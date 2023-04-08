using RateMe.Models;

namespace RateMe.Business.Services.Interfaces
{
    public interface IPicturesService
    {
        Task AddPictureAsync(Picture picture);
    }
}
