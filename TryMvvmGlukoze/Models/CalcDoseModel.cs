using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze
{
    class CalcDoseModel
    {
        private const double coeff = 1.44;
        public double GetDose(string mass, string speed) => Convert.ToDouble(speed) * (Convert.ToDouble(mass) / 1000) * coeff;
        public double GetVVDose(string dose, string enteralno) => Convert.ToDouble(dose) - Convert.ToDouble(enteralno);
    }
}
