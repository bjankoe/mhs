using MHS.Api.Models;
using System.Threading;

namespace MHS.Api.Vendors.VendorA
{
    /// <summary>
    /// Transport order vendor equivalent
    /// </summary>
    public class TransportOrderService : ICommandService, IIdentifiable
    {
        internal const string integrationId = "8e80cdae-f021-4016-80d1-ee7d47e26e1b";
        public Guid Id => Guid.Parse(integrationId);

        public async Task<bool> SendTransportOrder(TransportOrder order)
        {
            // implement converter to vendor specific message type
            // Implement vendor specific way of sending orders
            return await Task.FromResult(true);
        }
    }
}
