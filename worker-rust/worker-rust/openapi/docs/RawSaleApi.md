# \RawSaleApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_raw_sale_batch_insert_post**](RawSaleApi.md#api_app_raw_sale_batch_insert_post) | **POST** /api/app/raw-sale/batch-insert | 
[**api_app_raw_sale_get**](RawSaleApi.md#api_app_raw_sale_get) | **GET** /api/app/raw-sale | 
[**api_app_raw_sale_id_delete**](RawSaleApi.md#api_app_raw_sale_id_delete) | **DELETE** /api/app/raw-sale/{id} | 
[**api_app_raw_sale_id_get**](RawSaleApi.md#api_app_raw_sale_id_get) | **GET** /api/app/raw-sale/{id} | 
[**api_app_raw_sale_id_put**](RawSaleApi.md#api_app_raw_sale_id_put) | **PUT** /api/app/raw-sale/{id} | 
[**api_app_raw_sale_post**](RawSaleApi.md#api_app_raw_sale_post) | **POST** /api/app/raw-sale | 



## api_app_raw_sale_batch_insert_post

> api_app_raw_sale_batch_insert_post(gfa_web_sales_create_update_raw_sale_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_sales_create_update_raw_sale_dto** | Option<[**Vec<crate::models::GfaWebSalesCreateUpdateRawSaleDto>**](gfa_web.Sales.CreateUpdateRawSaleDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_raw_sale_get(start_date, end_date, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**start_date** | **String** |  | [required] |
**end_date** | **String** |  | [required] |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Sales.RawSaleDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_id_delete

> api_app_raw_sale_id_delete(id)


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


## api_app_raw_sale_id_get

> crate::models::GfaWebSalesRawSaleDto api_app_raw_sale_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebSalesRawSaleDto**](gfa_web.Sales.RawSaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_id_put

> crate::models::GfaWebSalesRawSaleDto api_app_raw_sale_id_put(id, gfa_web_sales_create_update_raw_sale_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_sales_create_update_raw_sale_dto** | Option<[**GfaWebSalesCreateUpdateRawSaleDto**](GfaWebSalesCreateUpdateRawSaleDto.md)> |  |  |

### Return type

[**crate::models::GfaWebSalesRawSaleDto**](gfa_web.Sales.RawSaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_post

> crate::models::GfaWebSalesRawSaleDto api_app_raw_sale_post(gfa_web_sales_create_update_raw_sale_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_sales_create_update_raw_sale_dto** | Option<[**GfaWebSalesCreateUpdateRawSaleDto**](GfaWebSalesCreateUpdateRawSaleDto.md)> |  |  |

### Return type

[**crate::models::GfaWebSalesRawSaleDto**](gfa_web.Sales.RawSaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

