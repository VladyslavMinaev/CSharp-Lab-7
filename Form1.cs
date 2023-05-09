using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variant_2.Model;
using variant_2.View;

namespace variant_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ForeColor = Color.Black;

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.ForeColor = Color.Black;

            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.ForeColor = Color.Black;

        }
        #region update DG data
        private async Task LoadGroupsData()
        {
            var groups = await Program.dbEntities.Groups.ToListAsync();

            dataGridView1.DataSource = groups.Select(s => new
            {
                ID = s.id,
                Назва = s.name,
                Рік_вступу = s.year_of_entry,
                Кількість_студентів = s.student_count
            }).ToList();
        }

        private async Task LoadFreeStudentsData()
        {
            var students = (await Program.dbEntities.Students.ToListAsync())
                .Where(w => w.group_id == null).ToList();

            dataGridView3.DataSource = students.Select(s => new
            {
                ID = s.id,
                ПІБ = s.full_name,
                Дата_народження = s.birth_date
            }).ToList();
        }

        private void LoadGroupStudentsData(Group group)
        {
            if (group == null)
                return;
            var students = group.Students.ToList();

            dataGridView2.DataSource = students.Select(s => new
            {
                ID = s.id,
                ПІБ = s.full_name,
                Дата_народження = s.birth_date
            }).ToList();
        }
        #endregion

        private async void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                var group = new Group
                {
                    name = Interaction.InputBox("Введіть назву групи!"),
                    year_of_entry = int.Parse(Interaction.InputBox("Коли ця група почала навчання?"))
                };

                try
                {

                    Program.dbEntities.Groups.Add(group);
                    await Program.dbEntities.SaveChangesAsync();

                    await LoadGroupsData();
                }
                catch (Exception ex)
                {
                    Program.dbEntities.Groups.Remove(group);
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async Task<Student> GetFreeStudent()
        {
            var student = (await Program.dbEntities
                .Students.ToListAsync()).First(f => f.id == Convert
                .ToInt32(dataGridView3[0, dataGridView3.CurrentCell.RowIndex].Value));
            return student;
        }

        async Task<Student> GetStudentFromGroup()
        {
            var student = (await Program.dbEntities
                .Students.ToListAsync()).First(f => f.id == Convert
                .ToInt32(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value));
            return student;
        }

        async Task<Group> GetGroup()
        {
            var groups = await Program.dbEntities
                .Groups.ToListAsync();

            if (dataGridView1.RowCount == 0) return null;

            var group = groups.FirstOrDefault(f => f.id == Convert
                .ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value));

            return group;
        }

        private async void додатиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentEditForm studentEditForm = new StudentEditForm();
                Hide();
                studentEditForm.ShowDialog();
                Show();

                await LoadFreeStudentsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void редагуватиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentEditForm studentEditForm = new StudentEditForm(await GetFreeStudent());
                Hide();
                studentEditForm.ShowDialog();
                Show();

                await LoadFreeStudentsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void delete_selected_Click(object sender, EventArgs e)
        {
            try
            {
                var student = await GetFreeStudent();
                var group = await GetGroup();

                if (group == null || student == null)
                    return;

                student.group_id = group.id;
                await Program.dbEntities.SaveChangesAsync();

                await LoadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var group = await GetGroup();
                if (group != null)
                    LoadGroupStudentsData(group);
            }
            catch { }
        }

        private async void зарахуватиУВибрануToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var student = await GetFreeStudent();
                var group = await GetGroup();

                if (group == null || student == null)
                    return;

                student.group_id = group.id;
                await Program.dbEntities.SaveChangesAsync();

                await LoadFreeStudentsData();
                await LoadGroupsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void видалиІзУніверситетуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var student = await GetFreeStudent();
                if (student == null) return;

                Program.dbEntities.Students.Remove(student);
                await Program.dbEntities.SaveChangesAsync();
                await LoadFreeStudentsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                var group = await GetGroup();
                if (group == null) return;

                group.name = Interaction.InputBox("Введіть назву групи!");
                group.year_of_entry = int.Parse(Interaction.InputBox("Коли ця група почала навчання?"));

                try
                {
                    await Program.dbEntities.SaveChangesAsync();
                    await LoadGroupsData();
                }
                catch (Exception ex)
                {
                    Program.dbEntities.Groups.Remove(group);
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void відрахуватиВсіхСтудентівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var group = await GetGroup();
                if (group == null) return;

                foreach (var student in group.Students)
                {
                    student.group_id = null;
                }

                await LoadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void видалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var group = await GetGroup();
            try
            {
                if (group == null) return;

                Program.dbEntities.Groups.Remove(group);
                await Program.dbEntities.SaveChangesAsync();

                await LoadGroupsData();
            }
            catch (Exception ex)
            {
                Program.dbEntities.Groups.Add(group);

                MessageBox.Show(ex.Message);
            }
        }

        private async void відрахуватиІзГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var student = await GetStudentFromGroup();
                if (student == null) return;

                student.group_id = null;

                await Program.dbEntities.SaveChangesAsync();

                await LoadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void відрахуватиІзУніверситетуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var student = await GetStudentFromGroup();
                if (student == null) return;

                Program.dbEntities.Students.Remove(student);
                await Program.dbEntities.SaveChangesAsync();

                await LoadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void редагуватиІнфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StudentEditForm studentEditForm = new StudentEditForm(await GetStudentFromGroup());
                Hide();
                studentEditForm.ShowDialog();
                Show();

                LoadGroupStudentsData(await GetGroup());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async Task LoadAllData()
        {
            try
            {
                await LoadFreeStudentsData();

                var x = await GetGroup();
                LoadGroupStudentsData(x);

                await LoadGroupsData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await LoadAllData();
        }

        private async void перевестиУІншуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var student = await GetStudentFromGroup();

                var groupName = Interaction.InputBox("Введіть назву групи");

                var newGroup = await Program.dbEntities.Groups.FirstOrDefaultAsync(f => f.name.Contains(groupName));
                if (newGroup == null) return;


                student.group_id = newGroup.id;

                await Program.dbEntities.SaveChangesAsync();

                await LoadAllData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}