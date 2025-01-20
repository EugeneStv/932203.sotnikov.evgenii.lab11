using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class MathService : IMathService
    {
        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }

        public MathService()
        {
            Random random = new Random();
            (FirstNumber, SecondNumber) = (random.Next(11), random.Next(11));
        }

        public int Sum()
        {
            return FirstNumber + SecondNumber;
        }

        public int Mul()
        {
            return FirstNumber * SecondNumber;
        }

        public int Sub()
        {
            return FirstNumber - SecondNumber;
        }

        public int Div()
        {
            try
            {
                var divResult = FirstNumber / SecondNumber;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }
    }
}
