using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TextEditorDesignPattern.Stragegy;

namespace TextEditorDesignPattern.Builder
{
    public class HTMLConverter : ITextConverter
    {
        Text _currentText;
        public HTMLConverter(Text text)
        {
            _currentText = text;
        }

        public ITextConverter BoldText()
        {
            FilterDirector filterDirector = new FilterDirector(new FilterSpecialTextHTML());
            string filterText = filterDirector.GetFilterText(_currentText);
            string[] textSplit = _currentText.text.Split(filterText);
            _currentText.text = textSplit[0] + "<b>" + filterText + "</b>" + textSplit[1];
            return this;
        }

        public ITextConverter ChangeFont()
        {
            string[] textSplit = _currentText.text.Split("<p");
            _currentText.text = textSplit[0] + "<p style=\"font-family:" + _currentText.font.Name + "; \"" + textSplit[1];
            return this;
        }

        public ITextConverter ConvertString()
        {
            _currentText.text = "<p>" + _currentText.text + "</p>";
            _currentText.format = "html";
            return this;
        }

        public ITextConverter ItalicText()
        {
            FilterDirector filterDirector = new FilterDirector(new FilterSpecialTextHTML());
            string filterText = filterDirector.GetFilterText(_currentText);
            if(filterText == "")
            {

            }
            string[] textSplit = _currentText.text.Split(filterText);
            _currentText.text = textSplit[0] + "<i>" + filterText + "</i>" + textSplit[1];
            return this;
        }

        public string GetText()
        {
            return _currentText.text;
        }

        public Font GetFont()
        {
            return new Font(_currentText.font, FontStyle.Regular);
        }
    }
}
