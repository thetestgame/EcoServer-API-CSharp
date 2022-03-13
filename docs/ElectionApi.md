# EcoServer-API.Api.ElectionApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ElectionAddComment**](ElectionApi.md#electionaddcomment) | **POST** /api/v1/elections/addcomment | Adds a comment to the currently running election, if any.
[**ElectionFinishElection**](ElectionApi.md#electionfinishelection) | **POST** /api/v1/elections/finishelection | 
[**ElectionForceElectionEnd**](ElectionApi.md#electionforceelectionend) | **POST** /api/v1/elections/forceelectionend | Forces the currently running election to end now, and for the current election winner to become the leader. Can only be called by an admin or dev.
[**ElectionGenerateTestData**](ElectionApi.md#electiongeneratetestdata) | **POST** /api/v1/elections/generatetestdata | Create a bunch of test elections.
[**ElectionGetComments**](ElectionApi.md#electiongetcomments) | **GET** /api/v1/elections/listcomments | List comments on the election.
[**ElectionGetElectedTitleById**](ElectionApi.md#electiongetelectedtitlebyid) | **GET** /api/v1/elections/titles/{id} | Returns the elected title with the given id.
[**ElectionGetElectionById**](ElectionApi.md#electiongetelectionbyid) | **GET** /api/v1/elections/{id} | Returns the election with the given id.
[**ElectionListElectedTitles**](ElectionApi.md#electionlistelectedtitles) | **GET** /api/v1/elections/titles | Returns all elected titles and their occupants matching the given state (active by default).
[**ElectionListElections**](ElectionApi.md#electionlistelections) | **GET** /api/v1/elections | Returns all elections that are either active or inactive.
[**ElectionVote**](ElectionApi.md#electionvote) | **POST** /api/v1/elections/vote | Places a vote on behalf of the given player.  Can only be called if an election is currently running.
[**ElectionVotes**](ElectionApi.md#electionvotes) | **GET** /api/v1/elections/votes | Returns a list of votes that were made on the indicated election.


<a name="electionaddcomment"></a>
# **ElectionAddComment**
> void ElectionAddComment (string authtoken, string authtokentype, int? electionId = null, EcoWebServerDataTransferObjectsElectionCommentDTO body = null)

Adds a comment to the currently running election, if any.

> This endpoint can only be invoked by a ??.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionAddCommentExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var electionId = 56;  // int? | ID of the election. (optional) 
            var body = new EcoWebServerDataTransferObjectsElectionCommentDTO(); // EcoWebServerDataTransferObjectsElectionCommentDTO | The comment to be added to the election. (optional) 

            try
            {
                // Adds a comment to the currently running election, if any.
                apiInstance.ElectionAddComment(authtoken, authtokentype, electionId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionAddComment: " + e.Message );
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
 **electionId** | **int?**| ID of the election. | [optional] 
 **body** | [**EcoWebServerDataTransferObjectsElectionCommentDTO**](EcoWebServerDataTransferObjectsElectionCommentDTO.md)| The comment to be added to the election. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electionfinishelection"></a>
# **ElectionFinishElection**
> void ElectionFinishElection (string authtoken, string authtokentype)



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
    public class ElectionFinishElectionExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                apiInstance.ElectionFinishElection(authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionFinishElection: " + e.Message );
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

<a name="electionforceelectionend"></a>
# **ElectionForceElectionEnd**
> void ElectionForceElectionEnd (string authtoken, string authtokentype, int? electionId = null)

Forces the currently running election to end now, and for the current election winner to become the leader. Can only be called by an admin or dev.

> This endpoint can only be invoked by a Admin user.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionForceElectionEndExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var electionId = 56;  // int? | ID of the election. (optional) 

            try
            {
                // Forces the currently running election to end now, and for the current election winner to become the leader. Can only be called by an admin or dev.
                apiInstance.ElectionForceElectionEnd(authtoken, authtokentype, electionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionForceElectionEnd: " + e.Message );
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
 **electionId** | **int?**| ID of the election. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electiongeneratetestdata"></a>
# **ElectionGenerateTestData**
> void ElectionGenerateTestData (string authtoken, string authtokentype)

Create a bunch of test elections.

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
    public class ElectionGenerateTestDataExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Create a bunch of test elections.
                apiInstance.ElectionGenerateTestData(authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionGenerateTestData: " + e.Message );
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

<a name="electiongetcomments"></a>
# **ElectionGetComments**
> List<EcoWebServerDataTransferObjectsElectionCommentDTO> ElectionGetComments (string authtoken, string authtokentype, int? electionId = null)

List comments on the election.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionGetCommentsExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var electionId = 56;  // int? | ID of the election. (optional) 

            try
            {
                // List comments on the election.
                List&lt;EcoWebServerDataTransferObjectsElectionCommentDTO&gt; result = apiInstance.ElectionGetComments(authtoken, authtokentype, electionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionGetComments: " + e.Message );
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
 **electionId** | **int?**| ID of the election. | [optional] 

### Return type

[**List<EcoWebServerDataTransferObjectsElectionCommentDTO>**](EcoWebServerDataTransferObjectsElectionCommentDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electiongetelectedtitlebyid"></a>
# **ElectionGetElectedTitleById**
> void ElectionGetElectedTitleById (int? id, string authtoken, string authtokentype)

Returns the elected title with the given id.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionGetElectedTitleByIdExample
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

            var apiInstance = new ElectionApi();
            var id = 56;  // int? | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns the elected title with the given id.
                apiInstance.ElectionGetElectedTitleById(id, authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionGetElectedTitleById: " + e.Message );
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

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electiongetelectionbyid"></a>
# **ElectionGetElectionById**
> void ElectionGetElectionById (int? id, string authtoken, string authtokentype)

Returns the election with the given id.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionGetElectionByIdExample
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

            var apiInstance = new ElectionApi();
            var id = 56;  // int? | 
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.

            try
            {
                // Returns the election with the given id.
                apiInstance.ElectionGetElectionById(id, authtoken, authtokentype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionGetElectionById: " + e.Message );
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

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electionlistelectedtitles"></a>
# **ElectionListElectedTitles**
> List<EcoWebServerDataTransferObjectsElectedTitleDTO> ElectionListElectedTitles (string authtoken, string authtokentype, Object state = null)

Returns all elected titles and their occupants matching the given state (active by default).

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionListElectedTitlesExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var state = new Object(); // Object |  (optional) 

            try
            {
                // Returns all elected titles and their occupants matching the given state (active by default).
                List&lt;EcoWebServerDataTransferObjectsElectedTitleDTO&gt; result = apiInstance.ElectionListElectedTitles(authtoken, authtokentype, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionListElectedTitles: " + e.Message );
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
 **state** | [**Object**](Object.md)|  | [optional] 

### Return type

[**List<EcoWebServerDataTransferObjectsElectedTitleDTO>**](EcoWebServerDataTransferObjectsElectedTitleDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electionlistelections"></a>
# **ElectionListElections**
> List<EcoWebServerDataTransferObjectsElectionDTO> ElectionListElections (string authtoken, string authtokentype, bool? returnActive = null)

Returns all elections that are either active or inactive.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionListElectionsExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var returnActive = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Returns all elections that are either active or inactive.
                List&lt;EcoWebServerDataTransferObjectsElectionDTO&gt; result = apiInstance.ElectionListElections(authtoken, authtokentype, returnActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionListElections: " + e.Message );
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
 **returnActive** | **bool?**|  | [optional] [default to true]

### Return type

[**List<EcoWebServerDataTransferObjectsElectionDTO>**](EcoWebServerDataTransferObjectsElectionDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electionvote"></a>
# **ElectionVote**
> void ElectionVote (string authtoken, string authtokentype, bool? forceVote = null, EcoWebServerDataTransferObjectsRunoffVoteDTO body = null)

Places a vote on behalf of the given player.  Can only be called if an election is currently running.

> This endpoint can only be invoked by a ??.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionVoteExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var forceVote = true;  // bool? | Force vote ignoring election process. (optional) 
            var body = new EcoWebServerDataTransferObjectsRunoffVoteDTO(); // EcoWebServerDataTransferObjectsRunoffVoteDTO | The player's vote.  Must contain a ranked list of all candidates for the current election. (optional) 

            try
            {
                // Places a vote on behalf of the given player.  Can only be called if an election is currently running.
                apiInstance.ElectionVote(authtoken, authtokentype, forceVote, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionVote: " + e.Message );
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
 **forceVote** | **bool?**| Force vote ignoring election process. | [optional] 
 **body** | [**EcoWebServerDataTransferObjectsRunoffVoteDTO**](EcoWebServerDataTransferObjectsRunoffVoteDTO.md)| The player&#39;s vote.  Must contain a ranked list of all candidates for the current election. | [optional] 

### Return type

void (empty response body)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="electionvotes"></a>
# **ElectionVotes**
> List<EcoWebServerDataTransferObjectsRunoffVoteDTO> ElectionVotes (string authtoken, string authtokentype, int? id = null)

Returns a list of votes that were made on the indicated election.

### Example
```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class ElectionVotesExample
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

            var apiInstance = new ElectionApi();
            var authtoken = authtoken_example;  // string | Eco user authentication token.
            var authtokentype = authtokentype_example;  // string | Eco user authentication token type.
            var id = 56;  // int? |  (optional) 

            try
            {
                // Returns a list of votes that were made on the indicated election.
                List&lt;EcoWebServerDataTransferObjectsRunoffVoteDTO&gt; result = apiInstance.ElectionVotes(authtoken, authtokentype, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElectionApi.ElectionVotes: " + e.Message );
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
 **id** | **int?**|  | [optional] 

### Return type

[**List<EcoWebServerDataTransferObjectsRunoffVoteDTO>**](EcoWebServerDataTransferObjectsRunoffVoteDTO.md)

### Authorization

[authtoken](../README.md#authtoken), [authtokentype](../README.md#authtokentype)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

