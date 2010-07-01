using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Rm.Tests.Spellchecker
{
    public class SpellcheckerTests
    {
        //var exampleText = @"Klein1, klein1 Groß1. Groß1! klein1 gro. ";

        [Test]
        public void Groß_und_KleinSchreibung()
        {
            var exampleText = @"Klein1, klein1 Groß1. Groß1! klein1 gro. ";
        }

        //public void Satzzeichen()
    }
}
