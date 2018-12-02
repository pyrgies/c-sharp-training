using System;

namespace CreateClass
{
    public class Employee : Person
    {
        
        
        public Employee(string name, DateTime birthdate, Genders gender, int salary, string profession) : base(name,
            birthdate, gender)
        {
            Salary = salary;
            Profession = profession;
           

        }

        

        private double Salary { get; set; }
        private string Profession { get; set; }

        public Room Room;
        

        public override string ToString()
        {
            return base.ToString() + $", Salary: {Salary}, Profession: {Profession}, Room number: {Room.Number}";
        }
        
       
    }
}