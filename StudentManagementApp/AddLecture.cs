using StudentManagementApp.Models;
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
    public partial class AddLecture : Form
    {
        private readonly ILectureRepository _lectureRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public AddLecture(ILectureRepository lectureRepository, IDepartmentRepository departmentRepository)
        {
            InitializeComponent();

            listBoxDepartments.ValueMember = "Id";
            listBoxDepartments.DisplayMember = "Name";
            _lectureRepository = lectureRepository;
            _departmentRepository = departmentRepository;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            listBoxDepartments.DataSource = _departmentRepository.GetDepartmentsList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtLectureName.Text;
            var selectedDepartments = listBoxDepartments.SelectedItems.Cast<Department>().Select(x => x.Id);

            try
            {
                _lectureRepository.AddLecture(name, selectedDepartments);
                MessageBox.Show("Lecture added!");
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error during lecture save. Exception: {ex.Message}");
            }
        }
    }
}
