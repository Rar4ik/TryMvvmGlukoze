using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMvvmGlukoze.View_Models
{
    class Validation
    {
        public bool CheckLenght(string parametr)
        {
            if (parametr == null)
                return false;
            else return true;
        }
        public bool CheckChar(string parametr)
        {
            bool IsValid;
            double number;
            IsValid = double.TryParse(parametr, out number);
            if (IsValid == false)
                return false;
            else return true;
        }
    }
}
