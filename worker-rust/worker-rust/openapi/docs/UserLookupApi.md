# \UserLookupApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_identity_users_lookup_by_username_user_name_get**](UserLookupApi.md#api_identity_users_lookup_by_username_user_name_get) | **GET** /api/identity/users/lookup/by-username/{userName} | 
[**api_identity_users_lookup_count_get**](UserLookupApi.md#api_identity_users_lookup_count_get) | **GET** /api/identity/users/lookup/count | 
[**api_identity_users_lookup_id_get**](UserLookupApi.md#api_identity_users_lookup_id_get) | **GET** /api/identity/users/lookup/{id} | 
[**api_identity_users_lookup_search_get**](UserLookupApi.md#api_identity_users_lookup_search_get) | **GET** /api/identity/users/lookup/search | 



## api_identity_users_lookup_by_username_user_name_get

> crate::models::VoloAbpUsersUserData api_identity_users_lookup_by_username_user_name_get(user_name)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**user_name** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpUsersUserData**](Volo.Abp.Users.UserData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_lookup_count_get

> i64 api_identity_users_lookup_count_get(filter)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**filter** | Option<**String**> |  |  |

### Return type

**i64**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_lookup_id_get

> crate::models::VoloAbpUsersUserData api_identity_users_lookup_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpUsersUserData**](Volo.Abp.Users.UserData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_lookup_search_get

> crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpUsersUserDataVoloAbpUsersAbstractionsVersion4400CultureneutralPublicKeyTokennull api_identity_users_lookup_search_get(filter, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**filter** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpUsersUserDataVoloAbpUsersAbstractionsVersion4400CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.ListResultDto`1[[Volo.Abp.Users.UserData, Volo.Abp.Users.Abstractions, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

