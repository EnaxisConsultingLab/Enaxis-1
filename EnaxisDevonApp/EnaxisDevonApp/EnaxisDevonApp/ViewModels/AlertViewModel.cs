using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using EnaxisDevonApp.Infrastructure;

namespace EnaxisDevonApp.ViewModels
{
    public class AlertViewModel : AppMapViewModelBase
    {


        public AlertViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
