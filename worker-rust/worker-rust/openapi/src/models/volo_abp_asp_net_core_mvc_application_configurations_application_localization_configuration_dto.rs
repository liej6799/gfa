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
pub struct VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationLocalizationConfigurationDto {
    #[serde(rename = "values", skip_serializing_if = "Option::is_none")]
    pub values: Option<::std::collections::HashMap<String, ::std::collections::HashMap<String, String>>>,
    #[serde(rename = "languages", skip_serializing_if = "Option::is_none")]
    pub languages: Option<Vec<crate::models::VoloAbpLocalizationLanguageInfo>>,
    #[serde(rename = "currentCulture", skip_serializing_if = "Option::is_none")]
    pub current_culture: Option<Box<crate::models::VoloAbpAspNetCoreMvcApplicationConfigurationsCurrentCultureDto>>,
    #[serde(rename = "defaultResourceName", skip_serializing_if = "Option::is_none")]
    pub default_resource_name: Option<String>,
    #[serde(rename = "languagesMap", skip_serializing_if = "Option::is_none")]
    pub languages_map: Option<::std::collections::HashMap<String, Vec<crate::models::VoloAbpNameValue>>>,
    #[serde(rename = "languageFilesMap", skip_serializing_if = "Option::is_none")]
    pub language_files_map: Option<::std::collections::HashMap<String, Vec<crate::models::VoloAbpNameValue>>>,
}

impl VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationLocalizationConfigurationDto {
    pub fn new() -> VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationLocalizationConfigurationDto {
        VoloAbpAspNetCoreMvcApplicationConfigurationsApplicationLocalizationConfigurationDto {
            values: None,
            languages: None,
            current_culture: None,
            default_resource_name: None,
            languages_map: None,
            language_files_map: None,
        }
    }
}


