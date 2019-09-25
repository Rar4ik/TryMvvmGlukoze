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
        private double _vvDose;
        CalcConcentrationModel CalcConcentrationModel = new CalcConcentrationModel();
        public double GetDose(string mass, string speed) => Convert.ToDouble(speed) * (Convert.ToDouble(mass) / 1000) * coeff;
        public double GetVVDose(string dose, string enteralno)
        {
            _vvDose = Convert.ToDouble(dose) - Convert.ToDouble(enteralno);
            CalcConcentrationModel.GetTHEFUCKINGDose(ref _vvDose);
            return _vvDose;
        }
    }
}
