namespace Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                username="aslinamazova",
                name="Asli",
                surname="Namazova",
                password="asli123",
                age=20,
                birthday=2003,
                
        };
            Console.WriteLine(person.name);

        }
    }
}