using PersonelTracking_4_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class DayOf : BaseEntity
    {
        public DateTime dayOfStartDate { get; set; }

        public int dayOfLenghtByDay { get; set; }

        public DateTime dayOfEndDate { get; set; }

        #region Navigation Properties
        // DayOf-EmployeeCompanyInfo Relation
        public EmployeeCompanyInfo employeeCompanyInfo { get; set; }
        public int employeeCompanyInfoID { get; set; }

        #endregion
    }
}
