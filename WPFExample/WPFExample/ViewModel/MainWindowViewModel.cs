using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFExample.Service;

namespace WPFExample.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        readonly AjinMotor motor = null;
      
        public MainWindowViewModel(AjinMotor _motor)
        {
            this.motor = _motor;
            
        }

        private string _Test = "";
        public string Test
        {
            get => _Test;
            set => Set<string>(nameof(Test), ref _Test, value);
        }

        public ICommand ChangeTextCommand
        {
            get => new RelayCommand(() =>
            {

                this.Test = "test";
            });
        }
    }
}
