using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core
{
    public class ConnString
    {
       public String localConnection()
       {
           return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
       }
    }



   
}