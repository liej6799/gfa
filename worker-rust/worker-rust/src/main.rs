// Scheduler, and trait for .seconds(), .minutes(), etc.
// Import week days and WeekDay
use openapi::apis::{configuration::Configuration, config_api};
use openapi::models::{GfaWebConfigsConfigDto};
use worker_rust::models::sales_model;

use std::time::Duration;
use std::{env, thread};

use worker_rust::models::appconfig::AppConfig;
use worker_rust::utils::{self, loader};
use worker_rust::api::{get_config, push_sales};
#[tokio::main]
async fn main()
{  
  let mut appconfig = AppConfig::default();
    loop
    {
  
      appconfig.base_urls = Some("https://gfaapi.liej6799.xyz".to_owned());
      get_config(&mut appconfig).await;

      println!("Hello{:?}", appconfig.sales_timer);

      // let sales_model: sales_model::Root = loader::test_json_file();
      // push_sales(sales_model).await;

      // println!("{:?}", appconfig.item_timer);
      // thread::sleep(Duration::from_millis(appconfig.item_timer.unwrap_or(1000) as u64));
        
    }
}

