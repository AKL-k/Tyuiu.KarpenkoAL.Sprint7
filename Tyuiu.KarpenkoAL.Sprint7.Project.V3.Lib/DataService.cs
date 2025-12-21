using System.Text;
using Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public List<Teacher> LoadTeachers(string path)
        {
            List<Teacher> teachers = new List<Teacher>();

            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(';');

                    if (parts.Length >= 5)
                    {
                        Teacher teacher = new Teacher
                        {
                            TeacherId = int.Parse(parts[0]),
                            FullName = parts[1],
                            Address = parts[2],
                            Position = parts[3],
                            DepartmentId = int.Parse(parts[4])
                        };

                        teachers.Add(teacher);
                    }
                }
            }

            return teachers;
        }

        public List<Department> LoadDepartments(string path)
        {
            List<Department> departments = new List<Department>();

            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(';');

                    if (parts.Length >= 3)
                    {
                        Department department = new Department
                        {
                            DepartmentId = int.Parse(parts[0]),
                            DepartmentName = parts[1],
                            HeadTeacherId = int.Parse(parts[2])
                        };

                        departments.Add(department);
                    }
                }
            }

            return departments;
        }

        public List<Course> LoadCourses(string path)
        {
            List<Course> courses = new List<Course>();

            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(';');

                    if (parts.Length >= 5)
                    {
                        Course course = new Course
                        {
                            CourseCode = parts[0],
                            CourseName = parts[1],
                            HoursTotal = int.Parse(parts[2]),
                            ControlType = parts[3],
                            Section = parts[4]
                        };

                        courses.Add(course);
                    }
                }
            }

            return courses;
        }

        public List<TeachingAssignment> LoadAssignments(string path)
        {
            List<TeachingAssignment> assignments = new List<TeachingAssignment>();

            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(';');

                    if (parts.Length >= 4)
                    {
                        TeachingAssignment assignment = new TeachingAssignment
                        {
                            AssignmentId = int.Parse(parts[0]),
                            TeacherId = int.Parse(parts[1]),
                            CourseCode = parts[2],
                            RoomNumber = parts[3]
                        };

                        assignments.Add(assignment);
                    }
                }
            }

            return assignments;
        }

        public Teacher? GetTeacherById(List<Teacher> teachers, int teacherId)
        {
            return teachers.Find(t => t.TeacherId == teacherId);
        }

        public Department? GetDepartmentById(List<Department> departments, int departmentId)
        {
            return departments.Find(d => d.DepartmentId == departmentId);
        }

        public Course? GetCourseByCode(List<Course> courses, string courseCode)
        {
            return courses.Find(c => c.CourseCode == courseCode);
        }

        public List<TeachingAssignment> GetAssignmentsByTeacher(List<TeachingAssignment> assignments, int teacherId)
        {
            return assignments.FindAll(a => a.TeacherId == teacherId);
        }

        public List<TeachingAssignment> GetAssignmentsByCourse(List<TeachingAssignment> assignments, string courseCode)
        {
            return assignments.FindAll(a => a.CourseCode == courseCode);
        }

        public int[] GetTeachersCountByPosition(List<Teacher> teachers, string[] positions)
        {
            int[] counts = new int[positions.Length];

            for (int i = 0; i < positions.Length; i++)
            {
                int count = 0;
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.Position == positions[i])
                        count++;
                }
                counts[i] = count;
            }

            return counts;
        }

        public int GetTotalHoursSum(List<Course> courses)
        {
            int sum = 0;
            foreach (Course course in courses)
            {
                sum += course.HoursTotal;
            }
            return sum;
        }

        public double GetAverageHours(List<Course> courses)
        {
            if (courses.Count == 0) return 0;

            int sum = 0;
            foreach (Course course in courses)
            {
                sum += course.HoursTotal;
            }

            return (double)sum / courses.Count;
        }

        public int[] GetHoursMinMax(List<Course> courses)
        {
            if (courses.Count == 0) return new int[] { 0, 0 };

            int min = courses[0].HoursTotal;
            int max = courses[0].HoursTotal;

            foreach (Course course in courses)
            {
                if (course.HoursTotal < min)
                    min = course.HoursTotal;

                if (course.HoursTotal > max)
                    max = course.HoursTotal;
            }

            return new int[] { min, max };
        }

        public int GetCoursesCountByControlType(List<Course> courses, string controlType)
        {
            int count = 0;
            foreach (Course course in courses)
            {
                if (course.ControlType == controlType)
                    count++;
            }
            return count;
        }

        public int GetTeacherTotalHours(int teacherId,
                                       List<TeachingAssignment> assignments,
                                       List<Course> courses)
        {

            List<string> teacherCourseCodes = new List<string>();
            foreach (TeachingAssignment assignment in assignments)
            {
                if (assignment.TeacherId == teacherId)
                    teacherCourseCodes.Add(assignment.CourseCode);
            }

            int totalHours = 0;
            foreach (Course course in courses)
            {
                if (teacherCourseCodes.Contains(course.CourseCode))
                    totalHours += course.HoursTotal;
            }

            return totalHours;
        }

        public int GetTeachersCountByDepartment(List<Teacher> teachers, int departmentId)
        {
            int count = 0;
            foreach (Teacher teacher in teachers)
            {
                if (teacher.DepartmentId == departmentId)
                    count++;
            }
            return count;
        }

    }
}
