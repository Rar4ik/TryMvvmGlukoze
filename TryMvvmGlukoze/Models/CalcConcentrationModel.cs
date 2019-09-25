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
        private double _theFuckingDose;
        public int GetBiggerAmount(/*string dose, */string lesserCon, string biggerCon, string overallV)
        {
            biggerV = (_theFuckingDose * coeff - Convert.ToInt32(lesserCon) * Convert.ToInt32(overallV)) 
                / (Convert.ToInt32(biggerCon) - Convert.ToInt32(lesserCon));
            return (int)biggerV;
        }
        public int GetLesserAmount(string overallV, string biggerV)
        {
            lesserV = Convert.ToInt32(overallV) - Convert.ToInt32(biggerV);
            return (int)lesserV;
        }
        public void GetTHEFUCKINGDose(ref double theFdose)
        {
            _theFuckingDose = theFdose;
        }
    }
}
