// Automatically generated by Interoptopus.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using My.Company;
using My.Company.Common;

namespace My.Company
{
    public static partial class Interop
    {
        public const string NativeLib = "interoptopus_reference_project";

        static Interop()
        {
            var api_version = Interop.pattern_api_guard();
            if (api_version != 5066755664026058268ul)
            {
                throw new Exception($"API reports hash {api_version} which differs from hash in bindings (5066755664026058268). You probably forgot to update / copy either the bindings or the library.");
            }
        }

        public const byte U8 = (byte) 255;

        public const float F32_MIN_POSITIVE = (float) 0.000000000000000000000000000000000000011754944;

        public const int COMPUTED_I32 = (int) -2147483647;


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_void")]
        public static extern void primitive_void();


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_void2")]
        public static extern void primitive_void2();


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_bool")]
        public static extern bool primitive_bool(bool x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_u8")]
        public static extern byte primitive_u8(byte x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_u16")]
        public static extern ushort primitive_u16(ushort x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_u32")]
        public static extern uint primitive_u32(uint x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_u64")]
        public static extern ulong primitive_u64(ulong x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_i8")]
        public static extern sbyte primitive_i8(sbyte x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_i16")]
        public static extern short primitive_i16(short x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_i32")]
        public static extern int primitive_i32(int x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "primitive_i64")]
        public static extern long primitive_i64(long x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "many_args_5")]
        public static extern long many_args_5(long x0, long x1, long x2, long x3, long x4);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "many_args_10")]
        public static extern long many_args_10(long x0, long x1, long x2, long x3, long x4, long x5, long x6, long x7, long x8, long x9);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ptr")]
        public static extern IntPtr ptr(ref long x);


        /// # Safety
        ///
        /// Parameter x must point to valid data.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ptr_mut")]
        public static extern IntPtr ptr_mut(out long x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ptr_ptr")]
        public static extern IntPtr ptr_ptr(ref IntPtr x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ref_simple")]
        public static extern IntPtr ref_simple(ref long x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ref_mut_simple")]
        public static extern IntPtr ref_mut_simple(out long x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ref_option")]
        public static extern bool ref_option(ref long x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ref_mut_option")]
        public static extern bool ref_mut_option(out long x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tupled")]
        public static extern Tupled tupled(Tupled x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "complex_args_1")]
        public static extern FFIError complex_args_1(Vec3f32 a, ref Empty b);

        public static void complex_args_1_checked(Vec3f32 a, ref Empty b) {
            var rval = complex_args_1(a, ref b);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "complex_args_2")]
        public static extern IntPtr complex_args_2(SomeForeignType cmplx);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "callback")]
        public static extern byte callback(InteropDelegate_fn_u8_rval_u8 callback, byte value);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "generic_1a")]
        public static extern uint generic_1a(Genericu32 x, Phantomu8 y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "generic_1b")]
        public static extern byte generic_1b(Genericu8 x, Phantomu8 y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "generic_1c")]
        public static extern byte generic_1c(ref Genericu8 x, ref Genericu8 y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "generic_2")]
        public static extern byte generic_2(IntPtr x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "generic_3")]
        public static extern byte generic_3(IntPtr x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "generic_4")]
        public static extern byte generic_4(IntPtr x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "array_1")]
        public static extern byte array_1(Array x);


        /// This function has documentation.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "documented")]
        public static extern EnumDocumented documented(StructDocumented x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ambiguous_1")]
        public static extern Vec1 ambiguous_1(Vec1 x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ambiguous_2")]
        public static extern Vec2 ambiguous_2(Vec2 x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ambiguous_3")]
        public static extern bool ambiguous_3(Vec1 x, Vec2 y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "namespaced_type")]
        public static extern Vec namespaced_type(Vec x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "panics")]
        public static extern FFIError panics();

        public static void panics_checked() {
            var rval = panics();;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "renamed")]
        public static extern EnumRenamed renamed(StructRenamed x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "sleep")]
        public static extern void sleep(ulong millis);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "weird_1")]
        public static extern bool weird_1(Weird1u32 x, Weird2u8 y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "visibility")]
        public static extern void visibility(Visibility1 x, Visibility2 y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ascii_pointer_1")]
        public static extern uint pattern_ascii_pointer_1(string x);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ascii_pointer_len")]
        public static extern uint pattern_ascii_pointer_len(string x, UseAsciiStringPattern y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_1")]
        public static extern uint pattern_ffi_slice_1(Sliceu32 ffi_slice);

        public static uint pattern_ffi_slice_1(uint[] ffi_slice) {
            var ffi_slice_pinned = GCHandle.Alloc(ffi_slice, GCHandleType.Pinned);
            var ffi_slice_slice = new Sliceu32(ffi_slice_pinned, (ulong) ffi_slice.Length);
            try
            {
                return pattern_ffi_slice_1(ffi_slice_slice);;
            }
            finally
            {
                ffi_slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_2")]
        public static extern Vec3f32 pattern_ffi_slice_2(SliceVec3f32 ffi_slice, int i);

        public static Vec3f32 pattern_ffi_slice_2(Vec3f32[] ffi_slice, int i) {
            var ffi_slice_pinned = GCHandle.Alloc(ffi_slice, GCHandleType.Pinned);
            var ffi_slice_slice = new SliceVec3f32(ffi_slice_pinned, (ulong) ffi_slice.Length);
            try
            {
                return pattern_ffi_slice_2(ffi_slice_slice, i);;
            }
            finally
            {
                ffi_slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_3")]
        public static extern void pattern_ffi_slice_3(SliceMutu8 slice, CallbackSliceMut callback);

        public static void pattern_ffi_slice_3(byte[] slice, CallbackSliceMut callback) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new SliceMutu8(slice_pinned, (ulong) slice.Length);
            try
            {
                pattern_ffi_slice_3(slice_slice, callback);;
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_4")]
        public static extern void pattern_ffi_slice_4(Sliceu8 slice, SliceMutu8 slice2);

        public static void pattern_ffi_slice_4(byte[] slice, byte[] slice2) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new Sliceu8(slice_pinned, (ulong) slice.Length);
            var slice2_pinned = GCHandle.Alloc(slice2, GCHandleType.Pinned);
            var slice2_slice = new SliceMutu8(slice2_pinned, (ulong) slice2.Length);
            try
            {
                pattern_ffi_slice_4(slice_slice, slice2_slice);;
            }
            finally
            {
                slice_pinned.Free();
                slice2_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_5")]
        public static extern void pattern_ffi_slice_5(ref Sliceu8 slice, ref SliceMutu8 slice2);

        public static void pattern_ffi_slice_5(byte[] slice, byte[] slice2) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new Sliceu8(slice_pinned, (ulong) slice.Length);
            var slice2_pinned = GCHandle.Alloc(slice2, GCHandleType.Pinned);
            var slice2_slice = new SliceMutu8(slice2_pinned, (ulong) slice2.Length);
            try
            {
                pattern_ffi_slice_5(ref slice_slice, ref slice2_slice);;
            }
            finally
            {
                slice_pinned.Free();
                slice2_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_6")]
        public static extern void pattern_ffi_slice_6(ref SliceMutu8 slice, CallbackU8 callback);

        public static void pattern_ffi_slice_6(byte[] slice, CallbackU8 callback) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new SliceMutu8(slice_pinned, (ulong) slice.Length);
            try
            {
                pattern_ffi_slice_6(ref slice_slice, callback);;
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_delegate")]
        public static extern byte pattern_ffi_slice_delegate(CallbackFFISlice callback);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_slice_delegate_huge")]
        public static extern Vec3f32 pattern_ffi_slice_delegate_huge(CallbackHugeVecSlice callback);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_option_1")]
        public static extern OptionInner pattern_ffi_option_1(OptionInner ffi_slice);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_option_2")]
        public static extern Inner pattern_ffi_option_2(OptionInner ffi_slice);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_ffi_bool")]
        public static extern Bool pattern_ffi_bool(Bool ffi_bool);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_api_guard")]
        public static extern ulong pattern_api_guard();


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "pattern_callback_1")]
        public static extern uint pattern_callback_1(MyCallback callback, uint x);


        /// Destroys the given instance.
        ///
        /// # Safety
        ///
        /// The passed parameter MUST have been created with the corresponding init function;
        /// passing any other value results in undefined behavior.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_destroy")]
        public static extern FFIError simple_service_destroy(ref IntPtr context);

        public static void simple_service_destroy_checked(ref IntPtr context) {
            var rval = simple_service_destroy(ref context);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        /// The constructor must return a `Result<Self, Error>`.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_new_with")]
        public static extern FFIError simple_service_new_with(ref IntPtr context, uint some_value);

        public static void simple_service_new_with_checked(ref IntPtr context, uint some_value) {
            var rval = simple_service_new_with(ref context, some_value);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_new_without")]
        public static extern FFIError simple_service_new_without(ref IntPtr context);

        public static void simple_service_new_without_checked(ref IntPtr context) {
            var rval = simple_service_new_without(ref context);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_new_failing")]
        public static extern FFIError simple_service_new_failing(ref IntPtr context, byte some_value);

        public static void simple_service_new_failing_checked(ref IntPtr context, byte some_value) {
            var rval = simple_service_new_failing(ref context, some_value);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        /// Methods returning a Result<(), _> are the default and do not
        /// need annotations.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_result")]
        public static extern FFIError simple_service_method_result(IntPtr context, uint anon1);

        public static void simple_service_method_result_checked(IntPtr context, uint anon1) {
            var rval = simple_service_method_result(context, anon1);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_value")]
        public static extern uint simple_service_method_value(IntPtr context, uint x);


        /// This method should be documented.
        ///
        /// Multiple lines.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_void")]
        public static extern void simple_service_method_void(IntPtr context);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self")]
        public static extern byte simple_service_method_mut_self(IntPtr context, Sliceu8 slice);

        public static byte simple_service_method_mut_self(IntPtr context, byte[] slice) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new Sliceu8(slice_pinned, (ulong) slice.Length);
            try
            {
                return simple_service_method_mut_self(context, slice_slice);;
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        /// Single line.
        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self_void")]
        public static extern void simple_service_method_mut_self_void(IntPtr context, SliceBool slice);

        public static void simple_service_method_mut_self_void(IntPtr context, Bool[] slice) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new SliceBool(slice_pinned, (ulong) slice.Length);
            try
            {
                simple_service_method_mut_self_void(context, slice_slice);;
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self_ref")]
        public static extern byte simple_service_method_mut_self_ref(IntPtr context, ref byte x, out byte y);


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self_ref_slice")]
        public static extern byte simple_service_method_mut_self_ref_slice(IntPtr context, ref byte x, out byte y, Sliceu8 slice);

        public static byte simple_service_method_mut_self_ref_slice(IntPtr context, ref byte x, out byte y, byte[] slice) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new Sliceu8(slice_pinned, (ulong) slice.Length);
            try
            {
                return simple_service_method_mut_self_ref_slice(context, ref x, out y, slice_slice);;
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self_ref_slice_limited")]
        public static extern byte simple_service_method_mut_self_ref_slice_limited(IntPtr context, ref byte x, out byte y, Sliceu8 slice, Sliceu8 slice2);

        public static byte simple_service_method_mut_self_ref_slice_limited(IntPtr context, ref byte x, out byte y, byte[] slice, byte[] slice2) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new Sliceu8(slice_pinned, (ulong) slice.Length);
            var slice2_pinned = GCHandle.Alloc(slice2, GCHandleType.Pinned);
            var slice2_slice = new Sliceu8(slice2_pinned, (ulong) slice2.Length);
            try
            {
                return simple_service_method_mut_self_ref_slice_limited(context, ref x, out y, slice_slice, slice2_slice);;
            }
            finally
            {
                slice_pinned.Free();
                slice2_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self_ffi_error")]
        public static extern FFIError simple_service_method_mut_self_ffi_error(IntPtr context, SliceMutu8 slice);

        public static void simple_service_method_mut_self_ffi_error(IntPtr context, byte[] slice) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new SliceMutu8(slice_pinned, (ulong) slice.Length);
            try
            {
                var rval = simple_service_method_mut_self_ffi_error(context, slice_slice);;
                if (rval != FFIError.Ok)
                {
                    throw new Exception($"Something went wrong: {rval}");
                }
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_mut_self_no_error")]
        public static extern FFIError simple_service_method_mut_self_no_error(IntPtr context, SliceMutu8 slice);

        public static void simple_service_method_mut_self_no_error(IntPtr context, byte[] slice) {
            var slice_pinned = GCHandle.Alloc(slice, GCHandleType.Pinned);
            var slice_slice = new SliceMutu8(slice_pinned, (ulong) slice.Length);
            try
            {
                var rval = simple_service_method_mut_self_no_error(context, slice_slice);;
                if (rval != FFIError.Ok)
                {
                    throw new Exception($"Something went wrong: {rval}");
                }
            }
            finally
            {
                slice_pinned.Free();
            }
        }

        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "simple_service_method_void_ffi_error")]
        public static extern FFIError simple_service_method_void_ffi_error(IntPtr context);

        public static void simple_service_method_void_ffi_error_checked(IntPtr context) {
            var rval = simple_service_method_void_ffi_error(context);;
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

    }

    /// Documented enum.
    public enum EnumDocumented
    {
        /// Variant A.
        A = 0,
        /// Variant B.
        B = 1,
        /// Variant B.
        C = 2,
    }

    public enum EnumRenamed
    {
        X = 0,
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Array
    {
        public byte data0;
        public byte data1;
        public byte data2;
        public byte data3;
        public byte data4;
        public byte data5;
        public byte data6;
        public byte data7;
        public byte data8;
        public byte data9;
        public byte data10;
        public byte data11;
        public byte data12;
        public byte data13;
        public byte data14;
        public byte data15;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Empty
    {
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExtraTypef32
    {
        public float x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Genericu32
    {
        public IntPtr x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Genericu8
    {
        public IntPtr x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Inner
    {
        float x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Phantomu8
    {
        public uint x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SomeForeignType
    {
        public uint x;
    }

    /// Documented struct.
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StructDocumented
    {
        /// Documented field.
        public float x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StructRenamed
    {
        public EnumRenamed e;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Tupled
    {
        public byte x0;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct UseAsciiStringPattern
    {
        public string ascii_string;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec1
    {
        public float x;
        public float y;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec2
    {
        public double x;
        public double z;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec3f32
    {
        public float x;
        public float y;
        public float z;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Visibility1
    {
        public byte pblc;
        byte prvt;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Visibility2
    {
        public byte pblc1;
        public byte pblc2;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Weird1u32
    {
        uint x;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Weird2u8
    {
        byte t;
        byte a0;
        byte a1;
        byte a2;
        byte a3;
        byte a4;
        IntPtr r;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte InteropDelegate_fn_u8_rval_u8(byte x0);

    public enum FFIError
    {
        Ok = 0,
        Null = 100,
        Panic = 200,
        Fail = 300,
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SliceVec3f32
    {
        IntPtr data;
        ulong len;
    }

    public partial struct SliceVec3f32 : IEnumerable<Vec3f32>
    {
        public SliceVec3f32(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public SliceVec3f32(IntPtr handle, ulong count)
        {
            this.data = handle;
            this.len = count;
        }
        public Vec3f32 this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                var size = Marshal.SizeOf(typeof(Vec3f32));
                var ptr = new IntPtr(data.ToInt64() + i * size);
                return Marshal.PtrToStructure<Vec3f32>(ptr);
            }
        }
        public Vec3f32[] Copied
        {
            get
            {
                var rval = new Vec3f32[len];
                for (var i = 0; i < (int) len; i++) {
                    rval[i] = this[i];
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<Vec3f32> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct OptionInner
    {
        Inner t;
        byte is_some;
    }

    public partial struct OptionInner
    {
        public static OptionInner FromNullable(Inner? nullable)
        {
            var result = new OptionInner();
            if (nullable.HasValue)
            {
                result.is_some = 1;
                result.t = nullable.Value;
            }

            return result;
        }

        public Inner? ToNullable()
        {
            return this.is_some == 1 ? this.t : (Inner?)null;
        }
    }


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte CallbackFFISlice(Sliceu8 x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate Vec3f32 CallbackHugeVecSlice(SliceVec3f32 x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CallbackSliceMut(SliceMutu8 x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte CallbackU8(byte x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint MyCallback(uint x0);


    /// Some struct we want to expose as a class.
    public partial class SimpleService : IDisposable
    {
        private IntPtr _context;
        /// The constructor must return a `Result<Self, Error>`.
        public  SimpleService(uint some_value)
        {
            var rval = Interop.simple_service_new_with(ref _context, some_value);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public  SimpleService()
        {
            var rval = Interop.simple_service_new_without(ref _context);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public  SimpleService(byte some_value)
        {
            var rval = Interop.simple_service_new_failing(ref _context, some_value);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public void Dispose()
        {
            var rval = Interop.simple_service_destroy(ref _context);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        /// Methods returning a Result<(), _> are the default and do not
        /// need annotations.
        public void MethodResult(uint anon1)
        {
            var rval = Interop.simple_service_method_result(_context, anon1);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public uint MethodValue(uint x)
        {
            return Interop.simple_service_method_value(_context, x);
        }

        /// This method should be documented.
        ///
        /// Multiple lines.
        public void MethodVoid()
        {
            Interop.simple_service_method_void(_context);
        }

        public byte MethodMutSelf(Sliceu8 slice)
        {
            return Interop.simple_service_method_mut_self(_context, slice);
        }

        public byte MethodMutSelf(byte[] slice)
        {
            return Interop.simple_service_method_mut_self(_context, slice);
        }

        /// Single line.
        public void MethodMutSelfVoid(SliceBool slice)
        {
            Interop.simple_service_method_mut_self_void(_context, slice);
        }

        public void MethodMutSelfVoid(Bool[] slice)
        {
            Interop.simple_service_method_mut_self_void(_context, slice);
        }

        public byte MethodMutSelfRef(ref byte x, out byte y)
        {
            return Interop.simple_service_method_mut_self_ref(_context, ref x, out y);
        }

        public byte MethodMutSelfRefSlice(ref byte x, out byte y, Sliceu8 slice)
        {
            return Interop.simple_service_method_mut_self_ref_slice(_context, ref x, out y, slice);
        }

        public byte MethodMutSelfRefSlice(ref byte x, out byte y, byte[] slice)
        {
            return Interop.simple_service_method_mut_self_ref_slice(_context, ref x, out y, slice);
        }

        public byte MethodMutSelfRefSliceLimited(ref byte x, out byte y, Sliceu8 slice, Sliceu8 slice2)
        {
            return Interop.simple_service_method_mut_self_ref_slice_limited(_context, ref x, out y, slice, slice2);
        }

        public byte MethodMutSelfRefSliceLimited(ref byte x, out byte y, byte[] slice, byte[] slice2)
        {
            return Interop.simple_service_method_mut_self_ref_slice_limited(_context, ref x, out y, slice, slice2);
        }

        public void MethodMutSelfFfiError(SliceMutu8 slice)
        {
            var rval = Interop.simple_service_method_mut_self_ffi_error(_context, slice);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public void MethodMutSelfFfiError(byte[] slice)
        {
            Interop.simple_service_method_mut_self_ffi_error(_context, slice);
        }

        public void MethodMutSelfNoError(SliceMutu8 slice)
        {
            var rval = Interop.simple_service_method_mut_self_no_error(_context, slice);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public void MethodMutSelfNoError(byte[] slice)
        {
            Interop.simple_service_method_mut_self_no_error(_context, slice);
        }

        public void MethodVoidFfiError()
        {
            var rval = Interop.simple_service_method_void_ffi_error(_context);
            if (rval != FFIError.Ok)
            {
                throw new Exception($"Something went wrong: {rval}");
            }
        }

        public IntPtr Context => _context;
    }


}
