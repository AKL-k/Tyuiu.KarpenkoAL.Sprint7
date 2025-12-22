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
            buttonOK_KAL = new Button();
            groupBox_KAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KAL).BeginInit();
            SuspendLayout();
            // 
            // groupBox_KAL
            // 
            groupBox_KAL.Controls.Add(textBoxAbout_KAL);
            groupBox_KAL.Location = new Point(396, 22);
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
            textBoxAbout_KAL.ReadOnly = true;
            textBoxAbout_KAL.Size = new Size(373, 314);
            textBoxAbout_KAL.TabIndex = 0;
            textBoxAbout_KAL.Text = resources.GetString("textBoxAbout_KAL.Text");
            // 
            // pictureBoxAbout_KAL
            // 
            pictureBoxAbout_KAL.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAbout_KAL.Image = Properties.Resources.ffffeeeerrrrrrrrrr1;
            pictureBoxAbout_KAL.InitialImage = null;
            pictureBoxAbout_KAL.Location = new Point(12, 42);
            pictureBoxAbout_KAL.Name = "pictureBoxAbout_KAL";
            pictureBoxAbout_KAL.Size = new Size(307, 320);
            pictureBoxAbout_KAL.TabIndex = 1;
            pictureBoxAbout_KAL.TabStop = false;
            // 
            // buttonOK_KAL
            // 
            buttonOK_KAL.Location = new Point(696, 380);
            buttonOK_KAL.Name = "buttonOK_KAL";
            buttonOK_KAL.Size = new Size(65, 26);
            buttonOK_KAL.TabIndex = 2;
            buttonOK_KAL.Text = "Ок";
            buttonOK_KAL.UseVisualStyleBackColor = true;
            buttonOK_KAL.Click += buttonOK_KAL_Click;
            // 
            // FormAbout_KAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 409);
            Controls.Add(buttonOK_KAL);
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
        private Button buttonOK_KAL;
    }
}