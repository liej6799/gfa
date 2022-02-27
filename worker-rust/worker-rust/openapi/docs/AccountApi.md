# \AccountApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_account_register_post**](AccountApi.md#api_account_register_post) | **POST** /api/account/register | 
[**api_account_reset_password_post**](AccountApi.md#api_account_reset_password_post) | **POST** /api/account/reset-password | 
[**api_account_send_password_reset_code_post**](AccountApi.md#api_account_send_password_reset_code_post) | **POST** /api/account/send-password-reset-code | 



## api_account_register_post

> crate::models::VoloAbpIdentityIdentityUserDto api_account_register_post(volo_abp_account_register_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_account_register_dto** | Option<[**VoloAbpAccountRegisterDto**](VoloAbpAccountRegisterDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpIdentityIdentityUserDto**](Volo.Abp.Identity.IdentityUserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_account_reset_password_post

> api_account_reset_password_post(volo_abp_account_reset_password_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_account_reset_password_dto** | Option<[**VoloAbpAccountResetPasswordDto**](VoloAbpAccountResetPasswordDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_account_send_password_reset_code_post

> api_account_send_password_reset_code_post(volo_abp_account_send_password_reset_code_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_account_send_password_reset_code_dto** | Option<[**VoloAbpAccountSendPasswordResetCodeDto**](VoloAbpAccountSendPasswordResetCodeDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

