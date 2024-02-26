using Microsoft.EntityFrameworkCore;
using netan.Models; 

namespace netan.Persistence
{
    public class NetanDbContext : DbContext
    {
        public NetanDbContext(DbContextOptions<NetanDbContext> options) : base(options)
        {

        } 
        public DbSet<Make> Makes { get; set; }  
        public DbSet<Feature> Features { get; set; }
    }
}