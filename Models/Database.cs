namespace PostExample.Models
{
    public class Database
    {
        public static ICollection<Instructor> Instructors { get; set; }
        public static int IdCounter { get; set; }

        static Database()
        {
            Instructors = new HashSet<Instructor>();
            Instructors.Add("Alex");
        }
    }
}
