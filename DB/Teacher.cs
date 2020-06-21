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
        string additionalHandling = "";

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
            try
            {
                PrepareGrid();
                string select = "SELECT ob.id_object, ob.title  " +
                                "   FROM object0 ob             " +
                                "   Order by ob.title;";
                all_update_button(select);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                additionalHandling = "object0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }



        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string select = "SELECT te.id_teacher, te.namt, te.middlenamet, te.secondnamet, te.logint, te.passwordt " +
                                "   FROM teacher te                                                                     " +
                                "   ORDER BY te.secondnamet;";
                all_update_button(select);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                additionalHandling = "teacher";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void PrepareGrid()
        {
            try
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.ReadOnly = false;
                }
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string select = "SELECT ls.id_lesson,                                       " +
                                "       ob.id_object, ob.title,                             " +
                                "       t.id_teacher, t.secondnamet, t.namt, t.middlenamet  " +
                                "   FROM lesson ls                                          " +
                                "   JOIN object0 ob on ls.id_object = ob.id_object          " +
                                "   JOIN teacher t on ls.id_teacher = t.id_teacher          " +
                                "   ORDER BY t.secondnamet, t.namt, t.middlenamet           ";
                all_select_button(select);

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                additionalHandling = "lesson";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void BtnLessonVid_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string sql = "SELECT ls.id_lesson, ob.title, te.namt, te.secondnamet, te.middlenamet " +
                                "   FROM lesson ls, object0 ob, teacher te " +
                                "   WHERE ls.id_object = ob.id_object AND ls.id_teacher=te.id_teacher;";
                all_select_button(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Program.mainForm.da.Update(Program.mainForm.ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string select = "select cl.id_classlesson,                                                                                      " +
                                "       c0.id_class, c0.class_number,                                                                           " +
                                "       ls.id_lesson, ob.title || ', ' || t.secondnamet || ' ' || t.namt || ' ' || t.middlenamet as teacher     " +
                                "   from      class_lesson cl                                                                                   " +
                                "   join class0 c0 on cl.id_class = c0.id_class                                                            " +
                                "   join lesson ls on cl.id_lesson = ls.id_lesson                                                          " +
                                "   join object0 ob on ls.id_object = ob.id_object                                                         " +
                                "   join teacher t on ls.id_teacher = t.id_teacher                                                         " +
                                "   order by c0.class_number, ob.title ";
                all_select_button(select);

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                additionalHandling = "class_lesson";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void BtnClassLesson_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string sql = "SELECT cl.id_classlesson, te.namt, te.secondnamet, te.middlenamet, c0.class_number " +
                                "   FROM class_lesson cl, class0 c0, lesson le, teacher te " +
                                "   WHERE cl.id_lesson=le.id_lesson AND c0.id_class=cl.id_class AND te.id_teacher=le.id_teacher;";
                all_select_button(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow dgvr = dgv.Rows[e.RowIndex];
                string tableName = (dgv.DataSource as DataTable).TableName;
                string localAdditionalHandling = additionalHandling;
                additionalHandling = "";
                switch (localAdditionalHandling)
                {
                    case "lesson":
                        LessonDoubleClick(dgvr);
                        break;

                    case "class_lesson":
                        ClassLessonDoubleClick(dgvr);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void ClassLessonDoubleClick(DataGridViewRow dgvr)
        {
            int id = (int)dgvr.Cells[0].Value;

            int classKey = dgvr.Cells[1].Value is DBNull ? -1 : (int)dgvr.Cells[1].Value;
            string classValue = dgvr.Cells[2].Value is DBNull ? "" : dgvr.Cells[2].Value as string;
            KeyValuePair<int, string> class0 = new KeyValuePair<int, string>(classKey, classValue);

            int teachKey = dgvr.Cells[3].Value is DBNull ? -1 : (int)dgvr.Cells[3].Value;
            string teachValue = dgvr.Cells[4].Value is DBNull ? "" : dgvr.Cells[4].Value as string;
            KeyValuePair<int, string> lesson = new KeyValuePair<int, string>(teachKey, teachValue);

            // по классам
            string sqlClass = "SELECT id_class, class_number FROM class0 order by class_number";
            Program.mainForm.da = new NpgsqlDataAdapter(sqlClass, Program.mainForm.con);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            IList<KeyValuePair<int, string>> dsClassList = new List<KeyValuePair<int, string>>();
            foreach (DataRow oneRow in Program.mainForm.dt.Rows)
            {
                dsClassList.Add(new KeyValuePair<int, string>((int)oneRow.ItemArray[0], oneRow.ItemArray[1] as string));
            }

            // по преподавателям
            string sqlTch = "SELECT ls.id_lesson,                                                                           " +
                            "       ob.title || ', ' || t.secondnamet || ' ' || t.namt || ' ' || t.middlenamet as teacher   " +
                            "   from lesson ls                                                                              " +
                            "   join object0 ob on ls.id_object = ob.id_object                                              " +
                            "   join teacher t on ls.id_teacher = t.id_teacher                                              " +
                            "   order by teacher    ";
            Program.mainForm.da = new NpgsqlDataAdapter(sqlTch, Program.mainForm.con);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            IList<KeyValuePair<int, string>> dsLessonList = new List<KeyValuePair<int, string>>();
            foreach (DataRow oneRow in Program.mainForm.dt.Rows)
            {
                dsLessonList.Add(new KeyValuePair<int, string>((int)oneRow.ItemArray[0], oneRow.ItemArray[1] as string));
            }

            LessonClass lessonClass = new LessonClass();
            lessonClass.lblId.Text = id.ToString();
            lessonClass.cbxClass.DataSource = dsClassList;
            lessonClass.cbxLesson.DataSource = dsLessonList;

            // 
            lessonClass.cbxClass.SelectedItem = class0;
            lessonClass.cbxLesson.SelectedItem = lesson;

            DialogResult dr = lessonClass.ShowDialog();
        }

        private void LessonDoubleClick(DataGridViewRow dgvr)
        {
            int id = (int)dgvr.Cells[0].Value;

            string teach = dgvr.Cells[4].Value as string + " " + dgvr.Cells[5].Value + " " + dgvr.Cells[6].Value;
            int predmetKey = dgvr.Cells[1].Value is DBNull ? -1 : (int)dgvr.Cells[1].Value;
            string predmetValue = dgvr.Cells[2].Value is DBNull ? "" : dgvr.Cells[2].Value as string;
            KeyValuePair<int, string> predmet = new KeyValuePair<int, string>(predmetKey, predmetValue);
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
