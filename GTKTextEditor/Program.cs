using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtk;
using Gtk.Source;

namespace GTKTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            Window wnd = new Window("Editor")
            {
                WidthRequest = 600,
                HeightRequest = 400
            };

            Setup(wnd, "foo.cs");

            wnd.ShowAll();
            wnd.Destroyed += (sender, e) => { Application.Quit(); };
            Application.Run();
        }

        private static void Setup(Window wnd, string languageID)
        {
            VBox box = new VBox();

            ScrolledWindow scrolled = new ScrolledWindow();

            SourceView view = new SourceView();

            view.ShowLineNumber = true;
            view.HighlightSyntax = true;
            view.HighlightCurrentLine = true;
            view.AutoIndent = true;


            scrolled.Add(view);

            LanguageManager languageManager = new LanguageManager();
            var s = languageManager.GetSearchPath();
            s.Add(Environment.CurrentDirectory + "/language-specs");
            languageManager.SetSearchPath(s.ToArray());
            view.Language = languageManager.GetGuessLanguage(languageID, null);

            StyleSchemeManager styleSchemeManager = new StyleSchemeManager();
            var ss = styleSchemeManager.GetSearchPath();
            ss.Add(Environment.CurrentDirectory + "/styles");
            styleSchemeManager.SetSearchPath(ss.ToArray());
            view.StyleScheme = styleSchemeManager.GetScheme("oblivion");
            box.PackEnd(scrolled, true, true, 0);

            wnd.Add(box);
        }
    }
}
