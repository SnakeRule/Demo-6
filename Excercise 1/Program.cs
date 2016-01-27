using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from Persons
            Persons myFriends = new Persons();

            // Create a few friends
            Person person1 = new Person { Firstname = "Jussi", Lastname = "Jurkka", SocialSecurityNumber = "010101-01E6" };
            Person person2 = new Person { Firstname = "Piitu", Lastname = "Piituli", SocialSecurityNumber = "020202-01A9" };
            Person person3 = new Person { Firstname = "Elmu", Lastname = "Kelmu", SocialSecurityNumber = "030303-04T1" };

            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection
            myFriends.PrintCollection();

            // get one person
            Console.WriteLine("Get one person from collection:");
            myFriends.GetPerson(0);
            Person person4 = myFriends.GetPerson(2);
            if(person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position!");
            }

            // find person with sotu
            Console.WriteLine("Find person with Social Security Number:");
            string socialSecurityNumber = "030303-04T1";
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position!");
            }
        }
    }
}
