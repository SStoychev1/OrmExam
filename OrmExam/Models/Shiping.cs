using OrmExam.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmExam.Models
{
    public class Shiping : BaseEntity
    {
        public string SalesChanel { get; set; }
        public string ShipDate { get; set; }
        public List<Order> Orders { get; set; }
    }
}
