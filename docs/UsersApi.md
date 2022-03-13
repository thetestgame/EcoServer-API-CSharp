# EcoServerAPI.Api.UsersApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersGetUsers**](UsersApi.md#usersgetusers) | **GET** /api/v1/users | 


<a name="usersgetusers"></a>
# **UsersGetUsers**
> List<EcoWebServerDataTransferObjectsUserDTO> UsersGetUsers (string authtoken, string authtokentype, int? hoursPlayedGte = null)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class UsersGetUsersExample
    {
        public void main()
        {
            // Configure API key authorization: authtoken
            Configuration.Default.AddApiKey("authtoken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("authtoken", "Bearer");
            // Configure API key authorization: authtokentype
            Configuration.Default.AddApiKey("authtokentype", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("authtokentype", "Bearer");

            var apiInstance = new UsersApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var hoursPlayedGte = 56;  // int? |  (optional) 

            try
            {
                List&lt;EcoWebServerDataTransferObjectsUserDTO&gt; result = apiInstance.UsersGetUsers(authtoken, authtokentype, hoursPlayedGte);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 
 **hoursPlayedGte** | **int?**|  | [optional] 

### Return type

[**List<EcoWebServerDataTransferObjectsUserDTO>**](EcoWebServerDataTransferObjectsUserDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

