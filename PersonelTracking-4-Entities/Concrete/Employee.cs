using PersonelTracking_4_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class Employee : BaseEntity
    {
        public int tcNo { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        #region Navigation Properties
        // Employee-EmployeeDetail Relation
        public EmployeeDetail employeeDetail { get; set; }
        public int employeeDetailID { get; set; }

        // Employee-EmployeePersonalDocumnet Relation
        public EmployeePersonalDocumnet employeePersonalDocumnet { get; set; }
        public int employeePersonalDocumnetID { get; set; }

        //Employee-EmployeeEducationInfo Relation
        public EmployeeEducationInfo employeeEducationInfo { get; set; }
        public int employeeEducationInfoID { get; set; }

        // Employee-EmployeeCompanyInfo Relation
        public EmployeeCompanyInfo employeeCompanyInfo { get; set; }
        public int employeeCompanyInfoID { get; set; }
        #endregion

    }
}
