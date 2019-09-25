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
        #region 
        /// <summary>
        /// Расчёт дозы
        /// </summary>
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
            set { _speed = value; OnPropertyChanged("Dose"); OnPropertyChanged("VVDose"); }
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
        private string _vvDose;
        public string VVDose
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                return calcDoseModel.GetVVDose(Dose, Enteralno).ToString();
            }
            set { _vvDose = value; }
        }
        #endregion

        #region
        /// <summary>
        /// Расчёт концентрации
        /// </summary>
        private string _overalAmount;
        public string OveralAmount
        {
            get { return _overalAmount; }
            set { _overalAmount = value; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
        }
        private string _biggerCon;
        public string BiggerCon
        {
            get { return _biggerCon; }
            set { _biggerCon = value; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
        }
        private string _lesserCon;
        public string LesserCon
        {
            get { return _lesserCon; }
            set { _lesserCon = value; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
        }
        private string _biggerConAmount;
        public string BiggerConAmount
        {
            get
            {
                CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                if (LesserCon == null | BiggerCon == null | OveralAmount == null)
                    return null;
                else
                    return calcConcentrationModel.GetBiggerAmount(LesserCon, BiggerCon, OveralAmount).ToString();
            }
            set { _biggerConAmount = value; }
        }
        public string LesserConAmount
        {
            get
            {
                CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                return calcConcentrationModel.GetLesserAmount(OveralAmount, BiggerConAmount).ToString();
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
