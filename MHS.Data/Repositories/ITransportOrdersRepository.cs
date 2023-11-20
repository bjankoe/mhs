using MHS.Api.Models;

namespace MHS.Data.Repositories
{
    public interface ITransportOrdersRepository
    {
        TransportOrder GetById(Guid id);
        IEnumerable<TransportOrder> GetByComponentId(Guid componentId);
    }
}
