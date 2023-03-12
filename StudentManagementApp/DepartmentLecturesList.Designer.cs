namespace StudentManagementApp
{
    partial class DepartmentLecturesList
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
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.dataGridViewDepartmentLectures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentLectures)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.DisplayMember = "Id";
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(194, 23);
            this.comboBoxDepartments.TabIndex = 0;
            this.comboBoxDepartments.ValueMember = "Id";
            // 
            // dataGridViewDepartmentLectures
            // 
            this.dataGridViewDepartmentLectures.AllowUserToAddRows = false;
            this.dataGridViewDepartmentLectures.AllowUserToDeleteRows = false;
            this.dataGridViewDepartmentLectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentLectures.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewDepartmentLectures.Name = "dataGridViewDepartmentLectures";
            this.dataGridViewDepartmentLectures.ReadOnly = true;
            this.dataGridViewDepartmentLectures.RowTemplate.Height = 25;
            this.dataGridViewDepartmentLectures.Size = new System.Drawing.Size(194, 279);
            this.dataGridViewDepartmentLectures.TabIndex = 1;
            // 
            // DepartmentLecturesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 332);
            this.Controls.Add(this.dataGridViewDepartmentLectures);
            this.Controls.Add(this.comboBoxDepartments);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentLecturesList";
            this.Text = "Department Lectures List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentLectures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxDepartments;
        private DataGridView dataGridViewDepartmentLectures;
    }
}