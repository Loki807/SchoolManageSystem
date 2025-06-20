using SchoolManageSystem.Controllers;
using SchoolManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManageSystem
{
    public partial class TeacherForm : Form
    {
        private TeacherController _controller = new TeacherController();
        private int selectedTeacherId = -1;
        public TeacherForm()
        {
            InitializeComponent();
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            dgvTeachers.DataSource = _controller.GetAllTeachers();
            dgvTeachers.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text
            };
            _controller.AddTeacher(teacher);
            LoadTeachers();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            selectedTeacherId = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId != -1)
            {
                Teacher teacher = new Teacher
                {
                    Id = selectedTeacherId,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text
                };
                _controller.UpdateTeacher(teacher);
                LoadTeachers();
                ClearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId != -1)
            {
                _controller.DeleteTeacher(selectedTeacherId);
                LoadTeachers();
                ClearInputs();
            }
        }

        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                var row = dgvTeachers.SelectedRows[0];
                var teacher = row.DataBoundItem as Teacher;
                if (teacher != null)
                {
                    selectedTeacherId = teacher.Id;
                    txtName.Text = teacher.Name;
                    txtPhone.Text = teacher.Phone;
                    txtAddress.Text = teacher.Address;
                }
            }
        }
    }
}
