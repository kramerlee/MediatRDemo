using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lib.Application.Cart.Commands
{
    public class CreateCartCommand : IRequest
    {
        public string Name { get; set; }
    }
    
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, Unit>
    {
        public Task<Unit> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Unit());
        }
    }
}