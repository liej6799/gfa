# \PurchaseApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_purchase_batch_insert_post**](PurchaseApi.md#api_app_purchase_batch_insert_post) | **POST** /api/app/purchase/batch-insert | 
[**api_app_purchase_get**](PurchaseApi.md#api_app_purchase_get) | **GET** /api/app/purchase | 
[**api_app_purchase_id_delete**](PurchaseApi.md#api_app_purchase_id_delete) | **DELETE** /api/app/purchase/{id} | 
[**api_app_purchase_id_get**](PurchaseApi.md#api_app_purchase_id_get) | **GET** /api/app/purchase/{id} | 
[**api_app_purchase_id_put**](PurchaseApi.md#api_app_purchase_id_put) | **PUT** /api/app/purchase/{id} | 
[**api_app_purchase_no_paged_get**](PurchaseApi.md#api_app_purchase_no_paged_get) | **GET** /api/app/purchase/no-paged | 
[**api_app_purchase_post**](PurchaseApi.md#api_app_purchase_post) | **POST** /api/app/purchase | 



## api_app_purchase_batch_insert_post

> api_app_purchase_batch_insert_post(gfa_web_purchases_create_update_purchase_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_purchases_create_update_purchase_dto** | Option<[**Vec<crate::models::GfaWebPurchasesCreateUpdatePurchaseDto>**](gfa_web.Purchases.CreateUpdatePurchaseDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_purchase_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebPurchasesPurchaseDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_purchase_get(start_date, end_date, group_by, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**start_date** | **String** |  | [required] |
**end_date** | **String** |  | [required] |
**group_by** | Option<[**crate::models::GfaWebPurchasesPurchaseGroup**](.md)> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebPurchasesPurchaseDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Purchases.PurchaseDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_purchase_id_delete

> api_app_purchase_id_delete(id)


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


## api_app_purchase_id_get

> crate::models::GfaWebPurchasesPurchaseDto api_app_purchase_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebPurchasesPurchaseDto**](gfa_web.Purchases.PurchaseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_purchase_id_put

> crate::models::GfaWebPurchasesPurchaseDto api_app_purchase_id_put(id, gfa_web_purchases_create_update_purchase_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_purchases_create_update_purchase_dto** | Option<[**GfaWebPurchasesCreateUpdatePurchaseDto**](GfaWebPurchasesCreateUpdatePurchaseDto.md)> |  |  |

### Return type

[**crate::models::GfaWebPurchasesPurchaseDto**](gfa_web.Purchases.PurchaseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_purchase_no_paged_get

> Vec<crate::models::GfaWebPurchasesCreateUpdatePurchaseDto> api_app_purchase_no_paged_get(start_date, end_date, group_by, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**start_date** | **String** |  | [required] |
**end_date** | **String** |  | [required] |
**group_by** | Option<[**crate::models::GfaWebPurchasesPurchaseGroup**](.md)> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**Vec<crate::models::GfaWebPurchasesCreateUpdatePurchaseDto>**](gfa_web.Purchases.CreateUpdatePurchaseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_purchase_post

> crate::models::GfaWebPurchasesPurchaseDto api_app_purchase_post(gfa_web_purchases_create_update_purchase_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_purchases_create_update_purchase_dto** | Option<[**GfaWebPurchasesCreateUpdatePurchaseDto**](GfaWebPurchasesCreateUpdatePurchaseDto.md)> |  |  |

### Return type

[**crate::models::GfaWebPurchasesPurchaseDto**](gfa_web.Purchases.PurchaseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

