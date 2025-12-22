using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib;
using Tyuiu.KarpenkoAL.Sprint7.Project.V3.Lib.DataModels;

namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3
{
    public partial class FormStatistics_KAL : Form
    {
        public FormStatistics_KAL()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonBack_KAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoadData_KAL_Click(object sender, EventArgs e)
        {
            try
            {
                var courses = ds.LoadCourses(@"C:\DataSprint7\Courses.csv");
                var teachers = ds.LoadTeachers(@"C:\DataSprint7\Teachers.csv");

                UpdateChart(courses);
                UpdateStats(courses, teachers);

                buttonRefresh_KAL.Enabled = true;
                MessageBox.Show("Данные загружены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateChart(List<Course> courses)
        {
            chartMain_KAL.Series.Clear();
            chartMain_KAL.ChartAreas.Clear();

            ChartArea area = new ChartArea("MainArea");
            chartMain_KAL.ChartAreas.Add(area);

            Series series = new Series("Часы по предметам");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;
            series.Font = new Font("Arial", 10, FontStyle.Bold);

            for (int i = 0; i < courses.Count; i++)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(i, courses[i].HoursTotal);
                point.AxisLabel = courses[i].CourseCode;
                point.Label = courses[i].HoursTotal.ToString();
                series.Points.Add(point);
            }

            chartMain_KAL.Series.Add(series);

            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = true;

            area.AxisX.Title = "Код предмета";
            area.AxisY.Title = "Часы";

            chartMain_KAL.Titles.Clear();
            chartMain_KAL.Titles.Add("Распределение часов по предметам");

            chartMain_KAL.Invalidate();
        }

        private void UpdateStats(List<Course> courses, List<Teacher> teachers)
        {
            if (courses.Count == 0)
            {
                textBoxStats_KAL.Text = "Нет данных";
                return;
            }

            int totalHours = ds.GetTotalHoursSum(courses);
            double avgHours = ds.GetAverageHours(courses);
            int[] minMax = ds.GetHoursMinMax(courses);

            string stats = "";
            stats += "Статистика по предметам:\r\n";
            stats += $"Всего предметов: {courses.Count}\r\n";
            stats += $"Сумма часов: {totalHours}\r\n";
            stats += $"Среднее часов: {avgHours:F1}\r\n";
            stats += $"Минимум часов: {minMax[0]}\r\n";
            stats += $"Максимум часов: {minMax[1]}\r\n\r\n";

            stats += "Статистика по преподавателям:\r\n";
            stats += $"Всего преподавателей: {teachers.Count}\r\n";

            textBoxStats_KAL.Text = stats;
        }

        private void buttonRefresh_KAL_Click(object sender, EventArgs e)
        {
            try
            {
                var courses = ds.LoadCourses(@"C:\DataSprint7\Courses.csv");
                var teachers = ds.LoadTeachers(@"C:\DataSprint7\Teachers.csv");

                UpdateChart(courses);
                UpdateStats(courses, teachers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadData_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipStats_KAL.ToolTipTitle = "Загрузить данные";
        }

        private void buttonRefresh_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipStats_KAL.ToolTipTitle = "Обновить";
        }

        private void buttonBack_KAL_MouseEnter(object sender, EventArgs e)
        {
            toolTipStats_KAL.ToolTipTitle = "Назад";
        }
    }
}
