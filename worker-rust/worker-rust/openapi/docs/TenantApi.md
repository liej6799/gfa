# \TenantApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_multi_tenancy_tenants_get**](TenantApi.md#api_multi_tenancy_tenants_get) | **GET** /api/multi-tenancy/tenants | 
[**api_multi_tenancy_tenants_id_default_connection_string_delete**](TenantApi.md#api_multi_tenancy_tenants_id_default_connection_string_delete) | **DELETE** /api/multi-tenancy/tenants/{id}/default-connection-string | 
[**api_multi_tenancy_tenants_id_default_connection_string_get**](TenantApi.md#api_multi_tenancy_tenants_id_default_connection_string_get) | **GET** /api/multi-tenancy/tenants/{id}/default-connection-string | 
[**api_multi_tenancy_tenants_id_default_connection_string_put**](TenantApi.md#api_multi_tenancy_tenants_id_default_connection_string_put) | **PUT** /api/multi-tenancy/tenants/{id}/default-connection-string | 
[**api_multi_tenancy_tenants_id_delete**](TenantApi.md#api_multi_tenancy_tenants_id_delete) | **DELETE** /api/multi-tenancy/tenants/{id} | 
[**api_multi_tenancy_tenants_id_get**](TenantApi.md#api_multi_tenancy_tenants_id_get) | **GET** /api/multi-tenancy/tenants/{id} | 
[**api_multi_tenancy_tenants_id_put**](TenantApi.md#api_multi_tenancy_tenants_id_put) | **PUT** /api/multi-tenancy/tenants/{id} | 
[**api_multi_tenancy_tenants_post**](TenantApi.md#api_multi_tenancy_tenants_post) | **POST** /api/multi-tenancy/tenants | 



## api_multi_tenancy_tenants_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1VoloAbpTenantManagementTenantDtoVoloAbpTenantManagementApplicationContractsVersion4400CultureneutralPublicKeyTokennull api_multi_tenancy_tenants_get(filter, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**filter** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1VoloAbpTenantManagementTenantDtoVoloAbpTenantManagementApplicationContractsVersion4400CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[Volo.Abp.TenantManagement.TenantDto, Volo.Abp.TenantManagement.Application.Contracts, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_multi_tenancy_tenants_id_default_connection_string_delete

> api_multi_tenancy_tenants_id_default_connection_string_delete(id)


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


## api_multi_tenancy_tenants_id_default_connection_string_get

> String api_multi_tenancy_tenants_id_default_connection_string_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

**String**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_multi_tenancy_tenants_id_default_connection_string_put

> api_multi_tenancy_tenants_id_default_connection_string_put(id, default_connection_string)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**default_connection_string** | Option<**String**> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_multi_tenancy_tenants_id_delete

> api_multi_tenancy_tenants_id_delete(id)


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


## api_multi_tenancy_tenants_id_get

> crate::models::VoloAbpTenantManagementTenantDto api_multi_tenancy_tenants_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpTenantManagementTenantDto**](Volo.Abp.TenantManagement.TenantDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_multi_tenancy_tenants_id_put

> crate::models::VoloAbpTenantManagementTenantDto api_multi_tenancy_tenants_id_put(id, volo_abp_tenant_management_tenant_update_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**volo_abp_tenant_management_tenant_update_dto** | Option<[**VoloAbpTenantManagementTenantUpdateDto**](VoloAbpTenantManagementTenantUpdateDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpTenantManagementTenantDto**](Volo.Abp.TenantManagement.TenantDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_multi_tenancy_tenants_post

> crate::models::VoloAbpTenantManagementTenantDto api_multi_tenancy_tenants_post(volo_abp_tenant_management_tenant_create_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**volo_abp_tenant_management_tenant_create_dto** | Option<[**VoloAbpTenantManagementTenantCreateDto**](VoloAbpTenantManagementTenantCreateDto.md)> |  |  |

### Return type

[**crate::models::VoloAbpTenantManagementTenantDto**](Volo.Abp.TenantManagement.TenantDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

