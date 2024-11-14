namespace WebDemo1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Age { get; set; }

        public Student() { }

        public Student(int id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
