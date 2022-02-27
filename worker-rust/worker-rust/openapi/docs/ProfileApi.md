# \ProfileApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_identity_my_profile_change_password_post**](ProfileApi.md#api_identity_my_profile_change_password_post) | **POST** /api/identity/my-profile/change-password | 
[**api_identity_my_profile_get**](ProfileApi.md#api_identity_my_profile_get) | **GET** /api/identity/my-profile | 
[**api_identity_my_profile_put**](ProfileApi.md#api_identity_my_profile_put) | **PUT** /api/identity/my-profile | 



## api_identity_my_profile_change_password_post

> api_identity_my_profile_change_password_post(volo_abp_identity_change_password_input)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_identity_change_password_input** | Option<[**VoloAbpIdentityChangePasswordInput**](VoloAbpIdentityChangePasswordInput.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_my_profile_get

> crate::models::VoloAbpIdentityProfileDto api_identity_my_profile_get()


### Parameters

This endpoint does not need any parameter.

### Return type

[**crate::models::VoloAbpIdentityProfileDto**](Volo.Abp.Identity.ProfileDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_my_profile_put

> crate::models::VoloAbpIdentityProfileDto api_identity_my_profile_put(volo_abp_identity_update_profile_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_identity_update_profile_dto** | Option<[**VoloAbpIdentityUpdateProfileDto**](VoloAbpIdentityUpdateProfileDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpIdentityProfileDto**](Volo.Abp.Identity.ProfileDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

