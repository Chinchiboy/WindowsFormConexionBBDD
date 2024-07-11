using System;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    public partial class FormAnadirEmployee : Form
    {
        private DALEmployee dalemployee;

        public FormAnadirEmployee()
        {
            InitializeComponent();
            dalemployee = new DALEmployee();
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                First_name = textBoxNombre.Text,
                Last_name = textBoxApellido.Text,
                Email = textBoxEmail.Text,
                Phone_number = textBoxTel.Text,
                Hire_date = dateTimeContratacion.Value,
                Job_id = int.Parse(textBoxTrabajo.Text),
                Salary = double.Parse(textBoxSalario.Text),
                Manager_id = int.Parse(textBoxManager.Text),
                Department_id = int.Parse(textBoxDepartamento.Text)
            };
            dalemployee.Insert(employee);
        }
    }
}
