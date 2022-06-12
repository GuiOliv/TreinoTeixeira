namespace _5students2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new (string Name, int Age)[5];
            for (int i = 0; i < 5; i++)
            {
                string name;
                int age;
                Console.WriteLine("Write the name of the " + (i + 1) + "# student");
                name = Console.ReadLine();
                Console.WriteLine("Write the age of the " + (i + 1) + "# student");
                age = int.Parse(Console.ReadLine());
                student[i] = (name, age);
            }
            foreach (var item in student.OrderBy(w => w.Age))
            {
                Console.WriteLine("Name: " + item.Name + " Age: " + item.Age);
            }
        }
    }
}