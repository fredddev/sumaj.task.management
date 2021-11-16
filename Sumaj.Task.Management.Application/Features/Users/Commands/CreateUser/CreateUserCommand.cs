using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.Task.Management.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public String Name { get; set; }
        public String Password { get; set; }
    }
}
