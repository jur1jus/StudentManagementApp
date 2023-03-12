using StudentManagementApp.Models;
using StudentManagementApp.Repositories;

namespace StudentManagementApp
{
    public partial class AddStudent : Form
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public AddStudent(IStudentRepository studentRepository, IDepartmentRepository departmentRepository)
        {
            InitializeComponent();
            _studentRepository = studentRepository;
            _departmentRepository = departmentRepository;

            cmbxDepartment.ValueMember = "Id";
            cmbxDepartment.DisplayMember = "Name";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            cmbxDepartment.DataSource = _departmentRepository.GetDepartmentsWithEmptyRecord();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDepartment = Convert.ToInt32(cmbxDepartment.SelectedValue);
                var student = new Student(txtFirstname.Text, txtLastname.Text, txtGroup.Text, txtCourse.Text, selectedDepartment);
                _studentRepository.AddStudent(student);
                MessageBox.Show("Student created.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during student save. Exception: {ex.Message}");
            }

        }
    }
}
