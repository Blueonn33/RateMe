namespace RateMe.Data.Repositories.Interfaces
{
    using RateMe.Models;
    using System.Collections.Generic;

    public interface IUsersRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllUsers();
    }
}
