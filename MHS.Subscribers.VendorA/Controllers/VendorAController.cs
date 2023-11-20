using MHS.Data.Repositories;
using MHS.Subscribers.VendorA.Models;
using Microsoft.AspNetCore.Mvc;

namespace MHS.Subscribers.VendorA.Controllers
{
    [ApiController]
    public class VendorAController : ControllerBase
    {
        private readonly IComponentsRepository componentsRepository;

        private readonly ITransportOrdersStatusRepository transportOrdersStatusRepository;
        private readonly ILogger<VendorAController> _logger;

        public VendorAController(
            IComponentsRepository componentsRepository,

            ITransportOrdersStatusRepository transportOrdersStatusRepository,
            ILogger<VendorAController> logger)
        {
            this.componentsRepository = componentsRepository;
            this.transportOrdersStatusRepository = transportOrdersStatusRepository;
            _logger = logger;
        }

        [HttpPost]
        [Route("api/vendora/v1/{status}/status")]
        public async Task<int> UpdateStatus([FromBody]VendorAComponentStatus status)
        {
            var component = componentsRepository.GetByVendorId(status.ComponentId.ToString());
            // get latest order (because fx. this component can only accept one at a time)
            // convert vendor status to status
            return await Task.FromResult(1);
        }
    }
}