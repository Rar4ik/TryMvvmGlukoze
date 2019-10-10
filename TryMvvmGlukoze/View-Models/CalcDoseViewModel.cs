using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TryMvvmGlukoze.Models;

namespace TryMvvmGlukoze.View_Models
{
    public class CalcDoseViewModel : INotifyPropertyChanged, IDataErrorInfo        
    {
        Validation Validation = new Validation();
        #region 
        /// <summary>
        /// Ввод параметров для модели
        /// </summary>
        private string _mass;
        public string Mass
        {
            get { return _mass; }
            set { if (Validation.CheckLenght(value) == true && Validation.CheckChar(value) == true)
                    _mass = value;
                else
                    _mass = null; 
                OnPropertyChanged("Dose"); }
        }
        private string _speed;
        public string Speed
        {
            get { return _speed; }
            set { if (Validation.CheckLenght(value) == true && Validation.CheckChar(value) == true)
                    _speed = value;
                else
                    _speed = null; OnPropertyChanged("Dose"); OnPropertyChanged("VVDose"); }
        }
        private string _enteralno;
        public string Enteralno
        {
            get { return _enteralno; }
            set { if (Validation.CheckLenght(value) == true && Validation.CheckChar(value) == true)
                    _enteralno = value;
                else
                    _enteralno = null;  OnPropertyChanged("VVDose"); }

        }
        public string Dose  
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                if (Mass == null | Speed == null)
                    return null;
                else
                    return calcDoseModel.GetDose(Mass, Speed).ToString("F");
            }
        }
        private string _vvDose;
        public string VVDose
        {
            get { CalcDoseModel calcDoseModel = new CalcDoseModel();
                if (Dose == null | Enteralno == null)
                    return null;
                else
                    return calcDoseModel.GetVVDose(Dose, Enteralno).ToString();
            }
            set { _vvDose = value; }
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
                    case "Mass":
                        if (Validation.CheckLenght(Mass) == false)
                        { msg = "Значение не введено или введено некорректно"; }
                        break;
                    case "Speed":
                        if (Validation.CheckLenght(Speed) == false)
                        { msg = "Значение не введено или введено некорректно"; }
                        break;
                    case "Enteralno":
                        if(Validation.CheckLenght(Enteralno) == false)
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
