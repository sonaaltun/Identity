using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Core.BaseEntites
{
    public class BaseUser :AuditableEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string IdentityId { get; set; }
    }
}
