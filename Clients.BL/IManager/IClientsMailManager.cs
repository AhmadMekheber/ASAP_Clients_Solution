namespace Clients.BL.IManager
{
    public interface IClientsMailManager
    {
        Task SendMailsToUnnotifiedClients();
    }
}