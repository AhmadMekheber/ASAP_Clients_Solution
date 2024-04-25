using Clients.DAL.BaseRepository;
using Clients.DAL.IRepository;
using Clients.Migrations.Data;
using Clients.Model;

namespace Clients.DAL.Repository
{
    public class PolygonTickerRepository : EFRepository<PolygonTicker>, IPolygonTickerRepository
    {
        public PolygonTickerRepository(DataContext context) : base(context)
        {
        }
    }
}