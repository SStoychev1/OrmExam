using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmExam.BaseModel
{
    public class BaseEntity : IBaseEntity
    {
        public string Id { get; set; }
    }
}
