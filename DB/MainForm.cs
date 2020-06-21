using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class MainForm : Form
    {
        const string connectionString = @"Data Source=DESKTOP-N3D8F06\SQLEXPRESS; Initial Catalog = AdminDB; Integrated Security = True";

        private InputAdmin inputAdmin = null;
        private SqlConnection sqlConnection = null;

        internal int IdAdmin;
        internal NpgsqlConnection con = null;
        internal NpgsqlDataAdapter da;
        internal DataSet ds = new DataSet();
        internal DataTable dt = new DataTable();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student newForm = new Student();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnLesson newForm = new BtnLesson();
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool flg = true;
            bool continueFlg = false;
            int? rslt = null;
            string selectCmd = @"select 1 from adminDB a where a.logina = @lgn and a.passworda = @psw";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                if (sqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Невозможно подключииться к БД MS SQL");
                    return;
                }

                using (SqlCommand checkLogin = new SqlCommand(selectCmd, sqlConnection))
                {
                    checkLogin.Parameters.Add("lgn", SqlDbType.NVarChar, 20);
                    checkLogin.Parameters.Add("psw", SqlDbType.NVarChar, 20);

                    using (inputAdmin = new InputAdmin())
                    {
                        while (flg)
                        {
                            DialogResult dr = inputAdmin.ShowDialog();

                            if (dr == DialogResult.Cancel)
                            {
                                flg = false;
                            }
                            else if (dr == DialogResult.OK)
                            {
                                string lgn = inputAdmin.TxLogin.Text.Trim();
                                string psw = inputAdmin.TxPassword.Text.Trim();

                                checkLogin.Parameters["lgn"].Value = lgn;
                                checkLogin.Parameters["psw"].Value = psw;
                                rslt = checkLogin.ExecuteScalar() as int?;
                                if (rslt.HasValue && rslt.Value == 1)
                                {
                                    flg = false;
                                    continueFlg = true;
                                    IdAdmin = getIdAdmin(lgn);
                                    SetSystemInfo();
                                    // записать в протокол
                                }
                                else
                                {
                                    inputAdmin.LbMessage.Text = "Вы ошиблись в логине или пароле";
                                    // записать в протокол !!!
                                }

                            }
                            else
                            {
                                inputAdmin.LbMessage.Text = "Ошибка программы № 1";
                                return;
                            }
                        }
                    }
                }

                if (continueFlg)
                {
                    con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=postgres; Database=school;");
                    con.Open();
                }
                else
                {
                    Close();
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }

        private int getIdAdmin(string lgn)
        {
            string selectCmd = @"select id_admin from adminDB a where a.logina = @lgn";
            int idAdmin;

            using (SqlCommand getAdminId = new SqlCommand(selectCmd, sqlConnection))
            {
                getAdminId.Parameters.Add("lgn", SqlDbType.NVarChar, 20);
                getAdminId.Parameters["lgn"].Value = lgn;
                idAdmin = (int)getAdminId.ExecuteScalar();
            }
            return idAdmin;
        }

        private void SetSystemInfo()
        {
            string machineName = Environment.MachineName;
            string osName = Environment.OSVersion.ToString();

            string sqlIns = "insert record(id_admin, dataCom, nameCom) values(@id, @dt, @nm)";
            using (SqlCommand setSysInfo = new SqlCommand(sqlIns, sqlConnection))
            {
                setSysInfo.Parameters.Add("id", SqlDbType.Int);
                setSysInfo.Parameters.Add("dt", SqlDbType.DateTime);
                setSysInfo.Parameters.Add("nm", SqlDbType.NVarChar, 50);

                setSysInfo.Parameters["id"].Value = IdAdmin;
                setSysInfo.Parameters["dt"].Value = DateTime.Now;
                setSysInfo.Parameters["nm"].Value = machineName + ", " +osName;

                setSysInfo.ExecuteNonQuery();
            }
        }
    }
}
