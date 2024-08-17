using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_1.Entity
{
    internal class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int Ins_id { get; set; }
        public DateTime HiringDate { get; set; }

    }
}
