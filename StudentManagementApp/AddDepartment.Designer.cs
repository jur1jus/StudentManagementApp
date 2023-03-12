namespace StudentManagementApp
{
    partial class AddDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSaveDepartment = new System.Windows.Forms.Button();
            this.listBoxLectures = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department name";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(121, 6);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(178, 23);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lectures";
            // 
            // BtnSaveDepartment
            // 
            this.BtnSaveDepartment.Location = new System.Drawing.Point(210, 322);
            this.BtnSaveDepartment.Name = "BtnSaveDepartment";
            this.BtnSaveDepartment.Size = new System.Drawing.Size(89, 23);
            this.BtnSaveDepartment.TabIndex = 4;
            this.BtnSaveDepartment.Text = "Save";
            this.BtnSaveDepartment.UseVisualStyleBackColor = true;
            this.BtnSaveDepartment.Click += new System.EventHandler(this.BtnSaveDepartment_Click);
            // 
            // listBoxLectures
            // 
            this.listBoxLectures.FormattingEnabled = true;
            this.listBoxLectures.ItemHeight = 15;
            this.listBoxLectures.Location = new System.Drawing.Point(179, 35);
            this.listBoxLectures.Name = "listBoxLectures";
            this.listBoxLectures.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxLectures.Size = new System.Drawing.Size(120, 94);
            this.listBoxLectures.TabIndex = 5;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 357);
            this.Controls.Add(this.listBoxLectures);
            this.Controls.Add(this.BtnSaveDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AddDepartment";
            this.Text = "Add Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDepartmentName;
        private Label label2;
        private Button BtnSaveDepartment;
        private ListBox listBoxLectures;
    }
}