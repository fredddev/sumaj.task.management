using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sumaj.Task.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.Task.Management.Persistence.Configurations
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
