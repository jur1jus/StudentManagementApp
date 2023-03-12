using Microsoft.Extensions.DependencyInjection;
using StudentManagementApp.Models;
using StudentManagementApp.Repositories;
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
    public partial class EditDepartment : Form
    {
        private readonly int _departmentId;
        private readonly string _departmentName;

        public EditDepartment(int departmentId, string departmentName)
        {
            InitializeComponent();
            _departmentId = departmentId;
            _departmentName = departmentName;

            listBoxLectures.ValueMember = "Id";
            listBoxLectures.DisplayMember  = "Name";
            listBoxLectures.SelectedItem = null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtDepartmentName.Text = _departmentName;
            txtDepartmentId.Text = _departmentId.ToString();
            var lecturesRepository = DIContainer.ServiceProvider.GetRequiredService<ILectureRepository>();
            listBoxLectures.DataSource =  lecturesRepository.GetLectures();

            var selectedLectures = lecturesRepository.GetDepartmentLectures(_departmentId);

            selectedLectures.ForEach(x =>
            {
                var selectedIndex = listBoxLectures.FindStringExact(x);

                if (selectedIndex != ListBox.NoMatches) 
                { 
                    listBoxLectures.SelectedIndex = selectedIndex;
                }
            });
        }

        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {
            var departmentId = Convert.ToInt32(txtDepartmentId.Text);
            var deparmentName = txtDepartmentName.Text;
            var selectedLectures = listBoxLectures.SelectedItems.Cast<Lecture>().Select(x => x.Id);

            var departmentRepository = DIContainer.ServiceProvider.GetRequiredService<IDepartmentRepository>();

            try
            {
                departmentRepository.SaveDepartment(departmentId, deparmentName, selectedLectures);
                MessageBox.Show("Department updated!");
                Close();
            }catch (Exception ex)
            {
                MessageBox.Show($"Error during department update! Exception: {ex.Message}");
            }
            
        }
    }
}
