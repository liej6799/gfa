# \EmailSettingsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_setting_management_emailing_get**](EmailSettingsApi.md#api_setting_management_emailing_get) | **GET** /api/setting-management/emailing | 
[**api_setting_management_emailing_post**](EmailSettingsApi.md#api_setting_management_emailing_post) | **POST** /api/setting-management/emailing | 



## api_setting_management_emailing_get

> crate::models::VoloAbpSettingManagementEmailSettingsDto api_setting_management_emailing_get()


### Parameters

This endpoint does not need any parameter.

### Return type

[**crate::models::VoloAbpSettingManagementEmailSettingsDto**](Volo.Abp.SettingManagement.EmailSettingsDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_setting_management_emailing_post

> api_setting_management_emailing_post(volo_abp_setting_management_update_email_settings_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_setting_management_update_email_settings_dto** | Option<[**VoloAbpSettingManagementUpdateEmailSettingsDto**](VoloAbpSettingManagementUpdateEmailSettingsDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

