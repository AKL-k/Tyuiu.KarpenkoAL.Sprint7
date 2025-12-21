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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KAL));
            panelButton_KAL = new Panel();
            buttonAbout_KAL = new Button();
            buttonHelp_KAL = new Button();
            buttonSave_KAL = new Button();
            buttonDone_KAL = new Button();
            buttonFileLoad_KAL = new Button();
            panelTask_KAL = new Panel();
            groupBoxTask_KAL = new GroupBox();
            textBoxTask_KAL = new TextBox();
            panelMain_KAL = new Panel();
            groupBoxMain_KAL = new GroupBox();
            tabControlMain_KAL = new TabControl();
            tabPageTeachers_KAL = new TabPage();
            dataGridViewTeachers_KAL = new DataGridView();
            tabPageDepartments_KAL = new TabPage();
            dataGridViewDepartments_KAL = new DataGridView();
            tabPageCourses_KAL = new TabPage();
            dataGridViewCourses_KAL = new DataGridView();
            tabPageAssignments_KAL = new TabPage();
            dataGridViewAssignments_KAL = new DataGridView();
            openFileDialogLoadFile_KAL = new OpenFileDialog();
            toolTipMain_KAL = new ToolTip(components);
            saveFileDialog_KAL = new SaveFileDialog();
            statusStripMain_KAL = new StatusStrip();
            toolStripStatusLabelCount_KAL = new ToolStripStatusLabel();
            panelButton_KAL.SuspendLayout();
            panelTask_KAL.SuspendLayout();
            groupBoxTask_KAL.SuspendLayout();
            panelMain_KAL.SuspendLayout();
            groupBoxMain_KAL.SuspendLayout();
            tabControlMain_KAL.SuspendLayout();
            tabPageTeachers_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KAL).BeginInit();
            tabPageDepartments_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments_KAL).BeginInit();
            tabPageCourses_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses_KAL).BeginInit();
            tabPageAssignments_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments_KAL).BeginInit();
            statusStripMain_KAL.SuspendLayout();
            SuspendLayout();
            // 
            // panelButton_KAL
            // 
            panelButton_KAL.Controls.Add(buttonAbout_KAL);
            panelButton_KAL.Controls.Add(buttonHelp_KAL);
            panelButton_KAL.Controls.Add(buttonSave_KAL);
            panelButton_KAL.Controls.Add(buttonDone_KAL);
            panelButton_KAL.Controls.Add(buttonFileLoad_KAL);
            panelButton_KAL.Dock = DockStyle.Top;
            panelButton_KAL.Location = new Point(0, 0);
            panelButton_KAL.Name = "panelButton_KAL";
            panelButton_KAL.Size = new Size(1400, 100);
            panelButton_KAL.TabIndex = 0;
            // 
            // buttonAbout_KAL
            // 
            buttonAbout_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_KAL.Location = new Point(1300, 15);
            buttonAbout_KAL.Name = "buttonAbout_KAL";
            buttonAbout_KAL.Size = new Size(88, 70);
            buttonAbout_KAL.TabIndex = 4;
            toolTipMain_KAL.SetToolTip(buttonAbout_KAL, "Информация о программе и авторе");
            buttonAbout_KAL.UseVisualStyleBackColor = true;
            buttonAbout_KAL.Click += buttonAbout_KAL_Click;
            buttonAbout_KAL.MouseEnter += buttonAbout_KAL_MouseEnter;
            // 
            // buttonHelp_KAL
            // 
            buttonHelp_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAL.Location = new Point(1200, 15);
            buttonHelp_KAL.Name = "buttonHelp_KAL";
            buttonHelp_KAL.Size = new Size(88, 70);
            buttonHelp_KAL.TabIndex = 3;
            toolTipMain_KAL.SetToolTip(buttonHelp_KAL, "Справка по использованию программы");
            buttonHelp_KAL.UseVisualStyleBackColor = true;
            buttonHelp_KAL.Click += buttonHelp_KAL_Click;
            buttonHelp_KAL.MouseEnter += buttonHelp_KAL_MouseEnter;
            // 
            // buttonSave_KAL
            // 
            buttonSave_KAL.Location = new Point(200, 15);
            buttonSave_KAL.Name = "buttonSave_KAL";
            buttonSave_KAL.Size = new Size(84, 70);
            buttonSave_KAL.TabIndex = 2;
            buttonSave_KAL.Enabled = false;
            toolTipMain_KAL.SetToolTip(buttonSave_KAL, "Сохранить изменения");
            buttonSave_KAL.UseVisualStyleBackColor = true;
            // 
            // buttonDone_KAL
            // 
            buttonDone_KAL.BackgroundImage = Properties.Resources.imagef; // Иконка выполнения
            buttonDone_KAL.Location = new Point(100, 15);
            buttonDone_KAL.Name = "buttonDone_KAL";
            buttonDone_KAL.Size = new Size(84, 70);
            buttonDone_KAL.TabIndex = 1;
            buttonDone_KAL.Enabled = false;
            toolTipMain_KAL.SetToolTip(buttonDone_KAL, "Выполнить операцию (поиск, фильтрация)");
            buttonDone_KAL.UseVisualStyleBackColor = true;
            buttonDone_KAL.Click += buttonDone_KAL_Click;
            buttonDone_KAL.MouseEnter += buttonDone_KAL_MouseEnter;
            // 
            // buttonFileLoad_KAL
            // 
            buttonFileLoad_KAL.Location = new Point(10, 15);
            buttonFileLoad_KAL.Name = "buttonFileLoad_KAL";
            buttonFileLoad_KAL.Size = new Size(84, 70);
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
            panelTask_KAL.Size = new Size(1400, 100);
            panelTask_KAL.TabIndex = 1;
            // 
            // groupBoxTask_KAL
            // 
            groupBoxTask_KAL.Controls.Add(textBoxTask_KAL);
            groupBoxTask_KAL.Dock = DockStyle.Fill;
            groupBoxTask_KAL.Location = new Point(5, 5);
            groupBoxTask_KAL.Name = "groupBoxTask_KAL";
            groupBoxTask_KAL.Size = new Size(1390, 90);
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
            textBoxTask_KAL.Size = new Size(1384, 64);
            textBoxTask_KAL.TabIndex = 0;
            textBoxTask_KAL.Text = "Система управления университетом. Загрузка и просмотр данных о преподавателях, кафедрах, предметах и нагрузке.";
            // 
            // panelMain_KAL
            // 
            panelMain_KAL.Controls.Add(groupBoxMain_KAL);
            panelMain_KAL.Dock = DockStyle.Fill;
            panelMain_KAL.Location = new Point(0, 200);
            panelMain_KAL.Name = "panelMain_KAL";
            panelMain_KAL.Padding = new Padding(5);
            panelMain_KAL.Size = new Size(1400, 646);
            panelMain_KAL.TabIndex = 2;
            // 
            // groupBoxMain_KAL
            // 
            groupBoxMain_KAL.Controls.Add(tabControlMain_KAL);
            groupBoxMain_KAL.Dock = DockStyle.Fill;
            groupBoxMain_KAL.Location = new Point(5, 5);
            groupBoxMain_KAL.Name = "groupBoxMain_KAL";
            groupBoxMain_KAL.Size = new Size(1390, 636);
            groupBoxMain_KAL.TabIndex = 0;
            groupBoxMain_KAL.TabStop = false;
            groupBoxMain_KAL.Text = "Данные";
            // 
            // tabControlMain_KAL
            // 
            tabControlMain_KAL.Controls.Add(tabPageTeachers_KAL);
            tabControlMain_KAL.Controls.Add(tabPageDepartments_KAL);
            tabControlMain_KAL.Controls.Add(tabPageCourses_KAL);
            tabControlMain_KAL.Controls.Add(tabPageAssignments_KAL);
            tabControlMain_KAL.Dock = DockStyle.Fill;
            tabControlMain_KAL.Location = new Point(3, 23);
            tabControlMain_KAL.Name = "tabControlMain_KAL";
            tabControlMain_KAL.SelectedIndex = 0;
            tabControlMain_KAL.Size = new Size(1384, 610);
            tabControlMain_KAL.TabIndex = 0;
            // 
            // tabPageTeachers_KAL
            // 
            tabPageTeachers_KAL.Controls.Add(dataGridViewTeachers_KAL);
            tabPageTeachers_KAL.Location = new Point(4, 29);
            tabPageTeachers_KAL.Name = "tabPageTeachers_KAL";
            tabPageTeachers_KAL.Padding = new Padding(3);
            tabPageTeachers_KAL.Size = new Size(1376, 577);
            tabPageTeachers_KAL.TabIndex = 0;
            tabPageTeachers_KAL.Text = "Преподаватели";
            tabPageTeachers_KAL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTeachers_KAL
            // 
            dataGridViewTeachers_KAL.AllowUserToAddRows = false;
            dataGridViewTeachers_KAL.AllowUserToDeleteRows = false;
            dataGridViewTeachers_KAL.AllowUserToResizeColumns = false;
            dataGridViewTeachers_KAL.AllowUserToResizeRows = false;
            dataGridViewTeachers_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers_KAL.Dock = DockStyle.Fill;
            dataGridViewTeachers_KAL.Location = new Point(3, 3);
            dataGridViewTeachers_KAL.Name = "dataGridViewTeachers_KAL";
            dataGridViewTeachers_KAL.ReadOnly = true;
            dataGridViewTeachers_KAL.RowHeadersWidth = 51;
            dataGridViewTeachers_KAL.Size = new Size(1370, 571);
            dataGridViewTeachers_KAL.TabIndex = 0;
            // 
            // tabPageDepartments_KAL
            // 
            tabPageDepartments_KAL.Controls.Add(dataGridViewDepartments_KAL);
            tabPageDepartments_KAL.Location = new Point(4, 29);
            tabPageDepartments_KAL.Name = "tabPageDepartments_KAL";
            tabPageDepartments_KAL.Padding = new Padding(3);
            tabPageDepartments_KAL.Size = new Size(1376, 577);
            tabPageDepartments_KAL.TabIndex = 1;
            tabPageDepartments_KAL.Text = "Кафедры";
            tabPageDepartments_KAL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDepartments_KAL
            // 
            dataGridViewDepartments_KAL.AllowUserToAddRows = false;
            dataGridViewDepartments_KAL.AllowUserToDeleteRows = false;
            dataGridViewDepartments_KAL.AllowUserToResizeColumns = false;
            dataGridViewDepartments_KAL.AllowUserToResizeRows = false;
            dataGridViewDepartments_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments_KAL.Dock = DockStyle.Fill;
            dataGridViewDepartments_KAL.Location = new Point(3, 3);
            dataGridViewDepartments_KAL.Name = "dataGridViewDepartments_KAL";
            dataGridViewDepartments_KAL.ReadOnly = true;
            dataGridViewDepartments_KAL.RowHeadersWidth = 51;
            dataGridViewDepartments_KAL.Size = new Size(1370, 571);
            dataGridViewDepartments_KAL.TabIndex = 0;
            // 
            // tabPageCourses_KAL
            // 
            tabPageCourses_KAL.Controls.Add(dataGridViewCourses_KAL);
            tabPageCourses_KAL.Location = new Point(4, 29);
            tabPageCourses_KAL.Name = "tabPageCourses_KAL";
            tabPageCourses_KAL.Padding = new Padding(3);
            tabPageCourses_KAL.Size = new Size(1376, 577);
            tabPageCourses_KAL.TabIndex = 2;
            tabPageCourses_KAL.Text = "Предметы";
            tabPageCourses_KAL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCourses_KAL
            // 
            dataGridViewCourses_KAL.AllowUserToAddRows = false;
            dataGridViewCourses_KAL.AllowUserToDeleteRows = false;
            dataGridViewCourses_KAL.AllowUserToResizeColumns = false;
            dataGridViewCourses_KAL.AllowUserToResizeRows = false;
            dataGridViewCourses_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses_KAL.Dock = DockStyle.Fill;
            dataGridViewCourses_KAL.Location = new Point(3, 3);
            dataGridViewCourses_KAL.Name = "dataGridViewCourses_KAL";
            dataGridViewCourses_KAL.ReadOnly = true;
            dataGridViewCourses_KAL.RowHeadersWidth = 51;
            dataGridViewCourses_KAL.Size = new Size(1370, 571);
            dataGridViewCourses_KAL.TabIndex = 0;
            // 
            // tabPageAssignments_KAL
            // 
            tabPageAssignments_KAL.Controls.Add(dataGridViewAssignments_KAL);
            tabPageAssignments_KAL.Location = new Point(4, 29);
            tabPageAssignments_KAL.Name = "tabPageAssignments_KAL";
            tabPageAssignments_KAL.Padding = new Padding(3);
            tabPageAssignments_KAL.Size = new Size(1376, 577);
            tabPageAssignments_KAL.TabIndex = 3;
            tabPageAssignments_KAL.Text = "Нагрузка";
            tabPageAssignments_KAL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAssignments_KAL
            // 
            dataGridViewAssignments_KAL.AllowUserToAddRows = false;
            dataGridViewAssignments_KAL.AllowUserToDeleteRows = false;
            dataGridViewAssignments_KAL.AllowUserToResizeColumns = false;
            dataGridViewAssignments_KAL.AllowUserToResizeRows = false;
            dataGridViewAssignments_KAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignments_KAL.Dock = DockStyle.Fill;
            dataGridViewAssignments_KAL.Location = new Point(3, 3);
            dataGridViewAssignments_KAL.Name = "dataGridViewAssignments_KAL";
            dataGridViewAssignments_KAL.ReadOnly = true;
            dataGridViewAssignments_KAL.RowHeadersWidth = 51;
            dataGridViewAssignments_KAL.Size = new Size(1370, 571);
            dataGridViewAssignments_KAL.TabIndex = 0;
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
            // statusStripMain_KAL
            // 
            statusStripMain_KAL.ImageScalingSize = new Size(20, 20);
            statusStripMain_KAL.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount_KAL });
            statusStripMain_KAL.Location = new Point(0, 846);
            statusStripMain_KAL.Name = "statusStripMain_KAL";
            statusStripMain_KAL.Size = new Size(1400, 26);
            statusStripMain_KAL.TabIndex = 3;
            statusStripMain_KAL.Text = "statusStripMain_KAL";
            // 
            // toolStripStatusLabelCount_KAL
            // 
            toolStripStatusLabelCount_KAL.Name = "toolStripStatusLabelCount_KAL";
            toolStripStatusLabelCount_KAL.Size = new Size(151, 20);
            toolStripStatusLabelCount_KAL.Text = "Данные не загружены";
            // 
            // FormMain_KAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 872);
            Controls.Add(panelMain_KAL);
            Controls.Add(panelTask_KAL);
            Controls.Add(panelButton_KAL);
            Controls.Add(statusStripMain_KAL);
            Name = "FormMain_KAL";
            Text = "Спринт 7 | Проект | Вариант 0 | Карпенко А. Л.";
            panelButton_KAL.ResumeLayout(false);
            panelTask_KAL.ResumeLayout(false);
            groupBoxTask_KAL.ResumeLayout(false);
            groupBoxTask_KAL.PerformLayout();
            panelMain_KAL.ResumeLayout(false);
            groupBoxMain_KAL.ResumeLayout(false);
            tabControlMain_KAL.ResumeLayout(false);
            tabPageTeachers_KAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KAL).EndInit();
            tabPageDepartments_KAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments_KAL).EndInit();
            tabPageCourses_KAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses_KAL).EndInit();
            tabPageAssignments_KAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments_KAL).EndInit();
            statusStripMain_KAL.ResumeLayout(false);
            statusStripMain_KAL.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelButton_KAL;
        private Panel panelTask_KAL;
        private Panel panelMain_KAL;
        private Button buttonFileLoad_KAL;
        private Button buttonDone_KAL;
        private Button buttonSave_KAL;
        private Button buttonHelp_KAL;
        private Button buttonAbout_KAL;
        private GroupBox groupBoxTask_KAL;
        private GroupBox groupBoxMain_KAL;
        private TextBox textBoxTask_KAL;
        private TabControl tabControlMain_KAL;
        private TabPage tabPageTeachers_KAL;
        private DataGridView dataGridViewTeachers_KAL;
        private TabPage tabPageDepartments_KAL;
        private DataGridView dataGridViewDepartments_KAL;
        private TabPage tabPageCourses_KAL;
        private DataGridView dataGridViewCourses_KAL;
        private TabPage tabPageAssignments_KAL;
        private DataGridView dataGridViewAssignments_KAL;
        private ToolTip toolTipMain_KAL;
        private OpenFileDialog openFileDialogLoadFile_KAL;
        private SaveFileDialog saveFileDialog_KAL;
        private StatusStrip statusStripMain_KAL;
        private ToolStripStatusLabel toolStripStatusLabelCount_KAL;
    }
}
