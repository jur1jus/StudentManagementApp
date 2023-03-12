using StudentManagementApp.Models;
using System.Data;
using System.Data.SQLite;

namespace StudentManagementApp.Repositories
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetStudentList()
        {
            var query = "SELECT " +
                "Students.Id, " +
                "Students.Firstname, " +
                "Students.Lastname, " +
                "Students.[Group], " +
                "Students.Course, " +
                "Departments.Name AS \"Department name\"" +
                "FROM Students LEFT JOIN Departments ON Students.DepartmentId = Departments.Id";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteDataAdapter = new SQLiteDataAdapter(query, sqliteConnection))
            {
                sqliteConnection.Open();
                var dataTable = new DataTable();

                sqliteDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetStudentLectures(int id)
        {
            var query = "SELECT Lectures.name FROM Students " +
                "INNER JOIN Departments ON Students.DepartmentId = Departments.Id " +
                "INNER JOIN DepartmentLectures ON Departments.Id = DepartmentLectures.DepartmentId " +
                "INNER JOIN Lectures ON DepartmentLectures.LectureId = Lectures.Id " +
                "WHERE Students.Id = @studentId";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteCommand.Parameters.AddWithValue("studentId", id);
                using (var sqliteDataAdapter = new SQLiteDataAdapter(sqliteCommand))
                {
                    sqliteConnection.Open();
                    var dataTable = new DataTable();

                    sqliteDataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public void AddStudent(Student student)
        {
            var query = "INSERT INTO Students ([Firstname], [Lastname], [Group], [Course], [DepartmentId]) VALUES (@Firstname, @Lastname, @Group, @Course, @DepartmentId)";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteCommand.Parameters.AddWithValue("@Firstname", student.Firstname);
                sqliteCommand.Parameters.AddWithValue("@Lastname", student.Lastname);
                sqliteCommand.Parameters.AddWithValue("@Group", student.Group);
                sqliteCommand.Parameters.AddWithValue("@Course", student.Course);
                sqliteCommand.Parameters.AddWithValue("@DepartmentId", student.DepartmentId == -1 ? null : student.DepartmentId);

                sqliteConnection.Open();
                sqliteCommand.ExecuteNonQuery();
            }
        }

        public void ChangeDeparment(int studentId, int selectedDepartment)
        {
            var query = "UPDATE Students SET DepartmentId = @DepartmentId WHERE Id = @StudentId";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteCommand.Parameters.AddWithValue("@StudentId", studentId);
                sqliteCommand.Parameters.AddWithValue("@DepartmentId", selectedDepartment == -1 ? null : selectedDepartment);

                sqliteConnection.Open();
                sqliteCommand.ExecuteNonQuery();
            }
        }
    }
}