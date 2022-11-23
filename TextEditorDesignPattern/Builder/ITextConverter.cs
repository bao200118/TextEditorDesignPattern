using System;
using System.Collections.Generic;
using System.Drawing;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern
{
    public interface ITextConverter
    {
        public ITextConverter ConvertString();
        public ITextConverter ChangeFont();
        public ITextConverter BoldText();
        public ITextConverter ItalicText();
        public string GetText();
        public Font GetFont();
    }
}
