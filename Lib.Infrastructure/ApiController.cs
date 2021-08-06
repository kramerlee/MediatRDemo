using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Lib.Infrastructure
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController : ControllerBase
    {
        private IMediator _mediator;

        private IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected async Task<IActionResult> SendAsync<TRequest>(TRequest command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}