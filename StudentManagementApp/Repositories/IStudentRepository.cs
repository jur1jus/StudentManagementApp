using StudentManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Repositories
{
    public interface IStudentRepository
    {
        DataTable GetStudentList();
        DataTable GetStudentLectures(int id);

        void AddStudent(Student student);
        void ChangeDeparment(int studentId, int selectedDepartment);
    }
}
