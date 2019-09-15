using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TryMvvmGlukoze.View_Models
{
    public class CalcDoseViewModel : INotifyPropertyChanged        
    {
        private string _mass;
        public string Mass
        {
            get { return _mass; }
            set { _mass = value; OnPropertyChanged("Dose"); }
        }
        private string _speed;
        public string Speed
        {
            get { return _speed; }
            set { _speed = value; OnPropertyChanged("Dose"); }
        }
        private string _enteralno;
        public string Enteralno
        {
            get { return _enteralno; }
            set { _enteralno = value; OnPropertyChanged("VVDose"); }

        }
        public string Dose
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                return calcDoseModel.GetDose(Mass, Speed).ToString();
            }
        }
        public string VVDose
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                return calcDoseModel.GetVVDose(Dose, Enteralno).ToString();
            }
        }
            
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
