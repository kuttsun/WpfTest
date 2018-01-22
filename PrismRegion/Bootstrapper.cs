﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrismRegion.Views;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Unity;
using System.Windows;


namespace PrismRegion
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            // ここでViewModelを差し込む
            // ここでやらないと、RegionManager に Region が生成される前に ViewModel が生成されたりして厄介なため
            //ViewModelLocator.SetAutoWireViewModel(Shell, true); 

            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            // View を全てコンテナに登録しておく (RegionManager で使うため)
            Container.RegisterTypeForNavigation<ViewA>("ViewA");
            Container.RegisterTypeForNavigation<ViewB>("ViewB");

            //    // Viewを全てobject型としてコンテナに登録しておく（RegionManagerで使うため）
            //    this.Container.RegisterTypes(
            //        AllClasses.FromLoadedAssemblies().Where(t => t.Namespace.EndsWith(".Views")),
            //        getFromTypes: _ => new[] { typeof(object) },
            //        getName: WithName.TypeName);
        }
    }
}
