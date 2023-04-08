using RateMe.Models;

namespace RateMe.Data.Repositories.Interfaces
{
    public interface IPicturesRepository : IRepository<Picture>
    {
        Task<IEnumerable<Picture>> GetAllPictures();
        Task<Picture?> FindPicture(int id);
    }
}
