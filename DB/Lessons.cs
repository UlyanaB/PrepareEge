using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Lessons : Form
    {
        public Lessons()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int id_lesson = int.Parse(lblLessonsId.Text);
                int id_teacher = ((KeyValuePair<int, string>)cbxTeacher.SelectedItem).Key;
                int id_object = ((KeyValuePair<int, string>)cbxObject.SelectedItem).Key; ;

                string updSql = "update lesson set id_teacher = @id_teacher, id_object = @id_object " +
                                "   where id_lesson = @id_lesson";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(updSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_teacher", id_teacher);
                    delCmd.Parameters.AddWithValue("id_object", id_object);
                    delCmd.Parameters.AddWithValue("id_lesson", id_lesson);
                    delCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id_teacher = ((KeyValuePair<int, string>)cbxTeacher.SelectedItem).Key;
                int id_object = ((KeyValuePair<int, string>)cbxObject.SelectedItem).Key; ;

                string insSql = "insert into lesson(id_teacher, id_object) values(@id_teacher, @id_object)";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(insSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_teacher", id_teacher);
                    delCmd.Parameters.AddWithValue("id_object", id_object);
                    delCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id_lesson = int.Parse(lblLessonsId.Text);
                string delSql = "delete from lesson where id_lesson = @id_lesson";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(delSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_lesson", id_lesson);
                    delCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
