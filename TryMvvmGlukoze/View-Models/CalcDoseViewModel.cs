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
        private double _mass;
        public double Mass
        {
            get { return _mass; }
            set { _mass = value; OnPropertyChanged("Dose"); }
        }
        private double _speed;
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; OnPropertyChanged("Dose"); }
        }
        private double _enteralno;
        public double Enteralno
        {
            get { return _enteralno; }
            set { _enteralno = value; OnPropertyChanged("VVDose"); }

        }
        public double Dose
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                return calcDoseModel.GetDose(Mass, Speed);
            }
        }
        public double VVDose
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                return calcDoseModel.GetVVDose(Dose, Enteralno);
            }
        }
            
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
