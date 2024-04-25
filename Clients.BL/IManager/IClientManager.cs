using ClientsDto.Dtos;

namespace Clients.BL.IManager
{
    public interface IClientManager
    {
        Task<IEnumerable<ClientDto>> GetAll();

        Task<ClientDto?> GetByID(long clientID);

        Task<ClientDto> CreateClient(UpdateClientDto createClientDto);

        Task UpdateClient(long clientID, UpdateClientDto updateClientDto);

        Task DeleteClient(long clientID);
    }
}