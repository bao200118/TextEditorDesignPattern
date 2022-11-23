using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Stragegy
{
    public class FilterSpecialTextASCII : FilterSpecialText
    {
        public string GetText(Text text)
        {
            return text.text;
        }
    }
}
