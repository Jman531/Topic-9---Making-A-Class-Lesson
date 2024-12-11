namespace Topic_9___Making_A_Class_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Robert", "Ross"));
            students.Add(new Student("Jim", "Smith"));
            students.Add(new Student("Jack", "Gallagher"));
        }
    }
}
