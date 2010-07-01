using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    public class TextElement
    {
        public string String
        {
            get
            {
                return String.Join("", _characters.ToArray());
            }
        }

        public List<char> _characters = new List<char>();

        public void Add(char character)
        {
            _characters.Add(character);
        }
    }
}
