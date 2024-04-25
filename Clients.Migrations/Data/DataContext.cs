using Clients.Model;
using Microsoft.EntityFrameworkCore;

namespace Clients.Migrations.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<PolygonRequest> PolygonRequests { get; set; }

        public DbSet<PolygonRequestType> PolygonRequestTypes { get; set; }

        public DbSet<PolygonTicker> PolygonTickers { get; set; }

        public DbSet<PreviousCloseResponse> PreviousCloseResponses { get; set; }
    }
}