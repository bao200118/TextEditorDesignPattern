using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TextEditorDesignPattern.Builder;
using TextEditorDesignPattern.Decorator;

namespace TextEditorDesignPattern.Memento
{
    public class Editor: IEditor
    {
        Text state = new Text();
        public void SetState(string text, string format, bool isBool = false, bool isItalic = false, string font = "Segoe UI")
        {
            state.text = text;
            state.format = format;
            state.isBold = isBool;
            state.isItalic = isItalic;
            Font fontText;
            try
            {
                if (font == "") throw new Exception("Font not found");
                fontText = new Font(font, 9);
            }
            catch
            {
                fontText = new Font("Segoe UI", 9);
            }
            state.font = fontText;
        }

        public Text GetState()
        {
            return new Text(this.state);
        }

        public Snapshot CreateSnapshot()
        {
            return new Snapshot(this, new Text(state));
        }
    }
}
