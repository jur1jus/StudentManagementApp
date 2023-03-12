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
    public partial class AddDepartment : Form
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILectureRepository _lectureRepository;

        public AddDepartment(IDepartmentRepository departmentRepository, ILectureRepository lectureRepository)
        {
            InitializeComponent();

            listBoxLectures.DisplayMember = "Name";
            listBoxLectures.ValueMember = "Id";

            _departmentRepository = departmentRepository;
            _lectureRepository = lectureRepository;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            listBoxLectures.DataSource = _lectureRepository.GetLectures();
            listBoxLectures.SelectedItem = null;
        }

        private void BtnSaveDepartment_Click(object sender, EventArgs e)
        {
            var selectedLectures = listBoxLectures.SelectedItems.Cast<Lecture>().Select(x => x.Id);
            var departmentName = txtDepartmentName.Text;

            try
            {
                _departmentRepository.AddDepartment(departmentName, selectedLectures);
                MessageBox.Show("Department saved!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during department save. Exception: {ex.Message}");
            }
        }
    }
}
