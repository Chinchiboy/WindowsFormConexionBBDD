namespace WindowsFormConexionBBDD
{
    public class Job
    {
        public int Job_id { get; set; }
        public string Job_title { get; set; }
        public double Min_salary { get; set; }
        public double Max_salary { get; set; }

        public Job() { }

        public Job(int job_id, string job_title, double min_salary, double max_salary)
        {
            Job_id = job_id;
            Job_title = job_title;
            Min_salary = min_salary;
            Max_salary = max_salary;
        }
    }
}
