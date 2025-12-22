namespace Tyuiu.KarpenkoAL.Sprint7.Project.V3
{
    partial class FormAbout_KAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KAL));
            groupBox_KAL = new GroupBox();
            textBoxAbout_KAL = new TextBox();
            pictureBoxAbout_KAL = new PictureBox();
            groupBox_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KAL).BeginInit();
            SuspendLayout();
            // 
            // groupBox_KAL
            // 
            groupBox_KAL.Controls.Add(textBoxAbout_KAL);
            groupBox_KAL.Location = new Point(392, 65);
            groupBox_KAL.Name = "groupBox_KAL";
            groupBox_KAL.Size = new Size(379, 340);
            groupBox_KAL.TabIndex = 0;
            groupBox_KAL.TabStop = false;
            // 
            // textBoxAbout_KAL
            // 
            textBoxAbout_KAL.Dock = DockStyle.Fill;
            textBoxAbout_KAL.Location = new Point(3, 23);
            textBoxAbout_KAL.Multiline = true;
            textBoxAbout_KAL.Name = "textBoxAbout_KAL";
            textBoxAbout_KAL.Size = new Size(373, 314);
            textBoxAbout_KAL.TabIndex = 0;
            textBoxAbout_KAL.Text = resources.GetString("textBoxAbout_KAL.Text");
            // 
            // pictureBoxAbout_KAL
            // 
            pictureBoxAbout_KAL.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAbout_KAL.InitialImage = Properties.Resources.ffffeeeerrrrrrrrrr;
            pictureBoxAbout_KAL.Location = new Point(41, 59);
            pictureBoxAbout_KAL.Name = "pictureBoxAbout_KAL";
            pictureBoxAbout_KAL.Size = new Size(292, 346);
            pictureBoxAbout_KAL.TabIndex = 1;
            pictureBoxAbout_KAL.TabStop = false;
            // 
            // FormAbout_KAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxAbout_KAL);
            Controls.Add(groupBox_KAL);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_KAL";
            Text = "FormAbout_KAL";
            groupBox_KAL.ResumeLayout(false);
            groupBox_KAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KAL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_KAL;
        private TextBox textBoxAbout_KAL;
        private PictureBox pictureBoxAbout_KAL;
    }
}