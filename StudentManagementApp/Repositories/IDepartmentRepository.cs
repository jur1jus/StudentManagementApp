using StudentManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Repositories
{
    public interface IDepartmentRepository
    {
        DataTable GetDepartmentsWithEmptyRecord();

        DataTable GetDepartmentLectures(int departmentId);

        DataTable GetDepartmentsDataTable();

        List<Department> GetDepartmentsList();

        void AddDepartment(string departmentName, IEnumerable<int> selectedLectures);
        
        void SaveDepartment(int departmentId, string departmentName, IEnumerable<int> selectedLectures);
    }
}
