using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditorDesignPattern.Memento
{
    class CareTaker
    {
        Editor editor;
        Stack<Snapshot> snapshots;
        public CareTaker(Editor editor)
        {
            this.editor = editor;
            snapshots = new Stack<Snapshot>();
        }

        public void MakeBackup()
        {
            snapshots.Push(editor.CreateSnapshot());
        }
        public void Restore()
        {
            if (snapshots.Count < 2) return;
            snapshots.Pop();
            snapshots.Peek().Restore();
        }

    }
}
