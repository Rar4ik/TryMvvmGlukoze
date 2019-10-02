using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace TryMvvmGlukoze.View_Models
{
    //class CaclConcentrationViewModel : INotifyPropertyChanged
    //{
    //    private string _overalAmount;
    //    public string OveralAmount
    //    {
    //        get { return _overalAmount; }
    //        set { _overalAmount = value; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
    //    }
    //    private string _biggerCon;
    //    public string BiggerCon
    //    {
    //        get { return _biggerCon; }
    //        set { _biggerCon = value; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
    //    }
    //    private string _lesserCon;
    //    public string LesserCon
    //    {
    //        get { return _lesserCon; }
    //        set { _lesserCon = value; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount"); }
    //    }
    //    private string _biggerConAmount;
    //    public string BiggerConAmount
    //    {
    //        get
    //        {
    //            CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
    //            if (LesserCon == null | BiggerCon == null | OveralAmount == null)
    //                return null;
    //            else
    //            return calcConcentrationModel.GetBiggerAmount(LesserCon, BiggerCon, OveralAmount).ToString();
    //        }
    //        set { _biggerConAmount = value; }
    //    }
    //    public string LesserConAmount
    //    {
    //        get { CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
    //            return calcConcentrationModel.GetLesserAmount(OveralAmount, BiggerConAmount).ToString(); }
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}
}
