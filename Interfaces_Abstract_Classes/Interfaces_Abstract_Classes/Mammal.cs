using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Abstract_Classes
{
    interface Mammal
    {
        string name { get; set; }
        string type { get; set; }

        void sound();
       
    }
}
