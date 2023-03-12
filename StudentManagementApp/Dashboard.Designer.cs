namespace StudentManagementApp
{
    partial class Dashboard
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
            this.btnStudentList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDepartmentList = new System.Windows.Forms.Button();
            this.btnAddLecture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentList
            // 
            this.btnStudentList.Location = new System.Drawing.Point(12, 12);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(165, 23);
            this.btnStudentList.TabIndex = 0;
            this.btnStudentList.Text = "Student List";
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Department Lecture List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDepartmentList
            // 
            this.btnDepartmentList.Location = new System.Drawing.Point(12, 70);
            this.btnDepartmentList.Name = "btnDepartmentList";
            this.btnDepartmentList.Size = new System.Drawing.Size(165, 23);
            this.btnDepartmentList.TabIndex = 2;
            this.btnDepartmentList.Text = "Department List";
            this.btnDepartmentList.UseVisualStyleBackColor = true;
            this.btnDepartmentList.Click += new System.EventHandler(this.btnDepartmentList_Click);
            // 
            // btnAddLecture
            // 
            this.btnAddLecture.Location = new System.Drawing.Point(12, 99);
            this.btnAddLecture.Name = "btnAddLecture";
            this.btnAddLecture.Size = new System.Drawing.Size(165, 23);
            this.btnAddLecture.TabIndex = 3;
            this.btnAddLecture.Text = "Add Lecture";
            this.btnAddLecture.UseVisualStyleBackColor = true;
            this.btnAddLecture.Click += new System.EventHandler(this.btnAddLecture_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 207);
            this.Controls.Add(this.btnAddLecture);
            this.Controls.Add(this.btnDepartmentList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStudentList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStudentList;
        private Button button1;
        private Button btnDepartmentList;
        private Button btnAddLecture;
    }
}