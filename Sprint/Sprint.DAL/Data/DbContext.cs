using Microsoft.EntityFrameworkCore;
using Sprint.DAL.Models;

namespace Sprint.DAL.Data
{
    public class DbContext
    {
        public DbSet<User> User { get; set; }

        //TODO
    }
}
