using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Abstract_Classes
{
    interface IDamage
    {
        int durability { get; set; }

        void takeDamage(int _damage);
    }
}
