using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Entities
{
    public class TaskItem
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime Creation { get; set; }
    }
}
