using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gtk.Source
{
    public class LanguageManager : GLib.Object
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_manager_new();
        private static d_gtk_source_language_manager_new gtk_source_language_manager_new = FuncLoader.LoadFunction<d_gtk_source_language_manager_new>(Native.Library, "gtk_source_language_manager_get_default");
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_manager_get_language_ids(IntPtr lm);
        private static d_gtk_source_language_manager_get_language_ids gtk_source_language_manager_get_language_ids = FuncLoader.LoadFunction<d_gtk_source_language_manager_get_language_ids>(Native.Library, "gtk_source_language_manager_get_language_ids");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_manager_get_language(IntPtr lm, string id);
        private static d_gtk_source_language_manager_get_language gtk_source_language_manager_get_language = FuncLoader.LoadFunction<d_gtk_source_language_manager_get_language>(Native.Library, "gtk_source_language_manager_get_language");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_manager_guess_language(IntPtr lm, string filename, string contentType);
        private static d_gtk_source_language_manager_guess_language gtk_source_language_manager_guess_language = FuncLoader.LoadFunction<d_gtk_source_language_manager_guess_language>(Native.Library, "gtk_source_language_manager_guess_language");


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_language_manager_get_search_path(IntPtr lm);
        private static d_gtk_source_language_manager_get_search_path gtk_source_language_manager_get_search_path = FuncLoader.LoadFunction<d_gtk_source_language_manager_get_search_path>(Native.Library, "gtk_source_language_manager_get_search_path");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_language_manager_set_search_path(IntPtr lm, IntPtr[] path);
        private static d_gtk_source_language_manager_set_search_path gtk_source_language_manager_set_search_path = FuncLoader.LoadFunction<d_gtk_source_language_manager_set_search_path>(Native.Library, "gtk_source_language_manager_set_search_path");



        public LanguageManager() : base (gtk_source_language_manager_new())
        {

        }

        public List<string> LanguageIds => Native.PtrToList(gtk_source_language_manager_get_language_ids(Handle));

        public Language GetLanguage(string id)
        {
            return new Language(gtk_source_language_manager_get_language(Handle, id));
        }

        public Language GetGuessLanguage(string filename, string contentType)
        {
            return new Language(gtk_source_language_manager_guess_language(Handle, filename, contentType));
        }

        public List<string> GetSearchPath()
        {
            return Native.PtrToList(gtk_source_language_manager_get_search_path(Handle));
        }

        public void SetSearchPath(params string[] dirs)
        {
            IntPtr[] ptrs = new IntPtr[dirs.Length];
            for (int i = 0; i < dirs.Length; i++)
            {
                if (dirs[i] != null)
                    ptrs[i] = Marshal.StringToHGlobalAnsi(dirs[i]);
            }
            gtk_source_language_manager_set_search_path(Handle, ptrs);
        }
    }
}