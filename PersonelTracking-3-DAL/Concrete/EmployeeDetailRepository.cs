using Microsoft.EntityFrameworkCore;
using PersonelTracking_4_Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_3_DAL.Concrete
{
    public class EmployeeDetailRepository : GenericRepository<EmployeeDetail>
    {
        private DbSet<EmployeeDetail> DbSetEmployeeDetail;
        public EmployeeDetailRepository(DbContext context) : base(context)
        {
            DbSetEmployeeDetail = context.Set<EmployeeDetail>();
        }



    }
}
