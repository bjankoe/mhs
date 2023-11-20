using System.Numerics;

namespace MHS.Api.Models
{
    public static class Integrations
    {
        internal const string integrationId = "8e80cdae-f021-4016-80d1-ee7d47e26e1b";
    }

    public class ComponentInfo
    {
        public Guid ComponentId { get; set; }
        public string InternalId { get; set; }
        public Guid IntegrationId { get; set; }
    }
}
