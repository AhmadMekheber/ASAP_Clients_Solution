using Clients.DAL.BaseRepository;
using Clients.DAL.IRepository;
using Clients.Migrations.Data;
using Clients.Model;

namespace Clients.DAL.Repository
{
    public class PolygonRequestRepository : EFRepository<PolygonRequest>, IPolygonRequestRepository
    {
        public PolygonRequestRepository(DataContext context) : base(context)
        {
        }
    }
}