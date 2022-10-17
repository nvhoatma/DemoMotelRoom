using DemoMotelRoom.DTO;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DemoMotelRoom.Models
{
    public class MotelRoomContext :DbContext
    {
        public MotelRoomContext(DbContextOptions<MotelRoomContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(b => b.users)
                .WithOne();
        }

        public DbSet<User> users { get; set; }
        public DbSet<Department> department { get; set; }
       
    }
}
