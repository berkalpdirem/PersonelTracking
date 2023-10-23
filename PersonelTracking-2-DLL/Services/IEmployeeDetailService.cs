using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_2_DLL.Services
{
    public interface IEmployeeDetailService
    {
        EmployeeDetail GetEmployee(int TcNO);
    }
}
