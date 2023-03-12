using StudentManagementApp.Repositories;

namespace StudentManagementApp
{
    public partial class DepartmentLecturesList : Form
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentLecturesList(IDepartmentRepository departmentRepository)
        {
            InitializeComponent();
            comboBoxDepartments.SelectedValueChanged += ComboBoxDepartments_SelectedValueChanged;
            _departmentRepository = departmentRepository;

            comboBoxDepartments.DisplayMember = "Name";
            comboBoxDepartments.ValueMember = "Id";

        }

        private void ComboBoxDepartments_SelectedValueChanged(object? sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;

            if (comboBox is null) return;

            var selectedValue = Convert.ToInt32((comboBox.SelectedValue as string));

            if (selectedValue < 0)
            {
                dataGridViewDepartmentLectures.DataSource = null;
                return;
            }

            LoadDepartmentLectures(selectedValue);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            comboBoxDepartments.Items.Clear();
            comboBoxDepartments.DataSource = _departmentRepository.GetDepartmentsWithEmptyRecord();
        }

        private void LoadDepartmentLectures(int departmentId)
        {
            dataGridViewDepartmentLectures.DataSource = _departmentRepository.GetDepartmentLectures(departmentId);
        }
    }
}
