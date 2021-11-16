using Sumaj.Task.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.Task.Management.Application.Contracts.Persistence
{
    public interface IUserRepository: IAsyncRepository<User>
    {
    }
}
