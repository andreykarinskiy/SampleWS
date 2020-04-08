using System;

namespace Users.API.Models
{
    public sealed class User
    {
        public string ID { get; set; }

        public DateTime LastAccessTime { get; set; }

        public DateTime BirthDate { get; set; }

        public string FullName { get; set; }
    }
}
