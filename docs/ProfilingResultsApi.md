# EcoServer-API.Api.ProfilingResultsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProfilingResultsDownload**](ProfilingResultsApi.md#profilingresultsdownload) | **GET** /api/v1/profiling-results/{filename} | 
[**ProfilingResultsList**](ProfilingResultsApi.md#profilingresultslist) | **GET** /api/v1/profiling-results | Returns the list of generated profiling results.


<a name="profilingresultsdownload"></a>
# **ProfilingResultsDownload**
> void ProfilingResultsDownload (string filename, string authtoken, string authtokentype)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ProfilingResultsDownloadExample
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

            var apiInstance = new ProfilingResultsApi();
            var filename = filename_example;  // string | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                apiInstance.ProfilingResultsDownload(filename, authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilingResultsApi.ProfilingResultsDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**|  | 
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

<a name="profilingresultslist"></a>
# **ProfilingResultsList**
> List<EcoWebServerDataTransferObjectsProfilingResultDTO> ProfilingResultsList (string authtoken, string authtokentype)

Returns the list of generated profiling results.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ProfilingResultsListExample
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

            var apiInstance = new ProfilingResultsApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns the list of generated profiling results.
                List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt; result = apiInstance.ProfilingResultsList(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilingResultsApi.ProfilingResultsList: " + e.Message );
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

[**List<EcoWebServerDataTransferObjectsProfilingResultDTO>**](EcoWebServerDataTransferObjectsProfilingResultDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

