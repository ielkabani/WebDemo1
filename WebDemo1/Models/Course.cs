namespace WebDemo1.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Course() { }
        public Course(int courseId, string name, string description)
        {
            this.courseId = courseId;
            this.name = name;
            this.description = description;
        }
    }
}
