namespace OLSA.Breakdowns.Models
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRemoved { get; set; }
        public string Photo { get; set; }

        public string FullName => $"{FirstName} {LastName}";


    }
}
