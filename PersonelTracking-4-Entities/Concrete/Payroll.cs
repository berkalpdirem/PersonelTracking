using PersonelTracking_4_Entities.Abstract;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Concrete
{
    public class Payroll :BaseEntity
    {
        public int netSalaryAmount { get; set; }
        public DateTime depositDate { get; set; }

        #region Navigation Properties
        //Payroll-EmployeeCompanyInfo Relation
        public EmployeeCompanyInfo employeeCompanyInfo { get; set; }
        public int employeeCompanyInfoID { get; set; }
        #endregion
    }
}
