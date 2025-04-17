using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip_Test.Models
{
    public class Randadd 
    {
       
        private int _randomValue;
        private Random _random = new Random();

        public int Execute(int value)
        {
           _randomValue = _random.Next(1,100);
      return value + _randomValue;
        }

        public int Undo(int value)
        {
           return value - _randomValue;
        }
    }
}
