using Clients.DAL.BaseRepository;
using Clients.Model;

namespace Clients.DAL.IRepository
{
    public interface IPreviousCloseResponseRepository : IRepository<PreviousCloseResponse>
    {
        IQueryable<PreviousCloseResponse> GetResponsesToNotify();
    }
}