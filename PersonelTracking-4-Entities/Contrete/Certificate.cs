using PersonelTracking_4_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class Certificate : BaseEntity
    {
        public string CertificateName { get; set; }
        public DateTime IssueDate { get; set; }

        #region Navigation Properties
        // EmployeeEducation-Certificate Relation 
        public EmployeeEducationInfo EmployeeEducationInfo { get; set; }
        public int EmployeeEducationInfoId { get; set; }
        #endregion
    }
}
