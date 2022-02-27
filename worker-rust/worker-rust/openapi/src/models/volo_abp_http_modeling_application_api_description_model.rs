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
pub struct VoloAbpHttpModelingApplicationApiDescriptionModel {
    #[serde(rename = "modules", skip_serializing_if = "Option::is_none")]
    pub modules: Option<::std::collections::HashMap<String, crate::models::VoloAbpHttpModelingModuleApiDescriptionModel>>,
    #[serde(rename = "types", skip_serializing_if = "Option::is_none")]
    pub types: Option<::std::collections::HashMap<String, crate::models::VoloAbpHttpModelingTypeApiDescriptionModel>>,
}

impl VoloAbpHttpModelingApplicationApiDescriptionModel {
    pub fn new() -> VoloAbpHttpModelingApplicationApiDescriptionModel {
        VoloAbpHttpModelingApplicationApiDescriptionModel {
            modules: None,
            types: None,
        }
    }
}


