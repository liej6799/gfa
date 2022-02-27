# \FeaturesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_feature_management_features_get**](FeaturesApi.md#api_feature_management_features_get) | **GET** /api/feature-management/features | 
[**api_feature_management_features_put**](FeaturesApi.md#api_feature_management_features_put) | **PUT** /api/feature-management/features | 



## api_feature_management_features_get

> crate::models::VoloAbpFeatureManagementGetFeatureListResultDto api_feature_management_features_get(provider_name, provider_key)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**provider_name** | Option<**String**> |  |  |
**provider_key** | Option<**String**> |  |  |

### Return type

[**crate::models::VoloAbpFeatureManagementGetFeatureListResultDto**](Volo.Abp.FeatureManagement.GetFeatureListResultDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_feature_management_features_put

> api_feature_management_features_put(provider_name, provider_key, volo_abp_feature_management_update_features_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**provider_name** | Option<**String**> |  |  |
**provider_key** | Option<**String**> |  |  |
**volo_abp_feature_management_update_features_dto** | Option<[**VoloAbpFeatureManagementUpdateFeaturesDto**](VoloAbpFeatureManagementUpdateFeaturesDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

