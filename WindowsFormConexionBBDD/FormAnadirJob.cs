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
                Job job = new Job
                {
                    Job_title = textBoxTrabajo.Text,
                    Min_salary = decimal.Parse(textBoxSalMin.Text),
                    Max_salary = decimal.Parse(textBoxSalMax.Text)
                };

                daljob.Insert(job);

                MessageBox.Show("Trabajo añadido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir trabajo: " + ex.Message);
            }
        }
    }
}

