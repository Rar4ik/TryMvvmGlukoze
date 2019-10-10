using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze.Models
{
    class CalcConcentrationModel
    {
        private const int coeff = 100;
        private double biggerV = 0;
        private double lesserV = 0;
        public int GetBiggerAmount(string lesserCon, string biggerCon, string overallV)
        {
            biggerV = (DoseObject.SendDose() * coeff - Convert.ToInt32(lesserCon) * Convert.ToInt32(overallV)) 
                / (Convert.ToInt32(biggerCon) - Convert.ToInt32(lesserCon));
                return (int)biggerV;                               
        }
        public int GetLesserAmount(string overallV, string biggerV)
        {
            lesserV = Convert.ToInt32(overallV) - Convert.ToInt32(biggerV);
            if (CheckNegative.IsNegative(lesserV) == true)
                return (int)lesserV;
            else
                SendMessage.SendMsg();
            return -1; 
        }
    }
}
