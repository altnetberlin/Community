using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace Rm.Spellchecker.Core
{
    public class Container
    {
        private static IContainer _currentContainer;

        public static void Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacCoreModule());
            _currentContainer = builder.Build();            
        }

        public static T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }

    }
}
