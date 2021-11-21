using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sumaj.MyTask.Management.Application.Contracts.Persistence
{
    public interface IUserRepository: IAsyncRepository<User>
    {
        Task<bool> IsUserNameUnique(string name);
    }
}
