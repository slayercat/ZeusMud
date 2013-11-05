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
    
    // Role: PROXY
    public sealed unsafe partial class CefZipReader : IDisposable
    {
        internal static CefZipReader FromNative(cef_zip_reader_t* ptr)
        {
            return new CefZipReader(ptr);
        }
        
        internal static CefZipReader FromNativeOrNull(cef_zip_reader_t* ptr)
        {
            if (ptr == null) return null;
            return new CefZipReader(ptr);
        }
        
        private cef_zip_reader_t* _self;
        
        private CefZipReader(cef_zip_reader_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefZipReader()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_zip_reader_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_zip_reader_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_zip_reader_t.get_refct(_self); }
        }
        
        internal cef_zip_reader_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
