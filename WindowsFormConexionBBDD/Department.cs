namespace WindowsFormConexionBBDD
{
    public class Department
    {
        public int Department_id { get; set; }
        public string Department_name { get; set; }
        public int Location_id { get; set; }

        public Department() { }

        public Department(int department_id, string department_name, int location_id)
        {
            Department_id = department_id;
            Department_name = department_name;
            Location_id = location_id;
        }
    }
}
