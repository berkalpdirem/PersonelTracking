using PersonelTracking_4_Entities.Abstract;
using PersonelTracking_4_Entities.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Contrete
{
    public class EmployeeCompanyInfo : BaseEntity
    {
        public DateTime startDateOfWork { get; set; }
        public DateTime endDateOfWork { get; set; }

        public EmployeeStatus employeeStatus { get; set; }
        public UnitOfWork unitOfWork { get; set; }
        public Seniority seniority { get; set; }
        public int salary { get; set; }

        public int  dayOfCountRightYearly{ get; set; }
        public int dayOfCountRightCurrent { get; set; }

        #region Navigation Properties
        // Employee-EmployeeCompanyInfo Relation
        public Employee employee { get; set; }
        public int employeeId { get; set; }

        // DayOf-EmployeeCompanyInfo Relation
        public List<DayOf> dayOfs { get; set; }

        #endregion
    }
}
