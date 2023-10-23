using PersonelTracking_2_DLL.Services;
using PersonelTracking_3_DAL.Concrete;
using PersonelTracking_4_Entities.Abstract.Enums;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_2_DLL.Managers
{
    public class EmployeeManager : BaseManager<Employee> , IEmployeeService
    {
        protected EmployeeRepository _employeeRepository;
        public int _id;

        public EmployeeManager(GenericRepository<Employee> genericRepository, EmployeeRepository employeeRepository) : base(genericRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public string RegisterEmployee(int TcNO, string Name, string SurName, MaritalStatus MartialStatus, Cities BirthCity, Cities LivingCity, DateTime BirthDate, string MotherName, string FatherName)
        {
            return _employeeRepository.RegisterEmployee(TcNO, Name, SurName, MartialStatus, BirthCity, LivingCity, BirthDate, MotherName, FatherName);
        }

        public string UpdateEmployee(int ID, int TcNO, string Name, string SurName, MaritalStatus MartialStatus, Cities BirthCity, Cities LivingCity, DateTime BirthDate, string MotherName, string FatherName)
        {
            return  _employeeRepository.UpdateEmployee(ID, TcNO, Name, SurName, MartialStatus, BirthCity, LivingCity, BirthDate, MotherName, FatherName);
        }

        public string DeleteEmployee(int ID)
        {
            return _employeeRepository.DeleteEmployee(ID);
        }


        public Employee GetEmployee(int TcNO)
        {
            return _employeeRepository.GetEmployee(TcNO);
        }
    }
}
