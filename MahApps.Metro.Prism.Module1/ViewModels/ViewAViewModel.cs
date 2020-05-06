using MahApps.Metro.PrismApp.Core.Base;

namespace MahApps.Metro.PrismModule1.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel()
        {
            Title = "ViewA - M1";
            Message = "View A from Module 1";
        }
    }
}
