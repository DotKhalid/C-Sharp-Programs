using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using namespaces.people;

namespace namespaces
{
    class Program
    {     
        static void Main(string[] args)
        {

            Person person = new Person();

            person.name = "ali";
            person.age = 34;
            person.email = "ali@gmail.com";

            person.greeting();

            Console.ReadLine();

        }
    }
}
