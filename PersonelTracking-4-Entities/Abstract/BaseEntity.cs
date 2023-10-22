using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTracking_4_Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
