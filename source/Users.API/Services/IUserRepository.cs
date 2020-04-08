using System.Collections.Generic;
using Users.API.Models;

namespace Users.API.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
