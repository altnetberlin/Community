using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    public class TextElementSplitRules
    {
        public static readonly char[] Marks = new char[] {',', ':', ';', '?', '!'};
        public static readonly char[] Spaces = new char[] {' '};

        public bool IsNewElement(char character, TextElementReader textElementReader)
        {

            if (!textElementReader.HasElements)
                return true;

            if (Marks.Contains(character))
                return true;

            if (Spaces.Contains(character))
                return true;

            return false;
        }
    }
}
