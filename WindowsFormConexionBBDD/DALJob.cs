using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    internal class DALJob
    {
        public void Insert(Job job)
        {
            SqlConnection connection = DBConnection.GetConnection();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return;
            }

            try
            {
                string sql = "INSERT INTO Jobs (job_title, min_salary, max_salary) " +
                             "VALUES (@job_title, @min_salary, @max_salary)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@job_id", job.Job_id);
                    command.Parameters.AddWithValue("@job_title", job.Job_title);
                    command.Parameters.AddWithValue("@min_salary", job.Min_salary);
                    command.Parameters.AddWithValue("@max_salary", job.Max_salary);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Trabajo añadido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir trabajo: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }
        }

        public List<Job> SelectAll()
        {
            SqlConnection connection = DBConnection.GetConnection();
            List<Job> jobs = new List<Job>();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return jobs;
            }

            try
            {
                string sql = "SELECT job_id, job_title, min_salary, max_salary FROM Jobs";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job
                            {
                                Job_id = reader.GetInt32(reader.GetOrdinal("job_id")),
                                Job_title = reader.GetString(reader.GetOrdinal("job_title")),
                                Min_salary = reader.GetDecimal(reader.GetOrdinal("min_salary")),
                                Max_salary = reader.GetDecimal(reader.GetOrdinal("max_salary"))
                            };

                            jobs.Add(job);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener trabajos: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }

            return jobs;
        }


    }
}