using System.Data;

namespace StudentManagementApp
{
    public partial class StudentLecturesList : Form
    {
        public StudentLecturesList(string studentFullname, DataTable studentLectures)
        {
            InitializeComponent();

            lblStudentFullname.Text = studentFullname;
            dataGridViewStudentLectures.DataSource = studentLectures;
        }
    }
}
