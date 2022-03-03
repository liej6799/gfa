use std::{fs::File, io::Read};

use crate::{utils, models::sales_model};



// Use this test_json for development only, when release should not use this.
pub fn test_json_file() -> sales_model::Root
{
    let sample_directory: String = std::env::current_dir().unwrap().to_str().unwrap().to_string() + "/sample/";
    let sample_base_sales = sample_directory + utils::BASE_SALES;
    let mut file = File::open(sample_base_sales).unwrap();
    let mut data = String::new();

    file.read_to_string(&mut data).unwrap();
    let sales_model: sales_model::Root  = serde_json::from_str(data.as_str()).unwrap();

    return sales_model;
}