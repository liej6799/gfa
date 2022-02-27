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
pub struct VoloAbpAspNetCoreMvcApplicationConfigurationsIanaTimeZone {
    #[serde(rename = "timeZoneName", skip_serializing_if = "Option::is_none")]
    pub time_zone_name: Option<String>,
}

impl VoloAbpAspNetCoreMvcApplicationConfigurationsIanaTimeZone {
    pub fn new() -> VoloAbpAspNetCoreMvcApplicationConfigurationsIanaTimeZone {
        VoloAbpAspNetCoreMvcApplicationConfigurationsIanaTimeZone {
            time_zone_name: None,
        }
    }
}


