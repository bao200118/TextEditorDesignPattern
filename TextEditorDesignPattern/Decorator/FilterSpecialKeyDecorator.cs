using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;
using TextEditorDesignPattern.Stragegy;

namespace TextEditorDesignPattern.Decorator
{
    class FilterSpecialKeyDecorator : FilterDecorator
    {
        private string[] badwords = { "Badword1", "Badword2", "Badword3" };
        public FilterSpecialKeyDecorator(IEditor editor) : base(editor) { }
        public override void SetState(string text, string format, bool isBool = false, bool isItalic = false, string font = "Segoe UI")
        {
            FilterSpecialText filterAlgo;
            switch (format)
            {
                case "ascii": filterAlgo = new FilterSpecialTextASCII(); break;
                case "html": filterAlgo = new FilterSpecialTextHTML(); break;
                case "teX": filterAlgo = new FilterSpecialTextTeX(); break;
                default: filterAlgo = new FilterSpecialTextASCII(); break;
            }
            FilterDirector filterDirector = new FilterDirector();
            filterDirector.SetFilterAlgorithm(filterAlgo);
            Text filterText = new Text(text, isBool, isItalic, font, format);
            string filterTextStr = filterDirector.GetFilterText(filterText);
            base.SetState(filterTextStr, format, isBool, isItalic, font);
        }
    }
}
