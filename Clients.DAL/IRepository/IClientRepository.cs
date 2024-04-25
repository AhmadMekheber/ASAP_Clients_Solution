using Clients.DAL.BaseRepository;
using Clients.Model;

namespace Clients.DAL.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        IQueryable<Client> GetNotDeleted();

        Task<Client?> GetByID(long clientID);

        Task<bool> EmailExists(string email, long? clientID);
    }
}