using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Caliburn.Micro.Autofac;
using CaliburnTemplate.Models;
using CaliburnTemplate.ViewModels;

namespace CaliburnTemplate
{
    class CaliburnTemplateBootstrapper : AutofacBootstrapper<MainViewModel>
    {
        public CaliburnTemplateBootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<PaddingService>().As<IPaddingService>();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
