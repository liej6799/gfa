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
pub struct VoloAbpAspNetCoreMvcApplicationConfigurationsObjectExtendingExtensionEnumDto {
    #[serde(rename = "fields", skip_serializing_if = "Option::is_none")]
    pub fields: Option<Vec<crate::models::VoloAbpAspNetCoreMvcApplicationConfigurationsObjectExtendingExtensionEnumFieldDto>>,
    #[serde(rename = "localizationResource", skip_serializing_if = "Option::is_none")]
    pub localization_resource: Option<String>,
}

impl VoloAbpAspNetCoreMvcApplicationConfigurationsObjectExtendingExtensionEnumDto {
    pub fn new() -> VoloAbpAspNetCoreMvcApplicationConfigurationsObjectExtendingExtensionEnumDto {
        VoloAbpAspNetCoreMvcApplicationConfigurationsObjectExtendingExtensionEnumDto {
            fields: None,
            localization_resource: None,
        }
    }
}

