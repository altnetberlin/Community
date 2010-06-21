using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace Rm.Spellchecker.Core
{
    public class AutofacCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TextElementReader>();
        }
    }
}
