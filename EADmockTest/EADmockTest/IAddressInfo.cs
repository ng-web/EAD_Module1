using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADmockTest
{
    interface IAddressInfo
    {
        string street { get; set; }
        string city { get; set; }
        string parish { get; set; }
    }
}
