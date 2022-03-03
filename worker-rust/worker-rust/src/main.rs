// Scheduler, and trait for .seconds(), .minutes(), etc.
// Import week days and WeekDay
use openapi::apis::{configuration::Configuration, config_api};
use openapi::models::{GfaWebConfigsConfigDto};
use worker_rust::staticvar;
use std::time::Duration;
use std::{env, thread};

mod loader;

#[tokio::main]
async fn main()
{  
    let mut staticValue = staticvar::Timer::default();
    
    staticValue = networkCall().await;
  
    loop
    {
        println!("Hello");
        loader::test_json_file();
        println!("{:?}", staticValue.item_timer);
        thread::sleep(Duration::from_millis(staticValue.item_timer.unwrap_or(1000) as u64));
        
    }
}

async fn networkCall() -> staticvar::Timer
{
    let mut staticValue = staticvar::Timer::default();


    // Call API
    let mut config = Configuration::default();
    config.base_path = "https://gfaapi.liej6799.xyz".to_owned();
    
    let message = 
    config_api::api_app_config_get(&config, None, None, None).await;


    let result = match message {
        Ok(result) => result,
        Err(error) => panic!("Something went wrong, {:?}", error),
      };
    println!("test");

      let res : Vec<GfaWebConfigsConfigDto> = result.items.unwrap();
      for i in res.iter(){
          if i.name == Some(staticvar::ItemWorker.to_owned())
          {
            *staticValue.item_timer_mut() = i.timer_in_ms;
          }      
          else if i.name == Some(staticvar::PurchaseWorker.to_owned())
          {
            *staticValue.purchase_timer_mut() = i.timer_in_ms;
          }     
          else if i.name == Some(staticvar::SalesWorker.to_owned())
          {
            *staticValue.sales_timer_mut() = i.timer_in_ms;
          }     
          else if i.name == Some(staticvar::VendorWorker.to_owned())
          {
            *staticValue.vendor_timer_mut() = i.timer_in_ms;
          }                
      }
      return staticValue;
}
