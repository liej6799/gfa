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
pub struct VoloAbpFeatureManagementUpdateFeaturesDto {
    #[serde(rename = "features", skip_serializing_if = "Option::is_none")]
    pub features: Option<Vec<crate::models::VoloAbpFeatureManagementUpdateFeatureDto>>,
}

impl VoloAbpFeatureManagementUpdateFeaturesDto {
    pub fn new() -> VoloAbpFeatureManagementUpdateFeaturesDto {
        VoloAbpFeatureManagementUpdateFeaturesDto {
            features: None,
        }
    }
}


