# EcoServer-API.Api.WorldLayerApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WorldLayerAreaDescription**](WorldLayerApi.md#worldlayerareadescription) | **GET** /api/v1/worldlayers/relationships/areadescription | Describes the area selected with a string.
[**WorldLayerListLayers**](WorldLayerApi.md#worldlayerlistlayers) | **GET** /api/v1/worldlayers/layers | Enumerates every world layer in the simulation.
[**WorldLayerListRelevantLayers**](WorldLayerApi.md#worldlayerlistrelevantlayers) | **GET** /api/v1/worldlayers/layers/{focusLayer} | Enumerates the layers that should be displayed when the user is focused on a particular layer and world area.
[**WorldLayerListRelevantRelationships**](WorldLayerApi.md#worldlayerlistrelevantrelationships) | **GET** /api/v1/worldlayers/relationships/{focusLayer} | Enumerates the layer relationships that should be displayed when the user is focused on a particular layer and world area.


<a name="worldlayerareadescription"></a>
# **WorldLayerAreaDescription**
> string WorldLayerAreaDescription (string authtoken, string authtokentype, float? minX = null, float? minY = null, float? maxX = null, float? maxY = null)

Describes the area selected with a string.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class WorldLayerAreaDescriptionExample
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

            var apiInstance = new WorldLayerApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var minX = 3.4;  // float? | The least x boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var minY = 3.4;  // float? | The least y boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var maxX = 3.4;  // float? | The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var maxY = 3.4;  // float? | The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)

            try
            {
                // Describes the area selected with a string.
                string result = apiInstance.WorldLayerAreaDescription(authtoken, authtokentype, minX, minY, maxX, maxY);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldLayerApi.WorldLayerAreaDescription: " + e.Message );
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
 **minX** | **float?**| The least x boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **minY** | **float?**| The least y boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **maxX** | **float?**| The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **maxY** | **float?**| The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]

### Return type

**string**

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="worldlayerlistlayers"></a>
# **WorldLayerListLayers**
> List<EcoWebServerDataTransferObjectsWorldLayersWorldLayerGroupDTO> WorldLayerListLayers (string authtoken, string authtokentype)

Enumerates every world layer in the simulation.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class WorldLayerListLayersExample
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

            var apiInstance = new WorldLayerApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Enumerates every world layer in the simulation.
                List&lt;EcoWebServerDataTransferObjectsWorldLayersWorldLayerGroupDTO&gt; result = apiInstance.WorldLayerListLayers(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldLayerApi.WorldLayerListLayers: " + e.Message );
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

[**List<EcoWebServerDataTransferObjectsWorldLayersWorldLayerGroupDTO>**](EcoWebServerDataTransferObjectsWorldLayersWorldLayerGroupDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="worldlayerlistrelevantlayers"></a>
# **WorldLayerListRelevantLayers**
> List<EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO> WorldLayerListRelevantLayers (string focusLayer, string authtoken, string authtokentype, float? minX = null, float? minY = null, float? maxX = null, float? maxY = null)

Enumerates the layers that should be displayed when the user is focused on a particular layer and world area.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class WorldLayerListRelevantLayersExample
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

            var apiInstance = new WorldLayerApi();
            var focusLayer = focusLayer_example;  // string | Name of the layer we're querying.
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var minX = 3.4;  // float? | The least x boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var minY = 3.4;  // float? | The least y boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var maxX = 3.4;  // float? | The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var maxY = 3.4;  // float? | The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)

            try
            {
                // Enumerates the layers that should be displayed when the user is focused on a particular layer and world area.
                List&lt;EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO&gt; result = apiInstance.WorldLayerListRelevantLayers(focusLayer, authtoken, authtokentype, minX, minY, maxX, maxY);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldLayerApi.WorldLayerListRelevantLayers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **focusLayer** | **string**| Name of the layer we&#39;re querying. | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 
 **minX** | **float?**| The least x boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **minY** | **float?**| The least y boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **maxX** | **float?**| The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **maxY** | **float?**| The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]

### Return type

[**List<EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO>**](EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="worldlayerlistrelevantrelationships"></a>
# **WorldLayerListRelevantRelationships**
> List<EcoWebServerDataTransferObjectsWorldLayersLayerRelationshipDTO> WorldLayerListRelevantRelationships (string focusLayer, string authtoken, string authtokentype, float? minX = null, float? minY = null, float? maxX = null, float? maxY = null)

Enumerates the layer relationships that should be displayed when the user is focused on a particular layer and world area.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class WorldLayerListRelevantRelationshipsExample
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

            var apiInstance = new WorldLayerApi();
            var focusLayer = focusLayer_example;  // string | The name of the focused layer.
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var minX = 3.4;  // float? | The least x boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var minY = 3.4;  // float? | The least y boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var maxX = 3.4;  // float? | The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)
            var maxY = 3.4;  // float? | The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped. (optional)  (default to -1)

            try
            {
                // Enumerates the layer relationships that should be displayed when the user is focused on a particular layer and world area.
                List&lt;EcoWebServerDataTransferObjectsWorldLayersLayerRelationshipDTO&gt; result = apiInstance.WorldLayerListRelevantRelationships(focusLayer, authtoken, authtokentype, minX, minY, maxX, maxY);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldLayerApi.WorldLayerListRelevantRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **focusLayer** | **string**| The name of the focused layer. | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 
 **minX** | **float?**| The least x boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **minY** | **float?**| The least y boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **maxX** | **float?**| The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]
 **maxY** | **float?**| The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped. | [optional] [default to -1]

### Return type

[**List<EcoWebServerDataTransferObjectsWorldLayersLayerRelationshipDTO>**](EcoWebServerDataTransferObjectsWorldLayersLayerRelationshipDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

