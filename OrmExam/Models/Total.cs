using OrmExam.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmExam.Models
{
    public class Total : BaseEntity
    {
        public string TotalRevenue { get; set; }
        public string TotalCosts { get; set; }
        public string TotalProfit { get; set; }
        public Order Order { get; set; }

    }
}
