using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword1 = new Weapon("Excalibur");
            Weapon sword2 = new Weapon("Katana");

            //adding experience point to weapon
            sword1.exp = 30;
            sword2.exp = 10;

            //adding durability to weapon
            sword1.durability = 10;
            sword2.durability = 75;

            Console.WriteLine($"{sword1.name} has {sword1.exp} Exp points and {sword1.durability} durability left.");
            Console.WriteLine($"{sword2.name} has {sword2.exp} Exp points and {sword2.durability} durability left.");

            //using takedamage method
            sword1.takeDamage(4);

            Console.WriteLine($"{sword1.name} has {sword1.exp} Exp points and {sword1.durability} durability left.");

            sword2.equip();
            sword1.drop();

            Console.ReadKey();
        }
    }
}

