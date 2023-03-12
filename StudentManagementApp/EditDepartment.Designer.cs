namespace StudentManagementApp
{
    partial class EditDepartment
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
            this.listBoxLectures = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.btnSaveDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLectures
            // 
            this.listBoxLectures.FormattingEnabled = true;
            this.listBoxLectures.ItemHeight = 15;
            this.listBoxLectures.Location = new System.Drawing.Point(178, 41);
            this.listBoxLectures.Name = "listBoxLectures";
            this.listBoxLectures.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxLectures.Size = new System.Drawing.Size(120, 94);
            this.listBoxLectures.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lectures";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(120, 12);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(178, 23);
            this.txtDepartmentName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department name";
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(11, 207);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(26, 23);
            this.txtDepartmentId.TabIndex = 10;
            this.txtDepartmentId.Visible = false;
            // 
            // btnSaveDepartment
            // 
            this.btnSaveDepartment.Location = new System.Drawing.Point(229, 207);
            this.btnSaveDepartment.Name = "btnSaveDepartment";
            this.btnSaveDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDepartment.TabIndex = 11;
            this.btnSaveDepartment.Text = "Save";
            this.btnSaveDepartment.UseVisualStyleBackColor = true;
            this.btnSaveDepartment.Click += new System.EventHandler(this.btnSaveDepartment_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 242);
            this.Controls.Add(this.btnSaveDepartment);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.listBoxLectures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label1);
            this.Name = "EditDepartment";
            this.Text = "EditDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxLectures;
        private Label label2;
        private TextBox txtDepartmentName;
        private Label label1;
        private TextBox txtDepartmentId;
        private Button btnSaveDepartment;
    }
}