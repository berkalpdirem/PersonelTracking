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
            DbSetEmployeeDetail= context.Set<EmployeeDetail>();
        }

        public string RegisterEmployee(int TcNO, string Name, string SurName, MaritalStatus MartialStatus, Cities BirthCity, Cities LivingCity, DateTime BirthDate, string MotherName, string FatherName )
        {
            if (DbSetEmployee.Where(e => e.tcNo == TcNO).Any())
            {
                return "Mevcut Çalışan Sisteme Daha Önce Eklenmiş";
            }
            else
            {
                try
                {
                    Employee newEmployee = new Employee()
                    {
                        tcNo = TcNO,
                        name = Name,
                        surname = SurName,
                        dataStatus = DataStatus.Current,
                        employeeDetail = new EmployeeDetail()
                        {
                            maritalStatus = MartialStatus,
                            birthCity = BirthCity,
                            livingCity = LivingCity,
                            birthDate = BirthDate,
                            motherName = MotherName,
                            fatherName = FatherName
                        }
                    };
                    Add(newEmployee);
                    return "Kayıt Başarılı";
                }
                catch (Exception)
                {

                    return "Kayıt Başarısız";
                }
               
            }
        }
        public string DeleteEmployee(int ID)
        {
            try
            {
                var softDeleteData = Get(ID);
                softDeleteData.dataStatus = DataStatus.SoftDeleted;
                return "Silme İşlemi Başarılı";
            }
            catch (Exception)
            {

                return "Silme İşlemi Başarısız";
            }
        }
        public string UpdateEmployee(int ID, int TcNO, string Name, string SurName, MaritalStatus MartialStatus, Cities BirthCity, Cities LivingCity, DateTime BirthDate, string MotherName, string FatherName)
        {
            var selectedEmployee = DbSetEmployee.Where(e => e.Id == ID).FirstOrDefault();
            if (selectedEmployee == null)
            {
                return "Güncelleme Başarısız";
            }
            else
            {
                try
                {
                    selectedEmployee.tcNo = TcNO;
                    selectedEmployee.name = Name;
                    selectedEmployee.surname = SurName;

                    var selectedEmployeeDetail = DbSetEmployeeDetail.Where(e => e.employeeID == ID).FirstOrDefault();

                    selectedEmployeeDetail.maritalStatus = MartialStatus;
                    selectedEmployeeDetail.birthCity = BirthCity;
                    selectedEmployeeDetail.livingCity = LivingCity;
                    selectedEmployeeDetail.birthDate = BirthDate;
                    selectedEmployeeDetail.motherName = MotherName;
                    selectedEmployeeDetail.fatherName = FatherName;

                    Update(selectedEmployee);
                    return "Güncelleme Başarılı";
                }
                catch (Exception)
                {

                    return "Güncelleme Başarısız";
                }
            }
            
        }
        
        public Employee GetEmployee(int TcNo)
        {
            return DbSetEmployee.Where(e => e.tcNo == TcNo).FirstOrDefault();
        }
        public List<Employee> ListEmployee()
        {
            return DbSetEmployee.ToList();
        }
    }
}
