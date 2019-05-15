

using System;
using System.Runtime.InteropServices;

namespace Gtk.Source
{
    public class SourceView : Gtk.TextView
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_view_new();
        private static d_gtk_source_view_new gtk_source_view_new = FuncLoader.LoadFunction<d_gtk_source_view_new>(Native.Library, "gtk_source_view_new");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_buffer_set_highlight_syntax(IntPtr buffer, bool highlight);
        private static d_gtk_source_buffer_set_highlight_syntax gtk_source_buffer_set_highlight_syntax = FuncLoader.LoadFunction<d_gtk_source_buffer_set_highlight_syntax>(Native.Library, "gtk_source_buffer_set_highlight_syntax");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool d_gtk_source_buffer_get_highlight_syntax(IntPtr buffer);
        private static d_gtk_source_buffer_get_highlight_syntax gtk_source_buffer_get_highlight_syntax = FuncLoader.LoadFunction<d_gtk_source_buffer_get_highlight_syntax>(Native.Library, "gtk_source_buffer_get_highlight_syntax");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_buffer_set_language(IntPtr buffer, IntPtr language);
        private static d_gtk_source_buffer_set_language gtk_source_buffer_set_language = FuncLoader.LoadFunction<d_gtk_source_buffer_set_language>(Native.Library, "gtk_source_buffer_set_language");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_buffer_get_language(IntPtr buffer);
        private static d_gtk_source_buffer_get_language gtk_source_buffer_get_language = FuncLoader.LoadFunction<d_gtk_source_buffer_get_language>(Native.Library, "gtk_source_buffer_get_language");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_buffer_set_style_scheme(IntPtr buffer, IntPtr scheme);
        private static d_gtk_source_buffer_set_style_scheme gtk_source_buffer_set_style_scheme = FuncLoader.LoadFunction<d_gtk_source_buffer_set_style_scheme>(Native.Library, "gtk_source_buffer_set_style_scheme");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr d_gtk_source_buffer_get_style_scheme(IntPtr buffer);
        private static d_gtk_source_buffer_get_style_scheme gtk_source_buffer_get_style_scheme = FuncLoader.LoadFunction<d_gtk_source_buffer_get_style_scheme>(Native.Library, "gtk_source_buffer_get_style_scheme");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_background_pattern(IntPtr buffer, BackgroundPatternType pattern);
        private static d_gtk_source_view_set_background_pattern gtk_source_view_set_background_pattern = FuncLoader.LoadFunction<d_gtk_source_view_set_background_pattern>(Native.Library, "gtk_source_view_set_background_pattern");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate BackgroundPatternType d_gtk_source_view_get_background_pattern(IntPtr buffer);
        private static d_gtk_source_view_get_background_pattern gtk_source_view_get_background_pattern = FuncLoader.LoadFunction<d_gtk_source_view_get_background_pattern>(Native.Library, "gtk_source_view_get_background_pattern");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_show_line_numbers(IntPtr buffer, bool show);
        private static d_gtk_source_view_set_show_line_numbers gtk_source_view_set_show_line_numbers = FuncLoader.LoadFunction<d_gtk_source_view_set_show_line_numbers>(Native.Library, "gtk_source_view_set_show_line_numbers");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool d_gtk_source_view_get_show_line_numbers(IntPtr buffer);
        private static d_gtk_source_view_get_show_line_numbers gtk_source_view_get_show_line_numbers = FuncLoader.LoadFunction<d_gtk_source_view_get_show_line_numbers>(Native.Library, "gtk_source_view_get_show_line_numbers");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_show_right_margin(IntPtr buffer, bool show);
        private static d_gtk_source_view_set_show_right_margin gtk_source_view_set_show_right_margin = FuncLoader.LoadFunction<d_gtk_source_view_set_show_right_margin>(Native.Library, "gtk_source_view_set_show_right_margin");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool d_gtk_source_view_get_show_right_margin(IntPtr buffer);
        private static d_gtk_source_view_get_show_right_margin gtk_source_view_get_show_right_margin = FuncLoader.LoadFunction<d_gtk_source_view_get_show_right_margin>(Native.Library, "gtk_source_view_get_show_right_margin");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_right_margin_position(IntPtr buffer, int pos);
        private static d_gtk_source_view_set_right_margin_position gtk_source_view_set_right_margin_position = FuncLoader.LoadFunction<d_gtk_source_view_set_right_margin_position>(Native.Library, "gtk_source_view_set_right_margin_position");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int d_gtk_source_view_get_right_margin_position(IntPtr buffer);
        private static d_gtk_source_view_get_right_margin_position gtk_source_view_get_right_margin_position = FuncLoader.LoadFunction<d_gtk_source_view_get_right_margin_position>(Native.Library, "gtk_source_view_get_right_margin_position");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_highlight_current_line(IntPtr buffer, bool highlight);
        private static d_gtk_source_view_set_highlight_current_line gtk_source_view_set_highlight_current_line = FuncLoader.LoadFunction<d_gtk_source_view_set_highlight_current_line>(Native.Library, "gtk_source_view_set_highlight_current_line");
 
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool d_gtk_source_view_get_highlight_current_line(IntPtr buffer);
        private static d_gtk_source_view_get_highlight_current_line gtk_source_view_get_highlight_current_line = FuncLoader.LoadFunction<d_gtk_source_view_get_highlight_current_line>(Native.Library, "gtk_source_view_get_highlight_current_line");
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_insert_spaces_instead_of_tabs (IntPtr buffer, bool highlight);
        private static d_gtk_source_view_set_insert_spaces_instead_of_tabs  gtk_source_view_set_insert_spaces_instead_of_tabs  = FuncLoader.LoadFunction<d_gtk_source_view_set_insert_spaces_instead_of_tabs >(Native.Library, "gtk_source_view_set_insert_spaces_instead_of_tabs");
 
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool d_gtk_source_view_get_insert_spaces_instead_of_tabs (IntPtr buffer);
        private static d_gtk_source_view_get_insert_spaces_instead_of_tabs  gtk_source_view_get_insert_spaces_instead_of_tabs  = FuncLoader.LoadFunction<d_gtk_source_view_get_insert_spaces_instead_of_tabs >(Native.Library, "gtk_source_view_get_insert_spaces_instead_of_tabs");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_indent_width(IntPtr buffer, int width);
        private static d_gtk_source_view_set_indent_width gtk_source_view_set_indent_width = FuncLoader.LoadFunction<d_gtk_source_view_set_indent_width>(Native.Library, "gtk_source_view_set_indent_width");
 
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int d_gtk_source_view_get_indent_width(IntPtr buffer);
        private static d_gtk_source_view_get_indent_width gtk_source_view_get_indent_width = FuncLoader.LoadFunction<d_gtk_source_view_get_indent_width>(Native.Library, "gtk_source_view_get_indent_width");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_tab_width(IntPtr buffer, int width);
        private static d_gtk_source_view_set_tab_width gtk_source_view_set_tab_width = FuncLoader.LoadFunction<d_gtk_source_view_set_tab_width>(Native.Library, "gtk_source_view_set_tab_width");
 
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int d_gtk_source_view_get_tab_width(IntPtr buffer);
        private static d_gtk_source_view_get_tab_width gtk_source_view_get_tab_width = FuncLoader.LoadFunction<d_gtk_source_view_get_tab_width>(Native.Library, "gtk_source_view_get_tab_width");
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_buffer_begin_not_undoable_action(IntPtr buffer);
        private static d_gtk_source_buffer_begin_not_undoable_action gtk_source_buffer_begin_not_undoable_action = FuncLoader.LoadFunction<d_gtk_source_buffer_begin_not_undoable_action>(Native.Library, "gtk_source_buffer_begin_not_undoable_action");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_buffer_end_not_undoable_action(IntPtr buffer);
        private static d_gtk_source_buffer_end_not_undoable_action gtk_source_buffer_end_not_undoable_action = FuncLoader.LoadFunction<d_gtk_source_buffer_end_not_undoable_action>(Native.Library, "gtk_source_buffer_end_not_undoable_action");
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void d_gtk_source_view_set_auto_indent(IntPtr buffer, bool enable);
        private static d_gtk_source_view_set_auto_indent gtk_source_view_set_auto_indent = FuncLoader.LoadFunction<d_gtk_source_view_set_auto_indent>(Native.Library, "gtk_source_view_set_auto_indent");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool d_gtk_source_view_get_auto_indent(IntPtr buffer);
        private static d_gtk_source_view_get_auto_indent gtk_source_view_get_auto_indent = FuncLoader.LoadFunction<d_gtk_source_view_get_auto_indent>(Native.Library, "gtk_source_view_get_auto_indent");

        
        public SourceView() : base(gtk_source_view_new())
        {

        }

