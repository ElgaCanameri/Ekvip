using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip_Test.Models
{
    public class Double 
    {
        
        private int _initialValue;
         public int Execute(int value)
        {
           _initialValue = value;
           return value *= 2;
        }

        public int Undo(int value)
        {
            return _initialValue;
        }
    }
}
