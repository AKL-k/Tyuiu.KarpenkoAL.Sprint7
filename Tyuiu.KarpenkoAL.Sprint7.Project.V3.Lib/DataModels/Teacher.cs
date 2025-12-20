using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? Position { get; set; }
        public int DepartmentId { get; set; }

        public Teacher() { }
    }
}
