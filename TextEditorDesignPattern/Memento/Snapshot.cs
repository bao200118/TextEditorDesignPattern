using System;
using System.Collections.Generic;
using System.Text;
using TextEditorDesignPattern.Builder;

namespace TextEditorDesignPattern.Memento
{
    public class Snapshot
    {
        Text state;
        Editor editor;
        public Snapshot(Editor editor,Text state)
        {
            this.editor = editor;
            this.state = state;
        }
        public void Restore()
        {
            editor.SetState(state.text,state.format,state.isBold,state.isItalic,state.font.Name);
        }
    }
}
