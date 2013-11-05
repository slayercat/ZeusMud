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
    public abstract unsafe partial class CefGetGeolocationCallback
    {
        private static Dictionary<IntPtr, CefGetGeolocationCallback> _roots = new Dictionary<IntPtr, CefGetGeolocationCallback>();
        
        private int _refct;
        private cef_get_geolocation_callback_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_get_geolocation_callback_t.add_ref_delegate _ds0;
        private cef_get_geolocation_callback_t.release_delegate _ds1;
        private cef_get_geolocation_callback_t.get_refct_delegate _ds2;
        private cef_get_geolocation_callback_t.on_location_update_delegate _ds3;
        
        protected CefGetGeolocationCallback()
        {
            _self = cef_get_geolocation_callback_t.Alloc();
        
            _ds0 = new cef_get_geolocation_callback_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_get_geolocation_callback_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_get_geolocation_callback_t.get_refct_delegate(get_refct);
            _self->_base._get_refct = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_get_geolocation_callback_t.on_location_update_delegate(on_location_update);
            _self->_on_location_update = Marshal.GetFunctionPointerForDelegate(_ds3);
        }
        
        ~CefGetGeolocationCallback()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_get_geolocation_callback_t.Free(_self);
                _self = null;
            }
        }
        
        private int add_ref(cef_get_geolocation_callback_t* self)
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
        
        private int release(cef_get_geolocation_callback_t* self)
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
        
        private int get_refct(cef_get_geolocation_callback_t* self)
        {
            return _refct;
        }
        
        internal cef_get_geolocation_callback_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_get_geolocation_callback_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
