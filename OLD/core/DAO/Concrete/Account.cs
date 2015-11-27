using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core.DAO
{
    public class Account : IAccount
    {
        public String Login { get; set; }
        public String Password { get; set; }
    }
}