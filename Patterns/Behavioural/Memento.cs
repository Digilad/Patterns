using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Memento
    /// Снимок
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class Memento
    {
        public void Using()
        {
            var editor = new Editor();
            editor.Type("This is the first sentence");
            editor.Type("This is the second one");
            var saved = editor.Save();
            editor.Type("This is the third sentence");
            Console.WriteLine(editor.GetContent());
            editor.Restore(saved);
            Console.WriteLine(editor.GetContent());
        }
    }

    public class EditorMemento
    {
        string content;

        public EditorMemento(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }

    public class Editor
    {
        string content;

        public void Type(string words)
        {
            content += " " + words;
        }

        public string GetContent()
        {
            return content;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }

        public void Restore(EditorMemento memento)
        {
            content = memento.GetContent();
        }
    }
}
