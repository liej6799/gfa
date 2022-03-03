// Scheduler, and trait for .seconds(), .minutes(), etc.
// Import week days and WeekDay
use openapi::apis::{configuration::Configuration, config_api};
use openapi::models::{GfaWebConfigsConfigDto};
use worker_rust::models::sales_model;

use std::time::Duration;
use std::{env, thread};

use worker_rust::models::timer::Timer;
use worker_rust::utils::{self, loader};
use worker_rust::api;
#[tokio::main]
async fn main()
{  
    let mut staticValue = Timer::default();
    
    staticValue = networkCall().await;
  
    loop
    {
        println!("Hello");

        let sales_model: sales_model::Root = loader::test_json_file();
        api::push_sales(sales_model).await;

        println!("{:?}", staticValue.item_timer);
        thread::sleep(Duration::from_millis(staticValue.item_timer.unwrap_or(1000) as u64));
        
    }
}

async fn networkCall() -> Timer
{
    let mut staticValue = Timer::default();


    // Call API
    let mut config = Configuration::default();
    config.base_path = utils::BASE_URLS.to_owned();
    
    let message = 
    config_api::api_app_config_get(&config, None, None, None).await;


    let result = match message {
        Ok(result) => result,
        Err(error) => panic!("Something went wrong, {:?}", error),
      };
    println!("test");

      let res : Vec<GfaWebConfigsConfigDto> = result.items.unwrap();
      for i in res.iter(){
          if i.name == Some(utils::ITEM_WORKER.to_owned())
          {
            *staticValue.item_timer_mut() = i.timer_in_ms;
          }      
          else if i.name == Some(utils::PURCHASE_WORKER.to_owned())
          {
            *staticValue.purchase_timer_mut() = i.timer_in_ms;
          }     
          else if i.name == Some(utils::SALES_WORKER.to_owned())
          {
            *staticValue.sales_timer_mut() = i.timer_in_ms;
          }     
          else if i.name == Some(utils::VENDOR_WORKER.to_owned())
          {
            *staticValue.vendor_timer_mut() = i.timer_in_ms;
          }                
      }
      return staticValue;
}
