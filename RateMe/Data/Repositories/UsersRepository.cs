using Microsoft.EntityFrameworkCore;
using RateMe.Data.Repositories.Interfaces;
using RateMe.Models;

namespace RateMe.Data.Repositories
{
    public class UsersRepository : Repository<User>, IUsersRepository
    {
        public UsersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var users = await Entities.ToListAsync();
            return users;
        }
    }
}
