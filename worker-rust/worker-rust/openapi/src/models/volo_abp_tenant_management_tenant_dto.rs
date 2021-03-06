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
pub struct VoloAbpTenantManagementTenantDto {
    #[serde(rename = "extraProperties", skip_serializing_if = "Option::is_none")]
    pub extra_properties: Option<::std::collections::HashMap<String, serde_json::Value>>,
    #[serde(rename = "id", skip_serializing_if = "Option::is_none")]
    pub id: Option<String>,
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
}

impl VoloAbpTenantManagementTenantDto {
    pub fn new() -> VoloAbpTenantManagementTenantDto {
        VoloAbpTenantManagementTenantDto {
            extra_properties: None,
            id: None,
            name: None,
        }
    }
}


