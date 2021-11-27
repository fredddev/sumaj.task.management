using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Application.Features.Users.Queries.GetUsersList
{
    public class GetUsersListQuery: IRequest<List<UserListVm>>
    {
    }
}
