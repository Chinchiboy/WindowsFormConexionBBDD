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

namespace WindowsFormConexionBBDD
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void anadirEmployee_Click(object sender, EventArgs e)
        {
            FormAnadirEmployee f = new FormAnadirEmployee();
            f.ShowDialog();
        }

        private void anadirDepartment_Click(object sender, EventArgs e)
        {
            FormAnadirDepartment f = new FormAnadirDepartment();
            f.ShowDialog();
        }

        private void anadirJob_Click(object sender, EventArgs e)
        {
            FormAnadirJob f = new FormAnadirJob();
            f.ShowDialog();
        }
    }
}
