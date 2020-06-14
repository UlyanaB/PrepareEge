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
    public partial class MainForm : Form
    {
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
            con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=postgres; Database=school;");
            con.Open();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            con.Dispose();
        }
    }
}
