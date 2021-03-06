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
pub struct VoloAbpIdentityIdentityUserUpdateRolesDto {
    #[serde(rename = "roleNames")]
    pub role_names: Vec<String>,
}

impl VoloAbpIdentityIdentityUserUpdateRolesDto {
    pub fn new(role_names: Vec<String>) -> VoloAbpIdentityIdentityUserUpdateRolesDto {
        VoloAbpIdentityIdentityUserUpdateRolesDto {
            role_names,
        }
    }
}


