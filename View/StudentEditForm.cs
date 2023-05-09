using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variant_2.Model;

namespace variant_2.View
{
    public partial class StudentEditForm : Form
    {
        Student student;
        bool isEditing = false;
        public StudentEditForm()
        {
            InitializeComponent();
            student = new Student();
        }
        public StudentEditForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            isEditing = true;

            textBox1.Text = student.full_name;
            textBox2.Text = student.student_ID_number;
            dateTimePicker1.Value = student.birth_date;
        }

        private async void delete_selected_Click(object sender, EventArgs e)
        {
            try
            {
                student.full_name = textBox1.Text;
                student.student_ID_number = textBox2.Text;
                student.birth_date = dateTimePicker1.Value;

                if (!isEditing)
                {
                    Program.dbEntities.Students.Add(student);
                }

                await Program.dbEntities.SaveChangesAsync();

                Close();
            }
            catch (Exception ex)
            {
                if (!isEditing)
                {
                    Program.dbEntities.Students.Remove(student);
                }

                MessageBox.Show(ex.Message);
            }
        }
    }
}