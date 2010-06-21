using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rm.Spellchecker.Core;

namespace Rm.Tests.Text
{
    public class TextElementReaderTests : BaseTest
    {
        [Test]
        public void Read_words()
        {

            var textElementReader = Resolve<TextElementReader>();
            textElementReader.Run("Klein1, klein1 ");
            var exampleText = @;
        }

    }
}
