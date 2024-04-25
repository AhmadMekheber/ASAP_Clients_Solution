using Clients.DAL.BaseRepository;
using Clients.DAL.IRepository;
using Clients.Migrations.Data;
using Clients.Model;
using Microsoft.EntityFrameworkCore;

namespace Clients.DAL.Repository
{
    public class PreviousCloseResponseRepository : EFRepository<PreviousCloseResponse>, IPreviousCloseResponseRepository
    {
        public PreviousCloseResponseRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<PreviousCloseResponse> GetResponsesToNotify()
        {
            return GetAll()
                .Where(response => response.IsClientsNotified == false)
                .Include(response => response.Request)
                .ThenInclude(request => request.Ticker);
        }
    }
}