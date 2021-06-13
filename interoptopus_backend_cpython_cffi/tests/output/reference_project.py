from cffi import FFI

api_definition = """
// Automatically generated by Interoptopus.



#define C1 1
#define C2 1
#define C3 -100

typedef enum FFIError
    {
    Ok = 0,
    Fail = 200,
    } FFIError;

typedef struct Opaque Opaque;

typedef struct Empty
    {
    } Empty;

typedef struct SomeForeignType
    {
    uint32_t x;
    } SomeForeignType;

typedef struct Vec3f32
    {
    float x;
    float y;
    float z;
    } Vec3f32;

typedef uint8_t (*fptr_fn_u8_rval_u8)(uint8_t x0);


uint8_t callback(fptr_fn_u8_rval_u8 callback, uint8_t value);
FFIError complex_1(Vec3f32 _a, Empty* _b);
Opaque* complex_2(SomeForeignType _cmplx);
bool primitive_bool(bool x);
int16_t primitive_i16(int16_t x);
int32_t primitive_i32(int32_t x);
int64_t primitive_i64(int64_t x);
int8_t primitive_i8(int8_t x);
uint16_t primitive_u16(uint16_t x);
uint32_t primitive_u32(uint32_t x);
uint64_t primitive_u64(uint64_t x);
uint8_t primitive_u8(uint8_t x);
void primitive_void();
void primitive_void2();
int64_t* ptr(int64_t* x);
int64_t* ptr_mut(int64_t* x);
int64_t* ptr_option(int64_t* x);
int64_t* ptr_option_mut(int64_t* x);
int64_t** ptr_ptr(int64_t** x);
int64_t* ptr_simple(int64_t* x);
int64_t* ptr_simple_mut(int64_t* x);
"""


def api_from_dll(dll):
    ffibuilder = FFI()
    ffibuilder.cdef(api_definition)
    return ffibuilder.dlopen(dll)
