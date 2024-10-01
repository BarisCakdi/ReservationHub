using Microsoft.EntityFrameworkCore;
using ReservationHub.Models;

namespace ReservationHub.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Event> Events { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // fluent api yönetimi
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)  
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.UserId);
        }
    }
    
}
