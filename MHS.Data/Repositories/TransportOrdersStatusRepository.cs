using MHS.Api.Models;
using MHS.Data.Models;

namespace MHS.Data.Repositories
{
    public class TransportOrdersStatusRepository : ITransportOrdersStatusRepository
    {
        private readonly IEnumerable<TransportOrderStatus> _statuses = new List<TransportOrderStatus>()
        {
            new TransportOrderStatus(new TransportOrder() { ComponentId = Guid.Parse("623FF033-45A7-47D6-9F8D-3BD7BED4D2DC") },
                status: TransportOrderStatus.Type.Sent,
                reported: DateTime.UtcNow.AddMinutes(-5)),
            new TransportOrderStatus(new TransportOrder() { ComponentId = Guid.Parse("623FF033-45A7-47D6-9F8D-3BD7BED4D2DC") },
                status: TransportOrderStatus.Type.Running,
                reported: DateTime.UtcNow.AddMinutes(-4)),
            new TransportOrderStatus(new TransportOrder() { ComponentId = Guid.Parse("623FF033-45A7-47D6-9F8D-3BD7BED4D2DC") },
                status: TransportOrderStatus.Type.Completed,
                reported: DateTime.UtcNow.AddMinutes(-2)),
            new TransportOrderStatus(new TransportOrder() { ComponentId = Guid.Parse("892BE913-5D61-4378-BDD1-B9ECE9992DAB") },
                status: TransportOrderStatus.Type.Sent,
                reported: DateTime.UtcNow.AddMinutes(-8)),

        };
        private readonly ITransportOrdersRepository transportOrdersRepository;

        public TransportOrdersStatusRepository(ITransportOrdersRepository transportOrdersRepository)
        {
            this.transportOrdersRepository = transportOrdersRepository;
        }
        public IEnumerable<TransportOrderStatus> GetById(Guid id)
        {
            // would join transportOrdersRepository to assemble status
            return _statuses.Where(s => s.Order.ComponentId == id).OrderByDescending(s => s.Reported).ToList();
        }
    }
}
