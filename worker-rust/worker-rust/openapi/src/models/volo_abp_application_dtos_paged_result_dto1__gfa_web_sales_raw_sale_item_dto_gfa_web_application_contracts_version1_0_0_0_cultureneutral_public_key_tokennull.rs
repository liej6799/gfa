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
pub struct VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull {
    #[serde(rename = "items", skip_serializing_if = "Option::is_none")]
    pub items: Option<Vec<crate::models::GfaWebSalesRawSaleItemDto>>,
    #[serde(rename = "totalCount", skip_serializing_if = "Option::is_none")]
    pub total_count: Option<i64>,
}

impl VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull {
    pub fn new() -> VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull {
        VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull {
            items: None,
            total_count: None,
        }
    }
}


