using Microsoft.EntityFrameworkCore;
using StreamCasa.Entities;

namespace StreamCasa.Repository.EFCore
{
    public class StreamDBContext:DbContext
    {
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersVideos> UsersVideos { get; set; }
        public DbSet<Videos> Videos { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"data source=ROOT-DEVICE;Database=StreamDB;Trusted_Connection=true;TrustServerCertificate=true");
        //}
    }
}