

using System;
using System.Runtime.InteropServices;

namespace Gtk.Source
{
    public class StyleSchemeChooserWidget : Gtk.Bin
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_chooser_widget_new();
        private static d_gtk_source_style_scheme_chooser_widget_new gtk_source_style_scheme_chooser_widget_new = FuncLoader.LoadFunction<d_gtk_source_style_scheme_chooser_widget_new>(Native.Library, "gtk_source_style_scheme_chooser_widget_new");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_style_scheme_chooser_set_style_scheme(IntPtr chooser, IntPtr scheme);
        private static d_gtk_source_style_scheme_chooser_set_style_scheme gtk_source_style_scheme_chooser_set_style_scheme = FuncLoader.LoadFunction<d_gtk_source_style_scheme_chooser_set_style_scheme>(Native.Library, "gtk_source_style_scheme_chooser_set_style_scheme");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_chooser_get_style_scheme(IntPtr chooser);
        private static d_gtk_source_style_scheme_chooser_get_style_scheme gtk_source_style_scheme_chooser_get_style_scheme = FuncLoader.LoadFunction<d_gtk_source_style_scheme_chooser_get_style_scheme>(Native.Library, "gtk_source_style_scheme_chooser_get_style_scheme");

        public StyleSchemeChooserWidget() : base(gtk_source_style_scheme_chooser_widget_new())
        {

        }

        public StyleScheme StyleScheme
        {
            get => new StyleScheme(gtk_source_style_scheme_chooser_get_style_scheme(Handle));
            set => gtk_source_style_scheme_chooser_set_style_scheme(Handle, value.Handle);
        }
    }
}