using Identity.Domain.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Utilities.Concretes
{
    public class Result : IResult
    {
        public bool IsSuccess { get ; set ; }
        public string Messages { get; set; }

        public Result()
        {
            IsSuccess = false;
            Messages = string.Empty;
        }
        public Result(bool isSuccess)
        {
            IsSuccess=isSuccess;
        }
        public Result(bool isSucces,string messages):this(isSucces)
        {
            Messages = messages;
        }
        
    }
}
