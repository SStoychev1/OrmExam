using OrmExam.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmExam.Models
{
    public class Order : BaseEntity
    {
        public string OrederId  { get; set; }
        public string OrderDate  { get; set; }
        public string OrderPriority { get; set; }
        public Shiping shiping { get; set; }
        public List<Total> Totals { get; set; }

    }
}
