//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_browser_host_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_browser;
        internal IntPtr _parent_window_will_close;
        internal IntPtr _close_browser;
        internal IntPtr _set_focus;
        internal IntPtr _get_window_handle;
        internal IntPtr _get_opener_window_handle;
        internal IntPtr _get_client;
        internal IntPtr _get_dev_tools_url;
        internal IntPtr _get_zoom_level;
        internal IntPtr _set_zoom_level;
        internal IntPtr _run_file_dialog;
        internal IntPtr _start_download;
        internal IntPtr _set_mouse_cursor_change_disabled;
        internal IntPtr _is_mouse_cursor_change_disabled;
        internal IntPtr _is_window_rendering_disabled;
        internal IntPtr _was_resized;
        internal IntPtr _was_hidden;
        internal IntPtr _notify_screen_info_changed;
        internal IntPtr _invalidate;
        internal IntPtr _send_key_event;
        internal IntPtr _send_mouse_click_event;
        internal IntPtr _send_mouse_move_event;
        internal IntPtr _send_mouse_wheel_event;
        internal IntPtr _send_focus_event;
        internal IntPtr _send_capture_lost_event;
        internal IntPtr _get_nstext_input_context;
        internal IntPtr _handle_key_event_before_text_input_client;
        internal IntPtr _handle_key_event_after_text_input_client;
        
        // CreateBrowser
        [DllImport(libcef.DllName, EntryPoint = "cef_browser_host_create_browser", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_browser(cef_window_info_t* windowInfo, cef_client_t* client, cef_string_t* url, cef_browser_settings_t* settings);
        
        // CreateBrowserSync
        [DllImport(libcef.DllName, EntryPoint = "cef_browser_host_create_browser_sync", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_browser_t* create_browser_sync(cef_window_info_t* windowInfo, cef_client_t* client, cef_string_t* url, cef_browser_settings_t* settings);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_browser_t* get_browser_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void parent_window_will_close_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void close_browser_delegate(cef_browser_host_t* self, int force_close);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_focus_delegate(cef_browser_host_t* self, int enable);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate IntPtr get_window_handle_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate IntPtr get_opener_window_handle_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_client_t* get_client_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_dev_tools_url_delegate(cef_browser_host_t* self, int http_scheme);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate double get_zoom_level_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_zoom_level_delegate(cef_browser_host_t* self, double zoomLevel);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void run_file_dialog_delegate(cef_browser_host_t* self, CefFileDialogMode mode, cef_string_t* title, cef_string_t* default_file_name, cef_string_list* accept_types, cef_run_file_dialog_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void start_download_delegate(cef_browser_host_t* self, cef_string_t* url);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_mouse_cursor_change_disabled_delegate(cef_browser_host_t* self, int disabled);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_mouse_cursor_change_disabled_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_window_rendering_disabled_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void was_resized_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void was_hidden_delegate(cef_browser_host_t* self, int hidden);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void notify_screen_info_changed_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void invalidate_delegate(cef_browser_host_t* self, cef_rect_t* dirtyRect, CefPaintElementType type);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void send_key_event_delegate(cef_browser_host_t* self, cef_key_event_t* @event);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void send_mouse_click_event_delegate(cef_browser_host_t* self, cef_mouse_event_t* @event, CefMouseButtonType type, int mouseUp, int clickCount);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void send_mouse_move_event_delegate(cef_browser_host_t* self, cef_mouse_event_t* @event, int mouseLeave);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void send_mouse_wheel_event_delegate(cef_browser_host_t* self, cef_mouse_event_t* @event, int deltaX, int deltaY);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void send_focus_event_delegate(cef_browser_host_t* self, int setFocus);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void send_capture_lost_event_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate IntPtr get_nstext_input_context_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void handle_key_event_before_text_input_client_delegate(cef_browser_host_t* self, IntPtr keyEvent);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void handle_key_event_after_text_input_client_delegate(cef_browser_host_t* self, IntPtr keyEvent);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_browser_host_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            return d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_browser_host_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static get_refct_delegate _d2;
        
        public static int get_refct(cef_browser_host_t* self)
        {
            get_refct_delegate d;
            var p = self->_base._get_refct;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (get_refct_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_refct_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // GetBrowser
        private static IntPtr _p3;
        private static get_browser_delegate _d3;
        
        public static cef_browser_t* get_browser(cef_browser_host_t* self)
        {
            get_browser_delegate d;
            var p = self->_get_browser;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (get_browser_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_browser_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // ParentWindowWillClose
        private static IntPtr _p4;
        private static parent_window_will_close_delegate _d4;
        
        public static void parent_window_will_close(cef_browser_host_t* self)
        {
            parent_window_will_close_delegate d;
            var p = self->_parent_window_will_close;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (parent_window_will_close_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(parent_window_will_close_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            d(self);
        }
        
        // CloseBrowser
        private static IntPtr _p5;
        private static close_browser_delegate _d5;
        
        public static void close_browser(cef_browser_host_t* self, int force_close)
        {
            close_browser_delegate d;
            var p = self->_close_browser;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (close_browser_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(close_browser_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self, force_close);
        }
        
        // SetFocus
        private static IntPtr _p6;
        private static set_focus_delegate _d6;
        
        public static void set_focus(cef_browser_host_t* self, int enable)
        {
            set_focus_delegate d;
            var p = self->_set_focus;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (set_focus_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_focus_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            d(self, enable);
        }
        
        // GetWindowHandle
        private static IntPtr _p7;
        private static get_window_handle_delegate _d7;
        
        public static IntPtr get_window_handle(cef_browser_host_t* self)
        {
            get_window_handle_delegate d;
            var p = self->_get_window_handle;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_window_handle_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_window_handle_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetOpenerWindowHandle
        private static IntPtr _p8;
        private static get_opener_window_handle_delegate _d8;
        
        public static IntPtr get_opener_window_handle(cef_browser_host_t* self)
        {
            get_opener_window_handle_delegate d;
            var p = self->_get_opener_window_handle;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_opener_window_handle_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_opener_window_handle_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // GetClient
        private static IntPtr _p9;
        private static get_client_delegate _d9;
        
        public static cef_client_t* get_client(cef_browser_host_t* self)
        {
            get_client_delegate d;
            var p = self->_get_client;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_client_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_client_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // GetDevToolsURL
        private static IntPtr _pa;
        private static get_dev_tools_url_delegate _da;
        
        public static cef_string_userfree* get_dev_tools_url(cef_browser_host_t* self, int http_scheme)
        {
            get_dev_tools_url_delegate d;
            var p = self->_get_dev_tools_url;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_dev_tools_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_dev_tools_url_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self, http_scheme);
        }
        
        // GetZoomLevel
        private static IntPtr _pb;
        private static get_zoom_level_delegate _db;
        
        public static double get_zoom_level(cef_browser_host_t* self)
        {
            get_zoom_level_delegate d;
            var p = self->_get_zoom_level;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_zoom_level_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_zoom_level_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // SetZoomLevel
        private static IntPtr _pc;
        private static set_zoom_level_delegate _dc;
        
        public static void set_zoom_level(cef_browser_host_t* self, double zoomLevel)
        {
            set_zoom_level_delegate d;
            var p = self->_set_zoom_level;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (set_zoom_level_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_zoom_level_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            d(self, zoomLevel);
        }
        
        // RunFileDialog
        private static IntPtr _pd;
        private static run_file_dialog_delegate _dd;
        
        public static void run_file_dialog(cef_browser_host_t* self, CefFileDialogMode mode, cef_string_t* title, cef_string_t* default_file_name, cef_string_list* accept_types, cef_run_file_dialog_callback_t* callback)
        {
            run_file_dialog_delegate d;
            var p = self->_run_file_dialog;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (run_file_dialog_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(run_file_dialog_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            d(self, mode, title, default_file_name, accept_types, callback);
        }
        
        // StartDownload
        private static IntPtr _pe;
        private static start_download_delegate _de;
        
        public static void start_download(cef_browser_host_t* self, cef_string_t* url)
        {
            start_download_delegate d;
            var p = self->_start_download;
            if (p == _pe) { d = _de; }
            else
            {
                d = (start_download_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(start_download_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            d(self, url);
        }
        
        // SetMouseCursorChangeDisabled
        private static IntPtr _pf;
        private static set_mouse_cursor_change_disabled_delegate _df;
        
        public static void set_mouse_cursor_change_disabled(cef_browser_host_t* self, int disabled)
        {
            set_mouse_cursor_change_disabled_delegate d;
            var p = self->_set_mouse_cursor_change_disabled;
            if (p == _pf) { d = _df; }
            else
            {
                d = (set_mouse_cursor_change_disabled_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_mouse_cursor_change_disabled_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            d(self, disabled);
        }
        
        // IsMouseCursorChangeDisabled
        private static IntPtr _p10;
        private static is_mouse_cursor_change_disabled_delegate _d10;
        
        public static int is_mouse_cursor_change_disabled(cef_browser_host_t* self)
        {
            is_mouse_cursor_change_disabled_delegate d;
            var p = self->_is_mouse_cursor_change_disabled;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (is_mouse_cursor_change_disabled_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_mouse_cursor_change_disabled_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            return d(self);
        }
        
        // IsWindowRenderingDisabled
        private static IntPtr _p11;
        private static is_window_rendering_disabled_delegate _d11;
        
        public static int is_window_rendering_disabled(cef_browser_host_t* self)
        {
            is_window_rendering_disabled_delegate d;
            var p = self->_is_window_rendering_disabled;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (is_window_rendering_disabled_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_window_rendering_disabled_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            return d(self);
        }
        
        // WasResized
        private static IntPtr _p12;
        private static was_resized_delegate _d12;
        
        public static void was_resized(cef_browser_host_t* self)
        {
            was_resized_delegate d;
            var p = self->_was_resized;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (was_resized_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(was_resized_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            d(self);
        }
        
        // WasHidden
        private static IntPtr _p13;
        private static was_hidden_delegate _d13;
        
        public static void was_hidden(cef_browser_host_t* self, int hidden)
        {
            was_hidden_delegate d;
            var p = self->_was_hidden;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (was_hidden_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(was_hidden_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            d(self, hidden);
        }
        
        // NotifyScreenInfoChanged
        private static IntPtr _p14;
        private static notify_screen_info_changed_delegate _d14;
        
        public static void notify_screen_info_changed(cef_browser_host_t* self)
        {
            notify_screen_info_changed_delegate d;
            var p = self->_notify_screen_info_changed;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (notify_screen_info_changed_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(notify_screen_info_changed_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            d(self);
        }
        
        // Invalidate
        private static IntPtr _p15;
        private static invalidate_delegate _d15;
        
        public static void invalidate(cef_browser_host_t* self, cef_rect_t* dirtyRect, CefPaintElementType type)
        {
            invalidate_delegate d;
            var p = self->_invalidate;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (invalidate_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(invalidate_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            d(self, dirtyRect, type);
        }
        
        // SendKeyEvent
        private static IntPtr _p16;
        private static send_key_event_delegate _d16;
        
        public static void send_key_event(cef_browser_host_t* self, cef_key_event_t* @event)
        {
            send_key_event_delegate d;
            var p = self->_send_key_event;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (send_key_event_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_key_event_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            d(self, @event);
        }
        
        // SendMouseClickEvent
        private static IntPtr _p17;
        private static send_mouse_click_event_delegate _d17;
        
        public static void send_mouse_click_event(cef_browser_host_t* self, cef_mouse_event_t* @event, CefMouseButtonType type, int mouseUp, int clickCount)
        {
            send_mouse_click_event_delegate d;
            var p = self->_send_mouse_click_event;
            if (p == _p17) { d = _d17; }
            else
            {
                d = (send_mouse_click_event_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_mouse_click_event_delegate));
                if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
            }
            d(self, @event, type, mouseUp, clickCount);
        }
        
        // SendMouseMoveEvent
        private static IntPtr _p18;
        private static send_mouse_move_event_delegate _d18;
        
        public static void send_mouse_move_event(cef_browser_host_t* self, cef_mouse_event_t* @event, int mouseLeave)
        {
            send_mouse_move_event_delegate d;
            var p = self->_send_mouse_move_event;
            if (p == _p18) { d = _d18; }
            else
            {
                d = (send_mouse_move_event_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_mouse_move_event_delegate));
                if (_p18 == IntPtr.Zero) { _d18 = d; _p18 = p; }
            }
            d(self, @event, mouseLeave);
        }
        
        // SendMouseWheelEvent
        private static IntPtr _p19;
        private static send_mouse_wheel_event_delegate _d19;
        
        public static void send_mouse_wheel_event(cef_browser_host_t* self, cef_mouse_event_t* @event, int deltaX, int deltaY)
        {
            send_mouse_wheel_event_delegate d;
            var p = self->_send_mouse_wheel_event;
            if (p == _p19) { d = _d19; }
            else
            {
                d = (send_mouse_wheel_event_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_mouse_wheel_event_delegate));
                if (_p19 == IntPtr.Zero) { _d19 = d; _p19 = p; }
            }
            d(self, @event, deltaX, deltaY);
        }
        
        // SendFocusEvent
        private static IntPtr _p1a;
        private static send_focus_event_delegate _d1a;
        
        public static void send_focus_event(cef_browser_host_t* self, int setFocus)
        {
            send_focus_event_delegate d;
            var p = self->_send_focus_event;
            if (p == _p1a) { d = _d1a; }
            else
            {
                d = (send_focus_event_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_focus_event_delegate));
                if (_p1a == IntPtr.Zero) { _d1a = d; _p1a = p; }
            }
            d(self, setFocus);
        }
        
        // SendCaptureLostEvent
        private static IntPtr _p1b;
        private static send_capture_lost_event_delegate _d1b;
        
        public static void send_capture_lost_event(cef_browser_host_t* self)
        {
            send_capture_lost_event_delegate d;
            var p = self->_send_capture_lost_event;
            if (p == _p1b) { d = _d1b; }
            else
            {
                d = (send_capture_lost_event_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_capture_lost_event_delegate));
                if (_p1b == IntPtr.Zero) { _d1b = d; _p1b = p; }
            }
            d(self);
        }
        
        // GetNSTextInputContext
        private static IntPtr _p1c;
        private static get_nstext_input_context_delegate _d1c;
        
        public static IntPtr get_nstext_input_context(cef_browser_host_t* self)
        {
            get_nstext_input_context_delegate d;
            var p = self->_get_nstext_input_context;
            if (p == _p1c) { d = _d1c; }
            else
            {
                d = (get_nstext_input_context_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_nstext_input_context_delegate));
                if (_p1c == IntPtr.Zero) { _d1c = d; _p1c = p; }
            }
            return d(self);
        }
        
        // HandleKeyEventBeforeTextInputClient
        private static IntPtr _p1d;
        private static handle_key_event_before_text_input_client_delegate _d1d;
        
        public static void handle_key_event_before_text_input_client(cef_browser_host_t* self, IntPtr keyEvent)
        {
            handle_key_event_before_text_input_client_delegate d;
            var p = self->_handle_key_event_before_text_input_client;
            if (p == _p1d) { d = _d1d; }
            else
            {
                d = (handle_key_event_before_text_input_client_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(handle_key_event_before_text_input_client_delegate));
                if (_p1d == IntPtr.Zero) { _d1d = d; _p1d = p; }
            }
            d(self, keyEvent);
        }
        
        // HandleKeyEventAfterTextInputClient
        private static IntPtr _p1e;
        private static handle_key_event_after_text_input_client_delegate _d1e;
        
        public static void handle_key_event_after_text_input_client(cef_browser_host_t* self, IntPtr keyEvent)
        {
            handle_key_event_after_text_input_client_delegate d;
            var p = self->_handle_key_event_after_text_input_client;
            if (p == _p1e) { d = _d1e; }
            else
            {
                d = (handle_key_event_after_text_input_client_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(handle_key_event_after_text_input_client_delegate));
                if (_p1e == IntPtr.Zero) { _d1e = d; _p1e = p; }
            }
            d(self, keyEvent);
        }
        
    }
}
