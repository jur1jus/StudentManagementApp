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
    public partial class ChangeDepartment : Form
    {
        private readonly string _studentFullname;
        private readonly string _currentDepartment;
        private readonly int _studentId;

        public ChangeDepartment(int studentId, string studentFullname, string currentDepartment)
        {
            InitializeComponent();
            comboBoxDepartments.ValueMember = "Id";
            comboBoxDepartments.DisplayMember = "Name";

            _studentId = studentId;
            _studentFullname = studentFullname;
            _currentDepartment = currentDepartment;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var departmentRepository = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            comboBoxDepartments.DataSource = departmentRepository.GetDepartmentsWithEmptyRecord();

            lblStudentFullname.Text = _studentFullname;
            txtStudentId.Text = _studentId.ToString();
            comboBoxDepartments.SelectedText = _currentDepartment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedDepartment = Convert.ToInt32(comboBoxDepartments.SelectedValue);
            var studentId = Convert.ToInt32(txtStudentId.Text);

            var studentRepository = DIContainer.ServiceProvider.GetRequiredService<IStudentRepository>();
            try
            {
                studentRepository.ChangeDeparment(studentId, selectedDepartment);
                MessageBox.Show("Department changed!");
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show($"Error during deparment change. Exception: {ex.Message}");
            }
        }
    }
}
