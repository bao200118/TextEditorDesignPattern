using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Stragegy
{
    public interface FilterSpecialText
    {
        public string GetText(Text text);
    }
}
