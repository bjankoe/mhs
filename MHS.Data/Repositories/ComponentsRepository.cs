using MHS.Api.Models;
using MHS.Data.Models;

namespace MHS.Data.Repositories
{
    public class ComponentsRepository : IComponentsRepository
    {
        /// <summary>
        /// For convenience only
        /// </summary>
        private static class IntegrationsIds
        {
            internal const string VendorA = "8e80cdae-f021-4016-80d1-ee7d47e26e1b";
            internal const string VendorB = "0934ee2f-777f-4d4f-98a2-a7078f2454b7";
        }

        private readonly IEnumerable<ComponentInfo> _components = new List<ComponentInfo>()
        {
            new ComponentInfo()
            {
                ComponentId = Guid.Parse("623FF033-45A7-47D6-9F8D-3BD7BED4D2DC"),
                InternalId = "007",
                IntegrationId = Guid.Parse(IntegrationsIds.VendorA)
            },
            new ComponentInfo()
            {
                ComponentId = Guid.Parse("892BE913-5D61-4378-BDD1-B9ECE9992DAB"),
                InternalId = "Bot25",
                IntegrationId = Guid.Parse(IntegrationsIds.VendorB)
            }
        };
        public ComponentInfo GetById(Guid id)
        {
            return _components.FirstOrDefault(c => c.ComponentId == id);
        }

        public ComponentInfo GetByVendorId(string vendorId)
        {
            return _components.FirstOrDefault(c => c.InternalId == vendorId);
        }
    }
}
