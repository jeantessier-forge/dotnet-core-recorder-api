#nullable disable
using Microsoft.EntityFrameworkCore;

namespace RecorderApi.Data
{
    public class RecorderApiContext : DbContext
    {
        public RecorderApiContext(DbContextOptions<RecorderApiContext> options)
            : base(options)
        {
        }
        
        public DbSet<RecorderApi.Models.Record> Records { get; set; }
    }    
}
