using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace TextEditorDesignPattern.Builder
{
    public static class ConverterDirector
    {
        public static ITextConverter convertText(
            ITextConverter builder, bool isBold = false, bool isItalic = false)
        {
            builder.ConvertString().ChangeFont();
            if (isBold) builder.BoldText();
            if (isItalic) builder.ItalicText();
            return builder;
        }
    }
}
