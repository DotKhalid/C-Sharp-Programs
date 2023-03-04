using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaces.people
{
    public class Person
    {
        public string name;
        public string email;
        public int age;

        public void greeting()
        {
            System.Console.WriteLine("Hello {0} verified your age {1} from {2} ", name, age, email);
        }

    }
}
