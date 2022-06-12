namespace StudentBubbleSort
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
            BubbleSort(student);
            foreach (var item in student)
            {
                Console.WriteLine("Name: " + item.Name + " Age: " + item.Age);
            }
        }

        static void BubbleSort((string Name, int Age) []arr)
        {
            int temp;
            for (int j = 0; j <= 5 - 2; j++)
            {
                for (int i = 0; i <= 5 - 2; i++)
                {
                    if (arr[i].Age > arr[i + 1].Age)
                    {
                        temp = arr[i + 1].Age;
                        arr[i + 1].Age = arr[i].Age;
                        arr[i].Age = temp;
                    }
                }
            }
        }
    }
}