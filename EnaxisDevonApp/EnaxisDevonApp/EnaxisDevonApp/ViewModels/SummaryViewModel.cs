using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using EnaxisDevonApp.Infrastructure;

namespace EnaxisDevonApp.ViewModels
{
    public class SummaryViewModel : AppMapViewModelBase
    {


        public SummaryViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
