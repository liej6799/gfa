use openapi::{models::GfaWebSalesCreateUpdateRawSaleDto, apis::configuration::Configuration};
use openapi::apis::{raw_sale_api};
use crate::{models::sales_model, utils};
use chrono::{NaiveDate, NaiveDateTime};

pub async fn push_sales(root: sales_model::Root)
{
    let mut rawSaleDtoList :Vec<GfaWebSalesCreateUpdateRawSaleDto> = Vec::new();
 
    for i in root.records.iter(){

        let mut tanggal_input: String = i.tanggal.to_owned();
            let jam_input: String = i.jam_input.to_owned();
            tanggal_input.push_str(" ");
            tanggal_input.push_str(&jam_input);

            rawSaleDtoList.push(GfaWebSalesCreateUpdateRawSaleDto {
                source_id : Some(i.id.to_owned() as i32),
                date_sales : Some(tanggal_input),
                total_cash : Some(i.lunas),
                total_change : Some(i.lunas - i.tot_harga),
                total_amount : Some(i.tot_harga),
                id: None,
                creation_time: None,
                creator_id: None,
                last_modification_time: None,
                last_modifier_id: None
            });
    }

    // Call API
    let mut config = Configuration::default();
    config.base_path = utils::BASE_URLS.to_owned();

    println!("Sending");

    let result = raw_sale_api::api_app_raw_sale_batch_insert_post(&config, Some(rawSaleDtoList)).await;
  
    match result {
        Ok(_) => { println!("OK"); },
        Err(error) => panic!("Something went wrong, {:?}", error),
    }
}
