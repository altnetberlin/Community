using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using Rm.Spellchecker.Core;
using SharpTestsEx;

namespace Rm.Tests.Text
{
    public class TextElementSplitRuleTests : BaseTest
    {

        public TextElementReader Arrange_empty_TextElementReader()
        {
            return Resolve<TextElementReader>();
        }

        public TextElementReader Arrange_TextElementReader_which_has_processed(string alreadyProccessed)
        {
            var textReader = Resolve<TextElementReader>();
            textReader.Run("abc");
            return textReader;
        }

        [Test]
        public void Is_new_element_if_no_previous_elements_exist()
        {
            Resolve<TextElementSplitRules>()
                .IsNewElement('a', Arrange_empty_TextElementReader())
                .Should().Be.True();
        }

        [Test]
        public void Is_new_element_if_space_after_word()
        {
            Resolve<TextElementSplitRules>()
                .IsNewElement(' ', Arrange_TextElementReader_which_has_processed("abc"))
                .Should().Be.True();
        }

        [Test]
        public void Is_new_element_if_hasPreviousElements_and_character_is_a_space()
        {
            var mockReader = new Mock<ITextElementReader>();
            mockReader.Setup(reader => reader.HasElements).Returns(true);

            Resolve<TextElementSplitRules>().IsNewElement(' ', mockReader.Object)
                .Should().Be.EqualTo(true);
        }

    }
}
