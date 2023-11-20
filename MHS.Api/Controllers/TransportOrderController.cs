using Microsoft.AspNetCore.Mvc;
using MHS.Api.Models;
using MHS.Api.Services;

namespace MHS.Api.Controllers
{
    [ApiController]
    
    public class TransportOrderController : ControllerBase
    {
        private readonly ILogger<TransportOrderController> _logger;
        private readonly IServiceFactory serviceFactory;

        public TransportOrderController(ILogger<TransportOrderController> logger, IServiceFactory serviceFactory)
        {
            _logger = logger;
            this.serviceFactory = serviceFactory;
        }

        /// <summary>
        /// An application or a rest endpoint that create a Transport Order for the AGV/Automation systems.
        /// </summary>
        [HttpPost]
        [Route("api/v1/send/[controller]")]
        public async Task<ActionResult<bool>> SendTransportOrder([FromBody]TransportOrder order)
        {
            var commandService = serviceFactory.Create(order.ComponentId);

            return await commandService.SendTransportOrder(order);
        }

        /// <summary>
        /// An application or API for fetching the current state of the Transport Order.
        /// </summary>
        [HttpGet]
        [Route("api/v1/get/{componentId}/[controller]")]
        public async Task<ActionResult<TransportOrder>> GetCurrentTransportOrder(Guid componentId)
        {
            return await Task.FromResult(new TransportOrder() { ComponentId = componentId });
        }

        /// <summary>
        /// An application for displaying historical Transport Orders.
        /// </summary>
        [HttpGet]
        [Route("api/v1/get/{componentId}/[controller]s")]
        public async Task<ActionResult<IEnumerable<TransportOrder>>> GetTransportOrders(Guid componentId)
        {
            var data = new List<TransportOrder>()
            {
                new TransportOrder() { ComponentId = componentId },
                new TransportOrder() { ComponentId = componentId }
            };

            return await Task.FromResult(data);
        }
    }
}