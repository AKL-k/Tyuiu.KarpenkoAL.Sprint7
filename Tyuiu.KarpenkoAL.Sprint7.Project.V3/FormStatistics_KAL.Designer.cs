namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3
{
    partial class FormStatistics_KAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelHeader_KAL = new Panel();
            groupBoxHeader_KAL = new GroupBox();
            buttonBack_KAL = new Button();
            textBoxHeader_KAL = new TextBox();
            panelMain_KAL = new Panel();
            groupBoxChart_KAL = new GroupBox();
            chartMain_KAL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxStats_KAL = new GroupBox();
            textBoxStats_KAL = new TextBox();
            panelControls_KAL = new Panel();
            buttonLoadData_KAL = new Button();
            buttonRefresh_KAL = new Button();
            toolTipStats_KAL = new ToolTip(components);
            panelHeader_KAL.SuspendLayout();
            groupBoxHeader_KAL.SuspendLayout();
            panelMain_KAL.SuspendLayout();
            groupBoxChart_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain_KAL).BeginInit();
            groupBoxStats_KAL.SuspendLayout();
            panelControls_KAL.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader_KAL
            // 
            panelHeader_KAL.Controls.Add(groupBoxHeader_KAL);
            panelHeader_KAL.Dock = DockStyle.Top;
            panelHeader_KAL.Location = new Point(0, 0);
            panelHeader_KAL.Name = "panelHeader_KAL";
            panelHeader_KAL.Size = new Size(1337, 120);
            panelHeader_KAL.TabIndex = 0;
            // 
            // groupBoxHeader_KAL
            // 
            groupBoxHeader_KAL.Controls.Add(buttonBack_KAL);
            groupBoxHeader_KAL.Controls.Add(textBoxHeader_KAL);
            groupBoxHeader_KAL.Dock = DockStyle.Fill;
            groupBoxHeader_KAL.Location = new Point(0, 0);
            groupBoxHeader_KAL.Name = "groupBoxHeader_KAL";
            groupBoxHeader_KAL.Size = new Size(1337, 120);
            groupBoxHeader_KAL.TabIndex = 0;
            groupBoxHeader_KAL.TabStop = false;
            groupBoxHeader_KAL.Text = "Статистика и графики";
            // 
            // buttonBack_KAL
            // 
            buttonBack_KAL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBack_KAL.BackgroundImage = Properties.Resources.feeeeeeeeeeeer;
            buttonBack_KAL.Location = new Point(1228, 35);
            buttonBack_KAL.Name = "buttonBack_KAL";
            buttonBack_KAL.Size = new Size(82, 70);
            buttonBack_KAL.TabIndex = 1;
            toolTipStats_KAL.SetToolTip(buttonBack_KAL, "Вернуться в главное меню");
            buttonBack_KAL.UseVisualStyleBackColor = true;
            buttonBack_KAL.Click += buttonBack_KAL_Click;
            buttonBack_KAL.MouseEnter += buttonBack_KAL_MouseEnter;
            // 
            // textBoxHeader_KAL
            // 
            textBoxHeader_KAL.Dock = DockStyle.Fill;
            textBoxHeader_KAL.Location = new Point(3, 23);
            textBoxHeader_KAL.Multiline = true;
            textBoxHeader_KAL.Name = "textBoxHeader_KAL";
            textBoxHeader_KAL.ReadOnly = true;
            textBoxHeader_KAL.Size = new Size(1331, 94);
            textBoxHeader_KAL.TabIndex = 0;
            textBoxHeader_KAL.Text = "Расширенная статистика по данным университета. График показывает распределение часов по предметам.";
            // 
            // panelMain_KAL
            // 
            panelMain_KAL.Controls.Add(groupBoxChart_KAL);
            panelMain_KAL.Controls.Add(groupBoxStats_KAL);
            panelMain_KAL.Dock = DockStyle.Fill;
            panelMain_KAL.Location = new Point(0, 120);
            panelMain_KAL.Name = "panelMain_KAL";
            panelMain_KAL.Padding = new Padding(10);
            panelMain_KAL.Size = new Size(1337, 530);
            panelMain_KAL.TabIndex = 1;
            // 
            // groupBoxChart_KAL
            // 
            groupBoxChart_KAL.Controls.Add(chartMain_KAL);
            groupBoxChart_KAL.Dock = DockStyle.Fill;
            groupBoxChart_KAL.Location = new Point(10, 10);
            groupBoxChart_KAL.Name = "groupBoxChart_KAL";
            groupBoxChart_KAL.Size = new Size(917, 510);
            groupBoxChart_KAL.TabIndex = 1;
            groupBoxChart_KAL.TabStop = false;
            groupBoxChart_KAL.Text = "График распределения часов";
            // 
            // chartMain_KAL
            // 
            chartArea1.Name = "ChartArea1";
            chartMain_KAL.ChartAreas.Add(chartArea1);
            chartMain_KAL.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMain_KAL.Legends.Add(legend1);
            chartMain_KAL.Location = new Point(3, 23);
            chartMain_KAL.Name = "chartMain_KAL";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartMain_KAL.Series.Add(series1);
            chartMain_KAL.Size = new Size(911, 484);
            chartMain_KAL.TabIndex = 0;
            chartMain_KAL.Text = "chart1";
            // 
            // groupBoxStats_KAL
            // 
            groupBoxStats_KAL.Controls.Add(textBoxStats_KAL);
            groupBoxStats_KAL.Dock = DockStyle.Right;
            groupBoxStats_KAL.Location = new Point(927, 10);
            groupBoxStats_KAL.Name = "groupBoxStats_KAL";
            groupBoxStats_KAL.Size = new Size(400, 510);
            groupBoxStats_KAL.TabIndex = 0;
            groupBoxStats_KAL.TabStop = false;
            groupBoxStats_KAL.Text = "Расширенная статистика";
            // 
            // textBoxStats_KAL
            // 
            textBoxStats_KAL.Dock = DockStyle.Fill;
            textBoxStats_KAL.Location = new Point(3, 23);
            textBoxStats_KAL.Multiline = true;
            textBoxStats_KAL.Name = "textBoxStats_KAL";
            textBoxStats_KAL.ReadOnly = true;
            textBoxStats_KAL.ScrollBars = ScrollBars.Vertical;
            textBoxStats_KAL.Size = new Size(394, 484);
            textBoxStats_KAL.TabIndex = 0;
            textBoxStats_KAL.Text = "Нажмите \"Загрузить данные\" для отображения статистики...";
            // 
            // panelControls_KAL
            // 
            panelControls_KAL.Controls.Add(buttonLoadData_KAL);
            panelControls_KAL.Controls.Add(buttonRefresh_KAL);
            panelControls_KAL.Dock = DockStyle.Bottom;
            panelControls_KAL.Location = new Point(0, 650);
            panelControls_KAL.Name = "panelControls_KAL";
            panelControls_KAL.Size = new Size(1337, 80);
            panelControls_KAL.TabIndex = 2;
            // 
            // buttonLoadData_KAL
            // 
            buttonLoadData_KAL.BackgroundImage = Properties.Resources.imaged1;
            buttonLoadData_KAL.Location = new Point(13, 10);
            buttonLoadData_KAL.Name = "buttonLoadData_KAL";
            buttonLoadData_KAL.Size = new Size(99, 60);
            buttonLoadData_KAL.TabIndex = 1;
            toolTipStats_KAL.SetToolTip(buttonLoadData_KAL, "Загрузить данные для анализа");
            buttonLoadData_KAL.UseVisualStyleBackColor = true;
            buttonLoadData_KAL.Click += buttonLoadData_KAL_Click;
            buttonLoadData_KAL.MouseEnter += buttonLoadData_KAL_MouseEnter;
            // 
            // buttonRefresh_KAL
            // 
            buttonRefresh_KAL.BackgroundImage = Properties.Resources.загружfffffffffffffffffffffffeeeeeeeeeeeeeeeeeeeeенное;
            buttonRefresh_KAL.Enabled = false;
            buttonRefresh_KAL.Location = new Point(140, 10);
            buttonRefresh_KAL.Name = "buttonRefresh_KAL";
            buttonRefresh_KAL.Size = new Size(73, 58);
            buttonRefresh_KAL.TabIndex = 0;
            toolTipStats_KAL.SetToolTip(buttonRefresh_KAL, "Обновить статистику");
            buttonRefresh_KAL.UseVisualStyleBackColor = true;
            buttonRefresh_KAL.Click += buttonRefresh_KAL_Click;
            buttonRefresh_KAL.MouseEnter += buttonRefresh_KAL_MouseEnter;
            // 
            // toolTipStats_KAL
            // 
            toolTipStats_KAL.ForeColor = SystemColors.Highlight;
            toolTipStats_KAL.IsBalloon = true;
            toolTipStats_KAL.ToolTipTitle = "Подсказка";
            // 
            // FormStatistics_KAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 730);
            Controls.Add(panelMain_KAL);
            Controls.Add(panelControls_KAL);
            Controls.Add(panelHeader_KAL);
            MinimumSize = new Size(1355, 777);
            Name = "FormStatistics_KAL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика университета | Карпенко А. Л.";
            panelHeader_KAL.ResumeLayout(false);
            groupBoxHeader_KAL.ResumeLayout(false);
            groupBoxHeader_KAL.PerformLayout();
            panelMain_KAL.ResumeLayout(false);
            groupBoxChart_KAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMain_KAL).EndInit();
            groupBoxStats_KAL.ResumeLayout(false);
            groupBoxStats_KAL.PerformLayout();
            panelControls_KAL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader_KAL;
        private Button buttonBack_KAL;
        private GroupBox groupBoxHeader_KAL;
        private TextBox textBoxHeader_KAL;
        private Panel panelMain_KAL;
        private GroupBox groupBoxStats_KAL;
        private TextBox textBoxStats_KAL;
        private Panel panelControls_KAL;
        private Button buttonRefresh_KAL;
        private Button buttonLoadData_KAL;
        private ToolTip toolTipStats_KAL;
        private GroupBox groupBoxChart_KAL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain_KAL;
    }
}