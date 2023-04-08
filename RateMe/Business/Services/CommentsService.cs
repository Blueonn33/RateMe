using RateMe.Business.Services.Interfaces;
using RateMe.Data;
using RateMe.Data.Repositories.Interfaces;
using RateMe.Models;

namespace RateMe.Business.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly ICommentsRepository _commentsRepository;
        public CommentsService(ICommentsRepository commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }

        public async Task<Comment> CreateComment(Comment comment)
        {
            return await _commentsRepository.AddAsync(comment);
        }

        public async Task<IEnumerable<Comment>> GetAllComments(int pictureId)
        {
            return await _commentsRepository.GetAllCommentsAsync(pictureId);
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync() => await _commentsRepository.GetAllComments();
        public Task<Comment?> GetCommentById(int id)
        {
            return _commentsRepository.FindComment(id);
        }
    }
}
