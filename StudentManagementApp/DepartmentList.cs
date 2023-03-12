using Microsoft.Extensions.DependencyInjection;
using StudentManagementApp.Repositories;

namespace StudentManagementApp
{
    public partial class DepartmentList : Form
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentList(IDepartmentRepository departmentRepository)
        {
            InitializeComponent();
            _departmentRepository = departmentRepository;
            dataGridDepartments.CellContentClick += DataGridDepartments_CellContentClick;
        }

        ~DepartmentList()
        {
            dataGridDepartments.CellContentClick -= DataGridDepartments_CellContentClick;
        }

        private void DataGridDepartments_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = sender as DataGridView;

            if (dataGrid is null) return;

            if (dataGridDepartments.Columns[e.ColumnIndex] is not DataGridViewButtonColumn || e.RowIndex < 0) return;

            if (dataGrid.Columns["btnEditDepartment"].Index == e.ColumnIndex)
            {
                var id = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
                var name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

                var editDepartmentForm = new EditDepartment(id, name);
                editDepartmentForm.FormClosed += EditDepartmentForm_FormClosed;
                editDepartmentForm.ShowDialog();
            }
        }

        private void EditDepartmentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridDepartments.DataSource = null;
            dataGridDepartments.Columns.Clear();
            dataGridDepartments.DataSource = _departmentRepository.GetDepartmentsDataTable();
            dataGridDepartments.Columns.Add(new DataGridViewButtonColumn() { Name = "btnEditDepartment", HeaderText = "", Text = "Edit", UseColumnTextForButtonValue = true });
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadData();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var departmentRepository = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            var lectureRepository = DIContainer.ServiceProvider.GetRequiredService<ILectureRepository>();
            var addDepartmentForm = new AddDepartment(departmentRepository, lectureRepository);
            addDepartmentForm.FormClosed += AddDepartmentForm_FormClosed;
            addDepartmentForm.ShowDialog();
        }

        private void AddDepartmentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadData();
        }
    }
}
