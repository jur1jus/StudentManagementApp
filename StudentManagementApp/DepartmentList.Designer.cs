namespace StudentManagementApp
{
    partial class DepartmentList
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
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.dataGridDepartments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(12, 12);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(142, 23);
            this.btnAddDepartment.TabIndex = 0;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // dataGridDepartments
            // 
            this.dataGridDepartments.AllowUserToAddRows = false;
            this.dataGridDepartments.AllowUserToDeleteRows = false;
            this.dataGridDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepartments.Location = new System.Drawing.Point(12, 41);
            this.dataGridDepartments.Name = "dataGridDepartments";
            this.dataGridDepartments.ReadOnly = true;
            this.dataGridDepartments.RowTemplate.Height = 25;
            this.dataGridDepartments.Size = new System.Drawing.Size(351, 167);
            this.dataGridDepartments.TabIndex = 1;
            // 
            // DepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 220);
            this.Controls.Add(this.dataGridDepartments);
            this.Controls.Add(this.btnAddDepartment);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentList";
            this.Text = "Department List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddDepartment;
        private DataGridView dataGridDepartments;
    }
}