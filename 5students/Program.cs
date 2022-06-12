using System.Linq;

namespace _5students
{
    internal class Program
    {
        public static List<Student>? ListOfStudents { get; private set; }=new List<Student>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Student student = new Student();
                Console.WriteLine("Write the name of the " + (i+1) + "# student");
                do
                {
                    student.Name = Console.ReadLine();
                } while (string.IsNullOrEmpty(student.Name));
                Console.WriteLine("Write the age of the " + (i+1) + "# student");
                student.Age = int.Parse(Console.ReadLine());
                ListOfStudents.Add(student);
            }
            foreach (var item in ListOfStudents.OrderBy(w => w.Age))
            {
                Console.WriteLine("Name: " + item.Name + " Age: " + item.Age);
            }
        }
    }

    public struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}