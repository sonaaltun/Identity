using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Identity.Domain.Core.BaseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Core.BaseEntityConfiguration
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x=>x.CreatedBy).IsRequired();
            builder.Property(x=>x.CreateDate).IsRequired();
            builder.Property(x=>x.Status).IsRequired();
            builder.Property(x=>x.UpdatedBy).IsRequired(false);
            builder.Property(x=>x.UpdatedDate).IsRequired(false);
        }
    }
}
