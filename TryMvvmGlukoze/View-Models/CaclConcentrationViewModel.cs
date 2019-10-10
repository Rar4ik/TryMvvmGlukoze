using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TryMvvmGlukoze.Models;


namespace TryMvvmGlukoze.View_Models
{
    class CaclConcentrationViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        Validation Validation = new Validation();

        #region
        /// <summary>
        /// Ввод параметров для модели
        /// </summary>
        private string _overalAmount;
        public string OveralAmount
        {
            get { return _overalAmount; }
            set {
                if (Validation.CheckLenght(value) == true && Validation.CheckChar(value) == true)
                    _overalAmount = value;
                else
                    _overalAmount = null; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
        }
        private string _biggerCon;
        public string BiggerCon
        {
            get { return _biggerCon; }
            set {
                if (Validation.CheckLenght(value) == true && Validation.CheckChar(value) == true)
                    _biggerCon = value;
                else
                    _biggerCon = null; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
        }
        private string _lesserCon;
        public string LesserCon
        {
            get { return _lesserCon; }
            set {
                if (Validation.CheckLenght(value) == true && Validation.CheckChar(value) == true)
                    _lesserCon = value;
                else
                    _lesserCon = null; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
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
                if (OveralAmount == null | BiggerConAmount == null)
                    return null;
                else 
                    return calcConcentrationModel.GetLesserAmount(OveralAmount, BiggerConAmount).ToString();
            }
        }
        #endregion

        #region
        /// <summary>
        /// Валидация данных
        /// </summary>
        public string Error => throw new NotImplementedException();
        public string this[string columnName]
        {
            get
            {
                string msg = null;

                switch (columnName)
                {
                    case "OveralAmount":
                        if (Validation.CheckLenght(OveralAmount) == false)
                        { msg = "Значение не введено или введено некорректно"; }
                        break;
                    case "BiggerCon":
                        if (Validation.CheckLenght(BiggerCon) == false)
                        { msg = "Значение не введено или введено некорректно"; }
                        break;
                    case "LesserCon":
                        if (Validation.CheckLenght(LesserCon) == false)
                        { msg = "Значение не введено или введено некорректно"; }
                        break;
                }
                return msg;
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
