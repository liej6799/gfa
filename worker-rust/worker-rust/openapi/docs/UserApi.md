# \UserApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_identity_users_assignable_roles_get**](UserApi.md#api_identity_users_assignable_roles_get) | **GET** /api/identity/users/assignable-roles | 
[**api_identity_users_by_email_email_get**](UserApi.md#api_identity_users_by_email_email_get) | **GET** /api/identity/users/by-email/{email} | 
[**api_identity_users_by_username_user_name_get**](UserApi.md#api_identity_users_by_username_user_name_get) | **GET** /api/identity/users/by-username/{userName} | 
[**api_identity_users_get**](UserApi.md#api_identity_users_get) | **GET** /api/identity/users | 
[**api_identity_users_id_delete**](UserApi.md#api_identity_users_id_delete) | **DELETE** /api/identity/users/{id} | 
[**api_identity_users_id_get**](UserApi.md#api_identity_users_id_get) | **GET** /api/identity/users/{id} | 
[**api_identity_users_id_put**](UserApi.md#api_identity_users_id_put) | **PUT** /api/identity/users/{id} | 
[**api_identity_users_id_roles_get**](UserApi.md#api_identity_users_id_roles_get) | **GET** /api/identity/users/{id}/roles | 
[**api_identity_users_id_roles_put**](UserApi.md#api_identity_users_id_roles_put) | **PUT** /api/identity/users/{id}/roles | 
[**api_identity_users_post**](UserApi.md#api_identity_users_post) | **POST** /api/identity/users | 



## api_identity_users_assignable_roles_get

> crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull api_identity_users_assignable_roles_get()


### Parameters

This endpoint does not need any parameter.

### Return type

[**crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.ListResultDto`1[[Volo.Abp.Identity.IdentityRoleDto, Volo.Abp.Identity.Application.Contracts, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_by_email_email_get

> crate::models::VoloAbpIdentityIdentityUserDto api_identity_users_by_email_email_get(email)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**email** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpIdentityIdentityUserDto**](Volo.Abp.Identity.IdentityUserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_by_username_user_name_get

> crate::models::VoloAbpIdentityIdentityUserDto api_identity_users_by_username_user_name_get(user_name)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**user_name** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpIdentityIdentityUserDto**](Volo.Abp.Identity.IdentityUserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1VoloAbpIdentityIdentityUserDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull api_identity_users_get(filter, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**filter** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1VoloAbpIdentityIdentityUserDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[Volo.Abp.Identity.IdentityUserDto, Volo.Abp.Identity.Application.Contracts, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_id_delete

> api_identity_users_id_delete(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_id_get

> crate::models::VoloAbpIdentityIdentityUserDto api_identity_users_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpIdentityIdentityUserDto**](Volo.Abp.Identity.IdentityUserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_id_put

> crate::models::VoloAbpIdentityIdentityUserDto api_identity_users_id_put(id, volo_abp_identity_identity_user_update_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**volo_abp_identity_identity_user_update_dto** | Option<[**VoloAbpIdentityIdentityUserUpdateDto**](VoloAbpIdentityIdentityUserUpdateDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpIdentityIdentityUserDto**](Volo.Abp.Identity.IdentityUserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_id_roles_get

> crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull api_identity_users_id_roles_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.ListResultDto`1[[Volo.Abp.Identity.IdentityRoleDto, Volo.Abp.Identity.Application.Contracts, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_id_roles_put

> api_identity_users_id_roles_put(id, volo_abp_identity_identity_user_update_roles_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**volo_abp_identity_identity_user_update_roles_dto** | Option<[**VoloAbpIdentityIdentityUserUpdateRolesDto**](VoloAbpIdentityIdentityUserUpdateRolesDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_users_post

> crate::models::VoloAbpIdentityIdentityUserDto api_identity_users_post(volo_abp_identity_identity_user_create_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_identity_identity_user_create_dto** | Option<[**VoloAbpIdentityIdentityUserCreateDto**](VoloAbpIdentityIdentityUserCreateDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpIdentityIdentityUserDto**](Volo.Abp.Identity.IdentityUserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

