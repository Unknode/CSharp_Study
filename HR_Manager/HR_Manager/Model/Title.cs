namespace HR_Manager.Model
{
    public class Title
    {
        public string TitleName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Employee Employee { get; set; }

        public int EmployeeNumber { get; set; }
    }
}
