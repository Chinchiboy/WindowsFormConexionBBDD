using System;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    public partial class FormAnadirDepartment : Form
    {
        private DALDepartment daldepartment;

        public FormAnadirDepartment()
        {
            InitializeComponent();
            daldepartment = new DALDepartment();
        }

        private void buttonAnadirDept_Click(object sender, EventArgs e)
        {
            Department d = new Department
            {
                Department_name = textBoxNombreDepartamento.Text,
                Location_id = int.Parse(textBoxLocalizacionDepartamento.Text)
            };
            daldepartment.Insert(d);
        }
    }
}
