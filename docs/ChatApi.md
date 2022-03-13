# EcoServerAPI.Api.ChatApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChatGetChat**](ChatApi.md#chatgetchat) | **GET** /api/v1/chat | Returns all non-private player chat messages sent within the given time range.
[**ChatGetChatByTag**](ChatApi.md#chatgetchatbytag) | **GET** /api/v1/chat/tag | Returns all non-private player chat messages sent to the given tag within the given time range.
[**ChatGetChatMessagesSentBy**](ChatApi.md#chatgetchatmessagessentby) | **GET** /api/v1/chat/{username} | Returns all non-private chat messages sent by the given user within the given time range.
[**ChatGetNext**](ChatApi.md#chatgetnext) | **POST** /api/v1/chat/next | Gets the. &lt;code&gt;numNextMessages&lt;/code&gt; chat messages sent after the given message on the same tag.
[**ChatGetPrevious**](ChatApi.md#chatgetprevious) | **POST** /api/v1/chat/previous | Gets the. &lt;code&gt;numPreviousMessages&lt;/code&gt; chat messages sent before the given message on the same tag.
[**ChatSendChat**](ChatApi.md#chatsendchat) | **GET** /api/v1/chat/sendChat | Sends chat message like username.


<a name="chatgetchat"></a>
# **ChatGetChat**
> void ChatGetChat (string authtoken, string authtokentype, double? startDay = null, double? endDay = null)

Returns all non-private player chat messages sent within the given time range.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class ChatGetChatExample
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

            var apiInstance = new ChatApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var startDay = 1.2;  // double? | The lower bound on the time range. Default is 0. (optional)  (default to 0)
            var endDay = 1.2;  // double? | The upper bound on the time range. Default is now. (optional)  (default to -1)

            try
            {
                // Returns all non-private player chat messages sent within the given time range.
                apiInstance.ChatGetChat(authtoken, authtokentype, startDay, endDay);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetChat: " + e.Message );
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
 **startDay** | **double?**| The lower bound on the time range. Default is 0. | [optional] [default to 0]
 **endDay** | **double?**| The upper bound on the time range. Default is now. | [optional] [default to -1]

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatgetchatbytag"></a>
# **ChatGetChatByTag**
> void ChatGetChatByTag (string authtoken, string authtokentype, string tag = null, double? startDay = null, double? endDay = null)

Returns all non-private player chat messages sent to the given tag within the given time range.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class ChatGetChatByTagExample
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

            var apiInstance = new ChatApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var tag = tag_example;  // string | The tag name in question. (optional) 
            var startDay = 1.2;  // double? | The lower bound on the time range. Default is 0. (optional)  (default to 0)
            var endDay = 1.2;  // double? | The upper bound on the time range. Default is now. (optional)  (default to -1)

            try
            {
                // Returns all non-private player chat messages sent to the given tag within the given time range.
                apiInstance.ChatGetChatByTag(authtoken, authtokentype, tag, startDay, endDay);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetChatByTag: " + e.Message );
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
 **tag** | **string**| The tag name in question. | [optional] 
 **startDay** | **double?**| The lower bound on the time range. Default is 0. | [optional] [default to 0]
 **endDay** | **double?**| The upper bound on the time range. Default is now. | [optional] [default to -1]

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatgetchatmessagessentby"></a>
# **ChatGetChatMessagesSentBy**
> void ChatGetChatMessagesSentBy (string username, string authtoken, string authtokentype, double? startDay = null, double? endDay = null)

Returns all non-private chat messages sent by the given user within the given time range.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class ChatGetChatMessagesSentByExample
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

            var apiInstance = new ChatApi();
            var username = username_example;  // string | The user in question.
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var startDay = 1.2;  // double? | The lower bound on the time range. Default is 0. (optional)  (default to 0)
            var endDay = 1.2;  // double? | The upper bound on the time range. Default is now. (optional)  (default to -1)

            try
            {
                // Returns all non-private chat messages sent by the given user within the given time range.
                apiInstance.ChatGetChatMessagesSentBy(username, authtoken, authtokentype, startDay, endDay);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetChatMessagesSentBy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The user in question. | 
 **authtoken** | **string**| Eco user authentication token. | 
 **authtokentype** | **string**| Eco user authentication token type. | 
 **startDay** | **double?**| The lower bound on the time range. Default is 0. | [optional] [default to 0]
 **endDay** | **double?**| The upper bound on the time range. Default is now. | [optional] [default to -1]

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatgetnext"></a>
# **ChatGetNext**
> void ChatGetNext (string authtoken, string authtokentype, int? numNextMessages = null, EcoWebServerDataTransferObjectsChatMessageDTO body = null)

Gets the. <code>numNextMessages</code> chat messages sent after the given message on the same tag.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class ChatGetNextExample
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

            var apiInstance = new ChatApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var numNextMessages = 56;  // int? | The number of following messages to return. (optional) 
            var body = new EcoWebServerDataTransferObjectsChatMessageDTO(); // EcoWebServerDataTransferObjectsChatMessageDTO | The message in question. (optional) 

            try
            {
                // Gets the. <code>numNextMessages</code> chat messages sent after the given message on the same tag.
                apiInstance.ChatGetNext(authtoken, authtokentype, numNextMessages, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetNext: " + e.Message );
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
 **numNextMessages** | **int?**| The number of following messages to return. | [optional] 
 **body** | [**EcoWebServerDataTransferObjectsChatMessageDTO**](EcoWebServerDataTransferObjectsChatMessageDTO.md)| The message in question. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatgetprevious"></a>
# **ChatGetPrevious**
> void ChatGetPrevious (string authtoken, string authtokentype, int? numPreviousMessages = null, EcoWebServerDataTransferObjectsChatMessageDTO body = null)

Gets the. <code>numPreviousMessages</code> chat messages sent before the given message on the same tag.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class ChatGetPreviousExample
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

            var apiInstance = new ChatApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var numPreviousMessages = 56;  // int? | The number of preceding messages to return. (optional) 
            var body = new EcoWebServerDataTransferObjectsChatMessageDTO(); // EcoWebServerDataTransferObjectsChatMessageDTO | The message in question. (optional) 

            try
            {
                // Gets the. <code>numPreviousMessages</code> chat messages sent before the given message on the same tag.
                apiInstance.ChatGetPrevious(authtoken, authtokentype, numPreviousMessages, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetPrevious: " + e.Message );
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
 **numPreviousMessages** | **int?**| The number of preceding messages to return. | [optional] 
 **body** | [**EcoWebServerDataTransferObjectsChatMessageDTO**](EcoWebServerDataTransferObjectsChatMessageDTO.md)| The message in question. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatsendchat"></a>
# **ChatSendChat**
> void ChatSendChat (string authtoken, string authtokentype, string username = null, string message = null)

Sends chat message like username.

> This endpoint can only be invoked when AllowDebugCalls is enabled on the server.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServerAPI.Api;
using EcoServerAPI.Client;
using EcoServerAPI.Model;

namespace Example
{
    public class ChatSendChatExample
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

            var apiInstance = new ChatApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var username = username_example;  // string | User who wants to send message. (optional) 
            var message = message_example;  // string | The message to send. (optional) 

            try
            {
                // Sends chat message like username.
                apiInstance.ChatSendChat(authtoken, authtokentype, username, message);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatSendChat: " + e.Message );
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
 **username** | **string**| User who wants to send message. | [optional] 
 **message** | **string**| The message to send. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

