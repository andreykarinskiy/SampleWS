using System;
using System.Collections.Generic;
using Users.API.Models;

namespace Users.API.Services
{
    public sealed class StubUserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            yield return new User
            {
                ID = "1",
                LastAccessTime = DateTime.UtcNow,
                BirthDate = new DateTime(1930, 1, 15),
                FullName = "Горбунков Семен Семенович"
            };
        }
    }
}
