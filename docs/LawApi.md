# EcoServerAPI.Api.LawApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LawGenerateTestData**](LawApi.md#lawgeneratetestdata) | **POST** /api/v1/laws/generatetestdata | Genereate test laws.
[**LawGetDistrictMap**](LawApi.md#lawgetdistrictmap) | **GET** /api/v1/laws/districtmap/{name} | 
[**LawGetLaw**](LawApi.md#lawgetlaw) | **GET** /api/v1/laws/{id} | Returns the law with the specified id.
[**LawList**](LawApi.md#lawlist) | **GET** /api/v1/laws/byStates/{states} | Returns all laws currently present in the game in the specified states, active by default.
[**LawListAll**](LawApi.md#lawlistall) | **GET** /api/v1/laws | Returns all laws currently present in the game


<a name="lawgeneratetestdata"></a>
# **LawGenerateTestData**
> void LawGenerateTestData (string authtoken, string authtokentype)

Genereate test laws.

> This endpoint can only be invoked by a DevTier user.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class LawGenerateTestDataExample
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

            var apiInstance = new LawApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Genereate test laws.
                apiInstance.LawGenerateTestData(authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LawApi.LawGenerateTestData: " + e.Message );
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

<a name="lawgetdistrictmap"></a>
# **LawGetDistrictMap**
> EcoWebServerDataTransferObjectsDistrictMapDTO LawGetDistrictMap (string name, string authtoken, string authtokentype)



### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class LawGetDistrictMapExample
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

            var apiInstance = new LawApi();
            var name = name_example;  // string | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                EcoWebServerDataTransferObjectsDistrictMapDTO result = apiInstance.LawGetDistrictMap(name, authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LawApi.LawGetDistrictMap: " + e.Message );
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

[**EcoWebServerDataTransferObjectsDistrictMapDTO**](EcoWebServerDataTransferObjectsDistrictMapDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lawgetlaw"></a>
# **LawGetLaw**
> EcoWebServerDataTransferObjectsLawDTO LawGetLaw (int? id, string authtoken, string authtokentype)

Returns the law with the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class LawGetLawExample
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

            var apiInstance = new LawApi();
            var id = 56;  // int? | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns the law with the specified id.
                EcoWebServerDataTransferObjectsLawDTO result = apiInstance.LawGetLaw(id, authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LawApi.LawGetLaw: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 

### Return type

[**EcoWebServerDataTransferObjectsLawDTO**](EcoWebServerDataTransferObjectsLawDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lawlist"></a>
# **LawList**
> List<EcoWebServerDataTransferObjectsLawDTO> LawList (string states, string authtoken, string authtokentype)

Returns all laws currently present in the game in the specified states, active by default.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class LawListExample
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

            var apiInstance = new LawApi();
            var states = states_example;  // string | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns all laws currently present in the game in the specified states, active by default.
                List&lt;EcoWebServerDataTransferObjectsLawDTO&gt; result = apiInstance.LawList(states, authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LawApi.LawList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **states** | **string**|  | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 

### Return type

[**List<EcoWebServerDataTransferObjectsLawDTO>**](EcoWebServerDataTransferObjectsLawDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lawlistall"></a>
# **LawListAll**
> List<EcoWebServerDataTransferObjectsLawDTO> LawListAll (string authtoken, string authtokentype)

Returns all laws currently present in the game

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class LawListAllExample
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

            var apiInstance = new LawApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns all laws currently present in the game
                List&lt;EcoWebServerDataTransferObjectsLawDTO&gt; result = apiInstance.LawListAll(authtoken, authtokentype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LawApi.LawListAll: " + e.Message );
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

[**List<EcoWebServerDataTransferObjectsLawDTO>**](EcoWebServerDataTransferObjectsLawDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

