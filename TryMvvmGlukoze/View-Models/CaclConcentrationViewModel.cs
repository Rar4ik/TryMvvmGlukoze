﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace TryMvvmGlukoze.View_Models
{
    class CaclConcentrationViewModel : INotifyPropertyChanged
    {
        private double _dose;
        public double Dose
        {
            get { return _dose; }
            set
            {
                CalcDoseViewModel calcDoseViewModel = new CalcDoseViewModel();
                _dose = calcDoseViewModel.Dose; OnPropertyChanged("BiggerConAmount");
            }
        }
        private int _overalAmount;
        public int OveralAmount
        {
            get { return _overalAmount; }
            set { _overalAmount = value; OnPropertyChanged("BiggerConAmount"); }
        }
        private int _biggerCon;
        public int BiggerCon
        {
            get { return _biggerCon; }
            set { _biggerCon = value; OnPropertyChanged("BiggerConAmount"); }
        }
        private int _lesserCon;
        public int LesserCon
        {
            get { return _lesserCon; }
            set { _lesserCon = value; OnPropertyChanged("BiggerConAmount"); }
        }        
        public int BiggerConAmount
        {
            get { CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                return calcConcentrationModel.GetBiggerAmount(Dose, LesserCon, BiggerCon, OveralAmount);
            }
        }
        public int LesserConAmount
        {
            get { CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                return calcConcentrationModel.GetLesserAmount(OveralAmount); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}