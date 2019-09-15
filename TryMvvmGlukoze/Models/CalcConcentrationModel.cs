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
        private int privateOverallV = 0;
        public int GetBiggerAmount(string dose, string lesserCon, string biggerCon, string overallV)
        {
            privateOverallV = Convert.ToInt32(overallV);
            biggerV = (Convert.ToDouble(dose) * coeff - Convert.ToInt32(lesserCon) * Convert.ToInt32(overallV)) / (Convert.ToInt32(biggerCon) - Convert.ToInt32(lesserCon));
            GetLesserAmount();
            return (int)biggerV;
        }
        public int GetLesserAmount()
        {
            lesserV = privateOverallV - biggerV;
            return (int)lesserV;
        }
    }
}
