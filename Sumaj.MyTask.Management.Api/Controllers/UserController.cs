using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sumaj.MyTask.Management.Application.Features.Users.Commands.CreateUser;
using Sumaj.MyTask.Management.Application.Features.Users.Queries.GetUsersList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sumaj.MyTask.Management.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("all", Name = "GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<UserListVm>>> GetAllUsers()
        {            
            var dtos = await _mediator.Send(new GetUsersListQuery());
            return Ok(dtos);
        }

        [HttpPost(Name = "AddUser")]
        public async Task<ActionResult<int>> Create([FromBody] CreateUserCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);

            //if (response.Success)
            //{

                return Ok(response);
            //}
            //else
            //{
                
            //    return BadRequest(response);
            //}


        }


        

    }
}
