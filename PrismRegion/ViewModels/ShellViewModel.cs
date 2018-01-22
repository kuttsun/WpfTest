﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Regions;

namespace PrismRegion.ViewModels
{
    public class ShellViewModel
    {
        public ShellViewModel(IRegionManager rm)
        {
            // 初期ページを表示
            rm.RegisterViewWithRegion("MainRegion", typeof(Views.ViewA));
        }
    }
}
