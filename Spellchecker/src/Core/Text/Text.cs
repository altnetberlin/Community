using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    public class Text
    {
        private readonly string _text;

        public Text(string text)
        {
            _text = text;

            TextElements = new TextElementList(text);
        }

        public TextElementList TextElements {get; private set;}
    }
}
