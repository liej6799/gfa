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


/// struct for typed errors of method [`api_app_vendor_batch_insert_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorBatchInsertPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_vendor_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_vendor_id_delete`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorIdDeleteError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_vendor_id_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorIdGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_vendor_id_put`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorIdPutError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_vendor_no_paged_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorNoPagedGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_vendor_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppVendorPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}


pub async fn api_app_vendor_batch_insert_post(configuration: &configuration::Configuration, gfa_web_vendors_create_update_vendor_dto: Option<Vec<crate::models::GfaWebVendorsCreateUpdateVendorDto>>) -> Result<(), Error<ApiAppVendorBatchInsertPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor/batch-insert", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_vendors_create_update_vendor_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<ApiAppVendorBatchInsertPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_vendor_get(configuration: &configuration::Configuration, skip_count: Option<i32>, max_result_count: Option<i32>, sorting: Option<&str>) -> Result<crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebVendorsVendorDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull, Error<ApiAppVendorGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_str) = skip_count {
        local_var_req_builder = local_var_req_builder.query(&[("SkipCount", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = max_result_count {
        local_var_req_builder = local_var_req_builder.query(&[("MaxResultCount", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = sorting {
        local_var_req_builder = local_var_req_builder.query(&[("Sorting", &local_var_str.to_string())]);
    }
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
        let local_var_entity: Option<ApiAppVendorGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_vendor_id_delete(configuration: &configuration::Configuration, id: &str) -> Result<(), Error<ApiAppVendorIdDeleteError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::DELETE, local_var_uri_str.as_str());

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
        Ok(())
    } else {
        let local_var_entity: Option<ApiAppVendorIdDeleteError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_vendor_id_get(configuration: &configuration::Configuration, id: &str) -> Result<crate::models::GfaWebVendorsVendorDto, Error<ApiAppVendorIdGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
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
        let local_var_entity: Option<ApiAppVendorIdGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_vendor_id_put(configuration: &configuration::Configuration, id: &str, gfa_web_vendors_create_update_vendor_dto: Option<crate::models::GfaWebVendorsCreateUpdateVendorDto>) -> Result<crate::models::GfaWebVendorsVendorDto, Error<ApiAppVendorIdPutError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_vendors_create_update_vendor_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiAppVendorIdPutError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_vendor_no_paged_get(configuration: &configuration::Configuration, ) -> Result<Vec<crate::models::GfaWebVendorsCreateUpdateVendorDto>, Error<ApiAppVendorNoPagedGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor/no-paged", local_var_configuration.base_path);
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
        let local_var_entity: Option<ApiAppVendorNoPagedGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_vendor_post(configuration: &configuration::Configuration, gfa_web_vendors_create_update_vendor_dto: Option<crate::models::GfaWebVendorsCreateUpdateVendorDto>) -> Result<crate::models::GfaWebVendorsVendorDto, Error<ApiAppVendorPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/vendor", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_vendors_create_update_vendor_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiAppVendorPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}
