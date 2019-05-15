using System;
using System.Runtime.InteropServices;

namespace Gtk.Source
{
    public class StyleScheme : GLib.Object
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_get_id(IntPtr scheme);
        private static d_gtk_source_style_scheme_get_id gtk_source_style_scheme_get_id = FuncLoader.LoadFunction<d_gtk_source_style_scheme_get_id>(Native.Library, "gtk_source_style_scheme_get_id");

        public StyleScheme(IntPtr native) : base(native)
        {

        }

        public unsafe string Id => Native.PtrToString(gtk_source_style_scheme_get_id(Handle));
    }
}
