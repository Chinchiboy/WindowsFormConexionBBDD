using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormConexionBBDD
{
    internal class Employee
    {
        public int Employee_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public DateTime Hire_date { get; set; }
        public int Job_id { get; set; }
        public double Salary { get; set; }
        public int Manager_id { get; set; }
        public int Department_id { get; set; }

        public Employee() { }

        public Employee(int employee_id, string first_name, string last_name, string email, string phone_number, DateTime hire_date, int job_id, double salary, int manager_id, int department_id)
        {
            Employee_id = employee_id;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Phone_number = phone_number;
            Hire_date = hire_date;
            Job_id = job_id;
            Salary = salary;
            Manager_id = manager_id;
            Department_id = department_id;
        }
    }
}
