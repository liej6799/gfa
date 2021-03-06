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
pub struct VoloAbpTenantManagementTenantUpdateDto {
    #[serde(rename = "extraProperties", skip_serializing_if = "Option::is_none")]
    pub extra_properties: Option<::std::collections::HashMap<String, serde_json::Value>>,
    #[serde(rename = "name")]
    pub name: String,
}

impl VoloAbpTenantManagementTenantUpdateDto {
    pub fn new(name: String) -> VoloAbpTenantManagementTenantUpdateDto {
        VoloAbpTenantManagementTenantUpdateDto {
            extra_properties: None,
            name,
        }
    }
}


