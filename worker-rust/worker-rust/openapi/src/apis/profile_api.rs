/*
 * gfa_web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://openapi-generator.tech
 */


use reqwest;

use crate::apis::ResponseContent;
use super::{Error, configuration};


/// struct for typed errors of method [`api_identity_my_profile_change_password_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiIdentityMyProfileChangePasswordPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_identity_my_profile_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiIdentityMyProfileGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_identity_my_profile_put`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiIdentityMyProfilePutError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}


pub async fn api_identity_my_profile_change_password_post(configuration: &configuration::Configuration, volo_abp_identity_change_password_input: Option<crate::models::VoloAbpIdentityChangePasswordInput>) -> Result<(), Error<ApiIdentityMyProfileChangePasswordPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/identity/my-profile/change-password", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&volo_abp_identity_change_password_input);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<ApiIdentityMyProfileChangePasswordPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_identity_my_profile_get(configuration: &configuration::Configuration, ) -> Result<crate::models::VoloAbpIdentityProfileDto, Error<ApiIdentityMyProfileGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/identity/my-profile", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiIdentityMyProfileGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_identity_my_profile_put(configuration: &configuration::Configuration, volo_abp_identity_update_profile_dto: Option<crate::models::VoloAbpIdentityUpdateProfileDto>) -> Result<crate::models::VoloAbpIdentityProfileDto, Error<ApiIdentityMyProfilePutError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/identity/my-profile", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&volo_abp_identity_update_profile_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiIdentityMyProfilePutError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

