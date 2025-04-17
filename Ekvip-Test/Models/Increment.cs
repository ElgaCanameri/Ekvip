using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip_Test.Models
{
    public class Increment
    {
        public int Execute(int value)
        {
            return value + 1;
        }

        public int Undo(int value)
        {
            return value - 1;
        }
    }
}
