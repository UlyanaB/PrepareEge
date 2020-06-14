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
    public partial class Student : Form
    {
        private NpgsqlConnection con;
        private NpgsqlDataAdapter da;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        #region Закрытие и открытие формы
        /// <summary>
        /// конструктор формы
        /// </summary>
        public Student()
        {
            InitializeComponent();
        }

        /// <summary>
        /// открыть соединение при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=postgres; Database=school;");
            con.Open();
        }

        /// <summary>
        /// закрыть соединение при выгрузке формы
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
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;

        }
        #endregion Работа с отчетами и формами ввода

        #region Методы для работы с отчетами
        /// <summary>
        /// количество заказов по сотрудникам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderQuantity_Click(object sender, EventArgs e)
        {
            string sql = "SELECT chs.id_choicestudent, s.nams, s.secondnames, s.middlenames, ob.title FROM choicestudent chs, student s, object0 ob WHERE s.id_student=chs.id_student and ob.id_object=chs.id_object;";
            all_select_button(sql);
        }

        /// <summary>
        /// доход по сотрудникам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkerProfit_Click(object sender, EventArgs e)
        {
            string sql = "select worker.id_worker, name \"имя\", second_name \"фамилия\", procent, " +
                        "       (sum(salary_a)*procent)+ salary as pay " +
                        "   from worker, older, activies " +
                        "   where   older.id_worker = worker.id_worker " +
                        "       and older.id_activity = activies.id_activity " +
                        "   group by worker.id_worker;";
            all_select_button(sql);
        }

        /// <summary>
        /// доход компании по сотрудникам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirmProfit_Click(object sender, EventArgs e)
        {
            string sql =    "select worker.id_worker, name, second_name, procent, " +
                            "       sum(salary_a) - (sum(salary_a)*procent) as pay_org " +
                            "   from worker, older, activies " +
                            "   where   older.id_worker = worker.id_worker " +
                            "       and older.id_activity = activies.id_activity " +
                            "   group by worker.id_worker " +
                            "   order by second_name, name;";
            all_select_button(sql);
        }

        /// <summary>
        /// Заказы сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderByWorker_Click(object sender, EventArgs e)
        {
            string sql = "select worker.second_name \"Фамилия\", worker.name \"Имя\", worker.procent \"%\", " +
                         "       activies.name_a \"наименование работы\", activies.salary_a \"стоимость работы\", " +
                         "       older.date  \"дата\"" +
                         "   from worker " +
                         "   left join older on worker.id_worker = older.id_worker " +
                         "   left join activies on older.id_activity = activies.id_activity " +
                         "   where worker.second_name = @param1 " +
                         "   order by second_name, name;";
            string param1 = tbParam1.Text;
            all_select_button(sql, param1);
        }

        /// <summary>
        /// Заказы сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkersOrder_Click(object sender, EventArgs e)
        {
            string sql = "SELECT s.id_student, c0.class_number, s.nams, s.secondnames, s.middlenames, s.logins, s.passwords FROM student s join class0 c0 on s.id_class = c0.id_class ORDER BY c0.class_number; ";
            all_select_button(sql);
        }

        /// <summary>
        /// количество заказов на дату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderByDate_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) \"заказов\"" +
                         "   from older " +
                         "   where older.date = @param1 ";
            DateTime dt = DateTime.Parse(tbParam1.Text);
            //int i = int.Parse(tbParam1.Text);
            all_select_button(sql, dt);
        }
        #endregion Методы для работы с отчетами

        #region Методы для работы с формами ввода данных
        /// <summary>
        /// редактирование списка классов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClass_Click(object sender, EventArgs e)
        {
            string select = "SELECT cl.id_class, cl.class_number FROM class0 cl;";
            all_update_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            dt.TableName = "class0";
        }

        /// <summary>
        /// редактирование списка предметов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObject_Click(object sender, EventArgs e)
        {
            string select = "SELECT ob.id_object, ob.title FROM object0 ob;";
            all_update_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            dt.TableName = "object0";
        }

        /// <summary>
        /// редактирование списка учащихся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudents_Click(object sender, EventArgs e)
        {
            string select = "SELECT s.id_student,                                                                                   " +
                            "       (select c.class_number from class0 c where c.id_class = s.id_class) class_number,               " +
                            "       s.nams, s.secondnames, s.middlenames, s.logins, s.passwords                                     " +
                            "   FROM    student s";
            all_update_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dt.TableName = "student";
        }

        /// <summary>
        /// записать в БД то что отредактировали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            da.Update(ds);
        }

        /// <summary>
        /// редактирование 'выбора учащегося'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentChoice_Click(object sender, EventArgs e)
        {
            string select = "SELECT chs.id_choicestudent,                                                               " +
                            "       s.id_student,                                                                       " +
                            "       (select c.class_number from class0 c where c.id_class = s.id_class) class_number,   " +
                            "       s.nams, s.secondnames, s.middlenames,                                               " +
                            "       chs.id_object, ob.title                                                             " +
                            "   FROM choicestudent chs                                                                  " +
                            "   JOIN student s on chs.id_student = s.id_student                                         " +
                            "   JOIN object0 ob on chs.id_object = ob.id_object                                         " + 
                            "   ORDER BY chs.id_choicestudent";
            all_select_button(select);
            dataGridView1.Columns[0].ReadOnly = true;
            dt.TableName = "choicestudent";
        }
        #endregion Методы для работы с формами ввода данных

        /// <summary>
        /// Перевод учащегося в другой класс
        /// </summary>
        /// <param name="dgvr"></param>
        private void StudentDoubleClick(DataGridViewRow dgvr)
        {
            int? id = dgvr.Cells[0].Value as int?;
            if (id != null)
            {
                string studFio = dgvr.Cells[2].Value as string + " " + dgvr.Cells[4].Value + " " + dgvr.Cells[3].Value;
                ChangeClass changeClass = new ChangeClass();
                changeClass.Visible = false;
                changeClass.lblId.Text = id.Value.ToString();
                changeClass.lblFio.Text = studFio;
                changeClass.txtClass.Text = dgvr.Cells[1].Value as string;
                DialogResult dr = changeClass.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string class0 = changeClass.txtClass.Text.Trim();
                    if (class0 != ((dgvr.Cells[1].Value as string) ?? ""))
                    {
                        int? id_class = null;

                        string selectSql = "select id_class from class0 where class_number = @class_number";
                        using (NpgsqlCommand selCmd = new NpgsqlCommand(selectSql, con))
                        {
                            selCmd.Parameters.AddWithValue("class_number", class0);
                            id_class = selCmd.ExecuteScalar() as int?;
                        }
                        if (!id_class.HasValue)
                        {
                            MessageBox.Show("нет такого класса", "error");
                            return;
                        }

                        string updateSql = "update student set id_class = @id_class where id_student = @id_student";
                        using (NpgsqlCommand updCmd = new NpgsqlCommand(updateSql, con))
                        {
                            updCmd.Parameters.AddWithValue("id_class", id_class);
                            updCmd.Parameters.AddWithValue("id_student", id);
                            updCmd.ExecuteNonQuery();
                        }
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    // ничего не делать
                }
                else
                {
                    MessageBox.Show("DialogResult = " + dr.ToString(), "Error");
                }
            }
        }

        private void ChoiceStudentDoubleClick(DataGridViewRow dgvr)
        {

        }

        /// <summary>
        /// всякая доп обработка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow dgvr = dgv.Rows[e.RowIndex];
            string tableName = (dgv.DataSource as DataTable).TableName;
            switch(tableName)
            {
                case "student":
                    StudentDoubleClick(dgvr);
                    break;

                case "choicestudent":
                    ChoiceStudentDoubleClick(dgvr);
                    break;

                default:
                    break;
            }
        }
    }
}
