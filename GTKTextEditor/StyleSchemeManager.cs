using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gtk.Source
{
    public class StyleSchemeManager : GLib.Object
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_manager_new();
        private static d_gtk_source_style_scheme_manager_new gtk_source_style_scheme_manager_new = FuncLoader.LoadFunction<d_gtk_source_style_scheme_manager_new>(Native.Library, "gtk_source_style_scheme_manager_new");
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_manager_get_scheme_ids(IntPtr manager);
        private static d_gtk_source_style_scheme_manager_get_scheme_ids gtk_source_style_scheme_manager_get_scheme_ids = FuncLoader.LoadFunction<d_gtk_source_style_scheme_manager_get_scheme_ids>(Native.Library, "gtk_source_style_scheme_manager_get_scheme_ids");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_manager_get_scheme(IntPtr manager, string scheme_id);
        private static d_gtk_source_style_scheme_manager_get_scheme gtk_source_style_scheme_manager_get_scheme = FuncLoader.LoadFunction<d_gtk_source_style_scheme_manager_get_scheme>(Native.Library, "gtk_source_style_scheme_manager_get_scheme");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_manager_set_search_path(IntPtr manager, IntPtr[] ptrs);
        private static d_gtk_source_style_scheme_manager_set_search_path gtk_source_style_scheme_manager_set_search_path = FuncLoader.LoadFunction<d_gtk_source_style_scheme_manager_set_search_path>(Native.Library, "gtk_source_style_scheme_manager_set_search_path");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_style_scheme_manager_get_search_path(IntPtr manager);
        private static d_gtk_source_style_scheme_manager_get_search_path gtk_source_style_scheme_manager_get_search_path = FuncLoader.LoadFunction<d_gtk_source_style_scheme_manager_get_search_path>(Native.Library, "gtk_source_style_scheme_manager_get_search_path");


        public StyleSchemeManager() : base(gtk_source_style_scheme_manager_new())
        {

        }

        public unsafe List<string> SchemeIds => Native.PtrToList(gtk_source_style_scheme_manager_get_scheme_ids(Handle));

        public StyleScheme GetScheme(string id)
        {
            return new StyleScheme(gtk_source_style_scheme_manager_get_scheme(Handle, id));
        }

        public List<string> GetSearchPath()
        {
            return Native.PtrToList(gtk_source_style_scheme_manager_get_search_path(Handle));
        }

        public void SetSearchPath(params string[] dirs)
        {
            IntPtr[] ptrs = new IntPtr[dirs.Length];
            for (int i = 0; i < dirs.Length; i++)
            {
                if (dirs[i] != null)
                    ptrs[i] = Marshal.StringToHGlobalAnsi(dirs[i]);
            }
            gtk_source_style_scheme_manager_set_search_path(Handle, ptrs);
        }
    }
}