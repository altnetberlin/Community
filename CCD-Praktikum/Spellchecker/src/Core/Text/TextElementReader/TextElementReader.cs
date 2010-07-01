using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    public class TextElementReader : ITextElementReader
    {
        private readonly TextElementSplitRules _splitRules;
        
        private TextElementList _elements;
        private TextElement _currentElement;

        public TextElementReader(TextElementSplitRules splitRules)
        {
            _splitRules = splitRules;
            Initialize();
        }

        public bool HasElements
        {
            get { return _elements.HasElements; }
        }

        private void Initialize()
        {
            _elements = new TextElementList();            
        }
        
        public TextElementList Run(string text)
        {
            foreach (char character in text)
                AddToTextElement(character);

            return _elements;
        }

        private void AddToTextElement(char character)
        {
            if (_splitRules.IsNewElement(character, this))
                AddNewElement(character);
            
            _currentElement.Add(character);
        }

        private void AddNewElement(char character)
        {
            _currentElement = new TextElement();
            _elements.Add(_currentElement);
        }
    }
}
