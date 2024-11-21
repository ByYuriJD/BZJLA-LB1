namespace LB1 {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panelTop = new Panel();
            labelUsers = new Label();
            panelDown = new Panel();
            labelInfAboutUsers = new Label();
            panelTop.SuspendLayout();
            panelDown.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(582, 100);
            panelTop.TabIndex = 0;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(562, 80);
            labelUsers.TabIndex = 0;
            labelUsers.Text = "Список пользователей";
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDown
            // 
            panelDown.Controls.Add(labelInfAboutUsers);
            panelDown.Dock = DockStyle.Fill;
            panelDown.Location = new Point(0, 100);
            panelDown.Name = "panelDown";
            panelDown.Size = new Size(582, 253);
            panelDown.TabIndex = 0;
            // 
            // labelInfAboutUsers
            // 
            labelInfAboutUsers.Dock = DockStyle.Fill;
            labelInfAboutUsers.Location = new Point(0, 0);
            labelInfAboutUsers.Name = "labelInfAboutUsers";
            labelInfAboutUsers.Size = new Size(582, 253);
            labelInfAboutUsers.TabIndex = 0;
            labelInfAboutUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 353);
            Controls.Add(panelDown);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Пользователи";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelDown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelUsers;
        private Panel panelDown;
        private Label labelInfAboutUsers;
    }
}
