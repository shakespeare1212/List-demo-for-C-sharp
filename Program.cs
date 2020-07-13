using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_HowTo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> myContacts = new List<Contact>();
            myContacts.Add(new Contact
            {
                Name = "Jimbo",
                PhoneNumber = "838-992-2737",
                Age = 26
            });
            myContacts[0].setGreeting("Hello.");

            myContacts.Add(new Contact
            {
                Name = "Stacy",
                PhoneNumber = "665-828-1488",
                Age = 43
                
            });
            myContacts[1].setGreeting("Hey!");


            myContacts.Add(new Contact
            {
                Name = "Jacko the Great",
                PhoneNumber = "824-333-3322",
                Age = 23

            });
            myContacts[2].setGreeting("'sup?");

            myContacts.Add(new Contact
            {
                Name = "Peter the above average",
                PhoneNumber = "824-333-3322",
                Age = 23

            });
            myContacts[3].setGreeting("Yo.");

            myContacts.Add(new Contact
            {
                Name = "Mimi",
                PhoneNumber = "883-225-3747",
                Age = 61

            });
            myContacts[4].setGreeting("Hey you.");




            foreach (Contact personUnit in myContacts)
            {
                Console.WriteLine("Name  : " + personUnit.Name);
                Console.WriteLine("Phone : " + personUnit.PhoneNumber);
                Console.WriteLine("Age   : " + personUnit.Age);
                Console.WriteLine(personUnit.greet());
                Console.WriteLine("=======================\n");

            }

            Console.WriteLine("Enter an Index to find:");

            string searchIndex = Console.ReadLine();

            int i = Int32.Parse(searchIndex);

            if (i < 0)
            {
                Console.WriteLine("The index must be zero or greater.");
                Console.WriteLine("(Note that the first item is index 0.");
                Console.ReadKey();
                return;
            }

            if (i > myContacts.Count)
            {
                Console.WriteLine("The index is too high.");
                Console.WriteLine("Run again and try a number less than.");
                Console.WriteLine(myContacts.Count);
                Console.ReadKey();
                return;
            }

            var aContact = myContacts[i];

            Console.WriteLine("I have retrieved a contact.\n\n\n");
            Console.WriteLine(aContact.Name + " says " + aContact.greet());
            Console.ReadKey();

        }

        class Contact
        {
            public string   Name { get; set; }
            public string   PhoneNumber { get; set; }
            public int      Age { get; set; }
            private string greeting;

            public string greet()
            {

                return greeting;
            }

            public void setGreeting (string theGreeting)
            {
                greeting = theGreeting;
            }
               
        }



    }








}
