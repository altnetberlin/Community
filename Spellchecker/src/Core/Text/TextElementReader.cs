using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    public class TextElementReader
    {
        private readonly TextElementSplitRuleService _splitRuleService;
        internal ArrayList _bufferCurrentWord;
        
        internal TextElementList _textElements;
        internal TextElement _currentElement;

        public TextElementReader(TextElementSplitRuleService splitRuleService)
        {
            _splitRuleService = splitRuleService;
            Initialize();
        }

        private void Initialize()
        {
            _bufferCurrentWord = new ArrayList();
            _textElements = new TextElementList();            
        }
        
        public TextElementList Run(string text)
        {
            Initialize();

            foreach (char character in text)
                AddToTextElement(character);

            return _textElements;
        }

        private void AddToTextElement(char character)
        {
            if (IsNewTextElement(character))
                AddToNewTextElement(character);

            _bufferCurrentWord.Add(character);
        }

        private bool IsNewTextElement(char character)
        {
            if (!_textElements.HasElements)
                return true;

            if (_splitRuleService.IsNewElement(character, this))
                return true;

            return false;
        }

        private void AddToNewTextElement(char character)
        {
            var newTextElement = new TextElement();
            newTextElement.Add(character);
            _textElements.Add(newTextElement);
        }
    }
}
