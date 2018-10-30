using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace sprinkler_scheduling_service.Models
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base (options)
        {
        }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Schedule>()
                .HasMany(s => s.Sections)
                .WithOne(c => c.Schedule)
                .IsRequired();

            builder.Entity<Section>()
                .HasOne<Schedule>(c => c.Schedule)
                .WithMany(s => s.Sections)
                .IsRequired();

            foreach (var entity in builder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.Relational().TableName.ToLower();

                foreach(var property in entity.GetProperties())
                {
                    property.Relational().ColumnName = property.Name.ToLower();
                }
            }
        }
    }
}