using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gtk.Source
{
    public class Language : GLib.Object
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_get_mime_types(IntPtr language);
        private static d_gtk_source_language_get_mime_types gtk_source_language_get_mime_types = FuncLoader.LoadFunction<d_gtk_source_language_get_mime_types>(Native.Library, "gtk_source_language_get_mime_types");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_get_globs(IntPtr language);
        private static d_gtk_source_language_get_globs gtk_source_language_get_globs = FuncLoader.LoadFunction<d_gtk_source_language_get_globs>(Native.Library, "gtk_source_language_get_globs");

        public Language(IntPtr native) : base(native)
        {

        }

        public List<string> MimeTypes => Native.PtrToList(gtk_source_language_get_mime_types(Handle));

        public List<string> Globs => Native.PtrToList(gtk_source_language_get_globs(Handle));
    }
}