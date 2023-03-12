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
