using System;

namespace Patterns.Structural
{
    /// <summary>
    /// Bridge
    /// Мост
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Bridge
    {
        public void Using()
        {
            var darkTheme = new DarkTheme();
            var about = new About(darkTheme);
            var careers = new Careers(darkTheme);
            Console.WriteLine(about.GetContent());
            Console.WriteLine(careers.GetContent());
        }
    }

    public abstract class WebPage
    {
        protected ITheme theme;
        public WebPage(ITheme theme)
        {
            this.theme = theme;
        }
        public abstract string GetContent();
    }

    public class About : WebPage
    {
        public About(ITheme theme) : base(theme){}

        public override string GetContent()
        {
            return $"Page About with '{theme.GetColor()}' color";
        }
    }

    public class Careers : WebPage
    {
        public Careers(ITheme theme) : base(theme) { }

        public override string GetContent()
        {
            return $"Page Careers with '{theme.GetColor()}' color";
        }
    }

    public interface ITheme
    {
        string GetColor();
    }

    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark black";
        }
    }

    public class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Off white";
        }
    }
}
