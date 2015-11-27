using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElearningPlatform.Core.DAO;

namespace ElearningPlatform.Core
{
    public interface IBLLFactroy
    {
        IExamsBLL BuildExamsBLL();

        IAccountBLL BuildAccountBLL();
    }




}
