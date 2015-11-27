using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core.DAO
{
    public interface IAccount
    {
        String Login { get; set; }
        String Password { get; set; }
    }
}