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

namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }


        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {


            var validator = new UpdateUserCommandValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);



            //obtener usuario actual
            var userToUpdate = await _userRepository.GetByIdAsync(request.Id);
            //mapear usuario de bd en datos de usuario que llego al endpoint
            _mapper.Map(request, userToUpdate, typeof(UpdateUserCommand), typeof(User));
            //aplicar update
            userToUpdate = await _userRepository.UpdateAsync(userToUpdate);



            return userToUpdate;
        }
    }
}
