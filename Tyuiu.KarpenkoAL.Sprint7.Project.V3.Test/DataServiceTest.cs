using Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileTeachers()
        {
            string path = @"C:\DataSprint7\Teachers.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFileDepartments()
        {
            string path = @"C:\DataSprint7\Departments.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFileCourses()
        {
            string path = @"C:\DataSprint7\Courses.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFileAssignments()
        {
            string path = @"C:\DataSprint7\TeachingAssignments.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
