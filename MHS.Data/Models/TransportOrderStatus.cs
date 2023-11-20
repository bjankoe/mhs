using MHS.Api.Models;

namespace MHS.Data.Models
{
    public class TransportOrderStatus
    {
        public enum Type
        {
            Unknown = 0,
            Sent = 1,
            Running = 2,
            Completed = 3,
            Failed = 4
        }

        public DateTime Reported { get; }
        public Type Status { get; }
        public TransportOrder Order { get; }
        public TransportOrderStatus(TransportOrder order, Type status, DateTime reported)
        {
            Order = order;
            Status = status;
            Reported = reported;
        }
    }
}
