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
pub struct VoloAbpAspNetCoreMvcApplicationConfigurationsDateTimeFormatDto {
    #[serde(rename = "calendarAlgorithmType", skip_serializing_if = "Option::is_none")]
    pub calendar_algorithm_type: Option<String>,
    #[serde(rename = "dateTimeFormatLong", skip_serializing_if = "Option::is_none")]
    pub date_time_format_long: Option<String>,
    #[serde(rename = "shortDatePattern", skip_serializing_if = "Option::is_none")]
    pub short_date_pattern: Option<String>,
    #[serde(rename = "fullDateTimePattern", skip_serializing_if = "Option::is_none")]
    pub full_date_time_pattern: Option<String>,
    #[serde(rename = "dateSeparator", skip_serializing_if = "Option::is_none")]
    pub date_separator: Option<String>,
    #[serde(rename = "shortTimePattern", skip_serializing_if = "Option::is_none")]
    pub short_time_pattern: Option<String>,
    #[serde(rename = "longTimePattern", skip_serializing_if = "Option::is_none")]
    pub long_time_pattern: Option<String>,
}

impl VoloAbpAspNetCoreMvcApplicationConfigurationsDateTimeFormatDto {
    pub fn new() -> VoloAbpAspNetCoreMvcApplicationConfigurationsDateTimeFormatDto {
        VoloAbpAspNetCoreMvcApplicationConfigurationsDateTimeFormatDto {
            calendar_algorithm_type: None,
            date_time_format_long: None,
            short_date_pattern: None,
            full_date_time_pattern: None,
            date_separator: None,
            short_time_pattern: None,
            long_time_pattern: None,
        }
    }
}


