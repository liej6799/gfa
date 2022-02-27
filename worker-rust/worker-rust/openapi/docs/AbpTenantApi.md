# \AbpTenantApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_abp_multi_tenancy_tenants_by_id_id_get**](AbpTenantApi.md#api_abp_multi_tenancy_tenants_by_id_id_get) | **GET** /api/abp/multi-tenancy/tenants/by-id/{id} | 
[**api_abp_multi_tenancy_tenants_by_name_name_get**](AbpTenantApi.md#api_abp_multi_tenancy_tenants_by_name_name_get) | **GET** /api/abp/multi-tenancy/tenants/by-name/{name} | 



## api_abp_multi_tenancy_tenants_by_id_id_get

> crate::models::VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto api_abp_multi_tenancy_tenants_by_id_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto**](Volo.Abp.AspNetCore.Mvc.MultiTenancy.FindTenantResultDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_abp_multi_tenancy_tenants_by_name_name_get

> crate::models::VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto api_abp_multi_tenancy_tenants_by_name_name_get(name)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**name** | **String** |  | [required] |

### Return type

[**crate::models::VoloAbpAspNetCoreMvcMultiTenancyFindTenantResultDto**](Volo.Abp.AspNetCore.Mvc.MultiTenancy.FindTenantResultDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

