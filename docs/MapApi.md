# EcoServerAPI.Api.MapApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapEntities**](MapApi.md#mapentities) | **GET** /api/v1/map/entities | Allows access to all entities currently available in the simulation.
[**MapEntityTypes**](MapApi.md#mapentitytypes) | **GET** /api/v1/map/entitytypes | Allows access to all species currently available in the simulation.
[**MapGetDimension**](MapApi.md#mapgetdimension) | **GET** /api/v1/map/dimension | Returns the dimension of the world, in blocks.
[**MapGetProperty**](MapApi.md#mapgetproperty) | **GET** /api/v1/map/property | 
[**MapLayerList**](MapApi.md#maplayerlist) | **GET** /api/v1/map/layerList | List Layer Names.
[**MapMakeMapJSON**](MapApi.md#mapmakemapjson) | **GET** /api/v1/map/map.json | One request to get all required web map data.
[**MapMapStats**](MapApi.md#mapmapstats) | **GET** /api/v1/map/mapstats | 
[**MapWaterLevel**](MapApi.md#mapwaterlevel) | **GET** /api/v1/map/waterLevel | Get water height.


<a name="mapentities"></a>
# **MapEntities**
> List<EcoWebServerDataTransferObjectsEntityDTO> MapEntities (string authtoken, string authtokentype, List<string> entityTypes = null, List<string> states = null)

Allows access to all entities currently available in the simulation.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapEntitiesExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var entityTypes = new List<string>(); // List<string> | A list of user type names that will be used to filter the response. (optional) 
            var states = new List<string>(); // List<string> | A list of Animal states that will be used to filter the response. (optional) 

            try
            {
                // Allows access to all entities currently available in the simulation.
                List&lt;EcoWebServerDataTransferObjectsEntityDTO&gt; result = apiInstance.MapEntities(authtoken, authtokentype, entityTypes, states);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapEntities: " + e.Message );
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
 **entityTypes** | [**List&lt;string&gt;**](string.md)| A list of user type names that will be used to filter the response. | [optional] 
 **states** | [**List&lt;string&gt;**](string.md)| A list of Animal states that will be used to filter the response. | [optional] 

### Return type

[**List<EcoWebServerDataTransferObjectsEntityDTO>**](EcoWebServerDataTransferObjectsEntityDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapentitytypes"></a>
# **MapEntityTypes**
> List<string> MapEntityTypes (string authtoken, string authtokentype)

Allows access to all species currently available in the simulation.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapEntityTypesExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Allows access to all species currently available in the simulation.
                List&lt;string&gt; result = apiInstance.MapEntityTypes(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapEntityTypes: " + e.Message );
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

**List<string>**

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapgetdimension"></a>
# **MapGetDimension**
> EcoSharedMathVector3i MapGetDimension (string authtoken, string authtokentype)

Returns the dimension of the world, in blocks.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapGetDimensionExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns the dimension of the world, in blocks.
                EcoSharedMathVector3i result = apiInstance.MapGetDimension(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapGetDimension: " + e.Message );
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

[**EcoSharedMathVector3i**](EcoSharedMathVector3i.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapgetproperty"></a>
# **MapGetProperty**
> void MapGetProperty (string authtoken, string authtokentype)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapGetPropertyExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                apiInstance.MapGetProperty(authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapGetProperty: " + e.Message );
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

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="maplayerlist"></a>
# **MapLayerList**
> List<string> MapLayerList (string authtoken, string authtokentype)

List Layer Names.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapLayerListExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // List Layer Names.
                List&lt;string&gt; result = apiInstance.MapLayerList(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapLayerList: " + e.Message );
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

**List<string>**

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapmakemapjson"></a>
# **MapMakeMapJSON**
> void MapMakeMapJSON (string authtoken, string authtokentype)

One request to get all required web map data.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapMakeMapJSONExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // One request to get all required web map data.
                apiInstance.MapMakeMapJSON(authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapMakeMapJSON: " + e.Message );
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

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapmapstats"></a>
# **MapMapStats**
> EcoWebServerDataTransferObjectsMapStats MapMapStats (string authtoken, string authtokentype)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapMapStatsExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                EcoWebServerDataTransferObjectsMapStats result = apiInstance.MapMapStats(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapMapStats: " + e.Message );
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

[**EcoWebServerDataTransferObjectsMapStats**](EcoWebServerDataTransferObjectsMapStats.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapwaterlevel"></a>
# **MapWaterLevel**
> float? MapWaterLevel (string authtoken, string authtokentype)

Get water height.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class MapWaterLevelExample
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

            var apiInstance = new MapApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Get water height.
                float? result = apiInstance.MapWaterLevel(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapWaterLevel: " + e.Message );
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

**float?**

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

