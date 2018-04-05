using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Abstract_Classes
{
    class Dog : Mammal
    {
        public string name { get; set; }
        public string type { get; set; }

        //constructor
        public Dog(string _name)
        {
            name = _name;
        }

        public void sound()
        {
            Console.WriteLine("woof woof");
        }
    }
}
