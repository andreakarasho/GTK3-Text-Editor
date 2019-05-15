using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gtk.Source
{
    class Native
    {
        public static IntPtr Library = GetLibrary();

        public static IntPtr GetLibrary()
        {
            // TODO: Add Windows / Mac library

            return FuncLoader.LoadLibrary("libgtksourceview-4-0.dll");
        }

        public static unsafe string PtrToString(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return string.Empty;

            var ptr = (byte*)handle;
            while (*ptr != 0)
                ptr++;

            var len = ptr - (byte*)handle;
            if (len == 0)
                return string.Empty;

            //var bytes = new byte[len];
            //Marshal.Copy(handle, bytes, 0, bytes.Length);
            //return Encoding.UTF8.GetString(bytes);
            return Encoding.UTF8.GetString((byte*)handle, (int) len);
        }

        public static unsafe List<string> PtrToList(IntPtr ptr)
        {
            var exts = (IntPtr*)ptr;
            var ret = new List<string>();

            if (ptr == IntPtr.Zero)
                return ret;
 
            for (int i = 0; i < 1000; i++)
            {
                if (exts[i] == IntPtr.Zero)
                    return ret;

                var temp = Marshal.PtrToStringAnsi(exts[i]);
                ret.Add(temp);
            }
 
            return ret;
        }
    }
}
