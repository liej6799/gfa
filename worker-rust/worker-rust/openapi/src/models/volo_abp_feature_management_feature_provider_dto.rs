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
pub struct VoloAbpFeatureManagementFeatureProviderDto {
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "key", skip_serializing_if = "Option::is_none")]
    pub key: Option<String>,
}

impl VoloAbpFeatureManagementFeatureProviderDto {
    pub fn new() -> VoloAbpFeatureManagementFeatureProviderDto {
        VoloAbpFeatureManagementFeatureProviderDto {
            name: None,
            key: None,
        }
    }
}

