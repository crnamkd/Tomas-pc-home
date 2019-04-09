using System.Collections.Generic;

namespace CollectionsAppHomework
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
        }
    }

    public enum Job
    {
        Archivist,
        Waiter,
        Choreographer,
        Developer,
        Dentist,
        Sculptor,
        Interpreter,
        Barber
    }

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };
            bool found = false;
            foreach (var developers in people.Contains.)
            {
                if (!found)
                {
                    var 

                    found = true;
                    break;
                }
            }

            //foreach (var E in Person)
            //{

            //}

            //foreach (var LNameR in Person)
            //{

            //}
            // 1. Find and print all persons working as 'Developers' and are younger than 30
            // 2. Find and print all persons names starting with 'E' where Name is longer than 4 characters
            // 3. Find and print all persons lastnames starting with 'R', ordered by Age - ASCENDING ORDER
        }
    }
}