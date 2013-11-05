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
    public abstract unsafe partial class CefUserData
    {
        private static Dictionary<IntPtr, CefUserData> _roots = new Dictionary<IntPtr, CefUserData>();
        
        private int _refct;
        private cef_user_data_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        internal static CefUserData FromNativeOrNull(cef_user_data_t* ptr)
        {
            CefUserData value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefUserData FromNative(cef_user_data_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_user_data_t.add_ref_delegate _ds0;
        private cef_user_data_t.release_delegate _ds1;
        private cef_user_data_t.get_refct_delegate _ds2;
        
        protected CefUserData()
        {
            _self = cef_user_data_t.Alloc();
        
            _ds0 = new cef_user_data_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_user_data_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_user_data_t.get_refct_delegate(get_refct);
            _self->_base._get_refct = Marshal.GetFunctionPointerForDelegate(_ds2);
        }
        
        ~CefUserData()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_user_data_t.Free(_self);
                _self = null;
            }
        }
        
        private int add_ref(cef_user_data_t* self)
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
        
        private int release(cef_user_data_t* self)
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
        
        private int get_refct(cef_user_data_t* self)
        {
            return _refct;
        }
        
        internal cef_user_data_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_user_data_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
