using MHS.Api.Models;

namespace MHS.Data.Repositories
{
    public interface IComponentsRepository
    {
        ComponentInfo GetById(Guid id);
        ComponentInfo GetByVendorId(string vendorId);
    }
}
