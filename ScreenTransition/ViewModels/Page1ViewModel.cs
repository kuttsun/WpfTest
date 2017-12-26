using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace ScreenTransition.ViewModels
{
    class Page1ViewModel : BindableBase
    {
        private string _AText;
        public string AText
        {
            get { return _AText; }
            set
            {
                if (_AText != value)
                {
                    _AText = value;
                    RaisePropertyChanged(nameof(AText));
                }
            }
        }
    }
}