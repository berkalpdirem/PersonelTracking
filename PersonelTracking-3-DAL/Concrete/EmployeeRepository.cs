using Microsoft.EntityFrameworkCore;
using PersonelTracking_4_Entities.Abstract.Enums;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_3_DAL.Concrete
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        private DbSet<Employee> DbSetEmployee;
        private DbSet<EmployeeDetail> DbSetEmployeeDetail;
        public EmployeeRepository(DbContext context) : base(context)
        {
            DbSetEmployee = context.Set<Employee>();
            DbSetEmployeeDetail = context.Set<EmployeeDetail>();
        }

        public string RegisterEmployee(int TcNO, string Name, string SurName, MaritalStatus MartialStatus, DateTime BirthDate, string BirthPlace, string MotherName, string FatherName, Cities LivingCity)
        {
            if (DbSetEmployee.Where(e => e.tcNo == TcNO).Any())
            {
                return "Mevcut Çalışan Sisteme Daha Önce Eklenmiş";
            }
            else
            {
                Employee newEmployee = new Employee()
                {
                    tcNo = TcNO,
                    name = Name,
                    surname = SurName,
                    employeeDetail = new EmployeeDetail()
                    {
                        maritalStatus = MartialStatus,
                        birthDate = BirthDate,
                        motherName = MotherName,
                        fatherName = FatherName,
                        livingCity = LivingCity
                    }
                };
                Add(newEmployee);
                return "Kayıt Başarılı";
            }

        }
    }
}
