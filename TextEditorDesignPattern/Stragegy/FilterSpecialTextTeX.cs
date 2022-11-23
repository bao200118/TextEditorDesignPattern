using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Stragegy
{
    public class FilterSpecialTextTeX: FilterSpecialText
    {
        public string GetText(Text text)
        {
            string newText = text.text;
            if (newText.Contains("\\emph{"))
            {
                string[] textSplitItalic = newText.Split("\\emph{");
                if (textSplitItalic[1].Contains("}}") || textSplitItalic[1].Contains("}\n"))
                {
                    string[] textSplitItalicSecond = textSplitItalic[1].Split('}');
                    return textSplitItalicSecond[0];
                }
                return textSplitItalic[1];
            }
            if (newText.Contains("\\textbf{"))
            {
                string[] textSplitBold = newText.Split("\\textbf{");
                if (textSplitBold[1].Contains("}\n"))
                {
                    string[] textSplitBoldSecond = textSplitBold[1].Split('}');
                    return textSplitBoldSecond[0];
                }
                return textSplitBold[1];
            }
            if (!newText.Contains("\\begin{document}\n")) return newText;
            string[] textSplit = newText.Split("\\begin{document}\n");
            string[] textSplitSecond = textSplit[1].Split("\n\\end{document}");
            return textSplitSecond[0];
            
        }
    }
}
