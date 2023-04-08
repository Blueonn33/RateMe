using Microsoft.EntityFrameworkCore;
using RateMe.Data.Repositories.Interfaces;
using RateMe.Models;

namespace RateMe.Data.Repositories
{
    public class CommentsRepository : Repository<Comment>, ICommentsRepository
    {
        public CommentsRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Comment>> GetAllCommentsAsync(int pictureId)
        {
            return await Entities.AsNoTracking().Include(t => t.Picture.User).Where(t => t.PictureId == pictureId).ToListAsync();
        }
        public async Task<IEnumerable<Comment>> GetAllComments() => await Entities.ToListAsync();

        public async Task<Comment?> FindComment(int id)
        {
            return await Entities.Include(t => t.Picture).FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
