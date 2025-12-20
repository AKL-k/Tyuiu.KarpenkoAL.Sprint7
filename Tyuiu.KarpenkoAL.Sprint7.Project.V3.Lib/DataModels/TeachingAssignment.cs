using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels
{
    public class TeachingAssignment
    {
        public int AssignmentId { get; set; }
        public int TeacherId { get; set; }
        public string? CourseCode { get; set; }
        public string? RoomNumber { get; set; }

        public TeachingAssignment() { }
    }
}
