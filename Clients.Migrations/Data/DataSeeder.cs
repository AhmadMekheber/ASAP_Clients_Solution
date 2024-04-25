using Clients.Model;
using Clients.Utils;
using Microsoft.EntityFrameworkCore;

namespace Clients.Migrations.Data
{
    public static class DataSeeder
    {
        public static void SeedData(this DataContext dataContext, ModelBuilder modelBuilder) 
        {
            SeedPolygonRequestTypes(modelBuilder);
            SeedPolygonTickers(modelBuilder);
        }

        private static void SeedPolygonRequestTypes(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<PolygonRequestType>().HasData(
                new PolygonRequestType
                { 
                    ID = (int)Utils.Enums.PolygonRequestType.PreviousClose,
                     Name = Utils.Enums.PolygonRequestType.PreviousClose.GetEnumDisplay()
                }
            );
        }

        private static void SeedPolygonTickers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PolygonTicker>().HasData(
                new PolygonTicker
                {
                    ID = 1,
                    Name = "MSFT",
                    CompanyName = "Microsoft Corp"
                },
                new PolygonTicker
                {
                    ID = 2,
                    Name = "AMZN",
                    CompanyName = "Amazon.Com Inc"
                },
                new PolygonTicker
                {
                    ID = 3,
                    Name = "META",
                    CompanyName = "Meta Platforms, Inc. Class A Common Stock"
                },
                new PolygonTicker
                {
                    ID = 4,
                    Name = "AAPL",
                    CompanyName = "Apple Inc."
                },
                new PolygonTicker
                {
                    ID = 5,
                    Name = "NFLX",
                    CompanyName = "NetFlix Inc"
                }
            );
        }
    }
}