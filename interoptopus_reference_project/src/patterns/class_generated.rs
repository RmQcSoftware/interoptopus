use crate::types::FFIError;
use interoptopus::{ffi_function, pattern_class_generated};

mod some_rust_module {
    use interoptopus::ffi_type;

    pub enum Error {
        Bad,
    }

    #[ffi_type(opaque)]
    #[derive(Default)]
    pub struct SimpleClass {
        pub some_value: u32,
    }

    impl SimpleClass {
        pub fn method_result(&self, _: u32) -> Result<(), Error> {
            Ok(())
        }

        pub fn method_value(&self, x: u32) -> u32 {
            x
        }

        pub fn method_mut_self(&mut self, x: u32) -> u32 {
            x
        }
    }
}

impl From<Result<(), some_rust_module::Error>> for FFIError {
    fn from(x: Result<(), some_rust_module::Error>) -> Self {
        match x {
            Ok(_) => Self::Ok,
            Err(some_rust_module::Error::Bad) => Self::Fail,
        }
    }
}

#[ffi_function]
#[no_mangle]
pub extern "C" fn simple_class_extra_method(context: Option<&mut some_rust_module::SimpleClass>) -> u32 {
    0
}

pattern_class_generated!(
    simple_class_pattern,
    some_rust_module::SimpleClass,
    simple_class_create() -> FFIError,
    simple_class_destroy() -> FFIError,
    [
        simple_class_result(x: u32) -> FFIError: method_result,
        simple_class_value(x: u32) -> u32: method_value,
        simple_class_mut_self(x: u32) -> u32: method_mut_self
    ],
    [
        simple_class_extra_method
    ]
);
