using PersonelTracking_4_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class EmployeePersonalDocumnet : BaseEntity
    {
        public string adress { get; set; }
        public string healthReport{ get; set; }
        public string criminalRecordCertificate { get; set; }
        public string driversLicense { get; set; }
        public string companyContract { get; set; }
        public string cv { get; set; }
        public string jobApplication { get; set; }
        public string familyIdentityCard { get; set; }
        public string militaryServiceCertificate { get; set; }

        #region Navigation Properties
        // Employee-EmployeePersonalDocumnet Relation
        public Employee employee { get; set; }
        public int employeeID { get; set; }
        #endregion

    }
}
