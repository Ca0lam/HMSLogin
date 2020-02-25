using HMSLogin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class Department
    {
        int departmentID { get; set; }
        string departmentName { get; set; }

        Bed[] beds { get; set; }
    }
}
