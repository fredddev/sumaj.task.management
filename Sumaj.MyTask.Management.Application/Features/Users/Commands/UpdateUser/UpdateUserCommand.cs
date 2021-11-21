using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommand:IRequest
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }

        public String Type { get; set; }

        public bool Enabled { get; set; }
    }
}
