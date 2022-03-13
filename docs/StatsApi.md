# EcoServer-API.Api.StatsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatsGenerateTestData**](StatsApi.md#statsgeneratetestdata) | **GET** /datasets/generatetestdata | Generates fake stat data for testing.
[**StatsGet**](StatsApi.md#statsget) | **GET** /datasets/get | /// Returns Eco.WebServer.Web.Controllers.StatsController.MaximumSamples data points between dayStart and dayEnd of the selected data.             If there are more than Eco.WebServer.Web.Controllers.StatsController.MaximumSamples samples, it will be averaged out to contain exactly Eco.WebServer.Web.Controllers.StatsController.MaximumSamples.///.
[**StatsGetFlatList**](StatsApi.md#statsgetflatlist) | **GET** /datasets/flatlist | /// Returns all stat infos that contain data, formatted as a list, where each key is a list of strings. ///.
[**StatsGetList**](StatsApi.md#statsgetlist) | **GET** /datasets/getlist | Returns a \&quot;package\&quot; of multiple statistics in the order of their request.
[**StatsGetTimeRange**](StatsApi.md#statsgettimerange) | **GET** /datasets/timerange | /// Returns the timerange of the simulation, in days///.
[**StatsGetTreeList**](StatsApi.md#statsgettreelist) | **GET** /datasets/treelist | Returns all dataset keys, formatted as a tree. ///.
[**StatsGraphs**](StatsApi.md#statsgraphs) | **GET** /datasets/graphs | Returns the list of premade graphs to be displayed on the front page.


<a name="statsgeneratetestdata"></a>
# **StatsGenerateTestData**
> void StatsGenerateTestData (string authtoken, string authtokentype, float? days = null, int? users = null, bool? generateClimateData = null, float? pollutionMultiplier = null)

Generates fake stat data for testing.

> This endpoint can only be invoked when AllowDebugCalls is enabled on the server.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGenerateTestDataExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var days = 3.4;  // float? | The number of days to simulate. (optional) 
            var users = 56;  // int? | The number of users to simulate. (optional) 
            var generateClimateData = true;  // bool? | Whether to generate climate data. Default is false. (optional)  (default to false)
            var pollutionMultiplier = 3.4;  // float? | How much pollution to generate. Default is 1. (optional)  (default to 1)

            try
            {
                // Generates fake stat data for testing.
                apiInstance.StatsGenerateTestData(authtoken, authtokentype, days, users, generateClimateData, pollutionMultiplier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGenerateTestData: " + e.Message );
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
 **days** | **float?**| The number of days to simulate. | [optional] 
 **users** | **int?**| The number of users to simulate. | [optional] 
 **generateClimateData** | **bool?**| Whether to generate climate data. Default is false. | [optional] [default to false]
 **pollutionMultiplier** | **float?**| How much pollution to generate. Default is 1. | [optional] [default to 1]

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statsget"></a>
# **StatsGet**
> EcoWebServerWebControllersStatReturn StatsGet (string authtoken, string authtokentype, string dataset = null, double? dayStart = null, double? dayEnd = null)

/// Returns Eco.WebServer.Web.Controllers.StatsController.MaximumSamples data points between dayStart and dayEnd of the selected data.             If there are more than Eco.WebServer.Web.Controllers.StatsController.MaximumSamples samples, it will be averaged out to contain exactly Eco.WebServer.Web.Controllers.StatsController.MaximumSamples.///.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGetExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var dataset = dataset_example;  // string | dataset to take the data from. (optional) 
            var dayStart = 1.2;  // double? | Day from which on data is returned. Default is 0. (optional)  (default to 0)
            var dayEnd = 1.2;  // double? | Day until which data is returned. Default is now. (optional)  (default to -1)

            try
            {
                // /// Returns Eco.WebServer.Web.Controllers.StatsController.MaximumSamples data points between dayStart and dayEnd of the selected data.             If there are more than Eco.WebServer.Web.Controllers.StatsController.MaximumSamples samples, it will be averaged out to contain exactly Eco.WebServer.Web.Controllers.StatsController.MaximumSamples.///.
                EcoWebServerWebControllersStatReturn result = apiInstance.StatsGet(authtoken, authtokentype, dataset, dayStart, dayEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGet: " + e.Message );
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
 **dataset** | **string**| dataset to take the data from. | [optional] 
 **dayStart** | **double?**| Day from which on data is returned. Default is 0. | [optional] [default to 0]
 **dayEnd** | **double?**| Day until which data is returned. Default is now. | [optional] [default to -1]

### Return type

[**EcoWebServerWebControllersStatReturn**](EcoWebServerWebControllersStatReturn.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statsgetflatlist"></a>
# **StatsGetFlatList**
> List<EcoStatsStatInfo> StatsGetFlatList (string authtoken, string authtokentype)

/// Returns all stat infos that contain data, formatted as a list, where each key is a list of strings. ///.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGetFlatListExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // /// Returns all stat infos that contain data, formatted as a list, where each key is a list of strings. ///.
                List&lt;EcoStatsStatInfo&gt; result = apiInstance.StatsGetFlatList(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGetFlatList: " + e.Message );
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

[**List<EcoStatsStatInfo>**](EcoStatsStatInfo.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statsgetlist"></a>
# **StatsGetList**
> List<EcoWebServerWebControllersStatReturn> StatsGetList (string authtoken, string authtokentype, List<string> requestedSets = null, double? dayStart = null, double? dayEnd = null)

Returns a \"package\" of multiple statistics in the order of their request.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGetListExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var requestedSets = new List<string>(); // List<string> | A list of statistics that should be returned. (optional) 
            var dayStart = 1.2;  // double? | Day from which the data should be taken from. Default is 0. (optional)  (default to 0)
            var dayEnd = 1.2;  // double? | Day until which data is returned. Default is now. (optional)  (default to -1)

            try
            {
                // Returns a \"package\" of multiple statistics in the order of their request.
                List&lt;EcoWebServerWebControllersStatReturn&gt; result = apiInstance.StatsGetList(authtoken, authtokentype, requestedSets, dayStart, dayEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGetList: " + e.Message );
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
 **requestedSets** | [**List&lt;string&gt;**](string.md)| A list of statistics that should be returned. | [optional] 
 **dayStart** | **double?**| Day from which the data should be taken from. Default is 0. | [optional] [default to 0]
 **dayEnd** | **double?**| Day until which data is returned. Default is now. | [optional] [default to -1]

### Return type

[**List<EcoWebServerWebControllersStatReturn>**](EcoWebServerWebControllersStatReturn.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statsgettimerange"></a>
# **StatsGetTimeRange**
> List<float?> StatsGetTimeRange (string authtoken, string authtokentype)

/// Returns the timerange of the simulation, in days///.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGetTimeRangeExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // /// Returns the timerange of the simulation, in days///.
                List&lt;float?&gt; result = apiInstance.StatsGetTimeRange(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGetTimeRange: " + e.Message );
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

**List<float?>**

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statsgettreelist"></a>
# **StatsGetTreeList**
> EcoStatsStatCategory StatsGetTreeList (string authtoken, string authtokentype)

Returns all dataset keys, formatted as a tree. ///.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGetTreeListExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns all dataset keys, formatted as a tree. ///.
                EcoStatsStatCategory result = apiInstance.StatsGetTreeList(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGetTreeList: " + e.Message );
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

[**EcoStatsStatCategory**](EcoStatsStatCategory.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statsgraphs"></a>
# **StatsGraphs**
> List<EcoStatsNamedGraph> StatsGraphs (string authtoken, string authtokentype)

Returns the list of premade graphs to be displayed on the front page.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class StatsGraphsExample
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

            var apiInstance = new StatsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns the list of premade graphs to be displayed on the front page.
                List&lt;EcoStatsNamedGraph&gt; result = apiInstance.StatsGraphs(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsGraphs: " + e.Message );
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

[**List<EcoStatsNamedGraph>**](EcoStatsNamedGraph.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

