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
    public partial class LessonClass : Form
    {
        public LessonClass()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int id_classlesson = int.Parse(lblId.Text);
                int id_lesson = ((KeyValuePair<int, string>)cbxLesson.SelectedItem).Key;
                int id_class = ((KeyValuePair<int, string>)cbxClass.SelectedItem).Key; ;

                string updSql = "update class_lesson set id_lesson = @id_lesson, id_class = @id_class " +
                                "   where id_classlesson = @id_classlesson";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(updSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_lesson", id_lesson);
                    delCmd.Parameters.AddWithValue("id_class", id_class);
                    delCmd.Parameters.AddWithValue("id_classlesson", id_classlesson);
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
                int id_lesson = ((KeyValuePair<int, string>)cbxLesson.SelectedItem).Key;
                int id_class = ((KeyValuePair<int, string>)cbxClass.SelectedItem).Key; ;

                string insSql = "insert into class_lesson(id_lesson, id_class) values(@id_lesson, @id_class)";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(insSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_lesson", id_lesson);
                    delCmd.Parameters.AddWithValue("id_class", id_class);
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
                int id_classlesson = int.Parse(lblId.Text);
                string delSql = "delete from class_lesson where id_classlesson = @id_classlesson";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(delSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_classlesson", id_classlesson);
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
