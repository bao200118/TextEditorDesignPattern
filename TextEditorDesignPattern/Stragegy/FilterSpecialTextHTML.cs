using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Stragegy
{
    public class FilterSpecialTextHTML: FilterSpecialText
    {
        private string[] specialWords = { "<p>", "</p>", "<b>","</b>","<i>","</i>" };
        public string GetText(Text text)
        {
            string newText = text.text;
            foreach (string specialWord in specialWords)
            {
                newText = newText.Replace(specialWord, "");
            }
            // Delete p tag have font style
            newText = newText.Replace("<p style=\"font-family:" + text.font.Name + "; \">", "");
            return newText;
        }
    }
}
