using System;
using System.Linq;
using System.Threading.Tasks;
using Sumaj.MyTask.Management.Domain.Entities;
using Sumaj.MyTask.Management.Application.Contracts.Persistence;


namespace Sumaj.MyTask.Management.Persistence.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {        
        public UserRepository(SumajTaskManagementDbContext dbContext) : base(dbContext)
        {
        
        }

        public Task<bool> IsUserNameUnique(string name)
        {

            //var user3 = _dbContext.Users.SingleOrDefault(e => e.Name == "Juan4");
            //var user2 = _dbContext.Users.SingleOrDefault(e => e.Id == 2);
            var user =  !(_dbContext.Users.Any(e => e.Name.Equals(name)));

            return Task.FromResult(user);
            
            //aca implementar validacion para ver si hay un usuario que tenga el mismo nombre
            //throw new NotImplementedException();
        }

        public Task<bool> IsUserNameUnique(string name, int userId)
        {
            var user = !(_dbContext.Users.Any(e => e.Name.Equals(name) && e.Id != userId));
            return Task.FromResult(user);
        }
    }
}
