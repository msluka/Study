using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
            //throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
            

        }

        public int Multiplay (int a, int b)
        {
            throw new NotImplementedException();
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / (double) b;
        }
    }
}
