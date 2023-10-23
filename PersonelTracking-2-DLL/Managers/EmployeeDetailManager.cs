using PersonelTracking_2_DLL.Services;
using PersonelTracking_3_DAL.Concrete;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_2_DLL.Managers
{
    public class EmployeeDetailManager : BaseManager<EmployeeDetail>, IEmployeeDetailService
    {

        protected EmployeeDetailRepository _employeeDetailRepository;
        public int _id;

        public EmployeeDetailManager(GenericRepository<EmployeeDetail> genericRepository, EmployeeDetailRepository employeeDetailRepository) : base(genericRepository)
        {
            _employeeDetailRepository = employeeDetailRepository;
        }

        public EmployeeDetail GetEmployee(int TcNO)
        {
            throw new NotImplementedException();
        }
    }
}
