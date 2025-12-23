namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3
{
    partial class FormMain_KAL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelButton_KAL = new Panel();
            buttonStatistics_KAL = new Button();
            buttonAbout_KAL = new Button();
            buttonHelp_KAL = new Button();
            buttonDone_KAL = new Button();
            buttonFileLoad_KAL = new Button();
            panelTask_KAL = new Panel();
            groupBoxTask_KAL = new GroupBox();
            textBoxTask_KAL = new TextBox();
            panelMain_KAL = new Panel();
            groupBoxAssignments_KAL = new GroupBox();
            panelAssignmentsControl_KAL = new Panel();
            buttonAddAssignment_KAL = new Button();
            buttonDeleteAssignment_KAL = new Button();
            textBoxSearchAssignment_KAL = new TextBox();
            dataGridViewAssignments_KAL = new DataGridView();
            groupBoxCourses_KAL = new GroupBox();
            panelCoursesControl_KAL = new Panel();
            buttonAddCourse_KAL = new Button();
            buttonDeleteCourse_KAL = new Button();
            textBoxSearchCourse_KAL = new TextBox();
            dataGridViewCourses_KAL = new DataGridView();
            groupBoxDepartments_KAL = new GroupBox();
            panelDepartmentsControl_KAL = new Panel();
            buttonAddDepartment_KAL = new Button();
            buttonDeleteDepartment_KAL = new Button();
            textBoxSearchDepartment_KAL = new TextBox();
            dataGridViewDepartments_KAL = new DataGridView();
            groupBoxTeachers_KAL = new GroupBox();
            panelTeachersControl_KAL = new Panel();
            buttonAddTeacher_KAL = new Button();
            buttonDeleteTeacher_KAL = new Button();
            textBoxSearchTeacher_KAL = new TextBox();
            dataGridViewTeachers_KAL = new DataGridView();
            panelStats_KAL = new Panel();
            groupBoxStats_KAL = new GroupBox();
            textBoxStats_KAL = new TextBox();
            openFileDialogLoadFile_KAL = new OpenFileDialog();
            toolTipMain_KAL = new ToolTip(components);
            saveFileDialog_KAL = new SaveFileDialog();
            panelButton_KAL.SuspendLayout();
            panelTask_KAL.SuspendLayout();
            groupBoxTask_KAL.SuspendLayout();
            panelMain_KAL.SuspendLayout();
            groupBoxAssignments_KAL.SuspendLayout();
            panelAssignmentsControl_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments_KAL).BeginInit();
            groupBoxCourses_KAL.SuspendLayout();
            panelCoursesControl_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses_KAL).BeginInit();
            groupBoxDepartments_KAL.SuspendLayout();
            panelDepartmentsControl_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments_KAL).BeginInit();
            groupBoxTeachers_KAL.SuspendLayout();
            panelTeachersControl_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KAL).BeginInit();
            panelStats_KAL.SuspendLayout();
            groupBoxStats_KAL.SuspendLayout();
            SuspendLayout();
            // 
            // panelButton_KAL
            // 
            panelButton_KAL.Controls.Add(buttonStatistics_KAL);
            panelButton_KAL.Controls.Add(buttonAbout_KAL);
            panelButton_KAL.Controls.Add(buttonHelp_KAL);
            panelButton_KAL.Controls.Add(buttonDone_KAL);
            panelButton_KAL.Controls.Add(buttonFileLoad_KAL);
            panelButton_KAL.Dock = DockStyle.Top;
            panelButton_KAL.Location = new Point(0, 0);
            panelButton_KAL.Name = "panelButton_KAL";
            panelButton_KAL.Size = new Size(1200, 100);
            panelButton_KAL.TabIndex = 0;
            // 
            // buttonStatistics_KAL
            // 
            buttonStatistics_KAL.BackgroundImage = Properties.Resources.imageкк;
            buttonStatistics_KAL.Enabled = false;
            buttonStatistics_KAL.Location = new Point(298, 26);
            buttonStatistics_KAL.Name = "buttonStatistics_KAL";
            buttonStatistics_KAL.Size = new Size(76, 59);
            buttonStatistics_KAL.TabIndex = 5;
            toolTipMain_KAL.SetToolTip(buttonStatistics_KAL, "Открыть статистику и графики");
            buttonStatistics_KAL.UseVisualStyleBackColor = true;
            buttonStatistics_KAL.Click += buttonStatistics_KAL_Click;
            buttonStatistics_KAL.MouseEnter += buttonStatistics_KAL_MouseEnter;
            // 
            // buttonAbout_KAL
            // 
            buttonAbout_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_KAL.BackgroundImage = Properties.Resources.d;
            buttonAbout_KAL.Location = new Point(1100, 26);
            buttonAbout_KAL.Name = "buttonAbout_KAL";
            buttonAbout_KAL.Size = new Size(88, 59);
            buttonAbout_KAL.TabIndex = 4;
            toolTipMain_KAL.SetToolTip(buttonAbout_KAL, "Информация о программе и авторе");
            buttonAbout_KAL.UseVisualStyleBackColor = true;
            buttonAbout_KAL.Click += buttonAbout_KAL_Click;
            buttonAbout_KAL.MouseEnter += buttonAbout_KAL_MouseEnter;
            // 
            // buttonHelp_KAL
            // 
            buttonHelp_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAL.BackgroundImage = Properties.Resources.зе;
            buttonHelp_KAL.Location = new Point(990, 12);
            buttonHelp_KAL.Name = "buttonHelp_KAL";
            buttonHelp_KAL.Size = new Size(93, 82);
            buttonHelp_KAL.TabIndex = 3;
            toolTipMain_KAL.SetToolTip(buttonHelp_KAL, "Справка по использованию программы");
            buttonHelp_KAL.UseVisualStyleBackColor = true;
            buttonHelp_KAL.Click += buttonHelp_KAL_Click;
            buttonHelp_KAL.MouseEnter += buttonHelp_KAL_MouseEnter;
            // 
            // buttonDone_KAL
            // 
            buttonDone_KAL.BackgroundImage = Properties.Resources.imagef;
            buttonDone_KAL.Enabled = false;
            buttonDone_KAL.Location = new Point(198, 26);
            buttonDone_KAL.Name = "buttonDone_KAL";
            buttonDone_KAL.Size = new Size(84, 59);
            buttonDone_KAL.TabIndex = 1;
            toolTipMain_KAL.SetToolTip(buttonDone_KAL, "Выполнить поиск по всем таблицам");
            buttonDone_KAL.UseVisualStyleBackColor = true;
            buttonDone_KAL.Click += buttonDone_KAL_Click;
            buttonDone_KAL.MouseEnter += buttonDone_KAL_MouseEnter;
            // 
            // buttonFileLoad_KAL
            // 
            buttonFileLoad_KAL.BackgroundImage = Properties.Resources.imaged;
            buttonFileLoad_KAL.Location = new Point(80, 26);
            buttonFileLoad_KAL.Name = "buttonFileLoad_KAL";
            buttonFileLoad_KAL.Size = new Size(99, 59);
            buttonFileLoad_KAL.TabIndex = 0;
            toolTipMain_KAL.SetToolTip(buttonFileLoad_KAL, "Загрузить данные из CSV файлов");
            buttonFileLoad_KAL.UseVisualStyleBackColor = true;
            buttonFileLoad_KAL.Click += buttonFileLoad_KAL_Click;
            buttonFileLoad_KAL.MouseEnter += buttonFileLoad_KAL_MouseEnter;
            // 
            // panelTask_KAL
            // 
            panelTask_KAL.Controls.Add(groupBoxTask_KAL);
            panelTask_KAL.Dock = DockStyle.Top;
            panelTask_KAL.Location = new Point(0, 100);
            panelTask_KAL.Name = "panelTask_KAL";
            panelTask_KAL.Padding = new Padding(5);
            panelTask_KAL.Size = new Size(1200, 100);
            panelTask_KAL.TabIndex = 1;
            // 
            // groupBoxTask_KAL
            // 
            groupBoxTask_KAL.Controls.Add(textBoxTask_KAL);
            groupBoxTask_KAL.Dock = DockStyle.Fill;
            groupBoxTask_KAL.Location = new Point(5, 5);
            groupBoxTask_KAL.Name = "groupBoxTask_KAL";
            groupBoxTask_KAL.Size = new Size(1190, 90);
            groupBoxTask_KAL.TabIndex = 0;
            groupBoxTask_KAL.TabStop = false;
            groupBoxTask_KAL.Text = "Описание проекта";
            // 
            // textBoxTask_KAL
            // 
            textBoxTask_KAL.Dock = DockStyle.Fill;
            textBoxTask_KAL.Location = new Point(3, 23);
            textBoxTask_KAL.Multiline = true;
            textBoxTask_KAL.Name = "textBoxTask_KAL";
            textBoxTask_KAL.ReadOnly = true;
            textBoxTask_KAL.Size = new Size(1184, 64);
            textBoxTask_KAL.TabIndex = 0;
            textBoxTask_KAL.Text = "Система управления университетом. Загрузка, редактирование и просмотр данных о преподавателях, кафедрах, предметах и нагрузке.";
            // 
            // panelMain_KAL
            // 
            panelMain_KAL.Controls.Add(groupBoxAssignments_KAL);
            panelMain_KAL.Controls.Add(groupBoxCourses_KAL);
            panelMain_KAL.Controls.Add(groupBoxDepartments_KAL);
            panelMain_KAL.Controls.Add(groupBoxTeachers_KAL);
            panelMain_KAL.Dock = DockStyle.Top;
            panelMain_KAL.Location = new Point(0, 200);
            panelMain_KAL.Name = "panelMain_KAL";
            panelMain_KAL.Padding = new Padding(5);
            panelMain_KAL.Size = new Size(1200, 400);
            panelMain_KAL.TabIndex = 2;
            // 
            // groupBoxAssignments_KAL
            // 
            groupBoxAssignments_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAssignments_KAL.Controls.Add(panelAssignmentsControl_KAL);
            groupBoxAssignments_KAL.Controls.Add(dataGridViewAssignments_KAL);
            groupBoxAssignments_KAL.Location = new Point(875, 5);
            groupBoxAssignments_KAL.Name = "groupBoxAssignments_KAL";
            groupBoxAssignments_KAL.Size = new Size(317, 390);
            groupBoxAssignments_KAL.TabIndex = 3;
            groupBoxAssignments_KAL.TabStop = false;
            groupBoxAssignments_KAL.Text = "Нагрузка";
            // 
            // panelAssignmentsControl_KAL
            // 
            panelAssignmentsControl_KAL.Controls.Add(buttonAddAssignment_KAL);
            panelAssignmentsControl_KAL.Controls.Add(buttonDeleteAssignment_KAL);
            panelAssignmentsControl_KAL.Controls.Add(textBoxSearchAssignment_KAL);
            panelAssignmentsControl_KAL.Dock = DockStyle.Top;
            panelAssignmentsControl_KAL.Location = new Point(3, 23);
            panelAssignmentsControl_KAL.Name = "panelAssignmentsControl_KAL";
            panelAssignmentsControl_KAL.Size = new Size(311, 40);
            panelAssignmentsControl_KAL.TabIndex = 1;
            // 
            // buttonAddAssignment_KAL
            // 
            buttonAddAssignment_KAL.BackgroundImage = Properties.Resources.bullet_add3;
            buttonAddAssignment_KAL.Enabled = false;
            buttonAddAssignment_KAL.Location = new Point(190, 5);
            buttonAddAssignment_KAL.Name = "buttonAddAssignment_KAL";
            buttonAddAssignment_KAL.Size = new Size(32, 30);
            buttonAddAssignment_KAL.TabIndex = 2;
            toolTipMain_KAL.SetToolTip(buttonAddAssignment_KAL, "Добавить нагрузку");
            buttonAddAssignment_KAL.UseVisualStyleBackColor = true;
            buttonAddAssignment_KAL.Click += buttonAddAssignment_KAL_Click;
            // 
            // buttonDeleteAssignment_KAL
            // 
            buttonDeleteAssignment_KAL.BackgroundImage = Properties.Resources.bullet_delete3;
            buttonDeleteAssignment_KAL.Enabled = false;
            buttonDeleteAssignment_KAL.Location = new Point(241, 5);
            buttonDeleteAssignment_KAL.Name = "buttonDeleteAssignment_KAL";
            buttonDeleteAssignment_KAL.Size = new Size(31, 30);
            buttonDeleteAssignment_KAL.TabIndex = 1;
            toolTipMain_KAL.SetToolTip(buttonDeleteAssignment_KAL, "Удалить нагрузку");
            buttonDeleteAssignment_KAL.UseVisualStyleBackColor = true;
            buttonDeleteAssignment_KAL.Click += buttonDeleteAssignment_KAL_Click;
            // 
            // textBoxSearchAssignment_KAL
            // 
            textBoxSearchAssignment_KAL.Enabled = false;
            textBoxSearchAssignment_KAL.Location = new Point(5, 5);
            textBoxSearchAssignment_KAL.Name = "textBoxSearchAssignment_KAL";
            textBoxSearchAssignment_KAL.PlaceholderText = "Поиск...";
            textBoxSearchAssignment_KAL.Size = new Size(180, 27);
            textBoxSearchAssignment_KAL.TabIndex = 0;
            textBoxSearchAssignment_KAL.KeyPress += textBoxSearchAssignment_KAL_KeyPress;
            // 
            // dataGridViewAssignments_KAL
            // 
            dataGridViewAssignments_KAL.AllowUserToAddRows = false;
            dataGridViewAssignments_KAL.AllowUserToDeleteRows = false;
            dataGridViewAssignments_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAssignments_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignments_KAL.ColumnHeadersVisible = false;
            dataGridViewAssignments_KAL.Location = new Point(3, 64);
            dataGridViewAssignments_KAL.Name = "dataGridViewAssignments_KAL";
            dataGridViewAssignments_KAL.ReadOnly = true;
            dataGridViewAssignments_KAL.RowHeadersVisible = false;
            dataGridViewAssignments_KAL.RowHeadersWidth = 51;
            dataGridViewAssignments_KAL.Size = new Size(311, 323);
            dataGridViewAssignments_KAL.TabIndex = 0;
            // 
            // groupBoxCourses_KAL
            // 
            groupBoxCourses_KAL.Controls.Add(panelCoursesControl_KAL);
            groupBoxCourses_KAL.Controls.Add(dataGridViewCourses_KAL);
            groupBoxCourses_KAL.Dock = DockStyle.Left;
            groupBoxCourses_KAL.Location = new Point(585, 5);
            groupBoxCourses_KAL.Name = "groupBoxCourses_KAL";
            groupBoxCourses_KAL.Size = new Size(290, 390);
            groupBoxCourses_KAL.TabIndex = 2;
            groupBoxCourses_KAL.TabStop = false;
            groupBoxCourses_KAL.Text = "Предметы";
            // 
            // panelCoursesControl_KAL
            // 
            panelCoursesControl_KAL.Controls.Add(buttonAddCourse_KAL);
            panelCoursesControl_KAL.Controls.Add(buttonDeleteCourse_KAL);
            panelCoursesControl_KAL.Controls.Add(textBoxSearchCourse_KAL);
            panelCoursesControl_KAL.Dock = DockStyle.Top;
            panelCoursesControl_KAL.Location = new Point(3, 23);
            panelCoursesControl_KAL.Name = "panelCoursesControl_KAL";
            panelCoursesControl_KAL.Size = new Size(284, 40);
            panelCoursesControl_KAL.TabIndex = 1;
            // 
            // buttonAddCourse_KAL
            // 
            buttonAddCourse_KAL.BackgroundImage = Properties.Resources.bullet_add2;
            buttonAddCourse_KAL.Enabled = false;
            buttonAddCourse_KAL.Location = new Point(190, 5);
            buttonAddCourse_KAL.Name = "buttonAddCourse_KAL";
            buttonAddCourse_KAL.Size = new Size(31, 30);
            buttonAddCourse_KAL.TabIndex = 2;
            toolTipMain_KAL.SetToolTip(buttonAddCourse_KAL, "Добавить предмет");
            buttonAddCourse_KAL.UseVisualStyleBackColor = true;
            buttonAddCourse_KAL.Click += buttonAddCourse_KAL_Click;
            // 
            // buttonDeleteCourse_KAL
            // 
            buttonDeleteCourse_KAL.BackgroundImage = Properties.Resources.bullet_delete2;
            buttonDeleteCourse_KAL.Enabled = false;
            buttonDeleteCourse_KAL.Location = new Point(241, 5);
            buttonDeleteCourse_KAL.Name = "buttonDeleteCourse_KAL";
            buttonDeleteCourse_KAL.Size = new Size(31, 30);
            buttonDeleteCourse_KAL.TabIndex = 1;
            toolTipMain_KAL.SetToolTip(buttonDeleteCourse_KAL, "Удалить предмет");
            buttonDeleteCourse_KAL.UseVisualStyleBackColor = true;
            buttonDeleteCourse_KAL.Click += buttonDeleteCourse_KAL_Click;
            // 
            // textBoxSearchCourse_KAL
            // 
            textBoxSearchCourse_KAL.Enabled = false;
            textBoxSearchCourse_KAL.Location = new Point(5, 5);
            textBoxSearchCourse_KAL.Name = "textBoxSearchCourse_KAL";
            textBoxSearchCourse_KAL.PlaceholderText = "Поиск...";
            textBoxSearchCourse_KAL.Size = new Size(180, 27);
            textBoxSearchCourse_KAL.TabIndex = 0;
            textBoxSearchCourse_KAL.KeyPress += textBoxSearchCourse_KAL_KeyPress;
            // 
            // dataGridViewCourses_KAL
            // 
            dataGridViewCourses_KAL.AllowUserToAddRows = false;
            dataGridViewCourses_KAL.AllowUserToDeleteRows = false;
            dataGridViewCourses_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCourses_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses_KAL.ColumnHeadersVisible = false;
            dataGridViewCourses_KAL.Location = new Point(3, 64);
            dataGridViewCourses_KAL.Name = "dataGridViewCourses_KAL";
            dataGridViewCourses_KAL.ReadOnly = true;
            dataGridViewCourses_KAL.RowHeadersVisible = false;
            dataGridViewCourses_KAL.RowHeadersWidth = 51;
            dataGridViewCourses_KAL.Size = new Size(284, 323);
            dataGridViewCourses_KAL.TabIndex = 0;
            // 
            // groupBoxDepartments_KAL
            // 
            groupBoxDepartments_KAL.Controls.Add(panelDepartmentsControl_KAL);
            groupBoxDepartments_KAL.Controls.Add(dataGridViewDepartments_KAL);
            groupBoxDepartments_KAL.Dock = DockStyle.Left;
            groupBoxDepartments_KAL.Location = new Point(295, 5);
            groupBoxDepartments_KAL.Name = "groupBoxDepartments_KAL";
            groupBoxDepartments_KAL.Size = new Size(290, 390);
            groupBoxDepartments_KAL.TabIndex = 1;
            groupBoxDepartments_KAL.TabStop = false;
            groupBoxDepartments_KAL.Text = "Кафедры";
            // 
            // panelDepartmentsControl_KAL
            // 
            panelDepartmentsControl_KAL.Controls.Add(buttonAddDepartment_KAL);
            panelDepartmentsControl_KAL.Controls.Add(buttonDeleteDepartment_KAL);
            panelDepartmentsControl_KAL.Controls.Add(textBoxSearchDepartment_KAL);
            panelDepartmentsControl_KAL.Dock = DockStyle.Top;
            panelDepartmentsControl_KAL.Location = new Point(3, 23);
            panelDepartmentsControl_KAL.Name = "panelDepartmentsControl_KAL";
            panelDepartmentsControl_KAL.Size = new Size(284, 40);
            panelDepartmentsControl_KAL.TabIndex = 1;
            // 
            // buttonAddDepartment_KAL
            // 
            buttonAddDepartment_KAL.BackgroundImage = Properties.Resources.bullet_add1;
            buttonAddDepartment_KAL.Enabled = false;
            buttonAddDepartment_KAL.Location = new Point(190, 5);
            buttonAddDepartment_KAL.Name = "buttonAddDepartment_KAL";
            buttonAddDepartment_KAL.Size = new Size(30, 30);
            buttonAddDepartment_KAL.TabIndex = 2;
            toolTipMain_KAL.SetToolTip(buttonAddDepartment_KAL, "Добавить кафедру");
            buttonAddDepartment_KAL.UseVisualStyleBackColor = true;
            buttonAddDepartment_KAL.Click += buttonAddDepartment_KAL_Click;
            // 
            // buttonDeleteDepartment_KAL
            // 
            buttonDeleteDepartment_KAL.BackgroundImage = Properties.Resources.bullet_delete1;
            buttonDeleteDepartment_KAL.Enabled = false;
            buttonDeleteDepartment_KAL.Location = new Point(241, 5);
            buttonDeleteDepartment_KAL.Name = "buttonDeleteDepartment_KAL";
            buttonDeleteDepartment_KAL.Size = new Size(31, 30);
            buttonDeleteDepartment_KAL.TabIndex = 1;
            toolTipMain_KAL.SetToolTip(buttonDeleteDepartment_KAL, "Удалить кафедру");
            buttonDeleteDepartment_KAL.UseVisualStyleBackColor = true;
            buttonDeleteDepartment_KAL.Click += buttonDeleteDepartment_KAL_Click;
            // 
            // textBoxSearchDepartment_KAL
            // 
            textBoxSearchDepartment_KAL.Enabled = false;
            textBoxSearchDepartment_KAL.Location = new Point(5, 5);
            textBoxSearchDepartment_KAL.Name = "textBoxSearchDepartment_KAL";
            textBoxSearchDepartment_KAL.PlaceholderText = "Поиск...";
            textBoxSearchDepartment_KAL.Size = new Size(180, 27);
            textBoxSearchDepartment_KAL.TabIndex = 0;
            textBoxSearchDepartment_KAL.KeyPress += textBoxSearchDepartment_KAL_KeyPress;
            // 
            // dataGridViewDepartments_KAL
            // 
            dataGridViewDepartments_KAL.AllowUserToAddRows = false;
            dataGridViewDepartments_KAL.AllowUserToDeleteRows = false;
            dataGridViewDepartments_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDepartments_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments_KAL.ColumnHeadersVisible = false;
            dataGridViewDepartments_KAL.Location = new Point(3, 64);
            dataGridViewDepartments_KAL.Name = "dataGridViewDepartments_KAL";
            dataGridViewDepartments_KAL.ReadOnly = true;
            dataGridViewDepartments_KAL.RowHeadersVisible = false;
            dataGridViewDepartments_KAL.RowHeadersWidth = 51;
            dataGridViewDepartments_KAL.Size = new Size(284, 323);
            dataGridViewDepartments_KAL.TabIndex = 0;
            // 
            // groupBoxTeachers_KAL
            // 
            groupBoxTeachers_KAL.Controls.Add(panelTeachersControl_KAL);
            groupBoxTeachers_KAL.Controls.Add(dataGridViewTeachers_KAL);
            groupBoxTeachers_KAL.Dock = DockStyle.Left;
            groupBoxTeachers_KAL.Location = new Point(5, 5);
            groupBoxTeachers_KAL.Name = "groupBoxTeachers_KAL";
            groupBoxTeachers_KAL.Size = new Size(290, 390);
            groupBoxTeachers_KAL.TabIndex = 0;
            groupBoxTeachers_KAL.TabStop = false;
            groupBoxTeachers_KAL.Text = "Преподаватели";
            // 
            // panelTeachersControl_KAL
            // 
            panelTeachersControl_KAL.Controls.Add(buttonAddTeacher_KAL);
            panelTeachersControl_KAL.Controls.Add(buttonDeleteTeacher_KAL);
            panelTeachersControl_KAL.Controls.Add(textBoxSearchTeacher_KAL);
            panelTeachersControl_KAL.Dock = DockStyle.Top;
            panelTeachersControl_KAL.Location = new Point(3, 23);
            panelTeachersControl_KAL.Name = "panelTeachersControl_KAL";
            panelTeachersControl_KAL.Size = new Size(284, 40);
            panelTeachersControl_KAL.TabIndex = 1;
            // 
            // buttonAddTeacher_KAL
            // 
            buttonAddTeacher_KAL.BackgroundImage = Properties.Resources.bullet_add;
            buttonAddTeacher_KAL.Enabled = false;
            buttonAddTeacher_KAL.Location = new Point(190, 5);
            buttonAddTeacher_KAL.Name = "buttonAddTeacher_KAL";
            buttonAddTeacher_KAL.Size = new Size(33, 30);
            buttonAddTeacher_KAL.TabIndex = 2;
            toolTipMain_KAL.SetToolTip(buttonAddTeacher_KAL, "Добавить преподавателя");
            buttonAddTeacher_KAL.UseVisualStyleBackColor = true;
            buttonAddTeacher_KAL.Click += buttonAddTeacher_KAL_Click;
            // 
            // buttonDeleteTeacher_KAL
            // 
            buttonDeleteTeacher_KAL.BackgroundImage = Properties.Resources.bullet_delete;
            buttonDeleteTeacher_KAL.Enabled = false;
            buttonDeleteTeacher_KAL.Location = new Point(240, 5);
            buttonDeleteTeacher_KAL.Name = "buttonDeleteTeacher_KAL";
            buttonDeleteTeacher_KAL.Size = new Size(34, 30);
            buttonDeleteTeacher_KAL.TabIndex = 1;
            toolTipMain_KAL.SetToolTip(buttonDeleteTeacher_KAL, "Удалить преподавателя");
            buttonDeleteTeacher_KAL.UseVisualStyleBackColor = true;
            buttonDeleteTeacher_KAL.Click += buttonDeleteTeacher_KAL_Click;
            // 
            // textBoxSearchTeacher_KAL
            // 
            textBoxSearchTeacher_KAL.Enabled = false;
            textBoxSearchTeacher_KAL.Location = new Point(5, 5);
            textBoxSearchTeacher_KAL.Name = "textBoxSearchTeacher_KAL";
            textBoxSearchTeacher_KAL.PlaceholderText = "Поиск...";
            textBoxSearchTeacher_KAL.Size = new Size(180, 27);
            textBoxSearchTeacher_KAL.TabIndex = 0;
            textBoxSearchTeacher_KAL.KeyPress += textBoxSearchTeacher_KAL_KeyPress;
            // 
            // dataGridViewTeachers_KAL
            // 
            dataGridViewTeachers_KAL.AllowUserToAddRows = false;
            dataGridViewTeachers_KAL.AllowUserToDeleteRows = false;
            dataGridViewTeachers_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTeachers_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers_KAL.ColumnHeadersVisible = false;
            dataGridViewTeachers_KAL.Location = new Point(3, 64);
            dataGridViewTeachers_KAL.Name = "dataGridViewTeachers_KAL";
            dataGridViewTeachers_KAL.ReadOnly = true;
            dataGridViewTeachers_KAL.RowHeadersVisible = false;
            dataGridViewTeachers_KAL.RowHeadersWidth = 51;
            dataGridViewTeachers_KAL.Size = new Size(284, 323);
            dataGridViewTeachers_KAL.TabIndex = 0;
            // 
            // panelStats_KAL
            // 
            panelStats_KAL.Controls.Add(groupBoxStats_KAL);
            panelStats_KAL.Dock = DockStyle.Fill;
            panelStats_KAL.Location = new Point(0, 600);
            panelStats_KAL.Name = "panelStats_KAL";
            panelStats_KAL.Padding = new Padding(5);
            panelStats_KAL.Size = new Size(1200, 150);
            panelStats_KAL.TabIndex = 3;
            // 
            // groupBoxStats_KAL
            // 
            groupBoxStats_KAL.Controls.Add(textBoxStats_KAL);
            groupBoxStats_KAL.Dock = DockStyle.Fill;
            groupBoxStats_KAL.Location = new Point(5, 5);
            groupBoxStats_KAL.Name = "groupBoxStats_KAL";
            groupBoxStats_KAL.Size = new Size(1190, 140);
            groupBoxStats_KAL.TabIndex = 0;
            groupBoxStats_KAL.TabStop = false;
            groupBoxStats_KAL.Text = "Статистика";
            // 
            // textBoxStats_KAL
            // 
            textBoxStats_KAL.Dock = DockStyle.Fill;
            textBoxStats_KAL.Location = new Point(3, 23);
            textBoxStats_KAL.Multiline = true;
            textBoxStats_KAL.Name = "textBoxStats_KAL";
            textBoxStats_KAL.ReadOnly = true;
            textBoxStats_KAL.ScrollBars = ScrollBars.Vertical;
            textBoxStats_KAL.Size = new Size(1184, 114);
            textBoxStats_KAL.TabIndex = 0;
            textBoxStats_KAL.Text = "Загрузите данные для отображения статистики...";
            // 
            // openFileDialogLoadFile_KAL
            // 
            openFileDialogLoadFile_KAL.FileName = "openFileDialogLoadFile_KAL";
            // 
            // toolTipMain_KAL
            // 
            toolTipMain_KAL.ForeColor = SystemColors.Highlight;
            toolTipMain_KAL.IsBalloon = true;
            toolTipMain_KAL.ToolTipTitle = "Подсказка";
            // 
            // saveFileDialog_KAL
            // 
            saveFileDialog_KAL.FileName = "saveFileDialog_KAL";
            // 
            // FormMain_KAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(panelStats_KAL);
            Controls.Add(panelMain_KAL);
            Controls.Add(panelTask_KAL);
            Controls.Add(panelButton_KAL);
            MinimumSize = new Size(1218, 797);
            Name = "FormMain_KAL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 3 | Карпенко А. Л.";
            panelButton_KAL.ResumeLayout(false);
            panelTask_KAL.ResumeLayout(false);
            groupBoxTask_KAL.ResumeLayout(false);
            groupBoxTask_KAL.PerformLayout();
            panelMain_KAL.ResumeLayout(false);
            groupBoxAssignments_KAL.ResumeLayout(false);
            panelAssignmentsControl_KAL.ResumeLayout(false);
            panelAssignmentsControl_KAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments_KAL).EndInit();
            groupBoxCourses_KAL.ResumeLayout(false);
            panelCoursesControl_KAL.ResumeLayout(false);
            panelCoursesControl_KAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses_KAL).EndInit();
            groupBoxDepartments_KAL.ResumeLayout(false);
            panelDepartmentsControl_KAL.ResumeLayout(false);
            panelDepartmentsControl_KAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments_KAL).EndInit();
            groupBoxTeachers_KAL.ResumeLayout(false);
            panelTeachersControl_KAL.ResumeLayout(false);
            panelTeachersControl_KAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KAL).EndInit();
            panelStats_KAL.ResumeLayout(false);
            groupBoxStats_KAL.ResumeLayout(false);
            groupBoxStats_KAL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_KAL;
        private Panel panelTask_KAL;
        private Panel panelMain_KAL;
        private Button buttonFileLoad_KAL;
        private Button buttonDone_KAL;
        private Button buttonHelp_KAL;
        private Button buttonAbout_KAL;
        private GroupBox groupBoxTask_KAL;
        private TextBox textBoxTask_KAL;
        private GroupBox groupBoxTeachers_KAL;
        private DataGridView dataGridViewTeachers_KAL;
        private GroupBox groupBoxDepartments_KAL;
        private DataGridView dataGridViewDepartments_KAL;
        private GroupBox groupBoxCourses_KAL;
        private DataGridView dataGridViewCourses_KAL;
        private GroupBox groupBoxAssignments_KAL;
        private DataGridView dataGridViewAssignments_KAL;
        private ToolTip toolTipMain_KAL;
        private OpenFileDialog openFileDialogLoadFile_KAL;
        private SaveFileDialog saveFileDialog_KAL;
        private Button buttonStatistics_KAL;
        private Panel panelTeachersControl_KAL;
        private TextBox textBoxSearchTeacher_KAL;
        private Button buttonAddTeacher_KAL;
        private Button buttonDeleteTeacher_KAL;
        private Panel panelDepartmentsControl_KAL;
        private Button buttonAddDepartment_KAL;
        private Button buttonDeleteDepartment_KAL;
        private TextBox textBoxSearchDepartment_KAL;
        private Panel panelCoursesControl_KAL;
        private Button buttonAddCourse_KAL;
        private Button buttonDeleteCourse_KAL;
        private TextBox textBoxSearchCourse_KAL;
        private Panel panelAssignmentsControl_KAL;
        private Button buttonAddAssignment_KAL;
        private Button buttonDeleteAssignment_KAL;
        private TextBox textBoxSearchAssignment_KAL;
        private Panel panelStats_KAL;
        private GroupBox groupBoxStats_KAL;
        private TextBox textBoxStats_KAL;
    }
}
