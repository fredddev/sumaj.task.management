using AutoMapper;
using MediatR;
using Sumaj.MyTask.Management.Application.Contracts.Persistence;
using Sumaj.MyTask.Management.Application.Exceptions;
using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //var createUserCommandResponse = new CreateUserCommandResponse();


            var validator = new CreateUserCommandValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var @user = _mapper.Map<User>(request);
            user = await _userRepository.AddAsync(user);


            return user;
        }
    }
}
