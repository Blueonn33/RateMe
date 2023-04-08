using RateMe.Models;

namespace RateMe.Business.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<User>> GetUserAsync();
        Task<User?> GetUserByIdAsync(string id);
    }
}
