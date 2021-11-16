using AutoMapper;
using MediatR;
using Sumaj.Task.Management.Application.Contracts.Persistence;
using Sumaj.Task.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sumaj.Task.Management.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository) 
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var @user = _mapper.Map<User>(request);

            user = await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}
