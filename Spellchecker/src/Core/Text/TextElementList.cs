using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rm.Spellchecker.Core
{
    /// <summary>
    /// Beinhaltet nicht nur zwingend Worte, sonder auch Trennzeichner.
    /// 
    /// Beinhaltet
    /// nicht
    /// nur 
    /// zwingend
    /// Worte,
    /// sonder
    /// auch 
    /// </summary>
    public class TextElementList : List<TextElement>
    {
        public bool HasElements
        {
            get
            {
                return Count > 0;
            }
        }

        public void Add(TextElementList item)
        {
            AddRange(item);
        }
    }
}
