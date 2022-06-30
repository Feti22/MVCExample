namespace PostExample.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Instructor> instructors { get; set; }

    }
}
