using Clients.Model;
using ClientsDto.PolygonEntities;

namespace Clients.BL.IManager
{
    public interface IPolygonManager 
    {
        Task<List<PolygonTicker>> GetPolygonTickers();

        Task SavePreviousCloses(List<(long tickerID, PreviousClose previousClose)> previousCloses);
    }
}