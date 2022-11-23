using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TextEditorDesignPattern.Memento;

namespace TextEditorDesignPattern.Builder
{
    public class Text
    {
        public Text() { }

        public Text(string text, bool isBold, bool isItalic, string font, string format)
        {
            this.text = text;
            this.isBold = isBold;
            this.isItalic = isItalic;
            try
            {
                this.font = new Font(font, 9);
            }
            catch
            {
                this.font = new Font("Segoe UI", 9);
            }
            this.format = format;
        }

        public Text(Text textData)
        {
            this.text = textData.text;
            this.isBold = textData.isBold;
            this.isItalic = textData.isItalic;
            try
            {
                this.font = new Font(textData.font.Name, 9);
            }
            catch
            {
                this.font = new Font("Segoe UI", 9);
            }
            this.format = textData.format;
        }

        public string text { get; set; } = "";
        public bool isBold { get; set; } = false;
        public bool isItalic { get; set; } = false;
        public Font font { get; set; } = new Font("Segoe UI", 9);
        public string format { get; set; } = "ascii";
    }
}
