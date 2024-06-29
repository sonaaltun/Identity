using Identity.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Core.BaseEntites
{
    public class AuditableEntity : BaseEntity,IDeletableEntity
    {
       
        public DateTime? DeleteDate { get ; set ; }
        public string? DeletedBy { get; set; }
    }
}
