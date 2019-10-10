using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze.Models
{
    class CalcDoseModel
    {
        private const double coeff = 1.44;
        private double _vvDose;
        public double GetDose(string mass, string speed) => Convert.ToDouble(speed) * (Convert.ToDouble(mass) / 1000) * coeff;
        public double GetVVDose(string dose, string enteralno)
        {
            _vvDose = Convert.ToDouble(dose) - Convert.ToDouble(enteralno);
            if (CheckNegative.IsNegative(_vvDose) == true)
            { DoseObject.GetDose(_vvDose); return _vvDose; }
            else
                SendMessage.SendMsg();
            return -1;
        }
    }
}
