using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace TryMvvmGlukoze.View_Models
{
    class CaclConcentrationViewModel : INotifyPropertyChanged
    {
        private string _dose;
        public string Dose
        {
            get { return _dose; }
            set
            {
                CalcDoseViewModel calcDoseViewModel = new CalcDoseViewModel();
                _dose = calcDoseViewModel.Dose; OnPropertyChanged("BiggerConAmount");
            }
        }
        private string _overalAmount;
        public string OveralAmount
        {
            get { return _overalAmount; }
            set { _overalAmount = value; OnPropertyChanged("BiggerConAmount"); }
        }
        private string _biggerCon;
        public string BiggerCon
        {
            get { return _biggerCon; }
            set { _biggerCon = value; OnPropertyChanged("BiggerConAmount"); }
        }
        private string _lesserCon;
        public string LesserCon
        {
            get { return _lesserCon; }
            set { _lesserCon = value; OnPropertyChanged("BiggerConAmount"); }
        }        
        public string BiggerConAmount
        {
            get { CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                return calcConcentrationModel.GetBiggerAmount(Dose, LesserCon, BiggerCon, OveralAmount).ToString();
            }
        }
        public string LesserConAmount
        {
            get { CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                return calcConcentrationModel.GetLesserAmount().ToString(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
