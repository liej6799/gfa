# \PermissionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_permission_management_permissions_get**](PermissionsApi.md#api_permission_management_permissions_get) | **GET** /api/permission-management/permissions | 
[**api_permission_management_permissions_put**](PermissionsApi.md#api_permission_management_permissions_put) | **PUT** /api/permission-management/permissions | 



## api_permission_management_permissions_get

> crate::models::VoloAbpPermissionManagementGetPermissionListResultDto api_permission_management_permissions_get(provider_name, provider_key)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**provider_name** | Option<**String**> |  |  |
**provider_key** | Option<**String**> |  |  |

### Return type

[**crate::models::VoloAbpPermissionManagementGetPermissionListResultDto**](Volo.Abp.PermissionManagement.GetPermissionListResultDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## api_permission_management_permissions_put

> api_permission_management_permissions_put(provider_name, provider_key, volo_abp_permission_management_update_permissions_dto)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**provider_name** | Option<**String**> |  |  |
**provider_key** | Option<**String**> |  |  |
**volo_abp_permission_management_update_permissions_dto** | Option<[**VoloAbpPermissionManagementUpdatePermissionsDto**](VoloAbpPermissionManagementUpdatePermissionsDto.md)> |  |  |

### Return type

 (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

