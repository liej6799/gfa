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


/// struct for typed errors of method [`api_app_item_batch_insert_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemBatchInsertPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_filter_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemFilterGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_id_delete`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemIdDeleteError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_id_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemIdGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_id_put`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemIdPutError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_no_paged_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemNoPagedGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_item_quantity_tracker_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppItemQuantityTrackerGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}


pub async fn api_app_item_batch_insert_post(configuration: &configuration::Configuration, gfa_web_items_create_update_item_dto: Option<Vec<crate::models::GfaWebItemsCreateUpdateItemDto>>) -> Result<(), Error<ApiAppItemBatchInsertPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/batch-insert", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_items_create_update_item_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<ApiAppItemBatchInsertPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_filter_get(configuration: &configuration::Configuration, filter: Option<&str>, sorting: Option<&str>, skip_count: Option<i32>, max_result_count: Option<i32>) -> Result<crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull, Error<ApiAppItemFilterGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/filter", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_str) = filter {
        local_var_req_builder = local_var_req_builder.query(&[("Filter", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = sorting {
        local_var_req_builder = local_var_req_builder.query(&[("Sorting", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = skip_count {
        local_var_req_builder = local_var_req_builder.query(&[("SkipCount", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = max_result_count {
        local_var_req_builder = local_var_req_builder.query(&[("MaxResultCount", &local_var_str.to_string())]);
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
        let local_var_entity: Option<ApiAppItemFilterGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_get(configuration: &configuration::Configuration, skip_count: Option<i32>, max_result_count: Option<i32>, sorting: Option<&str>) -> Result<crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull, Error<ApiAppItemGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item", local_var_configuration.base_path);
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
        let local_var_entity: Option<ApiAppItemGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_id_delete(configuration: &configuration::Configuration, id: &str) -> Result<(), Error<ApiAppItemIdDeleteError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
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
        let local_var_entity: Option<ApiAppItemIdDeleteError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_id_get(configuration: &configuration::Configuration, id: &str) -> Result<crate::models::GfaWebItemsItemDto, Error<ApiAppItemIdGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
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
        let local_var_entity: Option<ApiAppItemIdGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_id_put(configuration: &configuration::Configuration, id: &str, gfa_web_items_create_update_item_dto: Option<crate::models::GfaWebItemsCreateUpdateItemDto>) -> Result<crate::models::GfaWebItemsItemDto, Error<ApiAppItemIdPutError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_items_create_update_item_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiAppItemIdPutError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_no_paged_get(configuration: &configuration::Configuration, ) -> Result<Vec<crate::models::GfaWebItemsCreateUpdateItemDto>, Error<ApiAppItemNoPagedGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/no-paged", local_var_configuration.base_path);
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
        let local_var_entity: Option<ApiAppItemNoPagedGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_post(configuration: &configuration::Configuration, gfa_web_items_create_update_item_dto: Option<crate::models::GfaWebItemsCreateUpdateItemDto>) -> Result<crate::models::GfaWebItemsItemDto, Error<ApiAppItemPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_items_create_update_item_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiAppItemPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_item_quantity_tracker_get(configuration: &configuration::Configuration, item_id: Option<&str>, sorting: Option<&str>, skip_count: Option<i32>, max_result_count: Option<i32>) -> Result<crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull, Error<ApiAppItemQuantityTrackerGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/item/quantity-tracker", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_str) = item_id {
        local_var_req_builder = local_var_req_builder.query(&[("ItemId", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = sorting {
        local_var_req_builder = local_var_req_builder.query(&[("Sorting", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = skip_count {
        local_var_req_builder = local_var_req_builder.query(&[("SkipCount", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = max_result_count {
        local_var_req_builder = local_var_req_builder.query(&[("MaxResultCount", &local_var_str.to_string())]);
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
        let local_var_entity: Option<ApiAppItemQuantityTrackerGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

