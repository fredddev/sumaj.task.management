using AutoMapper;
using MediatR;
using Sumaj.Task.Management.Application.Contracts.Persistence;
using Sumaj.Task.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sumaj.Task.Management.Application.Features.Users.Queries.GetUsersList
{
    class GetUsersListQueryHandler: IRequestHandler<GetUsersListQuery,List<UserListVm>>
    {
        private readonly IMapper _mapper;
        private IAsyncRepository<User> _userRepository;

        public GetUsersListQueryHandler(IMapper mapper, IAsyncRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserListVm>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var users = (await _userRepository.ListAllAsync()).OrderBy(x => x.Name);

            return _mapper.Map<List<UserListVm>>(users);
        }
    }
}
