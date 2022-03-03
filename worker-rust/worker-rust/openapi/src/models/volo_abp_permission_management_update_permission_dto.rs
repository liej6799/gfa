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
pub struct VoloAbpPermissionManagementUpdatePermissionDto {
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "isGranted", skip_serializing_if = "Option::is_none")]
    pub is_granted: Option<bool>,
}

impl VoloAbpPermissionManagementUpdatePermissionDto {
    pub fn new() -> VoloAbpPermissionManagementUpdatePermissionDto {
        VoloAbpPermissionManagementUpdatePermissionDto {
            name: None,
            is_granted: None,
        }
    }
}


