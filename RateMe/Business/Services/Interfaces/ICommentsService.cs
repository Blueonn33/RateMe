using RateMe.Models;

namespace RateMe.Business.Services.Interfaces
{
    public interface ICommentsService
    {
        Task<IEnumerable<Comment>> GetAllComments(int pictureId);
        Task<Comment> CreateComment(Comment comment);
        Task<IEnumerable<Comment>> GetCommentsAsync();
        Task<Comment?> GetCommentById(int id);
    }
}
