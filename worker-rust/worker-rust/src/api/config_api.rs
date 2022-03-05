use openapi::{models::GfaWebConfigsConfigDto, apis::{configuration::Configuration, config_api}};

use crate::{models::AppConfig, utils};

pub async fn get_config(appconfig: &mut AppConfig)
{
    // Call API
    let mut config = Configuration::default();
    config.base_path = appconfig.base_urls.to_owned().unwrap();

    let message = config_api::api_app_config_get(&config, None, None, None).await;

    let result = match message {
        Ok(result) => result,
        Err(error) => panic!("Something went wrong, {:?}", error),
        };
    
    let res : Vec<GfaWebConfigsConfigDto> = result.items.unwrap();
    for i in res.iter(){
        if i.name == Some(utils::ITEM_WORKER.to_owned())
        {
        *appconfig.item_timer_mut() =  i.timer_in_ms;
        }      
        else if i.name == Some(utils::PURCHASE_WORKER.to_owned())
        {
        *appconfig.purchase_timer_mut() = i.timer_in_ms;
        }     
        else if i.name == Some(utils::SALES_WORKER.to_owned())
        {
        *appconfig.sales_timer_mut() = i.timer_in_ms;
        }     
        else if i.name == Some(utils::VENDOR_WORKER.to_owned())
        {
        *appconfig.vendor_timer_mut() = i.timer_in_ms;
        }                
    }
}