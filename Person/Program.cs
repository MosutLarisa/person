namespace Person
{
     class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            People[] person = new People[n];
            for (int i = 0; i < n; i++)
            {
                person[i] = new People();
                Console.WriteLine("FirstName:");
                person[i].FirstName = Console.ReadLine();
                Console.WriteLine("LastName:");
                person[i].LastName = Console.ReadLine();
                Console.WriteLine("YearOfBirth:");

            }
            PersonProcessor.GetOldestPerson(person);

        }
    }
    
}