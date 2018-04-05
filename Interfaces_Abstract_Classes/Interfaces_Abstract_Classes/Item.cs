using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Abstract_Classes
{
    public abstract class Item
    {
        string name { get; set; }
        int exp { get; set; }

        public virtual void addToInventory()
        {
            Console.WriteLine($"{this.name} added to inventory.");
        }
        public abstract void equip();
        public abstract void drop();
    }
}
