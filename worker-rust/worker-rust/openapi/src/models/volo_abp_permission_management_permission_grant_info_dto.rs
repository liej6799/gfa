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
pub struct VoloAbpPermissionManagementPermissionGrantInfoDto {
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "displayName", skip_serializing_if = "Option::is_none")]
    pub display_name: Option<String>,
    #[serde(rename = "parentName", skip_serializing_if = "Option::is_none")]
    pub parent_name: Option<String>,
    #[serde(rename = "isGranted", skip_serializing_if = "Option::is_none")]
    pub is_granted: Option<bool>,
    #[serde(rename = "allowedProviders", skip_serializing_if = "Option::is_none")]
    pub allowed_providers: Option<Vec<String>>,
    #[serde(rename = "grantedProviders", skip_serializing_if = "Option::is_none")]
    pub granted_providers: Option<Vec<crate::models::VoloAbpPermissionManagementProviderInfoDto>>,
}

impl VoloAbpPermissionManagementPermissionGrantInfoDto {
    pub fn new() -> VoloAbpPermissionManagementPermissionGrantInfoDto {
        VoloAbpPermissionManagementPermissionGrantInfoDto {
            name: None,
            display_name: None,
            parent_name: None,
            is_granted: None,
            allowed_providers: None,
            granted_providers: None,
        }
    }
}


