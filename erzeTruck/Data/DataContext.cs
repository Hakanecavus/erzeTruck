using Microsoft.EntityFrameworkCore;
using erzeTruck.Model;
namespace erzeTruck.Data
{
    public class DataContext:DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();

        public DbSet<userDetail> userDetails => Set<userDetail>();

    }
}
