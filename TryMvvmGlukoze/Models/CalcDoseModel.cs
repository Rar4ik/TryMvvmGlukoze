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
        public double GetDose(double mass, double speed) => speed * (mass / 1000) * coeff;
        public double GetVVDose(double dose, double enteralno) => dose - enteralno;
    }
}
