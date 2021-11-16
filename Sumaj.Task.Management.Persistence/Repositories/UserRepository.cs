using Sumaj.Task.Management.Application.Contracts.Persistence;
using Sumaj.Task.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.Task.Management.Persistence.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(SumajTaskManagementDbContext dbContext) : base(dbContext)
        {

        }
    }
}
