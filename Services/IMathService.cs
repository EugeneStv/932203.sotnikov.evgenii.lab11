using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public interface IMathService

    {
        int FirstNumber { get; }
        int SecondNumber { get; }
        int Sum();
        int Sub();
        int Mul();
        int Div();

    }
}
