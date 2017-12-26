using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace ScreenTransition.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Page1 = new Page1ViewModel();
            Page2 = new Page2ViewModel();
            CurrentPage = Page1;
        }

        private BindableBase _CurrentPage;
        public BindableBase CurrentPage
        {
            get { return _CurrentPage; }
            set
            {
                if (_CurrentPage != value)
                {
                    _CurrentPage = value;
                    RaisePropertyChanged(nameof(CurrentPage));
                    //SetProperty(ref _CurrentPage, value);
                }
            }
        }

        private Page1ViewModel _Page1;
        public Page1ViewModel Page1
        {
            get { return _Page1; }
            set
            {
                if (_Page1 != value)
                {
                    _Page1 = value;
                    RaisePropertyChanged(nameof(Page1));
                }
            }
        }

        private Page2ViewModel _Page2;
        public Page2ViewModel Page2
        {
            get { return _Page2; }
            set
            {
                if (_Page2 != value)
                {
                    _Page2 = value;
                    RaisePropertyChanged(nameof(Page2));
                }
            }
        }

        private ICommand _TogglePageCommand;
        public ICommand TogglePageCommand
        {
            get
            {
                if (_TogglePageCommand == null)
                {
                    _TogglePageCommand = new DelegateCommand(TogglePage);
                }

                return _TogglePageCommand;
            }
        }

        private void TogglePage()
        {
            if (CurrentPage == Page1) // AページだったらBページに切り替え
            {
                CurrentPage = Page2;
            }
            else if (CurrentPage == Page2) // BページだったらAページに切り替え
            {
                CurrentPage = Page1;
            }
        }
    }
}
