using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace MahApps.Metro.PrismApp.Core.Base
{
    public class ViewModelBase : BindableBase, INavigationAware, IActiveAware
    {
        protected IRegionNavigationService NavigationService { get; private set; }

        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ViewModelBase()
        {
            CancelCommand = new DelegateCommand(OnCancelCommandExecute);
        }

        public DelegateCommand CancelCommand { get; }

        private void OnCancelCommandExecute()
        {
            if (NavigationService.Journal.CanGoBack)
            {
                NavigationService.Journal.GoBack();
            }
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            NavigationService = navigationContext.NavigationService;
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        private bool _isActive;

        public virtual bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }

        public event EventHandler IsActiveChanged;
    }
}
