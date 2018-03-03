using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// State
    /// Состояние
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class State
    {
        public void Using()
        {
            var editor = new TextEditor(new Defaults());
            editor.Type("The first line");
            editor.SetState(new UpperCase());
            editor.Type("The second line");
            editor.Type("The third line");
            editor.SetState(new LowerCase());
            editor.Type("The fouth line");
            editor.Type("The fifth line");
        }
    }

    public interface IWritingState
    {
        void Write(string words);
    }

    public class UpperCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToUpper());
        }
    }

    public class LowerCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }

    public class Defaults : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }

    public class TextEditor
    {
        IWritingState state;

        public TextEditor(IWritingState state)
        {
            this.state = state;
        }

        public void SetState(IWritingState state)
        {
            this.state = state;
        }

        public void Type(string words)
        {
            state.Write(words);
        }
    }
}
