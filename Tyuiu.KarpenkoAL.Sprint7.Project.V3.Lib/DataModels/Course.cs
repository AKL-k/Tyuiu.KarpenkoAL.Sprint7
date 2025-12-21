using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels
{
    public class Course
    {
        public string CourseCode { get; set; } = "";
        public string CourseName { get; set; } = "";
        public int HoursTotal { get; set; }
        public string ControlType { get; set; } = "";
        public string Section { get; set; } = "";

        public Course() { }
    }
}
