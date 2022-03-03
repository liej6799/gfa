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


/// struct for typed errors of method [`api_app_purchase_item_batch_insert_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemBatchInsertPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_id_delete`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemIdDeleteError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_id_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemIdGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_id_put`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemIdPutError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_item_history_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemItemHistoryGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_no_paged_get`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemNoPagedGetError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`api_app_purchase_item_post`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ApiAppPurchaseItemPostError {
    Status403(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status401(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status400(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status404(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status501(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    Status500(crate::models::VoloAbpHttpRemoteServiceErrorResponse),
    UnknownValue(serde_json::Value),
}


pub async fn api_app_purchase_item_batch_insert_post(configuration: &configuration::Configuration, gfa_web_purchases_create_update_purchase_item_dto: Option<Vec<crate::models::GfaWebPurchasesCreateUpdatePurchaseItemDto>>) -> Result<(), Error<ApiAppPurchaseItemBatchInsertPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item/batch-insert", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_purchases_create_update_purchase_item_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<ApiAppPurchaseItemBatchInsertPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_get(configuration: &configuration::Configuration, purchase_id: Option<&str>, filter: Option<&str>, sorting: Option<&str>, skip_count: Option<i32>, max_result_count: Option<i32>) -> Result<crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebPurchasesPurchaseItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull, Error<ApiAppPurchaseItemGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_str) = purchase_id {
        local_var_req_builder = local_var_req_builder.query(&[("PurchaseId", &local_var_str.to_string())]);
    }
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
        let local_var_entity: Option<ApiAppPurchaseItemGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_id_delete(configuration: &configuration::Configuration, id: &str) -> Result<(), Error<ApiAppPurchaseItemIdDeleteError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
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
        let local_var_entity: Option<ApiAppPurchaseItemIdDeleteError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_id_get(configuration: &configuration::Configuration, id: &str) -> Result<crate::models::GfaWebPurchasesPurchaseItemDto, Error<ApiAppPurchaseItemIdGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
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
        let local_var_entity: Option<ApiAppPurchaseItemIdGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_id_put(configuration: &configuration::Configuration, id: &str, gfa_web_purchases_create_update_purchase_item_dto: Option<crate::models::GfaWebPurchasesCreateUpdatePurchaseItemDto>) -> Result<crate::models::GfaWebPurchasesPurchaseItemDto, Error<ApiAppPurchaseItemIdPutError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item/{id}", local_var_configuration.base_path, id=crate::apis::urlencode(id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_purchases_create_update_purchase_item_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiAppPurchaseItemIdPutError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_item_history_get(configuration: &configuration::Configuration, item_id: Option<&str>, sorting: Option<&str>, skip_count: Option<i32>, max_result_count: Option<i32>) -> Result<crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebPurchasesPurchaseItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull, Error<ApiAppPurchaseItemItemHistoryGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item/item-history", local_var_configuration.base_path);
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
        let local_var_entity: Option<ApiAppPurchaseItemItemHistoryGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_no_paged_get(configuration: &configuration::Configuration, start_date: String, end_date: String, sorting: Option<&str>, skip_count: Option<i32>, max_result_count: Option<i32>) -> Result<Vec<crate::models::GfaWebPurchasesCreateUpdatePurchaseItemDto>, Error<ApiAppPurchaseItemNoPagedGetError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item/no-paged", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    local_var_req_builder = local_var_req_builder.query(&[("StartDate", &start_date.to_string())]);
    local_var_req_builder = local_var_req_builder.query(&[("EndDate", &end_date.to_string())]);
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
        let local_var_entity: Option<ApiAppPurchaseItemNoPagedGetError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn api_app_purchase_item_post(configuration: &configuration::Configuration, gfa_web_purchases_create_update_purchase_item_dto: Option<crate::models::GfaWebPurchasesCreateUpdatePurchaseItemDto>) -> Result<crate::models::GfaWebPurchasesPurchaseItemDto, Error<ApiAppPurchaseItemPostError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/app/purchase-item", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = local_var_configuration.oauth_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&gfa_web_purchases_create_update_purchase_item_dto);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ApiAppPurchaseItemPostError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

