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
    internal unsafe struct cef_command_line_t
    {
        internal cef_base_t _base;
        internal IntPtr _is_valid;
        internal IntPtr _is_read_only;
        internal IntPtr _copy;
        internal IntPtr _init_from_argv;
        internal IntPtr _init_from_string;
        internal IntPtr _reset;
        internal IntPtr _get_argv;
        internal IntPtr _get_command_line_string;
        internal IntPtr _get_program;
        internal IntPtr _set_program;
        internal IntPtr _has_switches;
        internal IntPtr _has_switch;
        internal IntPtr _get_switch_value;
        internal IntPtr _get_switches;
        internal IntPtr _append_switch;
        internal IntPtr _append_switch_with_value;
        internal IntPtr _has_arguments;
        internal IntPtr _get_arguments;
        internal IntPtr _append_argument;
        internal IntPtr _prepend_wrapper;
        
        // CreateCommandLine
        [DllImport(libcef.DllName, EntryPoint = "cef_command_line_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_command_line_t* create();
        
        // GetGlobalCommandLine
        [DllImport(libcef.DllName, EntryPoint = "cef_command_line_get_global", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_command_line_t* get_global();
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_valid_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_read_only_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_command_line_t* copy_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void init_from_argv_delegate(cef_command_line_t* self, int argc, byte** argv);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void init_from_string_delegate(cef_command_line_t* self, cef_string_t* command_line);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void reset_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_argv_delegate(cef_command_line_t* self, cef_string_list* argv);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_command_line_string_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_program_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_program_delegate(cef_command_line_t* self, cef_string_t* program);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_switches_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_switch_delegate(cef_command_line_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_switch_value_delegate(cef_command_line_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_switches_delegate(cef_command_line_t* self, cef_string_map* switches);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void append_switch_delegate(cef_command_line_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void append_switch_with_value_delegate(cef_command_line_t* self, cef_string_t* name, cef_string_t* value);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_arguments_delegate(cef_command_line_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_arguments_delegate(cef_command_line_t* self, cef_string_list* arguments);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void append_argument_delegate(cef_command_line_t* self, cef_string_t* argument);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void prepend_wrapper_delegate(cef_command_line_t* self, cef_string_t* wrapper);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_command_line_t* self)
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
        
        public static int release(cef_command_line_t* self)
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
        
        public static int get_refct(cef_command_line_t* self)
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
        
        // IsValid
        private static IntPtr _p3;
        private static is_valid_delegate _d3;
        
        public static int is_valid(cef_command_line_t* self)
        {
            is_valid_delegate d;
            var p = self->_is_valid;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_valid_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_valid_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // IsReadOnly
        private static IntPtr _p4;
        private static is_read_only_delegate _d4;
        
        public static int is_read_only(cef_command_line_t* self)
        {
            is_read_only_delegate d;
            var p = self->_is_read_only;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (is_read_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_read_only_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // Copy
        private static IntPtr _p5;
        private static copy_delegate _d5;
        
        public static cef_command_line_t* copy(cef_command_line_t* self)
        {
            copy_delegate d;
            var p = self->_copy;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (copy_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(copy_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // InitFromArgv
        private static IntPtr _p6;
        private static init_from_argv_delegate _d6;
        
        public static void init_from_argv(cef_command_line_t* self, int argc, byte** argv)
        {
            init_from_argv_delegate d;
            var p = self->_init_from_argv;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (init_from_argv_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(init_from_argv_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            d(self, argc, argv);
        }
        
        // InitFromString
        private static IntPtr _p7;
        private static init_from_string_delegate _d7;
        
        public static void init_from_string(cef_command_line_t* self, cef_string_t* command_line)
        {
            init_from_string_delegate d;
            var p = self->_init_from_string;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (init_from_string_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(init_from_string_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            d(self, command_line);
        }
        
        // Reset
        private static IntPtr _p8;
        private static reset_delegate _d8;
        
        public static void reset(cef_command_line_t* self)
        {
            reset_delegate d;
            var p = self->_reset;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (reset_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(reset_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            d(self);
        }
        
        // GetArgv
        private static IntPtr _p9;
        private static get_argv_delegate _d9;
        
        public static void get_argv(cef_command_line_t* self, cef_string_list* argv)
        {
            get_argv_delegate d;
            var p = self->_get_argv;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_argv_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_argv_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            d(self, argv);
        }
        
        // GetCommandLineString
        private static IntPtr _pa;
        private static get_command_line_string_delegate _da;
        
        public static cef_string_userfree* get_command_line_string(cef_command_line_t* self)
        {
            get_command_line_string_delegate d;
            var p = self->_get_command_line_string;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_command_line_string_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_command_line_string_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self);
        }
        
        // GetProgram
        private static IntPtr _pb;
        private static get_program_delegate _db;
        
        public static cef_string_userfree* get_program(cef_command_line_t* self)
        {
            get_program_delegate d;
            var p = self->_get_program;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_program_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_program_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // SetProgram
        private static IntPtr _pc;
        private static set_program_delegate _dc;
        
        public static void set_program(cef_command_line_t* self, cef_string_t* program)
        {
            set_program_delegate d;
            var p = self->_set_program;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (set_program_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_program_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            d(self, program);
        }
        
        // HasSwitches
        private static IntPtr _pd;
        private static has_switches_delegate _dd;
        
        public static int has_switches(cef_command_line_t* self)
        {
            has_switches_delegate d;
            var p = self->_has_switches;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (has_switches_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_switches_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self);
        }
        
        // HasSwitch
        private static IntPtr _pe;
        private static has_switch_delegate _de;
        
        public static int has_switch(cef_command_line_t* self, cef_string_t* name)
        {
            has_switch_delegate d;
            var p = self->_has_switch;
            if (p == _pe) { d = _de; }
            else
            {
                d = (has_switch_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_switch_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            return d(self, name);
        }
        
        // GetSwitchValue
        private static IntPtr _pf;
        private static get_switch_value_delegate _df;
        
        public static cef_string_userfree* get_switch_value(cef_command_line_t* self, cef_string_t* name)
        {
            get_switch_value_delegate d;
            var p = self->_get_switch_value;
            if (p == _pf) { d = _df; }
            else
            {
                d = (get_switch_value_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_switch_value_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self, name);
        }
        
        // GetSwitches
        private static IntPtr _p10;
        private static get_switches_delegate _d10;
        
        public static void get_switches(cef_command_line_t* self, cef_string_map* switches)
        {
            get_switches_delegate d;
            var p = self->_get_switches;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (get_switches_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_switches_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            d(self, switches);
        }
        
        // AppendSwitch
        private static IntPtr _p11;
        private static append_switch_delegate _d11;
        
        public static void append_switch(cef_command_line_t* self, cef_string_t* name)
        {
            append_switch_delegate d;
            var p = self->_append_switch;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (append_switch_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(append_switch_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            d(self, name);
        }
        
        // AppendSwitchWithValue
        private static IntPtr _p12;
        private static append_switch_with_value_delegate _d12;
        
        public static void append_switch_with_value(cef_command_line_t* self, cef_string_t* name, cef_string_t* value)
        {
            append_switch_with_value_delegate d;
            var p = self->_append_switch_with_value;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (append_switch_with_value_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(append_switch_with_value_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            d(self, name, value);
        }
        
        // HasArguments
        private static IntPtr _p13;
        private static has_arguments_delegate _d13;
        
        public static int has_arguments(cef_command_line_t* self)
        {
            has_arguments_delegate d;
            var p = self->_has_arguments;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (has_arguments_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_arguments_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            return d(self);
        }
        
        // GetArguments
        private static IntPtr _p14;
        private static get_arguments_delegate _d14;
        
        public static void get_arguments(cef_command_line_t* self, cef_string_list* arguments)
        {
            get_arguments_delegate d;
            var p = self->_get_arguments;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (get_arguments_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_arguments_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            d(self, arguments);
        }
        
        // AppendArgument
        private static IntPtr _p15;
        private static append_argument_delegate _d15;
        
        public static void append_argument(cef_command_line_t* self, cef_string_t* argument)
        {
            append_argument_delegate d;
            var p = self->_append_argument;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (append_argument_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(append_argument_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            d(self, argument);
        }
        
        // PrependWrapper
        private static IntPtr _p16;
        private static prepend_wrapper_delegate _d16;
        
        public static void prepend_wrapper(cef_command_line_t* self, cef_string_t* wrapper)
        {
            prepend_wrapper_delegate d;
            var p = self->_prepend_wrapper;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (prepend_wrapper_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(prepend_wrapper_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            d(self, wrapper);
        }
        
    }
}
