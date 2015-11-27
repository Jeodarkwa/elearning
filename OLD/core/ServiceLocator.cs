using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElearningPlatform.Core
{
    public class ServiceLocator 
    {
        public static IDALFactory GetCurrentDALFactory()
        {
            return new DALFactory(); 
        }

        public static IBLLFactroy GetCurrentBLLFactory()
        {
            return new BLLFactory();
        }

    }
}