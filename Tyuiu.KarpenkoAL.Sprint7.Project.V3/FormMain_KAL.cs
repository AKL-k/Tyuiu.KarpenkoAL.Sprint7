using Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib;
using Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3
{
    public partial class FormMain_KAL : Form
    {
        public FormMain_KAL()
        {
            InitializeComponent();

            buttonDone_KAL.Enabled = false;
            buttonStatistics_KAL.Enabled = false;
            EnableEditingControls(false);

            dataGridViewTeachers_KAL.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewTeachers_KAL.ClearSelection();
                    dataGridViewTeachers_KAL.Rows[e.RowIndex].Selected = true;
                }
            };

            dataGridViewDepartments_KAL.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewDepartments_KAL.ClearSelection();
                    dataGridViewDepartments_KAL.Rows[e.RowIndex].Selected = true;
                }
            };

            dataGridViewCourses_KAL.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewCourses_KAL.ClearSelection();
                    dataGridViewCourses_KAL.Rows[e.RowIndex].Selected = true;
                }
            };

            dataGridViewAssignments_KAL.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewAssignments_KAL.ClearSelection();
                    dataGridViewAssignments_KAL.Rows[e.RowIndex].Selected = true;
                }
            };
        }

        DataService ds = new DataService();

        private List<Teacher> teachers = new();
        private List<Department> departments = new(); 
        private List<Course> courses = new();
        private List<TeachingAssignment> assignments = new();

        private Stack<Teacher> deletedTeachers = new Stack<Teacher>();
        private Stack<Department> deletedDepartments = new Stack<Department>();
        private Stack<Course> deletedCourses = new Stack<Course>();
        private Stack<TeachingAssignment> deletedAssignments = new Stack<TeachingAssignment>();

        private void EnableEditingControls(bool enable)
        {
            buttonAddTeacher_KAL.Enabled = enable;
            buttonDeleteTeacher_KAL.Enabled = enable;
            buttonAddDepartment_KAL.Enabled = enable;
            buttonDeleteDepartment_KAL.Enabled = enable;
            buttonAddCourse_KAL.Enabled = enable;
            buttonDeleteCourse_KAL.Enabled = enable;
            buttonAddAssignment_KAL.Enabled = enable;
            buttonDeleteAssignment_KAL.Enabled = enable;

            textBoxSearchTeacher_KAL.Enabled = enable;
            textBoxSearchDepartment_KAL.Enabled = enable;
            textBoxSearchCourse_KAL.Enabled = enable;
            textBoxSearchAssignment_KAL.Enabled = enable;
        }

        private void buttonFileLoad_KAL_Click(object sender, EventArgs e)
        {
            try
            {
                teachers = ds.LoadTeachers(@"C:\DataSprint7\Teachers.csv");
                departments = ds.LoadDepartments(@"C:\DataSprint7\Departments.csv");
                courses = ds.LoadCourses(@"C:\DataSprint7\Courses.csv");
                assignments = ds.LoadAssignments(@"C:\DataSprint7\TeachingAssignments.csv");

                DisplayTeachers();
                DisplayDepartments();
                DisplayCourses();
                DisplayAssignments();
                UpdateStatistics();

                EnableEditingControls(true);
                buttonDone_KAL.Enabled = true;
                buttonStatistics_KAL.Enabled = true;

                MessageBox.Show("Данные успешно загружены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics()
        {
            int totalHours = ds.GetTotalHoursSum(courses);
            double avgHours = ds.GetAverageHours(courses);
            int[] minMaxHours = ds.GetHoursMinMax(courses);

            string stats =
           $"Всего преподавателей: {teachers.Count}\r\n" +
           $"Всего кафедр: {departments.Count}\r\n" +
           $"Всего предметов: {courses.Count}\r\n" +
           $"Всего нагрузок: {assignments.Count}\r\n" +
           $"\r\n" + 
           $"Сумма часов: {totalHours}\r\n" +
           $"Среднее часов: {avgHours:F1}\r\n" +
           $"Min/Max часов: {minMaxHours[0]}/{minMaxHours[1]}";

            textBoxStats_KAL.Text = stats;
        }

        private void DisplayTeachers()
        {
            dataGridViewTeachers_KAL.Rows.Clear();
            dataGridViewTeachers_KAL.Columns.Clear();

            dataGridViewTeachers_KAL.Columns.Add("TeacherId", "ID");
            dataGridViewTeachers_KAL.Columns.Add("FullName", "ФИО");
            dataGridViewTeachers_KAL.Columns.Add("Address", "Адрес");
            dataGridViewTeachers_KAL.Columns.Add("Position", "Должность");
            dataGridViewTeachers_KAL.Columns.Add("DepartmentId", "Кафедра ID");

            foreach (var teacher in teachers)
            {
                dataGridViewTeachers_KAL.Rows.Add(teacher.TeacherId, teacher.FullName, teacher.Address, teacher.Position, teacher.DepartmentId);
            }
        }

        private void DisplayDepartments()
        {
            dataGridViewDepartments_KAL.Rows.Clear();
            dataGridViewDepartments_KAL.Columns.Clear();

            dataGridViewDepartments_KAL.Columns.Add("DepartmentId", "ID");
            dataGridViewDepartments_KAL.Columns.Add("DepartmentName", "Название");
            dataGridViewDepartments_KAL.Columns.Add("HeadTeacherId", "Зав. кафедрой ID");

            foreach (var dept in departments)
            {
                dataGridViewDepartments_KAL.Rows.Add(dept.DepartmentId, dept.DepartmentName, dept.HeadTeacherId);
            }
        }

        private void DisplayCourses()
        {
            dataGridViewCourses_KAL.Rows.Clear();
            dataGridViewCourses_KAL.Columns.Clear();

            dataGridViewCourses_KAL.Columns.Add("CourseCode", "Код");
            dataGridViewCourses_KAL.Columns.Add("CourseName", "Название");
            dataGridViewCourses_KAL.Columns.Add("HoursTotal", "Часы");
            dataGridViewCourses_KAL.Columns.Add("ControlType", "Тип контроля");
            dataGridViewCourses_KAL.Columns.Add("Section", "Раздел");

            foreach (var course in courses)
            {
                dataGridViewCourses_KAL.Rows.Add(course.CourseCode, course.CourseName, course.HoursTotal, course.ControlType, course.Section);
            }
        }

        private void DisplayAssignments()
        {
            dataGridViewAssignments_KAL.Rows.Clear();
            dataGridViewAssignments_KAL.Columns.Clear();

            dataGridViewAssignments_KAL.Columns.Add("AssignmentId", "ID");
            dataGridViewAssignments_KAL.Columns.Add("TeacherId", "Преподаватель ID");
            dataGridViewAssignments_KAL.Columns.Add("CourseCode", "Код предмета");
            dataGridViewAssignments_KAL.Columns.Add("RoomNumber", "Аудитория");

            foreach (var assign in assignments)
            {
                dataGridViewAssignments_KAL.Rows.Add(assign.AssignmentId, assign.TeacherId, assign.CourseCode, assign.RoomNumber);
            }
        }

        private void buttonDone_KAL_Click(object sender, EventArgs e)
        {
            SearchInTeachers();
            SearchInDepartments();
            SearchInCourses();
            SearchInAssignments();
        }

        private void SearchInTeachers()
        {
            string searchText = textBoxSearchTeacher_KAL.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayTeachers();
                return;
            }

            string searchLower = searchText.ToLower();
            bool isNumeric = int.TryParse(searchText, out int numericValue);

            var filtered = teachers.Where(t =>
                // ФИО (только если введено 2+ символа и не число)
                (searchText.Length >= 2 && !isNumeric && t.FullName.ToLower().Contains(searchLower)) ||
                // Должность
                t.Position.ToLower().Contains(searchLower) ||
                // Адрес
                t.Address.ToLower().Contains(searchLower) ||
                // ID преподавателя (только если точное число)
                (isNumeric && t.TeacherId == numericValue) ||
                // ID кафедры (только если точное число)
                (isNumeric && t.DepartmentId == numericValue)
            ).Distinct().ToList();

            dataGridViewTeachers_KAL.Rows.Clear();

            foreach (var teacher in filtered)
            {
                dataGridViewTeachers_KAL.Rows.Add(
                    teacher.TeacherId,
                    teacher.FullName,
                    teacher.Address,
                    teacher.Position,
                    teacher.DepartmentId
                );
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show($"Преподаватели по запросу '{searchText}' не найдены", "Результат поиска");
            }
        }

        private void SearchInDepartments()
        {
            string searchText = textBoxSearchDepartment_KAL.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayDepartments();
                return;
            }

            string searchLower = searchText.ToLower();
            bool isNumeric = int.TryParse(searchText, out int numericValue);

            var filtered = departments.Where(d =>
                // Название кафедры
                d.DepartmentName.ToLower().Contains(searchLower) ||
                // ID кафедры (точное число)
                (isNumeric && d.DepartmentId == numericValue) ||
                // ID заведующего (точное число)
                (isNumeric && d.HeadTeacherId == numericValue) ||
                // Поиск "кафедра" или "физики" и т.д.
                searchLower.Contains("кафедра") && d.DepartmentName.ToLower().Contains(searchLower.Replace("кафедра", "").Trim())
            ).Distinct().ToList();

            dataGridViewDepartments_KAL.Rows.Clear();

            foreach (var dept in filtered)
            {
                dataGridViewDepartments_KAL.Rows.Add(
                    dept.DepartmentId,
                    dept.DepartmentName,
                    dept.HeadTeacherId
                );
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show($"Кафедры по запросу '{searchText}' не найдены", "Результат поиска");
            }
        }

        private void SearchInCourses()
        {
            string searchText = textBoxSearchCourse_KAL.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayCourses();
                return;
            }

            string searchLower = searchText.ToLower();
            bool isNumeric = int.TryParse(searchText, out int numericValue);

            var filtered = courses.Where(c =>
                // Название предмета
                c.CourseName.ToLower().Contains(searchLower) ||
                // Код предмета (с точкой или без)
                c.CourseCode.ToLower().Contains(searchLower) ||
                c.CourseCode.Replace(".", "").ToLower().Contains(searchLower) ||
                // Тип контроля
                c.ControlType.ToLower().Contains(searchLower) ||
                // Раздел
                c.Section.ToLower().Contains(searchLower) ||
                // Часы (точное число)
                (isNumeric && c.HoursTotal == numericValue) ||
                // Поиск по части кода: "INF" или "101"
                (searchText.Length >= 2 && (
                    c.CourseCode.Split('.')[0].ToLower().Contains(searchLower) ||
                    (c.CourseCode.Contains('.') && c.CourseCode.Split('.')[1].Contains(searchText))
                ))
            ).Distinct().ToList();

            dataGridViewCourses_KAL.Rows.Clear();

            foreach (var course in filtered)
            {
                dataGridViewCourses_KAL.Rows.Add(
                    course.CourseCode,
                    course.CourseName,
                    course.HoursTotal,
                    course.ControlType,
                    course.Section
                );
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show($"Предметы по запросу '{searchText}' не найдены", "Результат поиска");
            }
        }

        private void SearchInAssignments()
        {
            string searchText = textBoxSearchAssignment_KAL.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayAssignments();
                return;
            }

            string searchLower = searchText.ToLower();
            bool isNumeric = int.TryParse(searchText, out int numericValue);

            var filtered = assignments.Where(a =>
                // Аудитория (точное совпадение с учётом регистра)
                a.RoomNumber.Equals(searchText, StringComparison.OrdinalIgnoreCase) ||
                // ID преподавателя (точное число)
                (isNumeric && a.TeacherId == numericValue) ||
                // Код предмета (точное совпадение)
                a.CourseCode.Equals(searchText, StringComparison.OrdinalIgnoreCase) ||
                // ID назначения (точное число)
                (isNumeric && a.AssignmentId == numericValue) ||
                // Поиск по букве аудитории: "А", "Г", "Л" (одна буква)
                (searchText.Length == 1 && char.IsLetter(searchText[0]) &&
                 a.RoomNumber.StartsWith(searchText.ToUpper())) ||
                // Поиск по номеру аудитории: "415", "301" (число после дефиса)
                (isNumeric && a.RoomNumber.Contains($"-{numericValue}")) ||
                // Частичный поиск по коду предмета: "INF", "MATH", "LANG"
                (searchText.Length >= 3 && a.CourseCode.Split('.')[0].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            ).Distinct().ToList();

            dataGridViewAssignments_KAL.Rows.Clear();

            foreach (var assign in filtered)
            {
                dataGridViewAssignments_KAL.Rows.Add(
                    assign.AssignmentId,
                    assign.TeacherId,
                    assign.CourseCode,
                    assign.RoomNumber
                );
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show($"Назначения по запросу '{searchText}' не найдены", "Результат поиска");
            }
        }

        private void buttonStatistics_KAL_Click(object sender, EventArgs e)
        {
            FormStatistics_KAL formStatistics = new FormStatistics_KAL();
            formStatistics.ShowDialog();
        }

        private void buttonHelp_KAL_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Краткое руководство пользователя\n\n" +
        "1. Загрузите данные через кнопку «Загрузить данные».\n" +
        "2. Используйте поиск в текстовых полях для фильтрации.\n" +
        "3. Просматривайте статистику в соответствующем разделе.\n" +
        "4. Восстанавливайте удалённые записи кнопками «Добавить».\n" +
        "5. Анализируйте графики в форме «Статистика и графики».",
        "Справка",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAbout_KAL_Click(object sender, EventArgs e) 
        {
            FormAbout_KAL formAbout = new FormAbout_KAL();
            formAbout.ShowDialog();
        }

        private void buttonAddTeacher_KAL_Click(object sender, EventArgs e)
        {
            if (deletedTeachers.Count > 0)
            {
                Teacher restoredTeacher = deletedTeachers.Pop();
                teachers.Add(restoredTeacher);

                DisplayTeachers();
                UpdateStatistics();

                MessageBox.Show($"Восстановлен преподаватель: {restoredTeacher.FullName}\n" +
                               $"Осталось в корзине: {deletedTeachers.Count}",
                    "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет удалённых преподавателей для восстановления",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddDepartment_KAL_Click(object sender, EventArgs e)
        {
            if (deletedDepartments.Count > 0)
            {
                Department restoredDept = deletedDepartments.Pop();
                departments.Add(restoredDept);

                DisplayDepartments();
                UpdateStatistics();

                MessageBox.Show($"Восстановлена кафедра: {restoredDept.DepartmentName}\n" +
                               $"Осталось в корзине: {deletedDepartments.Count}",
                    "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет удалённых кафедр для восстановления",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddCourse_KAL_Click(object sender, EventArgs e)
        {
            if (deletedCourses.Count > 0)
            {
                Course restoredCourse = deletedCourses.Pop();
                courses.Add(restoredCourse);

                DisplayCourses();
                UpdateStatistics();

                MessageBox.Show($"Восстановлен предмет: {restoredCourse.CourseName}\n" +
                               $"Осталось в корзине: {deletedCourses.Count}",
                    "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет удалённых предметов для восстановления",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddAssignment_KAL_Click(object sender, EventArgs e)
        {
            if (deletedAssignments.Count > 0)
            {
                TeachingAssignment restoredAssign = deletedAssignments.Pop();
                assignments.Add(restoredAssign);

                DisplayAssignments();
                UpdateStatistics();

                MessageBox.Show($"Восстановлено назначение ID: {restoredAssign.AssignmentId}\n" +
                               $"Осталось в корзине: {deletedAssignments.Count}",
                    "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет удалённых назначений для восстановления",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteTeacher_KAL_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers_KAL.CurrentCell == null)
            {
                MessageBox.Show("Выберите строку для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridViewTeachers_KAL.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < teachers.Count)
            {
                Teacher deletedTeacher = teachers[selectedIndex];
                teachers.RemoveAt(selectedIndex);
                deletedTeachers.Push(deletedTeacher);

                DisplayTeachers();
                UpdateStatistics();

                MessageBox.Show($"Удалён преподаватель: {deletedTeacher.FullName}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteDepartment_KAL_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartments_KAL.CurrentCell == null)
            {
                MessageBox.Show("Выберите строку для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridViewDepartments_KAL.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < departments.Count)
            {
                Department deletedDept = departments[selectedIndex];
                departments.RemoveAt(selectedIndex);
                deletedDepartments.Push(deletedDept);

                DisplayDepartments();
                UpdateStatistics();

                MessageBox.Show($"Удалена кафедра: {deletedDept.DepartmentName}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteCourse_KAL_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses_KAL.CurrentCell == null)
            {
                MessageBox.Show("Выберите строку для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridViewCourses_KAL.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < courses.Count)
            {
                Course deletedCourse = courses[selectedIndex];
                courses.RemoveAt(selectedIndex);
                deletedCourses.Push(deletedCourse);

                DisplayCourses();
                UpdateStatistics();

                MessageBox.Show($"Удалён предмет: {deletedCourse.CourseName}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteAssignment_KAL_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignments_KAL.CurrentCell == null)
            {
                MessageBox.Show("Выберите строку для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridViewAssignments_KAL.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < assignments.Count)
            {
                TeachingAssignment deletedAssign = assignments[selectedIndex];
                assignments.RemoveAt(selectedIndex);
                deletedAssignments.Push(deletedAssign);

                DisplayAssignments();
                UpdateStatistics();

                MessageBox.Show($"Удалено назначение ID: {deletedAssign.AssignmentId}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFileLoad_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipMain_KAL.ToolTipTitle = "Загрузить данные";
        }

        private void buttonDone_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipMain_KAL.ToolTipTitle = "Выполнить поиск";
        }

        private void buttonStatistics_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipMain_KAL.ToolTipTitle = "Статистика и графики";
        }

        private void buttonHelp_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipMain_KAL.ToolTipTitle = "Справка";
        }

        private void buttonAbout_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipMain_KAL.ToolTipTitle = "О программе";
        }

        private void textBoxSearchTeacher_KAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchInTeachers();
                e.Handled = true;
            }
        }

        private void textBoxSearchDepartment_KAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchInDepartments();
                e.Handled = true;
            }
        }

        private void textBoxSearchCourse_KAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchInCourses();
                e.Handled = true;
            }
        }

        private void textBoxSearchAssignment_KAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchInAssignments();
                e.Handled = true;
            }
        }
    }
}
