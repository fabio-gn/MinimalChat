using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using MinimalChat.Models.Domain;

namespace MinimalChat.Data
{
    public class MinimalChatDbContext : DbContext
    {
        public MinimalChatDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Rooms>()
        //        .HasMany(e => e.users)
        //        .WithOne(e => e.Rooms)
        //        .HasForeignKey(e => e.RoomsId)
        //        .HasPrincipalKey(e => e.Id);
        //    modelBuilder.Entity<Roles>()
        //        .HasMany(e => e.users)
        //        .WithOne(e => e.Roles)
        //        .HasForeignKey(e => e.RoleId)
        //        .HasPrincipalKey(e => e.Id);
        //}
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
