using Microsoft.EntityFrameworkCore;
namespace erzeTruck.Data
{
    public class DataContext:DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}
