using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sumaj.Task.Management.Application.Features.Users.Queries.GetUsersList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sumaj.TaskManagement.Api.Controllers
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

    }
}
