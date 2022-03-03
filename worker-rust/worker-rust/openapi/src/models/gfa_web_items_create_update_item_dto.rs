/*
 * gfa_web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Default, Serialize, Deserialize)]
pub struct GfaWebItemsCreateUpdateItemDto {
    #[serde(rename = "id", skip_serializing_if = "Option::is_none")]
    pub id: Option<String>,
    #[serde(rename = "creationTime", skip_serializing_if = "Option::is_none")]
    pub creation_time: Option<String>,
    #[serde(rename = "creatorId", skip_serializing_if = "Option::is_none")]
    pub creator_id: Option<String>,
    #[serde(rename = "lastModificationTime", skip_serializing_if = "Option::is_none")]
    pub last_modification_time: Option<String>,
    #[serde(rename = "lastModifierId", skip_serializing_if = "Option::is_none")]
    pub last_modifier_id: Option<String>,
    #[serde(rename = "sourceId")]
    pub source_id: i32,
    #[serde(rename = "name")]
    pub name: String,
    #[serde(rename = "code", skip_serializing_if = "Option::is_none")]
    pub code: Option<String>,
    #[serde(rename = "buyPrice", skip_serializing_if = "Option::is_none")]
    pub buy_price: Option<f64>,
    #[serde(rename = "sellPrice", skip_serializing_if = "Option::is_none")]
    pub sell_price: Option<f64>,
    #[serde(rename = "profitLoss", skip_serializing_if = "Option::is_none")]
    pub profit_loss: Option<f64>,
}

impl GfaWebItemsCreateUpdateItemDto {
    pub fn new(source_id: i32, name: String) -> GfaWebItemsCreateUpdateItemDto {
        GfaWebItemsCreateUpdateItemDto {
            id: None,
            creation_time: None,
            creator_id: None,
            last_modification_time: None,
            last_modifier_id: None,
            source_id,
            name,
            code: None,
            buy_price: None,
            sell_price: None,
            profit_loss: None,
        }
    }
}


