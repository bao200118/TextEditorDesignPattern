using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditorDesignPattern.Builder;
using TextEditorDesignPattern.Decorator;
using TextEditorDesignPattern.Memento;

namespace TextEditorDesignPattern
{
    public partial class Form1 : Form
    {
        IEditor editor;
        CareTaker careTaker;
        public Form1()
        {
            InitializeComponent();
            editor = new Editor();
            careTaker = new CareTaker(editor as Editor);
            editor = new FilterBadwordDecorator(editor);
            editor = new FilterSpecialKeyDecorator(editor);
        }

        private void convertAsciiButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputText.Text))
            {
                textDisplay.Text = "Please input text";
                textDisplay.ForeColor = Color.Red;
                return;
            }
            editor.SetState(inputText.Text, "ascii", boldButton.Checked, italicButton.Checked, fontText.Text);
            Text text = editor.GetState();
            ITextConverter textConverter = new ASCIIConverter(text);
            textConverter = ConverterDirector.convertText(textConverter, boldButton.Checked, italicButton.Checked);
            textDisplay.Text = textConverter.GetText();
            textDisplay.Font = textConverter.GetFont();
            textDisplay.ForeColor = Color.Black;
            careTaker.MakeBackup();
        }

        private void convertTeXButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputText.Text))
            {
                textDisplay.Text = "Please input text";
                textDisplay.ForeColor = Color.Red;
                return;
            }
            editor.SetState(inputText.Text, "teX", boldButton.Checked, italicButton.Checked, fontText.Text);
            Text text = editor.GetState();
            ITextConverter textConverter = new TeXConverter(text);
            textConverter = ConverterDirector.convertText(textConverter, boldButton.Checked, italicButton.Checked);
            textDisplay.Text = textConverter.GetText();
            textDisplay.Font = textConverter.GetFont();
            textDisplay.ForeColor = Color.Black;
            careTaker.MakeBackup();
        }

        private void convertHTMLButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputText.Text))
            {
                textDisplay.Text = "Please input text";
                textDisplay.ForeColor = Color.Red;
                return;
            }
            editor.SetState(inputText.Text, "html", boldButton.Checked, italicButton.Checked, fontText.Text);
            Text text = editor.GetState();
            ITextConverter textConverter = new HTMLConverter(text);
            textConverter = ConverterDirector.convertText(textConverter, boldButton.Checked, italicButton.Checked);
            textDisplay.Text = textConverter.GetText();
            textDisplay.Font = textConverter.GetFont();
            textDisplay.ForeColor = Color.Black;
            careTaker.MakeBackup();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            careTaker.Restore();
            Text text = editor.GetState();
            ITextConverter textConverter;
            inputText.Text = text.text;
            fontText.Text = text.font.Name;
            boldButton.Checked = text.isBold;
            italicButton.Checked = text.isItalic;
            switch (text.format)
            {
                case "ascii": textConverter = new ASCIIConverter(text); break;
                case "html": textConverter = new HTMLConverter(text); break;
                case "teX": textConverter = new TeXConverter(text); break;
                default:
                    textConverter = new ASCIIConverter(text);
                    break;
            }
            textConverter = ConverterDirector.convertText(textConverter, boldButton.Checked, italicButton.Checked);
            textDisplay.Text = textConverter.GetText();
            textDisplay.Font = textConverter.GetFont();
            textDisplay.ForeColor = Color.Black;

        }
    }
}
