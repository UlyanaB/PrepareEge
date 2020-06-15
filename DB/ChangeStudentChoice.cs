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
    public partial class ChangeStudentChoice : Form
    {
        public ChangeStudentChoice()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id_choicestudent = int.Parse(lblStudentChoiceId.Text);
                string delSql = "delete from choicestudent where id_choicestudent = @id_choicestudent";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(delSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_choicestudent", id_choicestudent);
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
                int id_student = ((KeyValuePair<int, string>)cbxStudent.SelectedItem).Key;
                int id_object = ((KeyValuePair<int, string>)cbxObject.SelectedItem).Key; ;

                string insSql = "insert into choicestudent(id_student, id_object) values(@id_student, @id_object)";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(insSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_student", id_student);
                    delCmd.Parameters.AddWithValue("id_object", id_object);
                    delCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int id_choicestudent = int.Parse(lblStudentChoiceId.Text);
                int id_student = ((KeyValuePair<int, string>)cbxStudent.SelectedItem).Key;
                int id_object = ((KeyValuePair<int, string>)cbxObject.SelectedItem).Key; ;

                string updSql = "update choicestudent set id_student = @id_student, id_object = @id_object " +
                                "   where id_choicestudent = @id_choicestudent";
                using (NpgsqlCommand delCmd = new NpgsqlCommand(updSql, Program.mainForm.con))
                {
                    delCmd.Parameters.AddWithValue("id_student", id_student);
                    delCmd.Parameters.AddWithValue("id_object", id_object);
                    delCmd.Parameters.AddWithValue("id_choicestudent", id_choicestudent);
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
