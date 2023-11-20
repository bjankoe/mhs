using MHS.Api.Models;

namespace MHS.Api.Vendors
{
    public interface ICommandService : IIdentifiable
    {
        Task<bool> SendTransportOrder(TransportOrder order);
    }
}
