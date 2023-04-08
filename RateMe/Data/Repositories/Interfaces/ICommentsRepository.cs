using RateMe.Models;

namespace RateMe.Data.Repositories.Interfaces
{
    public interface ICommentsRepository : IRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetAllCommentsAsync(int pictureId);
        Task<IEnumerable<Comment>> GetAllComments();
        Task<Comment?> FindComment(int id);
    }
}
