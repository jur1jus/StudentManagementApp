using Microsoft.Extensions.DependencyInjection;
using StudentManagementApp.Repositories;

namespace StudentManagementApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            var studentRepository = DIContainer.ServiceProvider.GetRequiredService<IStudentRepository>();
            var formStundetList = new StudentList(studentRepository);
            formStundetList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deparmentRepository = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            var formDepartmentLectureList = new DepartmentLecturesList(deparmentRepository);
            formDepartmentLectureList.ShowDialog();
        }

        private void btnDepartmentList_Click(object sender, EventArgs e)
        {
            var deparmentRepository = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            var departmentList = new DepartmentList(deparmentRepository);
            departmentList.ShowDialog();
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
            var departmentRepository = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            var lectureRepository = DIContainer.ServiceProvider.GetRequiredService<ILectureRepository>();

            var addLectureForm = new AddLecture(lectureRepository, departmentRepository);
            addLectureForm.ShowDialog();
        }
    }
}
