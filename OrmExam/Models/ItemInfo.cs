using OrmExam.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmExam.Models
{
    public class ItemInfo : BaseEntity
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string ItemType { get; set; }

        public Unit Unit { get; set; }
    }
}
