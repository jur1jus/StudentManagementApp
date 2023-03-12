using StudentManagementApp.Models;
using System.Data;
using System.Data.SQLite;

namespace StudentManagementApp.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly string _connectionString;
        public DepartmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetDepartmentsWithEmptyRecord()
        {
            var query = "select Id, Name from Departments";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteDataAdapter = new SQLiteDataAdapter(query, sqliteConnection))
            {
                sqliteConnection.Open();
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Name");

                dataTable.Rows.Add(-1, "");

                sqliteDataAdapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetDepartmentsDataTable()
        {
            var query = "select Id, Name from Departments";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteDataAdapter = new SQLiteDataAdapter(query, sqliteConnection))
            {
                sqliteConnection.Open();
                var dataTable = new DataTable();

                sqliteDataAdapter.Fill(dataTable);

                return dataTable;
            }
        }

        public List<Department> GetDepartmentsList()
        {
            var result = new List<Department>();
            var query = "select Id, Name from Departments";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteConnection.Open();
                var reader = sqliteCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add( new Department(reader.GetInt32("Id"), reader.GetString("Name")));
                }
            }

            return result;
        }

        public DataTable GetDepartmentLectures(int departmentId)
        {
            var query = "SELECT " +
                "Name " +
                "FROM Lectures inner join DepartmentLectures on Lectures.Id = DepartmentLectures.LectureId WHERE DepartmentLectures.DepartmentId = @departmentId";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqliteCommand.Parameters.AddWithValue("@departmentId", departmentId);
                using (var sqliteDataAdapter = new SQLiteDataAdapter(sqliteCommand))
                {
                    sqliteConnection.Open();
                    var dataTable = new DataTable();

                    sqliteDataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }

        }

        public void AddDepartment(string departmentName, IEnumerable<int> selectedLectures)
        {
            var saveDepartmentCommand = "INSERT INTO Departments (Name) VALUES (@departmetName); SELECT last_insert_rowid()";
            var saveDepartmentLecturesCommand = $"INSERT OR IGNORE INTO DepartmentLectures (DepartmentId, LectureId) VALUES (@departmentId, @lectureId)";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(saveDepartmentCommand, sqliteConnection))
            {
                try
                {
                    sqliteConnection.Open();
                    sqliteCommand.Parameters.AddWithValue("@departmetName", departmentName);

                    var departmentId = Convert.ToInt32(sqliteCommand.ExecuteScalar());

                    foreach (var selectedLecture in selectedLectures)
                    {
                        using (var insertSelectedLecturesCommand = new SQLiteCommand(saveDepartmentLecturesCommand, sqliteConnection))
                        {
                            insertSelectedLecturesCommand.Parameters.AddWithValue("@departmentId", departmentId);
                            insertSelectedLecturesCommand.Parameters.AddWithValue("@lectureId", selectedLecture);

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

        public void SaveDepartment(int departmentId, string departmentName, IEnumerable<int> selectedLectures)
        {
            var updateDepartmentCommand = "UPDATE Departments SET Name = @Name where Id = @Id";
            var updateDepartmentLecturesCommand = "INSERT OR IGNORE INTO DepartmentLectures (DepartmentId, LectureId) VALUES (@departmentId, @lectureId)";

            using (var sqliteConnection = new SQLiteConnection(_connectionString))
            using (var sqliteCommand = new SQLiteCommand(updateDepartmentCommand, sqliteConnection))
            {
                try
                {
                    sqliteConnection.Open();
                    sqliteCommand.Parameters.AddWithValue("@Name", departmentName);
                    sqliteCommand.Parameters.AddWithValue("@Id", departmentId);

                    sqliteCommand.ExecuteNonQuery();

                    foreach (var selectedLecture in selectedLectures)
                    {
                        using (var insertSelectedLecturesCommand = new SQLiteCommand(updateDepartmentLecturesCommand, sqliteConnection))
                        {
                            insertSelectedLecturesCommand.Parameters.AddWithValue("@departmentId", departmentId);
                            insertSelectedLecturesCommand.Parameters.AddWithValue("@lectureId", selectedLecture);

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
