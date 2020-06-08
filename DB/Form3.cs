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

        private NpgsqlConnection con;
        private NpgsqlDataAdapter da;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public BtnLesson()
        {
            InitializeComponent();
        }

        #region Закрытие и открытие формы
        /// <summary>
        /// конструктор формы
        /// </summary>


        /// <summary>
        /// открыть соединение при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=2000; Database=school;");
            con.Open();
        }

        /// <summary>
        /// закрыть соединение при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }
        #endregion Закрытие и открытие формы

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
            da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// для всех кнопок по которым происходит только отображение данных 
        /// и один параметр
        /// </summary>
        /// <param name="sql"></param>
        private void all_select_button(string sql, object param1)
        {
            viewOnly();
            da = new NpgsqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("param1", param1);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// для всех кнопок по которым происходит только отображение данных 
        /// и один параметр
        /// </summary>
        /// <param name="sql"></param>
        private void all_select_button(string sql, object param1, object param2)
        {
            viewOnly();
            da = new NpgsqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("param1", param1);
            da.SelectCommand.Parameters.AddWithValue("param2", param2);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// для всех кнопок по которым допускается изменение даннх
        /// </summary>
        /// <param name="select"></param>
        private void all_update_button(string select)
        {
            allowEdit();
            da = new NpgsqlDataAdapter(select, con);
            NpgsqlCommandBuilder npgsqlCommandBuilder = new NpgsqlCommandBuilder(da);
            da.InsertCommand = npgsqlCommandBuilder.GetInsertCommand();
            da.UpdateCommand = npgsqlCommandBuilder.GetUpdateCommand();
            da.DeleteCommand = npgsqlCommandBuilder.GetDeleteCommand();
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        #endregion Работа с отчетами и формами ввода

        private void BtnObject_Click(object sender, EventArgs e)
        {
            string select = "SELECT ob.id_object, ob.title FROM object0 ob;";
            all_update_button(select);
        }

        

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            string select = "SELECT te.id_teacher, te.namt, te.secondnamet, te.middlenamet, te.logint, te.passwordt FROM teacher te;";
            all_update_button(select);
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
            da.Update(ds);
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
