# \VendorApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_vendor_batch_insert_post**](VendorApi.md#api_app_vendor_batch_insert_post) | **POST** /api/app/vendor/batch-insert | 
[**api_app_vendor_get**](VendorApi.md#api_app_vendor_get) | **GET** /api/app/vendor | 
[**api_app_vendor_id_delete**](VendorApi.md#api_app_vendor_id_delete) | **DELETE** /api/app/vendor/{id} | 
[**api_app_vendor_id_get**](VendorApi.md#api_app_vendor_id_get) | **GET** /api/app/vendor/{id} | 
[**api_app_vendor_id_put**](VendorApi.md#api_app_vendor_id_put) | **PUT** /api/app/vendor/{id} | 
[**api_app_vendor_no_paged_get**](VendorApi.md#api_app_vendor_no_paged_get) | **GET** /api/app/vendor/no-paged | 
[**api_app_vendor_post**](VendorApi.md#api_app_vendor_post) | **POST** /api/app/vendor | 



## api_app_vendor_batch_insert_post

> api_app_vendor_batch_insert_post(gfa_web_vendors_create_update_vendor_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_vendors_create_update_vendor_dto** | Option<[**Vec<crate::models::GfaWebVendorsCreateUpdateVendorDto>**](gfa_web.Vendors.CreateUpdateVendorDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_vendor_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebVendorsVendorDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_vendor_get(skip_count, max_result_count, sorting)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |
**sorting** | Option<**String**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebVendorsVendorDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Vendors.VendorDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_vendor_id_delete

> api_app_vendor_id_delete(id)


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


## api_app_vendor_id_get

> crate::models::GfaWebVendorsVendorDto api_app_vendor_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebVendorsVendorDto**](gfa_web.Vendors.VendorDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_vendor_id_put

> crate::models::GfaWebVendorsVendorDto api_app_vendor_id_put(id, gfa_web_vendors_create_update_vendor_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_vendors_create_update_vendor_dto** | Option<[**GfaWebVendorsCreateUpdateVendorDto**](GfaWebVendorsCreateUpdateVendorDto.md)> |  |  |

### Return type

[**crate::models::GfaWebVendorsVendorDto**](gfa_web.Vendors.VendorDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_vendor_no_paged_get

> Vec<crate::models::GfaWebVendorsCreateUpdateVendorDto> api_app_vendor_no_paged_get()


### Parameters

This endpoint does not need any parameter.

### Return type

[**Vec<crate::models::GfaWebVendorsCreateUpdateVendorDto>**](gfa_web.Vendors.CreateUpdateVendorDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_vendor_post

> crate::models::GfaWebVendorsVendorDto api_app_vendor_post(gfa_web_vendors_create_update_vendor_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_vendors_create_update_vendor_dto** | Option<[**GfaWebVendorsCreateUpdateVendorDto**](GfaWebVendorsCreateUpdateVendorDto.md)> |  |  |

### Return type

[**crate::models::GfaWebVendorsVendorDto**](gfa_web.Vendors.VendorDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

