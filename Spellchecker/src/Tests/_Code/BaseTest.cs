using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rm.Spellchecker.Core;

namespace Rm.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public void SetUp()
        {
            Container.Build();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

    }
}
