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
pub struct GfaWebConfigsConfigDto {
    #[serde(rename = "id", skip_serializing_if = "Option::is_none")]
    pub id: Option<String>,
    #[serde(rename = "creationTime", skip_serializing_if = "Option::is_none")]
    pub creation_time: Option<String>,
    #[serde(rename = "creatorId", skip_serializing_if = "Option::is_none")]
    pub creator_id: Option<String>,
    #[serde(rename = "lastModificationTime", skip_serializing_if = "Option::is_none")]
    pub last_modification_time: Option<String>,
    #[serde(rename = "lastModifierId", skip_serializing_if = "Option::is_none")]
    pub last_modifier_id: Option<String>,
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "isDaily", skip_serializing_if = "Option::is_none")]
    pub is_daily: Option<bool>,
    #[serde(rename = "isMonthly", skip_serializing_if = "Option::is_none")]
    pub is_monthly: Option<bool>,
    #[serde(rename = "isYearly", skip_serializing_if = "Option::is_none")]
    pub is_yearly: Option<bool>,
    #[serde(rename = "isAll", skip_serializing_if = "Option::is_none")]
    pub is_all: Option<bool>,
    #[serde(rename = "timerInMs", skip_serializing_if = "Option::is_none")]
    pub timer_in_ms: Option<i32>,
}

impl GfaWebConfigsConfigDto {
    pub fn new() -> GfaWebConfigsConfigDto {
        GfaWebConfigsConfigDto {
            id: None,
            creation_time: None,
            creator_id: None,
            last_modification_time: None,
            last_modifier_id: None,
            name: None,
            is_daily: None,
            is_monthly: None,
            is_yearly: None,
            is_all: None,
            timer_in_ms: None,
        }
    }
}


