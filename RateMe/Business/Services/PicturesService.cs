using RateMe.Business.Services.Interfaces;
using RateMe.Data;
using RateMe.Models;

namespace RateMe.Business.Services
{
    public class PicturesService : IPicturesService
    {
        private readonly ApplicationDbContext _dbContext;

        public PicturesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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
    }
}
