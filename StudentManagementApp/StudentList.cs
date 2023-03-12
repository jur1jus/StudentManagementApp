using Microsoft.Extensions.DependencyInjection;
using StudentManagementApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class StudentList : Form
    {
        private readonly IStudentRepository _studentRepository;
        public StudentList(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            InitializeComponent();

            dataGridStudents.CellContentClick += DataGridStudents_CellContentClick;
        }

        private void DataGridStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = sender as DataGridView;

            if (dataGrid is null) return;

            if (dataGridStudents.Columns[e.ColumnIndex] is not DataGridViewButtonColumn || e.RowIndex < 0) return;

            if (dataGrid.Columns["btnStudentLectures"] == dataGrid.Columns[e.ColumnIndex])
            {
                var studentFullName = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value as string} {dataGrid.Rows[e.RowIndex].Cells[2].Value as string}";

                var studentLecturesDataTable = _studentRepository.GetStudentLectures(Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value));

                var studentLecturesListForm = new StudentLecturesList(studentFullName, studentLecturesDataTable);
                studentLecturesListForm.ShowDialog();
            }

            if (dataGrid.Columns["btnChangeStudentDepartment"] == dataGrid.Columns[e.ColumnIndex])
            {
                var studentId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
                var studentFullName = $"{dataGrid.Rows[e.RowIndex].Cells[1].Value as string} {dataGrid.Rows[e.RowIndex].Cells[2].Value as string}";
                var currentDepartment = dataGrid.Rows[e.RowIndex].Cells[5].Value as string;

                var changeDepartmentForm = new ChangeDepartment(studentId, studentFullName, currentDepartment);
                changeDepartmentForm.FormClosed += ChangeDepartmentForm_FormClosed;

                changeDepartmentForm.ShowDialog();
            }
        }

        private void ChangeDepartmentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadData();
        }

        private void LoadData()
        {
            dataGridStudents.DataSource = null;
            dataGridStudents.Columns.Clear();

            dataGridStudents.DataSource = _studentRepository.GetStudentList();
            dataGridStudents.Columns.Add(new DataGridViewButtonColumn() { Name = "btnStudentLectures", HeaderText = "", UseColumnTextForButtonValue = true, Text = "Student Lectures" });
            dataGridStudents.Columns.Add(new DataGridViewButtonColumn() { Name = "btnChangeStudentDepartment", HeaderText = "", UseColumnTextForButtonValue = true, Text = "Change department" });
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var departmentReposotory = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            var addStudentForm = new AddStudent(_studentRepository, departmentReposotory);
            addStudentForm.FormClosed += AddStudentForm_FormClosed;
            addStudentForm.ShowDialog();
        }

        private void AddStudentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadData();
        }
    }
}
