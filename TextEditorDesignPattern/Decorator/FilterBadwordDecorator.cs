using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Decorator
{
    class FilterBadwordDecorator: FilterDecorator
    {
        private string[] badwords = { "Badword1", "Badword2", "Badword3" };
        public FilterBadwordDecorator(IEditor editor): base(editor) { }
        public override void SetState(string text, string format, bool isBool = false, bool isItalic = false, string font = "Segoe UI")
        {
            foreach(string badword in badwords)
            {
                text = text.Replace(badword, "********");
            }
            base.SetState(text, format, isBool, isItalic, font);
        }

    }
}
