using RateMe.Business.Services.Interfaces;
using RateMe.Data;
using RateMe.Data.Repositories.Interfaces;
using RateMe.Models;

namespace RateMe.Business.Services
{
    public class PicturesService : IPicturesService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IPicturesRepository _picturesRepository;

        public PicturesService(ApplicationDbContext dbContext, IPicturesRepository picturesRepository)
        {
            _dbContext = dbContext;
            _picturesRepository = picturesRepository;
        }

        //public async Task AddPictureAsync(Picture picture)
        //{
        //    await _dbContext.Pictures.AddAsync(picture);
        //    await _dbContext.SaveChangesAsync();
        //}
        public async Task<Picture> SavePictureAsync(Picture picture)
        {
            await _dbContext.Pictures.AddAsync(picture);
            await _dbContext.SaveChangesAsync();
            return picture;
        }
        public async Task<IEnumerable<Picture>> GetPicturesAsync() => await _picturesRepository.GetAllPictures();
    }
}
