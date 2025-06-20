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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SectionForm sectionForm = new SectionForm();
            sectionForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
