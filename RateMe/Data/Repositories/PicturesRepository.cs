using Microsoft.EntityFrameworkCore;
using RateMe.Data.Repositories.Interfaces;
using RateMe.Models;

namespace RateMe.Data.Repositories
{
    public class PicturesRepository : Repository<Picture>, IPicturesRepository
    {
        public PicturesRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Picture?> FindPicture(int id)
        {
            return await Entities.Include(t => t.User).FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Picture>> GetAllPictures() => await Entities.ToListAsync();
    }
}
