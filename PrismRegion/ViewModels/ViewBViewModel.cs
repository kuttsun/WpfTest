using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismRegion.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand ButtonCommand { get; }

        public ViewBViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            ButtonCommand = new DelegateCommand(ButtonClicked);
        }

        private void ButtonClicked()
        {
            _regionManager.RequestNavigate("MainRegion", "ViewA");
        }
    }
}
