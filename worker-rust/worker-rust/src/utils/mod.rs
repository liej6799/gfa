pub mod static_name;
pub use self::static_name::ITEM_WORKER;
pub use self::static_name::PURCHASE_WORKER;
pub use self::static_name::VENDOR_WORKER;
pub use self::static_name::SALES_WORKER;
pub use self::static_name::BASE_SALES;
pub use self::static_name::BASE_URLS;

pub mod loader;
pub use self::loader::test_json_file;