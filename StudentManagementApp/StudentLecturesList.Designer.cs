namespace StudentManagementApp
{
    partial class StudentLecturesList
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
            this.dataGridViewStudentLectures = new System.Windows.Forms.DataGridView();
            this.lblStudentFullname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentLectures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentLectures
            // 
            this.dataGridViewStudentLectures.AllowUserToAddRows = false;
            this.dataGridViewStudentLectures.AllowUserToDeleteRows = false;
            this.dataGridViewStudentLectures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentLectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentLectures.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewStudentLectures.Name = "dataGridViewStudentLectures";
            this.dataGridViewStudentLectures.ReadOnly = true;
            this.dataGridViewStudentLectures.RowTemplate.Height = 25;
            this.dataGridViewStudentLectures.Size = new System.Drawing.Size(214, 272);
            this.dataGridViewStudentLectures.TabIndex = 0;
            // 
            // lblStudentFullname
            // 
            this.lblStudentFullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStudentFullname.AutoSize = true;
            this.lblStudentFullname.Location = new System.Drawing.Point(12, 9);
            this.lblStudentFullname.Name = "lblStudentFullname";
            this.lblStudentFullname.Size = new System.Drawing.Size(0, 15);
            this.lblStudentFullname.TabIndex = 1;
            // 
            // StudentLecturesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 335);
            this.Controls.Add(this.lblStudentFullname);
            this.Controls.Add(this.dataGridViewStudentLectures);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "StudentLecturesList";
            this.Text = "StudentLecturesList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentLectures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewStudentLectures;
        private Label lblStudentFullname;
    }
}