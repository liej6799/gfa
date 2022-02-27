# \ItemApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_item_batch_insert_post**](ItemApi.md#api_app_item_batch_insert_post) | **POST** /api/app/item/batch-insert | 
[**api_app_item_filter_get**](ItemApi.md#api_app_item_filter_get) | **GET** /api/app/item/filter | 
[**api_app_item_get**](ItemApi.md#api_app_item_get) | **GET** /api/app/item | 
[**api_app_item_id_delete**](ItemApi.md#api_app_item_id_delete) | **DELETE** /api/app/item/{id} | 
[**api_app_item_id_get**](ItemApi.md#api_app_item_id_get) | **GET** /api/app/item/{id} | 
[**api_app_item_id_put**](ItemApi.md#api_app_item_id_put) | **PUT** /api/app/item/{id} | 
[**api_app_item_no_paged_get**](ItemApi.md#api_app_item_no_paged_get) | **GET** /api/app/item/no-paged | 
[**api_app_item_post**](ItemApi.md#api_app_item_post) | **POST** /api/app/item | 
[**api_app_item_quantity_tracker_get**](ItemApi.md#api_app_item_quantity_tracker_get) | **GET** /api/app/item/quantity-tracker | 



## api_app_item_batch_insert_post

> api_app_item_batch_insert_post(gfa_web_items_create_update_item_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_items_create_update_item_dto** | Option<[**Vec<crate::models::GfaWebItemsCreateUpdateItemDto>**](gfa_web.Items.CreateUpdateItemDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_filter_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_item_filter_get(filter, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**filter** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Items.ItemDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_item_get(skip_count, max_result_count, sorting)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |
**sorting** | Option<**String**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Items.ItemDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_id_delete

> api_app_item_id_delete(id)


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


## api_app_item_id_get

> crate::models::GfaWebItemsItemDto api_app_item_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebItemsItemDto**](gfa_web.Items.ItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_id_put

> crate::models::GfaWebItemsItemDto api_app_item_id_put(id, gfa_web_items_create_update_item_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_items_create_update_item_dto** | Option<[**GfaWebItemsCreateUpdateItemDto**](GfaWebItemsCreateUpdateItemDto.md)> |  |  |

### Return type

[**crate::models::GfaWebItemsItemDto**](gfa_web.Items.ItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_no_paged_get

> Vec<crate::models::GfaWebItemsCreateUpdateItemDto> api_app_item_no_paged_get()


### Parameters

This endpoint does not need any parameter.

### Return type

[**Vec<crate::models::GfaWebItemsCreateUpdateItemDto>**](gfa_web.Items.CreateUpdateItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_post

> crate::models::GfaWebItemsItemDto api_app_item_post(gfa_web_items_create_update_item_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_items_create_update_item_dto** | Option<[**GfaWebItemsCreateUpdateItemDto**](GfaWebItemsCreateUpdateItemDto.md)> |  |  |

### Return type

[**crate::models::GfaWebItemsItemDto**](gfa_web.Items.ItemDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_item_quantity_tracker_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_item_quantity_tracker_get(item_id, sorting, skip_count, max_result_count)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**item_id** | Option<**String**> |  |  |
**sorting** | Option<**String**> |  |  |
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebItemsItemDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Items.ItemDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

