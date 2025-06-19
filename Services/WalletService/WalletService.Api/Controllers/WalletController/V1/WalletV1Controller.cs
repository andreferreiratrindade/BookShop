using Framework.Core.Mediator;
using Framework.WebApi.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace WalletService.Api.Controllers;


[ApiController]
[Route("api/transaction/v1/")]
[OpenApiTag("Activity workers", Description = "Activity workers services")]
public class WalletV1Controller(IMediatorHandler mediatorHandler) : MainController
{
// {
//     public async Task<IActionResult> GetWallets()
//     {
//         return CustomResponseStatusCodeOk(await mediatorHandler.Send(new GetAllWallets()));
//     }
}