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
        private readonly TextElementSplitRules _splitRules;
        internal ArrayList _bufferCurrentWord;
        
        internal TextElementList _textElements;
        internal TextElement _currentElement;

        public TextElementReader(TextElementSplitRules splitRules)
        {
            _splitRules = splitRules;
            Initialize();
        }

        public bool HasElements
        {
            get { return _textElements.HasElements; }
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
            if (_splitRules.IsNewElement(character, this))
                AddToNewTextElement(character);

            _bufferCurrentWord.Add(character);
        }


        private void AddToNewTextElement(char character)
        {
            var newTextElement = new TextElement();
            newTextElement.Add(character);
            _textElements.Add(newTextElement);
        }
    }
}
