using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze.Models
{
    public static class DoseObject
    {
        public static double Dose { get; set; }
        public static void GetDose(double dose)
        {
            Dose = dose;
        }
        public static double SendDose()
        {
            return Dose;
        }
    }
}
