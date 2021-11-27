using MediatR;
using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommand:IRequest<User>
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }

        public String Type { get; set; }

        public bool Enabled { get; set; }
    }
}
