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
    }
}
