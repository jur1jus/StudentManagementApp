using StudentManagementApp.Models;
using System.Data;

namespace StudentManagementApp.Repositories
{
    public interface ILectureRepository
    {
        List<Lecture> GetLectures();

        List<string> GetDepartmentLectures(int departmentId);

        void AddLecture(string name, IEnumerable<int> deparmentIds);
    }
}
