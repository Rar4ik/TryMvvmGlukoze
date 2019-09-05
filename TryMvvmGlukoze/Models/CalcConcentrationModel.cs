using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze
{
    class CalcConcentrationModel
    {
        private const int coeff = 100;
        private double biggerV = 0;
        private double lesserV = 0;
        public int GetBiggerAmount(double dose, int lesserCon, int biggerCon, int overallV)
        {
            biggerV = (dose * coeff - lesserCon * overallV) / (biggerCon - lesserCon);
            return (int)biggerV;
        }
        public int GetLesserAmount(int overallV)
        {
            lesserV = overallV - biggerV;
            return (int)lesserV;
        }
    }
}
