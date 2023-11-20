using MHS.Data.Repositories;
using MHS.Api.Vendors;

namespace MHS.Api.Services
{
    public interface IServiceFactory
    {
        ICommandService Create(Guid integrationId);
    }

    public class ServiceFactory : IServiceFactory
    {
        private readonly IEnumerable<ICommandService> commandServices;
        private readonly IComponentsRepository componentRepository;

        public ServiceFactory(IEnumerable<ICommandService> commandServices,
            IComponentsRepository componentRepository)
        {
            this.commandServices = commandServices;
            this.componentRepository = componentRepository;
        }

        public ICommandService Create(Guid componentId)
        {
            var componentInfo = componentRepository.GetById(componentId);
            if (componentInfo is null)
                throw new ArgumentException($"Component {componentId} not registered.");

            var service = commandServices.FirstOrDefault(c => componentInfo.IntegrationId == c.Id);

            if (service is null)
                throw new ArgumentException($"Cannot find associated service for component {componentId}");

            return service;
        }
    }
}
