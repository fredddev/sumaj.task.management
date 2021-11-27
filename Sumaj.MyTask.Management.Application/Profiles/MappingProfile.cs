using AutoMapper;
using Sumaj.MyTask.Management.Application.Features.Users.Commands.CreateUser;
using Sumaj.MyTask.Management.Application.Features.Users.Commands.UpdateUser;
using Sumaj.MyTask.Management.Application.Features.Users.Queries.GetUsersList;
using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<User, UserListVm>().ReverseMap();
            CreateMap<User, CreateUserCommand>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();
        }
    }
}