        public BackgroundPatternType BackgroundPatternType
        {
            get => gtk_source_view_get_background_pattern(Handle);
            set => gtk_source_view_set_background_pattern(Handle, value);
        }

        public bool AutoIndent
        {
            get => gtk_source_view_get_auto_indent(Handle);
            set => gtk_source_view_set_auto_indent(Handle, value);
        }

        public bool ShowLineNumber
        {
            get => gtk_source_view_get_show_line_numbers(Handle);
            set => gtk_source_view_set_show_line_numbers(Handle, value);
        }

        public int IntentWidth
        {
            get => gtk_source_view_get_indent_width(Handle);
            set => gtk_source_view_set_indent_width(Handle, value);
        }

        public int TabWidth
        {
            get => gtk_source_view_get_tab_width(Handle);
            set => gtk_source_view_set_tab_width(Handle, value);
        }

        public bool ShowRightMargin
        {
            get => gtk_source_view_get_show_right_margin(Handle);
            set => gtk_source_view_set_show_right_margin(Handle, value);
        }

        public bool HighlightCurrentLine
        {
            get => gtk_source_view_get_highlight_current_line(Handle);
            set => gtk_source_view_set_highlight_current_line(Handle, value);
        }

        public bool InsertSpacesInsteadOfTabs
        {
            get => gtk_source_view_get_insert_spaces_instead_of_tabs (Handle);
            set => gtk_source_view_set_insert_spaces_instead_of_tabs (Handle, value);
        }

        public bool HighlightSyntax
        {
            get => gtk_source_buffer_get_highlight_syntax(Buffer.Handle);
            set => gtk_source_buffer_set_highlight_syntax(Buffer.Handle, value);
        }

        public Language Language
        {
            get => new Language(gtk_source_buffer_get_language(Buffer.Handle));
            set => gtk_source_buffer_set_language(Buffer.Handle, value.Handle);
        }

        public StyleScheme StyleScheme
        {
            get => new StyleScheme(gtk_source_buffer_get_style_scheme(Buffer.Handle));
            set => gtk_source_buffer_set_style_scheme(Buffer.Handle, value.Handle);
        }

        public int RightMarginPosition
        {
            get => gtk_source_view_get_right_margin_position(Handle);
            set => gtk_source_view_set_right_margin_position(Handle, value);
        }

        public void BeginNotUndoableAction()
        {
            gtk_source_buffer_begin_not_undoable_action(Buffer.Handle);
        }

        public void EndNotUndoableAction()
        {
            gtk_source_buffer_end_not_undoable_action(Buffer.Handle);
        }
    }
}
