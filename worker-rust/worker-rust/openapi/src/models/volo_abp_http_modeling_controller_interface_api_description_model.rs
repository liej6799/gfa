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
pub struct VoloAbpHttpModelingControllerInterfaceApiDescriptionModel {
    #[serde(rename = "type", skip_serializing_if = "Option::is_none")]
    pub _type: Option<String>,
}

impl VoloAbpHttpModelingControllerInterfaceApiDescriptionModel {
    pub fn new() -> VoloAbpHttpModelingControllerInterfaceApiDescriptionModel {
        VoloAbpHttpModelingControllerInterfaceApiDescriptionModel {
            _type: None,
        }
    }
}

