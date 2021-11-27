using Microsoft.EntityFrameworkCore;
using Sumaj.MyTask.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Persistence
{
    public class SumajTaskManagementDbContext : DbContext
    {
        public SumajTaskManagementDbContext(DbContextOptions<SumajTaskManagementDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SumajTaskManagementDbContext).Assembly);
        }
    }
}
