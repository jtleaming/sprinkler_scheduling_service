using Microsoft.EntityFrameworkCore;

namespace sprinkler_scheduling_service.Models
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base (options)
        {
        }

        public DbSet<Schedule> Schedules { get; set; }
    }
}