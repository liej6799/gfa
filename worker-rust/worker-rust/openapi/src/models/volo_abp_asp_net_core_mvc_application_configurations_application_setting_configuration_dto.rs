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
pub struct VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationSettingConfigurationDto {
    #[serde(rename = "values", skip_serializing_if = "Option::is_none")]
    pub values: Option<::std::collections::HashMap<String, String>>,
}

impl VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationSettingConfigurationDto {
    pub fn new() -> VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationSettingConfigurationDto {
        VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationSettingConfigurationDto {
            values: None,
        }
    }
}


