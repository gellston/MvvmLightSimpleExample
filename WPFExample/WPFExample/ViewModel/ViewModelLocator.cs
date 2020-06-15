using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using WPFExample.Service;

namespace WPFExample.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {

            SimpleIoc.Default.Register<AjinMotor>();
            SimpleIoc.Default.Register<MainWindowViewModel>();


        }


        public MainWindowViewModel MainWindowViewModel
        {
            get => SimpleIoc.Default.GetInstance<MainWindowViewModel>();
        }


    }
}
