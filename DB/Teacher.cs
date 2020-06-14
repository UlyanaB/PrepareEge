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
        }



        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            string select = "SELECT te.id_teacher, te.namt, te.middlenamet, te.secondnamet, te.logint, te.passwordt " +
                            "   FROM teacher te                                                                     " +
                            "   ORDER BY te.secondnamet;";
            all_update_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "SELECT ls.id_lesson,                                       " +
                            "       ob.id_object, ob.title,                             " +
                            "       t.id_teacher, t.secondnamet, t.namt, t.middlenamet  " +
                            "   FROM lesson ls                                          " +
                            "   LEFT JOIN object0 ob on ls.id_object = ob.id_object          " +
                            "   LEFT JOIN teacher t on ls.id_teacher = t.id_teacher          " +
                            "   ORDER BY t.secondnamet, t.namt, t.middlenamet           ";
            all_select_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            Program.mainForm.dt.TableName = "lesson";
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow dgvr = dgv.Rows[e.RowIndex];
            string tableName = (dgv.DataSource as DataTable).TableName;
            switch (tableName)
            {
                case "lesson":
                    LessonDoubleClick(dgvr);
                    break;

                default:
                    break;
            }
        }

        private void LessonDoubleClick(DataGridViewRow dgvr)
        {
            int id = (int)dgvr.Cells[0].Value;

            string teach =    dgvr.Cells[4].Value as string + " " + dgvr.Cells[5].Value + " " + dgvr.Cells[6].Value;
            KeyValuePair<int, string> predmet = new KeyValuePair<int, string>((int)dgvr.Cells[1].Value, dgvr.Cells[2].Value as string);
            KeyValuePair<int, string> teacher = new KeyValuePair<int, string>((int)dgvr.Cells[3].Value, teach);

            Lessons ls = new Lessons();
            ls.lblLessonsId.Text = id.ToString();

            // по преподавателям 
            string sqlStud = "select      t.id_teacher, t.secondnamet || ' ' || t.namt || ' ' || t.middlenamet " +
                                "    from    teacher t                                                         " +
                                "    order by t.secondnamet, t.namt, t.middlenamet  ";
            Program.mainForm.da = new NpgsqlDataAdapter(sqlStud, Program.mainForm.con);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            IList<KeyValuePair<int, string>> dsStudList = new List<KeyValuePair<int, string>>();
            foreach (DataRow oneRow in Program.mainForm.dt.Rows)
            {
                dsStudList.Add(new KeyValuePair<int, string>((int)oneRow.ItemArray[0], oneRow.ItemArray[1] as string));
            }
            ls.cbxTeacher.DataSource = dsStudList;

            // по предметам
            string sqlObj = "select id_object, title from object0 order by title";
            Program.mainForm.da = new NpgsqlDataAdapter(sqlObj, Program.mainForm.con);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            IList<KeyValuePair<int, string>> dsObjList = new List<KeyValuePair<int, string>>();
            foreach (DataRow oneRow in Program.mainForm.dt.Rows)
            {
                dsObjList.Add(new KeyValuePair<int, string>((int)oneRow.ItemArray[0], oneRow.ItemArray[1] as string));
            }
            ls.cbxObject.DataSource = dsObjList;

            // 
            ls.cbxTeacher.SelectedItem = teacher;
            ls.cbxObject.SelectedItem = predmet;

            DialogResult dr = ls.ShowDialog();
        }
    }
}
