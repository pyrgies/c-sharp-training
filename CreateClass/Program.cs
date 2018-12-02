using System;

namespace CreateClass
{
    internal class Program
    {
       

        public static void Main(string[] args)
        {
            
            Person Albert = new Person("Albi", Convert.ToDateTime("12.03.1984"), Person.Genders.Male);
            Employee Alberto = new Employee("Albert", Convert.ToDateTime("12.03.1984"), Person.Genders.Male, 300, "bum");
            Alberto.Room = new Room(11);
            Console.WriteLine(Alberto);

        }
    }
}