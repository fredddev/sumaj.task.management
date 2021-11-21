using AutoMapper;
using MediatR;
using Sumaj.MyTask.Management.Application.Contracts.Persistence;
using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IAsyncRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IMapper mapper,IAsyncRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }


        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userToUpdate = await _userRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, userToUpdate, typeof(UpdateUserCommand), typeof(User));
            
            await _userRepository.UpdateAsync(userToUpdate);

            return Unit.Value;
        }
    }
}
