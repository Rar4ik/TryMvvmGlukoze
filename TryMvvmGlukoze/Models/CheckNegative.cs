using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze.Models
{
    static class CheckNegative
    {
        public static bool IsNegative(double parametr)
        {
            if (parametr < 0)
                return false;
            else
                return true;
        }
    }
}
