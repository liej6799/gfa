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
pub struct VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto {
    #[serde(rename = "success", skip_serializing_if = "Option::is_none")]
    pub success: Option<bool>,
    #[serde(rename = "tenantId", skip_serializing_if = "Option::is_none")]
    pub tenant_id: Option<String>,
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "isActive", skip_serializing_if = "Option::is_none")]
    pub is_active: Option<bool>,
}

impl VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto {
    pub fn new() -> VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto {
        VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto {
            success: None,
            tenant_id: None,
            name: None,
            is_active: None,
        }
    }
}


