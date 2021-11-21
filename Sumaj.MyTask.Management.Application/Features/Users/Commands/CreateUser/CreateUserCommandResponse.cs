using Sumaj.MyTask.Management.Application.Responses;
using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandResponse:BaseResponse
    {
        public User User { get; set; }

        public CreateUserCommandResponse():base()
        { 
        
        }
    }
}
