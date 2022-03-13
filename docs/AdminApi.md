# EcoServer-API.Api.AdminApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminGetGetAccess**](AdminApi.md#admingetgetaccess) | **GET** /api/v1/admin/get/access | 
[**AdminGetGetServerName**](AdminApi.md#admingetgetservername) | **GET** /api/v1/admin/get/servername | 
[**AdminPostGameExport**](AdminApi.md#adminpostgameexport) | **POST** /api/v1/admin/game/export | 
[**AdminPostSetAccess**](AdminApi.md#adminpostsetaccess) | **POST** /api/v1/admin/set/access | Sets how accessible this server is.
[**AdminPostSetServerName**](AdminApi.md#adminpostsetservername) | **POST** /api/v1/admin/set/servername | 


<a name="admingetgetaccess"></a>
# **AdminGetGetAccess**
> string AdminGetGetAccess (string authtoken, string authtokentype)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class AdminGetGetAccessExample
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

            var apiInstance = new AdminApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                string result = apiInstance.AdminGetGetAccess(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AdminGetGetAccess: " + e.Message );
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

### Return type

**string**

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="admingetgetservername"></a>
# **AdminGetGetServerName**
> string AdminGetGetServerName ()



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class AdminGetGetServerNameExample
    {
        public void main()
        {
            var apiInstance = new AdminApi();

            try
            {
                string result = apiInstance.AdminGetGetServerName();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AdminGetGetServerName: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminpostgameexport"></a>
# **AdminPostGameExport**
> EcoWebServerWebModelsAdminReturnModel AdminPostGameExport (string authtoken, string authtokentype, EcoWebServerWebModelsExportGameModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class AdminPostGameExportExample
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

            var apiInstance = new AdminApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var body = new EcoWebServerWebModelsExportGameModel(); // EcoWebServerWebModelsExportGameModel |  (optional) 

            try
            {
                EcoWebServerWebModelsAdminReturnModel result = apiInstance.AdminPostGameExport(authtoken, authtokentype, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AdminPostGameExport: " + e.Message );
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
 **body** | [**EcoWebServerWebModelsExportGameModel**](EcoWebServerWebModelsExportGameModel.md)|  | [optional] 

### Return type

[**EcoWebServerWebModelsAdminReturnModel**](EcoWebServerWebModelsAdminReturnModel.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminpostsetaccess"></a>
# **AdminPostSetAccess**
> void AdminPostSetAccess (string authtoken, string authtokentype, string value = null, string password = null)

Sets how accessible this server is.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class AdminPostSetAccessExample
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

            var apiInstance = new AdminApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var value = value_example;  // string | Can be 'public' (listed in server browser, no password), 'private' (listed in server browser, with password) or 'hidden' (unlisted, without password). (optional) 
            var password = password_example;  // string | If setting private, must set a password. If not set to private, this is unused. (optional) 

            try
            {
                // Sets how accessible this server is.
                apiInstance.AdminPostSetAccess(authtoken, authtokentype, value, password);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AdminPostSetAccess: " + e.Message );
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
 **value** | **string**| Can be &#39;public&#39; (listed in server browser, no password), &#39;private&#39; (listed in server browser, with password) or &#39;hidden&#39; (unlisted, without password). | [optional] 
 **password** | **string**| If setting private, must set a password. If not set to private, this is unused. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminpostsetservername"></a>
# **AdminPostSetServerName**
> void AdminPostSetServerName (string authtoken, string authtokentype, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class AdminPostSetServerNameExample
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

            var apiInstance = new AdminApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.AdminPostSetServerName(authtoken, authtokentype, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AdminPostSetServerName: " + e.Message );
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
 **name** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

