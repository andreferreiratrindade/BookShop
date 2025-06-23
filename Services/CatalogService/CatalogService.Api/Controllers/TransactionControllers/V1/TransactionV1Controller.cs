using System.Net;
using Microsoft.AspNetCore.Mvc;
using Framework.WebApi.Core.Controllers;
using Framework.Core.Mediator;
using NSwag.Annotations;
using CatalogService.Application.Commands.Purchase;
using CatalogService.Application.Commands.Sell;

namespace CatalogService.Api.Controllers
{
    [ApiController]
    [Route("api/transaction/v1/")]
    [OpenApiTag("Activity workers", Description = "Activity workers services")]
    public class TransactionV1Controller(IMediatorHandler mediatorHandler) : MainController
    {
        /// <summary>
        /// Purchase a stock
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("purchase")]
        [ProducesResponseType(typeof(PurchaseCommandOutput),(int)HttpStatusCode.Accepted)]
        [ProducesResponseType(typeof(ValidationProblemDetails),(int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationProblemDetails),(int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Purchase([FromBody] PurchaseCommand command)
        {
            var commandHandlerOutput = await mediatorHandler.SendCommand<PurchaseCommand, PurchaseCommandOutput>(command);
            return CustomResponseStatusCodeAccepted(commandHandlerOutput, $"api/transaction/v1/{commandHandlerOutput.TransactionStockId}");
        }

          /// <summary>
        /// Sell a stock
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("sell")]
        [ProducesResponseType(typeof(PurchaseCommandOutput),(int)HttpStatusCode.Accepted)]
        [ProducesResponseType(typeof(ValidationProblemDetails),(int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationProblemDetails),(int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Sell([FromBody] SellCommand command)
        {
            var commandHandlerOutput = await mediatorHandler.SendCommand<SellCommand, SellCommandOutput>(command);
            return CustomResponseStatusCodeAccepted(commandHandlerOutput, $"api/transaction/v1/{commandHandlerOutput.TransactionStockId}");
        }
    }
}
