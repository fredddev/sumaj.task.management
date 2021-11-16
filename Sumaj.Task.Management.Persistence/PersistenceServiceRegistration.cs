using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sumaj.Task.Management.Application.Contracts.Persistence;
using Sumaj.Task.Management.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.Task.Management.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SumajTaskManagementDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SumajTaskManagementConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
