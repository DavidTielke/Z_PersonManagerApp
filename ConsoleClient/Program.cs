namespace ConsoleClient
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            
        }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayAllAdults();
            DisplayAllChildren();
        }

        // Max. 20 LOC
        // Max 5 Parameter
        // Max 7 Cyclomatic Complexity

        static void DisplayAllAdults()
        {
            var adults = GetAllAdults().ToList();
            Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
            adults.ForEach(a => Console.WriteLine(a.Name));
        }

        static void DisplayAllChildren()
        {
            var children = GetAllChildren().ToList();
            Console.WriteLine($"### Kinder ({children.Count}) ###");
            children.ForEach(c => Console.WriteLine(c.Name));
        }

        static IQueryable<Person> GetAllAdults()
        {
            return Load().Where(p => p.Age >= 18);
        }

        static IQueryable<Person> GetAllChildren()
        {
            return Load().Where(p => p.Age < 18);
        }

        static IQueryable<Person> Load()
        {
            var dataLines = ReadLines("data.csv");
            var persons = dataLines
                .Select(Parse)
                .AsQueryable();
            return persons;
        }

        static Person Parse(string dataLine)
        {
            var parts = dataLine.Split(',');
            return new Person
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Age = int.Parse(parts[2])
            };
        }

        static IEnumerable<string> ReadLines(string path)
        {
            return File.ReadLines(path);
        }
    }
}
