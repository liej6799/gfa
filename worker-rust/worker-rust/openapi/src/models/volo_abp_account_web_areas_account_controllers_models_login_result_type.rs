/*
 * gfa_web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://openapi-generator.tech
 */


/// 
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum VoloAbpAccountWebAreasAccountControllersModelsLoginResultType {
    #[serde(rename = "1")]
    _1,
    #[serde(rename = "2")]
    _2,
    #[serde(rename = "3")]
    _3,
    #[serde(rename = "4")]
    _4,
    #[serde(rename = "5")]
    _5,

}

impl ToString for VoloAbpAccountWebAreasAccountControllersModelsLoginResultType {
    fn to_string(&self) -> String {
        match self {
            Self::_1 => String::from("1"),
            Self::_2 => String::from("2"),
            Self::_3 => String::from("3"),
            Self::_4 => String::from("4"),
            Self::_5 => String::from("5"),
        }
    }
}

impl Default for VoloAbpAccountWebAreasAccountControllersModelsLoginResultType {
    fn default() -> VoloAbpAccountWebAreasAccountControllersModelsLoginResultType {
        Self::_1
    }
}



