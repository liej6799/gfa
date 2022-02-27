# \LoginApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_account_check_password_post**](LoginApi.md#api_account_check_password_post) | **POST** /api/account/check-password | 
[**api_account_login_post**](LoginApi.md#api_account_login_post) | **POST** /api/account/login | 
[**api_account_logout_get**](LoginApi.md#api_account_logout_get) | **GET** /api/account/logout | 



## api_account_check_password_post

> crate::models::VoloAbpAccountWebAreasAccountControllersModelsAbpLoginResult api_account_check_password_post(volo_abp_account_web_areas_account_controllers_models_user_login_info)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_account_web_areas_account_controllers_models_user_login_info** | Option<[**VoloAbpAccountWebAreasAccountControllersModelsUserLoginInfo**](VoloAbpAccountWebAreasAccountControllersModelsUserLoginInfo.md)> |  |  |

### Return type

[**crate::models::VoloAbpAccountWebAreasAccountControllersModelsAbpLoginResult**](Volo.Abp.Account.Web.Areas.Account.Controllers.Models.AbpLoginResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_account_login_post

> crate::models::VoloAbpAccountWebAreasAccountControllersModelsAbpLoginResult api_account_login_post(volo_abp_account_web_areas_account_controllers_models_user_login_info)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_account_web_areas_account_controllers_models_user_login_info** | Option<[**VoloAbpAccountWebAreasAccountControllersModelsUserLoginInfo**](VoloAbpAccountWebAreasAccountControllersModelsUserLoginInfo.md)> |  |  |

### Return type

[**crate::models::VoloAbpAccountWebAreasAccountControllersModelsAbpLoginResult**](Volo.Abp.Account.Web.Areas.Account.Controllers.Models.AbpLoginResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_account_logout_get

> api_account_logout_get()


### Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

