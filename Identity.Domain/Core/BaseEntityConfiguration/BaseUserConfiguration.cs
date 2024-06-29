using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Identity.Domain.Core.BaseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Core.BaseEntityConfiguration
{
    public class BaseUserConfiguration<TEntity> : AuditableEntityConfiguration<TEntity> where TEntity : BaseUser
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x=>x.Password).IsRequired();
           
            base.Configure(builder);
        }
    }
}
