using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lib.Application.User.Commands
{
    public class CreateUserCommand : IRequest<UserEntity>
    {
        public string Username { get; set; }
    }
    
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserEntity>
    {
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<UserEntity> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine(request.Username);
            return Task.FromResult(_mapper.Map<UserEntity>(request));
        }
    }

    public class UserEntity
    {
        public string Name { get; set; }
    }

    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserCommand, UserEntity>();
        }
    }
}