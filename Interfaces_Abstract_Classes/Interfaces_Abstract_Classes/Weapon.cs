using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Abstract_Classes
{
    public class Weapon : Item, IDamage
    {
        //public properties
        public string name { get; set; }
        public int exp { get; set; }
        public int durability { get; set; }

        //default constructor
        public Weapon(string _name)
        {
            this.name = _name;
        }
        //override abstract methods
        public override void addToInventory()
        {
            base.addToInventory();
        }
        public override void drop()
        {
            Console.WriteLine($"Dropped {this.name}...");
        }

        public override void equip()
        {
            Console.WriteLine($"{this.name} has been equipped...");
        }
        //implement damage interface
        public void takeDamage(int _damage)
        {
            durability -= _damage;
            Console.WriteLine($"{this.name} has taken {_damage} damage points...");
        }

    }
}
