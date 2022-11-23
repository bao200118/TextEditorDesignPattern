using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Decorator
{
    public abstract class FilterDecorator: IEditor
    {
        protected IEditor editor;
        public FilterDecorator(IEditor editor)
        {
            this.editor = editor;
        }
        public virtual void SetState(string text,string format,bool isBool = false,bool isItalic = false, string font = "Segoe UI")
        {
            if(this.editor != null)
            {
                this.editor.SetState(text,format,isBool,isItalic,font);
            }
        }
        public Text GetState()
        {
            if (this.editor != null)
            {
                return this.editor.GetState();
            }
            else return null;
        }
    }
}
