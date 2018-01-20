using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using PrismModule.Models;
using PrismModule.Views;
using Prism.Modularity;
using Prism.Regions;

namespace PrismModule
{
    public class HelloWorldModule : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            this.Container.RegisterType<MessageProvider>(new ContainerControlledLifetimeManager());
            this.Container.RegisterType<object, HelloWorldView>(nameof(HelloWorldView));

            this.RegionManager.RequestNavigate("MainRegion", nameof(HelloWorldView));
        }
    }
}
