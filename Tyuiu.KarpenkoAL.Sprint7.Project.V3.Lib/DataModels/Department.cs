using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int HeadTeacherId { get; set; }

        public Department() { }
    }
}
