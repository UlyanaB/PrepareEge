using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace DB
{
    public partial class BtnLesson : Form
    {

        public BtnLesson()
        {
            InitializeComponent();
        }
        #region Работа с отчетами и формами ввода
        /// <summary>
        /// датаГрид в режим просмотра
        /// </summary>
        private void viewOnly()
        {
            btnSave.Enabled = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// датаГрид в режим редактирования
        /// </summary>
        private void allowEdit()
        {
            btnSave.Enabled = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }

        /// <summary>
        /// для всех кнопок по которым происходит только отображение данных
        /// </summary>
        /// <param name="sql"></param>
        private void all_select_button(string sql)
        {
            viewOnly();
            Program.mainForm.da = new NpgsqlDataAdapter(sql, Program.mainForm.con);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            dataGridView1.DataSource = Program.mainForm.dt;
        }

        /// <summary>
        /// для всех кнопок по которым происходит только отображение данных 
        /// и один параметр
        /// </summary>
        /// <param name="sql"></param>
        private void all_select_button(string sql, object param1)
        {
            viewOnly();
            Program.mainForm.da = new NpgsqlDataAdapter(sql, Program.mainForm.con);
            Program.mainForm.da.SelectCommand.Parameters.AddWithValue("param1", param1);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            dataGridView1.DataSource = Program.mainForm.dt;
        }

        /// <summary>
        /// для всех кнопок по которым происходит только отображение данных 
        /// и один параметр
        /// </summary>
        /// <param name="sql"></param>
        private void all_select_button(string sql, object param1, object param2)
        {
            viewOnly();
            Program.mainForm.da = new NpgsqlDataAdapter(sql, Program.mainForm.con);
            Program.mainForm.da.SelectCommand.Parameters.AddWithValue("param1", param1);
            Program.mainForm.da.SelectCommand.Parameters.AddWithValue("param2", param2);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            dataGridView1.DataSource = Program.mainForm.dt;
        }

        /// <summary>
        /// для всех кнопок по которым допускается изменение даннх
        /// </summary>
        /// <param name="select"></param>
        private void all_update_button(string select)
        {
            allowEdit();
            Program.mainForm.da = new NpgsqlDataAdapter(select, Program.mainForm.con);
            NpgsqlCommandBuilder npgsqlCommandBuilder = new NpgsqlCommandBuilder(Program.mainForm.da);
            Program.mainForm.da.InsertCommand = npgsqlCommandBuilder.GetInsertCommand();
            Program.mainForm.da.UpdateCommand = npgsqlCommandBuilder.GetUpdateCommand();
            Program.mainForm.da.DeleteCommand = npgsqlCommandBuilder.GetDeleteCommand();
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            dataGridView1.DataSource = Program.mainForm.dt;
        }

        #endregion Работа с отчетами и формами ввода

        /// <summary>
        /// редактировать список предметов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObject_Click(object sender, EventArgs e)
        {
            string select = "SELECT ob.id_object, ob.title  " +
                            "   FROM object0 ob             " +
                            "   Order by ob.title;";
            all_update_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            Program.mainForm.dt.TableName = "object0";
        }



        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            string select = "SELECT te.id_teacher, te.namt, te.middlenamet, te.secondnamet, te.logint, te.passwordt " +
                            "   FROM teacher te                                                                     " +
                            "   ORDER BY te.secondnamet;";
            all_update_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            Program.mainForm.dt.TableName = "teacher";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "SELECT ls.id_lesson, ls.id_object, ls.id_teacher FROM lesson ls;";
            all_update_button(select);
        }

        private void BtnLessonVid_Click(object sender, EventArgs e)
        {
            string sql = "SELECT ls.id_lesson, ob.title, te.namt, te.secondnamet, te.middlenamet FROM lesson ls, object0 ob, teacher te WHERE ls.id_object = ob.id_object AND ls.id_teacher=te.id_teacher;";
            all_select_button(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.mainForm.da.Update(Program.mainForm.ds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select = "SELECT cl.id_classlesson, cl.id_lesson, cl.id_class FROM class_lesson cl;";
            all_update_button(select);
        }

        private void BtnClassLesson_Click(object sender, EventArgs e)
        {
            string sql = "SELECT cl.id_classlesson, te.namt, te.secondnamet, te.middlenamet, c0.class_number FROM class_lesson cl, class0 c0, lesson le, teacher te WHERE cl.id_lesson=le.id_lesson AND c0.id_class=cl.id_class AND te.id_teacher=le.id_teacher;";
            all_select_button(sql);
        }
    }
}
