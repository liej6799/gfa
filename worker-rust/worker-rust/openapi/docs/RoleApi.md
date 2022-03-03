# \RoleApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_identity_roles_all_get**](RoleApi.md#api_identity_roles_all_get) | **GET** /api/identity/roles/all | 
[**api_identity_roles_get**](RoleApi.md#api_identity_roles_get) | **GET** /api/identity/roles | 
[**api_identity_roles_id_delete**](RoleApi.md#api_identity_roles_id_delete) | **DELETE** /api/identity/roles/{id} | 
[**api_identity_roles_id_get**](RoleApi.md#api_identity_roles_id_get) | **GET** /api/identity/roles/{id} | 
[**api_identity_roles_id_put**](RoleApi.md#api_identity_roles_id_put) | **PUT** /api/identity/roles/{id} | 
[**api_identity_roles_post**](RoleApi.md#api_identity_roles_post) | **POST** /api/identity/roles | 



## api_identity_roles_all_get

> crate::models::VoloAbpApplicationDtosListResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull api_identity_roles_all_get()


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


## api_identity_roles_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull api_identity_roles_get(filter, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**filter** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1VoloAbpIdentityIdentityRoleDtoVoloAbpIdentityApplicationContractsVersion4400CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[Volo.Abp.Identity.IdentityRoleDto, Volo.Abp.Identity.Application.Contracts, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_roles_id_delete

> api_identity_roles_id_delete(id)


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


## api_identity_roles_id_get

> crate::models::VoloAbpIdentityIdentityRoleDto api_identity_roles_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpIdentityIdentityRoleDto**](Volo.Abp.Identity.IdentityRoleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_roles_id_put

> crate::models::VoloAbpIdentityIdentityRoleDto api_identity_roles_id_put(id, volo_abp_identity_identity_role_update_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**volo_abp_identity_identity_role_update_dto** | Option<[**VoloAbpIdentityIdentityRoleUpdateDto**](VoloAbpIdentityIdentityRoleUpdateDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpIdentityIdentityRoleDto**](Volo.Abp.Identity.IdentityRoleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_identity_roles_post

> crate::models::VoloAbpIdentityIdentityRoleDto api_identity_roles_post(volo_abp_identity_identity_role_create_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_identity_identity_role_create_dto** | Option<[**VoloAbpIdentityIdentityRoleCreateDto**](VoloAbpIdentityIdentityRoleCreateDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpIdentityIdentityRoleDto**](Volo.Abp.Identity.IdentityRoleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

