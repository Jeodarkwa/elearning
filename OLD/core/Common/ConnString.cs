using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core
{
    public static class ConnString
    {
       public static String localConnection()
       {
           return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
       }
    }



   
}