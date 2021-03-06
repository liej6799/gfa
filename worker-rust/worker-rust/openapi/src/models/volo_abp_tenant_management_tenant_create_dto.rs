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
pub struct VoloAbpTenantManagementTenantCreateDto {
    #[serde(rename = "extraProperties", skip_serializing_if = "Option::is_none")]
    pub extra_properties: Option<::std::collections::HashMap<String, serde_json::Value>>,
    #[serde(rename = "name")]
    pub name: String,
    #[serde(rename = "adminEmailAddress")]
    pub admin_email_address: String,
    #[serde(rename = "adminPassword")]
    pub admin_password: String,
}

impl VoloAbpTenantManagementTenantCreateDto {
    pub fn new(name: String, admin_email_address: String, admin_password: String) -> VoloAbpTenantManagementTenantCreateDto {
        VoloAbpTenantManagementTenantCreateDto {
            extra_properties: None,
            name,
            admin_email_address,
            admin_password,
        }
    }
}


