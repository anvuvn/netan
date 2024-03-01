using Microsoft.EntityFrameworkCore;
using netan.Models; 

namespace netan.Persistence
{
    public class NetanDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }


        public NetanDbContext(DbContextOptions<NetanDbContext> options) : base(options)
        {

        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .HasMany(left => left.Features)    
                .WithMany(right => right.Vehicles)
                .UsingEntity(join => join.ToTable("VehicleFeatures"));
        }
    }
}