using PersonelTracking_4_Entities.Abstract;
using PersonelTracking_4_Entities.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class EmployeeDetail : BaseEntity
    {
        public MaritalStatus maritalStatus { get; set; }
        public DateTime birthDate { get; set; }
        public Cities birthCity { get; set; }
        public string motherName { get; set; }
        public string fatherName { get; set; }
        public Cities livingCity { get; set; }

        #region Navigation Properties
        // Employee-EmployeeDetail Relation
        public Employee employee { get; set; }
        public int employeeID { get; set; }
        #endregion
    }
}
