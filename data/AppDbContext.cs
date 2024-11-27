
using Login.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Login.data

    {
        public class AppDbContext : IdentityDbContext<Users>
        {
            public AppDbContext(DbContextOptions options) : base(options)
            {
            }
        }
    }
