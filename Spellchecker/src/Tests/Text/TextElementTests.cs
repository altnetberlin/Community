using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rm.Spellchecker.Core;
using SharpTestsEx;

namespace Rm.Tests.Text
{
    public class TextElementTests
    {
        [Test]
        public void Should_add_chars()
        {
            var element = new TextElement();
            element.Add('a');
            element.Add('b');

            element.String.Should().Be.EqualTo("ab");

        }
    }
}
