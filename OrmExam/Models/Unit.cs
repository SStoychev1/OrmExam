using OrmExam.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmExam.Models
{
    public class Unit : BaseEntity
    {
        public string UnitSold{ get; set; }
        public string UnitCost { get; set; }
        public  string UnitPrice { get; set; }

        public ItemInfo ItemInfo { get; set; }
    }
}
