using StudentManagementApp.Models;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace StudentManagementApp.Repositories
{
    public class LectureRepository : ILectureRepository
    {
        private readonly string _connectionString;

        public LectureRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Lecture> GetLectures()
        {
            var result = new List<Lecture>();
            var query = "SELECT * FROM Lectures";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteConnection.Open();

                var reader = sqliteCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Lecture(reader.GetInt32("Id"), reader.GetString("Name")));
                }

                return result;
            }
        }

        public List<string> GetDepartmentLectures(int departmentId)
        {
            var result = new List<string>();

            var query = "SELECT Lectures.Name FROM DepartmentLectures " +
                "INNER JOIN Lectures ON DepartmentLectures.LectureId = Lectures.Id " +
                "WHERE DepartmentId = @departmentId";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteCommand.Parameters.AddWithValue("@departmentId", departmentId);
                sqliteConnection.Open();

                var reader = sqliteCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader.GetString("Name"));
                }

                return result;
            }
        }

        public void AddLecture(string name, IEnumerable<int> deparmentIds)
        {
            var addLectureCommand = "INSERT INTO Lectures (Name) VALUES (@Name)";
            var addDepartmentsCommand = "INSERT OR IGNORE INTO DepartmentLectures (DepartmentId, LectureId) VALUES (@DepartmentId, @LectureId)";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(addLectureCommand, sqliteConnection))
            {
                try
                {
                    sqliteConnection.Open();
                    sqliteCommand.Parameters.AddWithValue("@Name", name);

                    var lectureId = Convert.ToInt32(sqliteCommand.ExecuteScalar());

                    foreach (var departmentId in deparmentIds)
                    {
                        using (var insertSelectedLecturesCommand = new SQLiteCommand(addDepartmentsCommand, sqliteConnection))
                        {
                            insertSelectedLecturesCommand.Parameters.AddWithValue("@DepartmentId", departmentId);
                            insertSelectedLecturesCommand.Parameters.AddWithValue("@LectureId", lectureId);

                            insertSelectedLecturesCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
