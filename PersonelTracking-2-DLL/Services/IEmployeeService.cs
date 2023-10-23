using PersonelTracking_4_Entities.Abstract.Enums;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_2_DLL.Services
{
    public interface IEmployeeService
    {
        string RegisterEmployee(int TcNO, string Name, string SurName, MaritalStatus MartialStatus, Cities BirthCity, Cities LivingCity, DateTime BirthDate, string MotherName, string FatherName);

        string UpdateEmployee(int ID, int TcNO, string Name, string SurName, MaritalStatus MartialStatus, Cities BirthCity, Cities LivingCity, DateTime BirthDate, string MotherName, string FatherName);

        string DeleteEmployee(int ID);

        Employee GetEmployee(int TcNO);
    }
}
