using Lib.Application.User.Commands;
using Lib.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace UserService.Controllers
{
    [Route("api/users")]
    public class UserController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command) => await SendAsync(command);
    }
}