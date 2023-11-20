using MHS.Api.Models;

namespace MHS.Api.Vendors.VendorB
{
    /// <summary>
    /// Transport order vendor equivalent
    /// </summary>
    public class TransportOrderService : ICommandService, IIdentifiable
    {
        internal const string integrationId = "0934ee2f-777f-4d4f-98a2-a7078f2454b7";
        public Guid Id => Guid.Parse(integrationId);

        public async Task<bool> SendTransportOrder(TransportOrder order)
        {
            // implement converter to vendor specific message type
            // Implement vendor specific way of sending orders
            return await Task.FromResult(true);
        }
    }
}
