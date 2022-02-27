# \SaleApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_sale_batch_insert_post**](SaleApi.md#api_app_sale_batch_insert_post) | **POST** /api/app/sale/batch-insert | 
[**api_app_sale_get**](SaleApi.md#api_app_sale_get) | **GET** /api/app/sale | 
[**api_app_sale_id_delete**](SaleApi.md#api_app_sale_id_delete) | **DELETE** /api/app/sale/{id} | 
[**api_app_sale_id_get**](SaleApi.md#api_app_sale_id_get) | **GET** /api/app/sale/{id} | 
[**api_app_sale_id_put**](SaleApi.md#api_app_sale_id_put) | **PUT** /api/app/sale/{id} | 
[**api_app_sale_no_paged_get**](SaleApi.md#api_app_sale_no_paged_get) | **GET** /api/app/sale/no-paged | 
[**api_app_sale_post**](SaleApi.md#api_app_sale_post) | **POST** /api/app/sale | 



## api_app_sale_batch_insert_post

> api_app_sale_batch_insert_post(gfa_web_sales_create_update_sale_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_sales_create_update_sale_dto** | Option<[**Vec<crate::models::GfaWebSalesCreateUpdateSaleDto>**](gfa_web.Sales.CreateUpdateSaleDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_sale_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebSalesSaleDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_sale_get(start_date, end_date, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**start_date** | **String** |  | [required] |
**end_date** | **String** |  | [required] |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebSalesSaleDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Sales.SaleDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_sale_id_delete

> api_app_sale_id_delete(id)


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


## api_app_sale_id_get

> crate::models::GfaWebSalesSaleDto api_app_sale_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebSalesSaleDto**](gfa_web.Sales.SaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_sale_id_put

> crate::models::GfaWebSalesSaleDto api_app_sale_id_put(id, gfa_web_sales_create_update_sale_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_sales_create_update_sale_dto** | Option<[**GfaWebSalesCreateUpdateSaleDto**](GfaWebSalesCreateUpdateSaleDto.md)> |  |  |

### Return type

[**crate::models::GfaWebSalesSaleDto**](gfa_web.Sales.SaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_sale_no_paged_get

> Vec<crate::models::GfaWebSalesCreateUpdateSaleDto> api_app_sale_no_paged_get(start_date, end_date, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**start_date** | **String** |  | [required] |
**end_date** | **String** |  | [required] |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**Vec<crate::models::GfaWebSalesCreateUpdateSaleDto>**](gfa_web.Sales.CreateUpdateSaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_sale_post

> crate::models::GfaWebSalesSaleDto api_app_sale_post(gfa_web_sales_create_update_sale_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_sales_create_update_sale_dto** | Option<[**GfaWebSalesCreateUpdateSaleDto**](GfaWebSalesCreateUpdateSaleDto.md)> |  |  |

### Return type

[**crate::models::GfaWebSalesSaleDto**](gfa_web.Sales.SaleDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

