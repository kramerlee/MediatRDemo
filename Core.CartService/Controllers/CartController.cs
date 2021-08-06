using Lib.Application.Cart.Commands;
using Lib.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CartService.Controllers
{
    [Route("api/carts")]
    public class CartController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateCartCommand command) => await SendAsync(command);
    }
}