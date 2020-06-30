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
        private string additionalHandling = "";

        /// <summary>
        /// конструктор формы
        /// </summary>
        public Student()
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
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;

        }

        private void PrepareGrid()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = false;
                column.Visible = true;
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
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
            string sql = "select worker.id_worker, name, second_name, procent, " +
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
            try
            {
                PrepareGrid();
                string select = "SELECT cl.id_class, cl.class_number FROM class0 cl;";
                all_update_button(select);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                additionalHandling = "class0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        /// <summary>
        /// редактирование списка предметов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObject_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string select = "SELECT ob.id_object, ob.title FROM object0 ob;";
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

        /// <summary>
        /// редактирование списка учащихся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudents_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
                string select = "SELECT s.id_student,                                                                                   " +
                                "       (select c.class_number from class0 c where c.id_class = s.id_class) class_number,               " +
                                "       s.nams, s.secondnames, s.middlenames, s.logins, s.passwords                                     " +
                                "   FROM    student s";
                all_update_button(select);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;

                additionalHandling = "student";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        /// <summary>
        /// записать в БД то что отредактировали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// редактирование 'выбора учащегося'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentChoice_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareGrid();
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
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                additionalHandling = "choicestudent";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

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
                        using (NpgsqlCommand selCmd = new NpgsqlCommand(selectSql, Program.mainForm.con))
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
                        using (NpgsqlCommand updCmd = new NpgsqlCommand(updateSql, Program.mainForm.con))
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
            int id = (int)dgvr.Cells[0].Value;

            string student = dgvr.Cells[2].Value as string + " " + dgvr.Cells[4].Value + " " +
                                dgvr.Cells[3].Value + " " + dgvr.Cells[5].Value;
            KeyValuePair<int, string> stud = new KeyValuePair<int, string>((int)dgvr.Cells[1].Value, student);
            KeyValuePair<int, string> predmet = new KeyValuePair<int, string>((int)dgvr.Cells[6].Value, dgvr.Cells[7].Value as string);

            ChangeStudentChoice csc = new ChangeStudentChoice();
            csc.lblStudentChoiceId.Text = id.ToString();

            // по студентам
            string sqlStud = "select      s.id_student, c.class_number || ' ' || s.secondnames || ' ' || s.nams || ' ' || s.middlenames   " +
                                "    from    student s                                                                                       " +
                                "    left join    class0 c on s.id_class = c.id_class                                                        " +
                                "    order by c.class_number, s.secondnames, s.nams";
            Program.mainForm.da = new NpgsqlDataAdapter(sqlStud, Program.mainForm.con);
            Program.mainForm.ds.Reset();
            Program.mainForm.da.Fill(Program.mainForm.ds);
            Program.mainForm.dt = Program.mainForm.ds.Tables[0];
            IList<KeyValuePair<int, string>> dsStudList = new List<KeyValuePair<int, string>>();
            foreach (DataRow oneRow in Program.mainForm.dt.Rows)
            {
                dsStudList.Add(new KeyValuePair<int, string>((int)oneRow.ItemArray[0], oneRow.ItemArray[1] as string));
            }
            csc.cbxStudent.DataSource = dsStudList;

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
            csc.cbxObject.DataSource = dsObjList;

            // 
            csc.cbxStudent.SelectedItem = stud;
            csc.cbxObject.SelectedItem = predmet;

            DialogResult dr = csc.ShowDialog();
        }

        /// <summary>
        /// всякая доп обработка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow dgvr = dgv.Rows[e.RowIndex];
                string localAdditionalHandling = additionalHandling;
                additionalHandling = "";
                switch (localAdditionalHandling)
                {
                    case "student":
                        StudentDoubleClick(dgvr);
                        break;

                    case "choicestudent":
                        ChoiceStudentDoubleClick(dgvr);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
