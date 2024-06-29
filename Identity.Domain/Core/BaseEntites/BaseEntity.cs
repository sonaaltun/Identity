using Identity.Domain.Core.Interfaces;
using Identity.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Core.BaseEntites
{
    public class BaseEntity :IUpdatebleEntity
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set ; }
        public DateTime? UpdatedDate { get ; set ; }
    }
    
}
