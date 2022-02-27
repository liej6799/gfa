# \RawSaleItemApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_raw_sale_item_batch_insert_post**](RawSaleItemApi.md#api_app_raw_sale_item_batch_insert_post) | **POST** /api/app/raw-sale-item/batch-insert | 
[**api_app_raw_sale_item_get**](RawSaleItemApi.md#api_app_raw_sale_item_get) | **GET** /api/app/raw-sale-item | 
[**api_app_raw_sale_item_id_delete**](RawSaleItemApi.md#api_app_raw_sale_item_id_delete) | **DELETE** /api/app/raw-sale-item/{id} | 
[**api_app_raw_sale_item_id_get**](RawSaleItemApi.md#api_app_raw_sale_item_id_get) | **GET** /api/app/raw-sale-item/{id} | 
[**api_app_raw_sale_item_id_put**](RawSaleItemApi.md#api_app_raw_sale_item_id_put) | **PUT** /api/app/raw-sale-item/{id} | 
[**api_app_raw_sale_item_post**](RawSaleItemApi.md#api_app_raw_sale_item_post) | **POST** /api/app/raw-sale-item | 



## api_app_raw_sale_item_batch_insert_post

> api_app_raw_sale_item_batch_insert_post(gfa_web_sales_create_update_raw_sale_item_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_sales_create_update_raw_sale_item_dto** | Option<[**Vec<crate::models::GfaWebSalesCreateUpdateRawSaleItemDto>**](gfa_web.Sales.CreateUpdateRawSaleItemDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_item_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_raw_sale_item_get(sale_id, filter, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**sale_id** | Option<**String**> |  |  |
**filter** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebSalesRawSaleItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Sales.RawSaleItemDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_item_id_delete

> api_app_raw_sale_item_id_delete(id)


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


## api_app_raw_sale_item_id_get

> crate::models::GfaWebSalesRawSaleItemDto api_app_raw_sale_item_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebSalesRawSaleItemDto**](gfa_web.Sales.RawSaleItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_item_id_put

> crate::models::GfaWebSalesRawSaleItemDto api_app_raw_sale_item_id_put(id, gfa_web_sales_create_update_raw_sale_item_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_sales_create_update_raw_sale_item_dto** | Option<[**GfaWebSalesCreateUpdateRawSaleItemDto**](GfaWebSalesCreateUpdateRawSaleItemDto.md)> |  |  |

### Return type

[**crate::models::GfaWebSalesRawSaleItemDto**](gfa_web.Sales.RawSaleItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_raw_sale_item_post

> crate::models::GfaWebSalesRawSaleItemDto api_app_raw_sale_item_post(gfa_web_sales_create_update_raw_sale_item_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_sales_create_update_raw_sale_item_dto** | Option<[**GfaWebSalesCreateUpdateRawSaleItemDto**](GfaWebSalesCreateUpdateRawSaleItemDto.md)> |  |  |

### Return type

[**crate::models::GfaWebSalesRawSaleItemDto**](gfa_web.Sales.RawSaleItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

