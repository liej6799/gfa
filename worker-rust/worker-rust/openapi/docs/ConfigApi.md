# \ConfigApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_app_config_get**](ConfigApi.md#api_app_config_get) | **GET** /api/app/config | 
[**api_app_config_id_delete**](ConfigApi.md#api_app_config_id_delete) | **DELETE** /api/app/config/{id} | 
[**api_app_config_id_get**](ConfigApi.md#api_app_config_id_get) | **GET** /api/app/config/{id} | 
[**api_app_config_id_put**](ConfigApi.md#api_app_config_id_put) | **PUT** /api/app/config/{id} | 
[**api_app_config_post**](ConfigApi.md#api_app_config_post) | **POST** /api/app/config | 



## api_app_config_get

> crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebConfigsConfigDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull api_app_config_get(skip_count, max_result_count, sorting)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**skip_count** | Option<**i32**> |  |  |
**max_result_count** | Option<**i32**> |  |  |
**sorting** | Option<**String**> |  |  |

### Return type

[**crate::models::VoloAbpApplicationDtosPagedResultDto1GfaWebConfigsConfigDtoGfaWebApplicationContractsVersion1000CultureneutralPublicKeyTokennull**](Volo.Abp.Application.Dtos.PagedResultDto`1[[gfa_web.Configs.ConfigDto, gfa_web.Application.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_config_id_delete

> api_app_config_id_delete(id)


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


## api_app_config_id_get

> crate::models::GfaWebConfigsConfigDto api_app_config_id_get(id)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |

### Return type

[**crate::models::GfaWebConfigsConfigDto**](gfa_web.Configs.ConfigDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_config_id_put

> crate::models::GfaWebConfigsConfigDto api_app_config_id_put(id, gfa_web_configs_create_update_config_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **String** |  | [required] |
**gfa_web_configs_create_update_config_dto** | Option<[**GfaWebConfigsCreateUpdateConfigDto**](GfaWebConfigsCreateUpdateConfigDto.md)> |  |  |

### Return type

[**crate::models::GfaWebConfigsConfigDto**](gfa_web.Configs.ConfigDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_app_config_post

> crate::models::GfaWebConfigsConfigDto api_app_config_post(gfa_web_configs_create_update_config_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**gfa_web_configs_create_update_config_dto** | Option<[**GfaWebConfigsCreateUpdateConfigDto**](GfaWebConfigsCreateUpdateConfigDto.md)> |  |  |

### Return type

[**crate::models::GfaWebConfigsConfigDto**](gfa_web.Configs.ConfigDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

