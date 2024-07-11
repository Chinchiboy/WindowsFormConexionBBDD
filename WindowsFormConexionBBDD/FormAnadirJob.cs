using System;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    public partial class FormAnadirJob : Form
    {
        private DALJob daljob;

        public FormAnadirJob()
        {
            InitializeComponent();
            daljob = new DALJob();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar los datos de los campos de entrada
                Job job = new Job
                {
                    Job_title = textBoxTrabajo.Text,
                    Min_salary = double.Parse(textBoxSalMin.Text),
                    Max_salary = double.Parse(textBoxSalMax.Text)
                };

                // Insertar el trabajo en la base de datos
                daljob.Insert(job);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Trabajo añadido correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de que ocurra una excepción
                MessageBox.Show("Error al añadir trabajo: " + ex.Message);
            }
        }
    }
}

