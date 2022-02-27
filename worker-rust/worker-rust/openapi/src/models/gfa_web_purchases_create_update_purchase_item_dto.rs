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
pub struct GfaWebPurchasesCreateUpdatePurchaseItemDto {
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
    #[serde(rename = "sourceId", skip_serializing_if = "Option::is_none")]
    pub source_id: Option<i32>,
    #[serde(rename = "quantity", skip_serializing_if = "Option::is_none")]
    pub quantity: Option<f64>,
    #[serde(rename = "price", skip_serializing_if = "Option::is_none")]
    pub price: Option<f64>,
    #[serde(rename = "total", skip_serializing_if = "Option::is_none")]
    pub total: Option<f64>,
    #[serde(rename = "itemId", skip_serializing_if = "Option::is_none")]
    pub item_id: Option<String>,
    #[serde(rename = "itemSourceId", skip_serializing_if = "Option::is_none")]
    pub item_source_id: Option<i32>,
    #[serde(rename = "purchaseId", skip_serializing_if = "Option::is_none")]
    pub purchase_id: Option<String>,
    #[serde(rename = "purchaseSourceId", skip_serializing_if = "Option::is_none")]
    pub purchase_source_id: Option<i32>,
}

impl GfaWebPurchasesCreateUpdatePurchaseItemDto {
    pub fn new() -> GfaWebPurchasesCreateUpdatePurchaseItemDto {
        GfaWebPurchasesCreateUpdatePurchaseItemDto {
            id: None,
            creation_time: None,
            creator_id: None,
            last_modification_time: None,
            last_modifier_id: None,
            source_id: None,
            quantity: None,
            price: None,
            total: None,
            item_id: None,
            item_source_id: None,
            purchase_id: None,
            purchase_source_id: None,
        }
    }
}


