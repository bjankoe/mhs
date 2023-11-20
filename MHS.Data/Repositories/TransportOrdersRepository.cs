using MHS.Api.Models;

namespace MHS.Data.Repositories
{
    public class TransportOrdersRepository : ITransportOrdersRepository
    {
        private readonly IEnumerable<TransportOrder> _orders = new List<TransportOrder>()
        {
            new TransportOrder() { ComponentId = Guid.Parse("623FF033-45A7-47D6-9F8D-3BD7BED4D2DC") },
            new TransportOrder() { ComponentId = Guid.Parse("892BE913-5D61-4378-BDD1-B9ECE9992DAB") },
        };
        public TransportOrder GetById(Guid id)
        {
            return _orders.FirstOrDefault(t => t.ComponentId == id);
        }

        public IEnumerable<TransportOrder> GetByComponentId(Guid componentId)
        {
            return _orders.Where(o => o.ComponentId == componentId).ToList();
        }
    }
}
