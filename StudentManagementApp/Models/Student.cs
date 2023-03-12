using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Models
{
    public record Student (string Firstname, string Lastname, string Group, string Course, int DepartmentId);
}
