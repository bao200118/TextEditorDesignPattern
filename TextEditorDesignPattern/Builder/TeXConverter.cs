using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using TextEditorDesignPattern.Stragegy;

namespace TextEditorDesignPattern.Builder
{
    public class TeXConverter: ITextConverter  
    {
        Text _currentText;
        public TeXConverter(Text text)
        {
            _currentText = text;
        }

        public ITextConverter BoldText()
        {
            FilterDirector filterDirector = new FilterDirector(new FilterSpecialTextTeX());
            string filterText = filterDirector.GetFilterText(_currentText);
            string[] textSplit = _currentText.text.Split(filterText);
            _currentText.text = textSplit[0] + "\\textbf{" + filterText + "}" + textSplit[1];
            return this;
        }

        public ITextConverter ChangeFont()
        {
            string fontGeneric = FontFamily.Families.Where(c => c.Name == _currentText.font.Name).FirstOrDefault().Name;
            string fontTag;
            switch (fontGeneric)
            {
                case "serif": 
                    fontTag = "\\rmdefault";
                    break;
                case "sans-serif":
                    fontTag = "\\sfdefault";
                    break;
                case "monospace":
                    fontTag = "\\ttdefault";
                    break;
                default:
                    fontTag = "\\rmdefault";
                    break;

            }
            string[] textSplit = _currentText.text.Split("\\documentclass{article}");
            _currentText.text = "\\documentclass{article}" + "\n\\renewcommand{\\familydefault}{" + fontTag + "}" + textSplit[1];
            return this;
        }

        public ITextConverter ConvertString()
        {
            _currentText.text = "\\documentclass{article}\n\\begin{document}\n" + _currentText.text + "\n\\end{document}";
            return this;
        }

        public ITextConverter ItalicText()
        {
            FilterDirector filterDirector = new FilterDirector(new FilterSpecialTextTeX());
            string filterText = filterDirector.GetFilterText(_currentText);
            string[] textSplit = _currentText.text.Split(filterText);
            _currentText.text = textSplit[0] + "\\emph{" + filterText + "}" + textSplit[1];
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
