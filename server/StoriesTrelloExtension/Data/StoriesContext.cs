using Microsoft.EntityFrameworkCore;
using StoriesTrelloExtension.Data.Models;

namespace StoriesTrelloExtension.Data
{
    public class StoriesContext : DbContext
    {
        public DbSet<Epic> Epics { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Epic>()
                .HasMany(e => e.Steps)
                .WithOne(s => s.Epic);

            modelBuilder.Entity<Release>()
                .HasMany(r => r.Tasks)
                .WithOne(t => t.Release);

            modelBuilder.Entity<Step>()
                .HasMany(s => s.Tasks)
                .WithOne(t => t.Step);
        }
    }
}
