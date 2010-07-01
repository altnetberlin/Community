using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    public class Text
    {
        private readonly TextElementReader _elementReader;
        private readonly string _text;

        public Text(TextElementReader elementReader)
        {
            _elementReader = elementReader;
            TextElements = new TextElementList();
        }

        public void Add(string text)
        {
            TextElements.Add(_elementReader.Run(text));
        }

        public TextElementList TextElements {get; private set;}
    }
}
