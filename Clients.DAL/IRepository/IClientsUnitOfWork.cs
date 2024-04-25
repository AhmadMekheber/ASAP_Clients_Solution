using Clients.DAL.BaseRepository;

namespace Clients.DAL.IRepository
{
    public interface IClientsUnitOfWork : IUnitOfWork
    {
        IClientRepository ClientRepository { get; }

        IPolygonTickerRepository PolygonTickerRepository { get; }

        IPolygonRequestRepository PolygonRequestRepository { get; }
        
        IPreviousCloseResponseRepository PreviousCloseResponseRepository { get; }
    }
}