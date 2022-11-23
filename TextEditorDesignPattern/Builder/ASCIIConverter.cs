using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TextEditorDesignPattern.Stragegy;

namespace TextEditorDesignPattern.Builder
{
    public class ASCIIConverter: ITextConverter
    {
        Text _currentText;
        public ASCIIConverter(Text text)
        {
            _currentText = text;
        }
        public ITextConverter ConvertString()
        {
            return this;
        }
        public ITextConverter ChangeFont()
        {
            return this;
        }
        public ITextConverter BoldText()
        {
            return this;
        }
        public ITextConverter ItalicText()
        {
            return this;
        }

        public string GetText()
        {
            return _currentText.text;
        }

        public Font GetFont()
        {
            FontStyle fontStyle = FontStyle.Regular;
            if (_currentText.isBold) fontStyle = FontStyle.Bold;
            if (_currentText.isItalic) fontStyle = fontStyle | FontStyle.Italic;
            return new Font(_currentText.font,fontStyle);
        }
    }
}
