using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //this creates a person model variable which calls all the overloads for personmodel
            var person = new PersonModel("Shah", "Haque");

            person.GenerateEmail();

            Console.WriteLine(person.Email);

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }


        //What are Constructors?
        //A constructor is a special method that is used to initialize objects.
        //The advantage of a constructor, is that it is called when an object of a class is created.
        //It can be used to set initial values for fields: Example Create a constructor:
   

        /// <summary>
        /// These three constructors' are different because they take in different amount properties
        /// the first one has no properties inside making it a parameterless constructor 
        /// The second one takes two parameters and sets it equal to their respective properties from the personModel
        /// the third one same as the second one but this time email has been added to the constructor meaning it has three overloads
        /// these constructors are allowed to be used as although they may have the same name their signatures is what sets them apart
        /// </summary>


        public PersonModel() 
        { 
        
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonModel (string firstName, string lastName, string email) 
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }


        public void GenerateEmail()
        {
            GenerateEmail("aol.com",false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain,false) ;
        }

        public void GenerateEmail(bool FirstInitialMethod)
        {
            GenerateEmail("aol.com", FirstInitialMethod);
        }


        public void GenerateEmail(string domain, bool FirstInitialMethod)
        {
            if (FirstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)} {LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName} {LastName}@{domain}";
            }
        }

    }
}