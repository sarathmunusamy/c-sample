using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTargestProject
{
    publisc class MyTargetClass
    {
        public int AddNumbers(int pintFirstNumber, int pintSecondNumber)
        {
            return pintFirstNumber + pintSecondNumber;
        }
        public int SubractNumbers(int pintFirstNumber, int pintSecondNumber)
        {
            return pintFirstNumber - pintSecondNumber;
        }
        public int DivideNumbers(int pintFirstNumber, int pintSecondNumber)
        {
            return pintFirstNumber / pintSecondNumber;
        }
    }
}
