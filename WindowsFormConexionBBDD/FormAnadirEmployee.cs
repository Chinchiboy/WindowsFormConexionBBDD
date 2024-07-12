using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    public partial class FormAnadirEmployee : Form
    {
        private DALEmployee dalemployee;
        private DALJob daljob;
        private DALDepartment daldepartment;

        public FormAnadirEmployee()
        {
            InitializeComponent();
            dalemployee = new DALEmployee();
            daljob = new DALJob();
            daldepartment = new DALDepartment();

            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            List<Job> jobs = daljob.SelectAll();
            comboBoxTrabajo.DataSource = jobs;
            comboBoxTrabajo.DisplayMember = "Job_title";
            comboBoxTrabajo.ValueMember = "Job_id";

            List<Employee> managers = dalemployee.SelectManager();
            comboBoxManager.DataSource = managers;
            comboBoxManager.DisplayMember = "FullName";
            comboBoxManager.ValueMember = "Employee_id";

            List<Department> departments = daldepartment.SelectAll();
            comboBoxDepartamento.DataSource = departments;
            comboBoxDepartamento.DisplayMember = "Department_name";
            comboBoxDepartamento.ValueMember = "Department_id";
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
                Job_id = (int)comboBoxTrabajo.SelectedValue,
                Salary = decimal.Parse(textBoxSalario.Text),
                Manager_id = (int?)comboBoxManager.SelectedValue,
                Department_id = (int)comboBoxDepartamento.SelectedValue
            };

            dalemployee.Insert(employee);
        }
    }
}
