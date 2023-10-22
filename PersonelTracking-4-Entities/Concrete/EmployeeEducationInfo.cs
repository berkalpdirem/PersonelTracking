using PersonelTracking_4_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class EmployeeEducationInfo : BaseEntity
    {
        public string highSchoolGradued { get; set; }
        public int highSchoolGraduedGPA { get; set; }

        public string universityGradued { get; set; }
        public int universityGraduedGPA { get; set; }

        #region Navigation Properties
        //Employee-EmployeeEducationInfo Relation

        public Employee employee { get; set; }
        public int employeeID { get; set; }

        // EmployeeEducation-Certificate Relation
        public List<Certificate> Certificates { get; set; }
        #endregion
    }
}
