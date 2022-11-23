using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Decorator
{
    public interface IEditor
    {
        public void SetState(string text, string format, bool isBool = false, bool isItalic = false, string font = "Segoe UI");
        public Text GetState();
    }
}
