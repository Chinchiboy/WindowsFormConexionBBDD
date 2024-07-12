using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormConexionBBDD
{
    internal class DALEmployee
    {
        public void Insert(Employee e)
        {
            SqlConnection connection = DBConnection.GetConnection();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return;
            }

            try
            {
                string sql = "INSERT INTO Employees (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) " +
                             "VALUES (@first_name, @last_name, @email, @phone_number, @hire_date, @job_id, @salary, @manager_id, @department_id)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@first_name", e.First_name);
                    command.Parameters.AddWithValue("@last_name", e.Last_name);
                    command.Parameters.AddWithValue("@email", e.Email);
                    command.Parameters.AddWithValue("@phone_number", e.Phone_number);
                    command.Parameters.AddWithValue("@hire_date", e.Hire_date);
                    command.Parameters.AddWithValue("@job_id", e.Job_id);
                    command.Parameters.AddWithValue("@salary", e.Salary);
                    command.Parameters.AddWithValue("@manager_id", e.Manager_id);
                    command.Parameters.AddWithValue("@department_id", e.Department_id);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Empleado añadido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir empleado: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }
        }

        public List<Employee> SelectAll()
        {
            SqlConnection connection = DBConnection.GetConnection();
            List<Employee> employees = new List<Employee>();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return employees;
            }

            try
            {
                string sql = "SELECT * FROM Employees";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                Employee_id = reader.GetInt32(reader.GetOrdinal("employee_id")),
                                First_name = reader.GetString(reader.GetOrdinal("first_name")),
                                Last_name = reader.GetString(reader.GetOrdinal("last_name")),
                                Email = reader.GetString(reader.GetOrdinal("email")),
                                Phone_number = reader.GetString(reader.GetOrdinal("phone_number")),
                                Hire_date = reader.GetDateTime(reader.GetOrdinal("hire_date")),
                                Job_id = reader.GetInt32(reader.GetOrdinal("job_id")),
                                Salary = reader.GetDecimal(reader.GetOrdinal("salary")),
                                Manager_id = reader.GetInt32(reader.GetOrdinal("manager_id")),
                                Department_id = reader.GetInt32(reader.GetOrdinal("department_id"))
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener empleados: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }

            return employees;
        }

        public List<Employee> SelectManager()
        {
            SqlConnection connection = DBConnection.GetConnection();
            List<Employee> employees = new List<Employee>();

            if (connection == null)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos.");
                return employees;
            }

            try
            {
                string sql = "SELECT employee_id, first_name, last_name FROM Employees";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();

                            employee.Employee_id = reader.IsDBNull(reader.GetOrdinal("employee_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("employee_id"));
                            employee.First_name = reader.IsDBNull(reader.GetOrdinal("first_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("first_name"));
                            employee.Last_name = reader.IsDBNull(reader.GetOrdinal("last_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("last_name"));

                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener empleados: " + ex.Message);
            }
            finally
            {
                DBConnection.CloseConnection();
            }
            return employees;
        }

    }
}