using MHS.Data.Models;

namespace MHS.Data.Repositories
{
    public interface ITransportOrdersStatusRepository 
    {
        IEnumerable<TransportOrderStatus> GetById(Guid id);
    }
}
