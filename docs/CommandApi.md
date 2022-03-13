# EcoServer-API.Api.CommandApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommandExecCommand**](CommandApi.md#commandexeccommand) | **POST** /api/v1/command/exec | Executes a chat command on the server.


<a name="commandexeccommand"></a>
# **CommandExecCommand**
> EcoWebServerDataTransferObjectsCommandResultDTO CommandExecCommand (string authtoken, string authtokentype, EcoWebServerDataTransferObjectsExecuteCommandDTO body = null)

Executes a chat command on the server.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class CommandExecCommandExample
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

            var apiInstance = new CommandApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var body = new EcoWebServerDataTransferObjectsExecuteCommandDTO(); // EcoWebServerDataTransferObjectsExecuteCommandDTO |  (optional) 

            try
            {
                // Executes a chat command on the server.
                EcoWebServerDataTransferObjectsCommandResultDTO result = apiInstance.CommandExecCommand(authtoken, authtokentype, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommandApi.CommandExecCommand: " + e.Message );
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
 **body** | [**EcoWebServerDataTransferObjectsExecuteCommandDTO**](EcoWebServerDataTransferObjectsExecuteCommandDTO.md)|  | [optional] 

### Return type

[**EcoWebServerDataTransferObjectsCommandResultDTO**](EcoWebServerDataTransferObjectsCommandResultDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

