# EcoServer-API.Api.PluginsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PluginsGetPluginConfig**](PluginsApi.md#pluginsgetpluginconfig) | **GET** /api/v1/plugins/{name} | 
[**PluginsGetPlugins**](PluginsApi.md#pluginsgetplugins) | **GET** /api/v1/plugins | Gets the list and status of all running plugins on the server.
[**PluginsPostPluginConfig**](PluginsApi.md#pluginspostpluginconfig) | **POST** /api/v1/plugins/{name} | Sets the configuration options for the given plugin.


<a name="pluginsgetpluginconfig"></a>
# **PluginsGetPluginConfig**
> void PluginsGetPluginConfig (string name, string authtoken, string authtokentype)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class PluginsGetPluginConfigExample
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

            var apiInstance = new PluginsApi();
            var name = name_example;  // string | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                apiInstance.PluginsGetPluginConfig(name, authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsGetPluginConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginsgetplugins"></a>
# **PluginsGetPlugins**
> List<EcoWebServerDataTransferObjectsPluginInfo> PluginsGetPlugins ()

Gets the list and status of all running plugins on the server.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class PluginsGetPluginsExample
    {
        public void main()
        {
            var apiInstance = new PluginsApi();

            try
            {
                // Gets the list and status of all running plugins on the server.
                List&lt;EcoWebServerDataTransferObjectsPluginInfo&gt; result = apiInstance.PluginsGetPlugins();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsGetPlugins: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<EcoWebServerDataTransferObjectsPluginInfo>**](EcoWebServerDataTransferObjectsPluginInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginspostpluginconfig"></a>
# **PluginsPostPluginConfig**
> void PluginsPostPluginConfig (string name, string authtoken, string authtokentype, Object body = null)

Sets the configuration options for the given plugin.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class PluginsPostPluginConfigExample
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

            var apiInstance = new PluginsApi();
            var name = name_example;  // string | The name of the plugin.
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var body = ;  // Object | New plugin config. (optional) 

            try
            {
                // Sets the configuration options for the given plugin.
                apiInstance.PluginsPostPluginConfig(name, authtoken, authtokentype, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsPostPluginConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin. | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 
 **body** | **Object**| New plugin config. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

