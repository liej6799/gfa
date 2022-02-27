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
pub struct VoloAbpLocalizationLanguageInfo {
    #[serde(rename = "cultureName", skip_serializing_if = "Option::is_none")]
    pub culture_name: Option<String>,
    #[serde(rename = "uiCultureName", skip_serializing_if = "Option::is_none")]
    pub ui_culture_name: Option<String>,
    #[serde(rename = "displayName", skip_serializing_if = "Option::is_none")]
    pub display_name: Option<String>,
    #[serde(rename = "flagIcon", skip_serializing_if = "Option::is_none")]
    pub flag_icon: Option<String>,
}

impl VoloAbpLocalizationLanguageInfo {
    pub fn new() -> VoloAbpLocalizationLanguageInfo {
        VoloAbpLocalizationLanguageInfo {
            culture_name: None,
            ui_culture_name: None,
            display_name: None,
            flag_icon: None,
        }
    }
}


