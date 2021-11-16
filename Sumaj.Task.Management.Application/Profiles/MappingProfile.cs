using AutoMapper;
using Sumaj.Task.Management.Application.Features.Users.Queries.GetUsersList;
using Sumaj.Task.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.Task.Management.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<User, UserListVm>().ReverseMap();
        }
    }
}
