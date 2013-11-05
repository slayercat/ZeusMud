//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefBrowserProcessHandler
    {
        private static Dictionary<IntPtr, CefBrowserProcessHandler> _roots = new Dictionary<IntPtr, CefBrowserProcessHandler>();
        
        private int _refct;
        private cef_browser_process_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_browser_process_handler_t.add_ref_delegate _ds0;
        private cef_browser_process_handler_t.release_delegate _ds1;
        private cef_browser_process_handler_t.get_refct_delegate _ds2;
        private cef_browser_process_handler_t.on_context_initialized_delegate _ds3;
        private cef_browser_process_handler_t.on_before_child_process_launch_delegate _ds4;
        private cef_browser_process_handler_t.on_render_process_thread_created_delegate _ds5;
        
        protected CefBrowserProcessHandler()
        {
            _self = cef_browser_process_handler_t.Alloc();
        
            _ds0 = new cef_browser_process_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_browser_process_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_browser_process_handler_t.get_refct_delegate(get_refct);
            _self->_base._get_refct = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_browser_process_handler_t.on_context_initialized_delegate(on_context_initialized);
            _self->_on_context_initialized = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_browser_process_handler_t.on_before_child_process_launch_delegate(on_before_child_process_launch);
            _self->_on_before_child_process_launch = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_browser_process_handler_t.on_render_process_thread_created_delegate(on_render_process_thread_created);
            _self->_on_render_process_thread_created = Marshal.GetFunctionPointerForDelegate(_ds5);
        }
        
        ~CefBrowserProcessHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_browser_process_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private int add_ref(cef_browser_process_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
                return result;
            }
        }
        
        private int release(cef_browser_process_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                }
                return result;
            }
        }
        
        private int get_refct(cef_browser_process_handler_t* self)
        {
            return _refct;
        }
        
        internal cef_browser_process_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_browser_process_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
