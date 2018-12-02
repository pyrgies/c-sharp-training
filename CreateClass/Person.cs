using System;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Schema;

namespace CreateClass
{
    public class Person
    {
        private string Name { get; set; }
        private DateTime Birthdate { get; set; }
        private Genders Gender { get; set; }

        public enum Genders 
        {
            Male,    
            Female
        };

        public Person(string name, DateTime birthdate, Genders gender)
        {
            Name = name;
            Birthdate = birthdate;
            Gender = gender;
        }
        
        public override string ToString()
        {
            return "Your name is " + Name + " and you were born on " + Birthdate + " Gender: " + Gender;
            
        }
        
    }
}