using Microsoft.EntityFrameworkCore;

namespace MrgGameNews
{
    public class MrgGameNewsContext : DbContext
    {
        public MrgGameNewsContext(DbContextOptions<MrgGameNewsContext> options)
        : base(options)
        {
        }
    }
}
