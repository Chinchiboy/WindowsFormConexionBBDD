using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    internal class DALDepartment
    {
        public void Insert(Department d)
        {
            SqlConnection connection = DBConnection.GetConnection();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return;
            }

            try
            {
                string sql = "INSERT INTO Departments (department_name, location_id) " +
                             "VALUES (@department_name, @location_id)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@department_name", d.Department_name);
                    command.Parameters.AddWithValue("@location_id", d.Location_id);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Departamento añadido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir departamento: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }
        }

        public List<Department> SelectAll()
        {
            SqlConnection connection = DBConnection.GetConnection();
            List<Department> departments = new List<Department>();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return departments;
            }

            try
            {
                string sql = "SELECT * FROM Departments";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                Department_id = reader.GetInt32(reader.GetOrdinal("department_id")),
                                Department_name = reader.GetString(reader.GetOrdinal("department_name")),
                                Location_id = reader.GetInt32(reader.GetOrdinal("location_id"))
                            };
                            departments.Add(department);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener departamentos: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }

            return departments;
        }
    }
}