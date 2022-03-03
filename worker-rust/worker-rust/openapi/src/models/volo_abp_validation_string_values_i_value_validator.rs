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
pub struct VoloAbpValidationStringValuesIValueValidator {
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "properties", skip_serializing_if = "Option::is_none")]
    pub properties: Option<::std::collections::HashMap<String, serde_json::Value>>,
}

impl VoloAbpValidationStringValuesIValueValidator {
    pub fn new() -> VoloAbpValidationStringValuesIValueValidator {
        VoloAbpValidationStringValuesIValueValidator {
            name: None,
            properties: None,
        }
    }
}

