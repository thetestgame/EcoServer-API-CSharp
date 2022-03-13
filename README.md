# EcoServer-API - the C# library for the Eco Game API

First API draft for Eco. Heavy work in progress and subject to changes.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out EcoServer-API.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using EcoServer-API.Api;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: authtoken
            Configuration.Default.ApiKey.Add("authtoken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authtoken", "Bearer");
            // Configure API key authorization: authtokentype
            Configuration.Default.ApiKey.Add("authtokentype", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authtokentype", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**AdminGetGetAccess**](docs/AdminApi.md#admingetgetaccess) | **GET** /api/v1/admin/get/access | 
*AdminApi* | [**AdminGetGetServerName**](docs/AdminApi.md#admingetgetservername) | **GET** /api/v1/admin/get/servername | 
*AdminApi* | [**AdminPostGameExport**](docs/AdminApi.md#adminpostgameexport) | **POST** /api/v1/admin/game/export | 
*AdminApi* | [**AdminPostSetAccess**](docs/AdminApi.md#adminpostsetaccess) | **POST** /api/v1/admin/set/access | Sets how accessible this server is.
*AdminApi* | [**AdminPostSetServerName**](docs/AdminApi.md#adminpostsetservername) | **POST** /api/v1/admin/set/servername | 
*ChatApi* | [**ChatGetChat**](docs/ChatApi.md#chatgetchat) | **GET** /api/v1/chat | Returns all non-private player chat messages sent within the given time range.
*ChatApi* | [**ChatGetChatByTag**](docs/ChatApi.md#chatgetchatbytag) | **GET** /api/v1/chat/tag | Returns all non-private player chat messages sent to the given tag within the given time range.
*ChatApi* | [**ChatGetChatMessagesSentBy**](docs/ChatApi.md#chatgetchatmessagessentby) | **GET** /api/v1/chat/{username} | Returns all non-private chat messages sent by the given user within the given time range.
*ChatApi* | [**ChatGetNext**](docs/ChatApi.md#chatgetnext) | **POST** /api/v1/chat/next | Gets the. <code>numNextMessages</code> chat messages sent after the given message on the same tag.
*ChatApi* | [**ChatGetPrevious**](docs/ChatApi.md#chatgetprevious) | **POST** /api/v1/chat/previous | Gets the. <code>numPreviousMessages</code> chat messages sent before the given message on the same tag.
*ChatApi* | [**ChatSendChat**](docs/ChatApi.md#chatsendchat) | **GET** /api/v1/chat/sendChat | Sends chat message like username.
*CommandApi* | [**CommandExecCommand**](docs/CommandApi.md#commandexeccommand) | **POST** /api/v1/command/exec | Executes a chat command on the server.
*DataExportApi* | [**DataExportGetActionList**](docs/DataExportApi.md#dataexportgetactionlist) | **GET** /api/v1/exporter/actionlist | 
*DataExportApi* | [**DataExportGetEnvironmentList**](docs/DataExportApi.md#dataexportgetenvironmentlist) | **GET** /api/v1/exporter/environmentlist | 
*DataExportApi* | [**DataExportGetExportAction**](docs/DataExportApi.md#dataexportgetexportaction) | **GET** /api/v1/exporter/actions | 
*DataExportApi* | [**DataExportGetExportEnvironment**](docs/DataExportApi.md#dataexportgetexportenvironment) | **GET** /api/v1/exporter/environment | 
*DataExportApi* | [**DataExportGetExportSpecies**](docs/DataExportApi.md#dataexportgetexportspecies) | **GET** /api/v1/exporter/species | 
*DataExportApi* | [**DataExportGetSpeciesList**](docs/DataExportApi.md#dataexportgetspecieslist) | **GET** /api/v1/exporter/specieslist | 
*DataExportApi* | [**DataExportPostExportActions**](docs/DataExportApi.md#dataexportpostexportactions) | **POST** /api/v1/exporter/actions | 
*DataExportApi* | [**DataExportPostExportAll**](docs/DataExportApi.md#dataexportpostexportall) | **POST** /api/v1/exporter/all | 
*DataExportApi* | [**DataExportPostExportChat**](docs/DataExportApi.md#dataexportpostexportchat) | **POST** /api/v1/exporter/chat | 
*DataExportApi* | [**DataExportPostExportEnvironment**](docs/DataExportApi.md#dataexportpostexportenvironment) | **POST** /api/v1/exporter/environment | 
*DataExportApi* | [**DataExportPostExportSpecies**](docs/DataExportApi.md#dataexportpostexportspecies) | **POST** /api/v1/exporter/species | 
*ElectionApi* | [**ElectionAddComment**](docs/ElectionApi.md#electionaddcomment) | **POST** /api/v1/elections/addcomment | Adds a comment to the currently running election, if any.
*ElectionApi* | [**ElectionFinishElection**](docs/ElectionApi.md#electionfinishelection) | **POST** /api/v1/elections/finishelection | 
*ElectionApi* | [**ElectionForceElectionEnd**](docs/ElectionApi.md#electionforceelectionend) | **POST** /api/v1/elections/forceelectionend | Forces the currently running election to end now, and for the current election winner to become the leader. Can only be called by an admin or dev.
*ElectionApi* | [**ElectionGenerateTestData**](docs/ElectionApi.md#electiongeneratetestdata) | **POST** /api/v1/elections/generatetestdata | Create a bunch of test elections.
*ElectionApi* | [**ElectionGetComments**](docs/ElectionApi.md#electiongetcomments) | **GET** /api/v1/elections/listcomments | List comments on the election.
*ElectionApi* | [**ElectionGetElectedTitleById**](docs/ElectionApi.md#electiongetelectedtitlebyid) | **GET** /api/v1/elections/titles/{id} | Returns the elected title with the given id.
*ElectionApi* | [**ElectionGetElectionById**](docs/ElectionApi.md#electiongetelectionbyid) | **GET** /api/v1/elections/{id} | Returns the election with the given id.
*ElectionApi* | [**ElectionListElectedTitles**](docs/ElectionApi.md#electionlistelectedtitles) | **GET** /api/v1/elections/titles | Returns all elected titles and their occupants matching the given state (active by default).
*ElectionApi* | [**ElectionListElections**](docs/ElectionApi.md#electionlistelections) | **GET** /api/v1/elections | Returns all elections that are either active or inactive.
*ElectionApi* | [**ElectionVote**](docs/ElectionApi.md#electionvote) | **POST** /api/v1/elections/vote | Places a vote on behalf of the given player.  Can only be called if an election is currently running.
*ElectionApi* | [**ElectionVotes**](docs/ElectionApi.md#electionvotes) | **GET** /api/v1/elections/votes | Returns a list of votes that were made on the indicated election.
*LawApi* | [**LawGenerateTestData**](docs/LawApi.md#lawgeneratetestdata) | **POST** /api/v1/laws/generatetestdata | Genereate test laws.
*LawApi* | [**LawGetDistrictMap**](docs/LawApi.md#lawgetdistrictmap) | **GET** /api/v1/laws/districtmap/{name} | 
*LawApi* | [**LawGetLaw**](docs/LawApi.md#lawgetlaw) | **GET** /api/v1/laws/{id} | Returns the law with the specified id.
*LawApi* | [**LawList**](docs/LawApi.md#lawlist) | **GET** /api/v1/laws/byStates/{states} | Returns all laws currently present in the game in the specified states, active by default.
*LawApi* | [**LawListAll**](docs/LawApi.md#lawlistall) | **GET** /api/v1/laws | Returns all laws currently present in the game
*LogApi* | [**LogGetAllLogs**](docs/LogApi.md#loggetalllogs) | **GET** /api/v1/logs | Retrieves a list of all log files on the server.
*LogApi* | [**LogGetCategoryLogs**](docs/LogApi.md#loggetcategorylogs) | **GET** /api/v1/logs/{category} | Retrieves a list of all log files in the requested category subfolder if it exists.
*LogApi* | [**LogGetLogFile**](docs/LogApi.md#loggetlogfile) | **GET** /api/v1/logs/get | Streams a log file over HTTP/HTTPS to a client.
*MapApi* | [**MapEntities**](docs/MapApi.md#mapentities) | **GET** /api/v1/map/entities | Allows access to all entities currently available in the simulation.
*MapApi* | [**MapEntityTypes**](docs/MapApi.md#mapentitytypes) | **GET** /api/v1/map/entitytypes | Allows access to all species currently available in the simulation.
*MapApi* | [**MapGetDimension**](docs/MapApi.md#mapgetdimension) | **GET** /api/v1/map/dimension | Returns the dimension of the world, in blocks.
*MapApi* | [**MapGetProperty**](docs/MapApi.md#mapgetproperty) | **GET** /api/v1/map/property | 
*MapApi* | [**MapLayerList**](docs/MapApi.md#maplayerlist) | **GET** /api/v1/map/layerList | List Layer Names.
*MapApi* | [**MapMakeMapJSON**](docs/MapApi.md#mapmakemapjson) | **GET** /api/v1/map/map.json | One request to get all required web map data.
*MapApi* | [**MapMapStats**](docs/MapApi.md#mapmapstats) | **GET** /api/v1/map/mapstats | 
*MapApi* | [**MapWaterLevel**](docs/MapApi.md#mapwaterlevel) | **GET** /api/v1/map/waterLevel | Get water height.
*PluginsApi* | [**PluginsGetPluginConfig**](docs/PluginsApi.md#pluginsgetpluginconfig) | **GET** /api/v1/plugins/{name} | 
*PluginsApi* | [**PluginsGetPlugins**](docs/PluginsApi.md#pluginsgetplugins) | **GET** /api/v1/plugins | Gets the list and status of all running plugins on the server.
*PluginsApi* | [**PluginsPostPluginConfig**](docs/PluginsApi.md#pluginspostpluginconfig) | **POST** /api/v1/plugins/{name} | Sets the configuration options for the given plugin.
*ProfilingResultsApi* | [**ProfilingResultsDownload**](docs/ProfilingResultsApi.md#profilingresultsdownload) | **GET** /api/v1/profiling-results/{filename} | 
*ProfilingResultsApi* | [**ProfilingResultsList**](docs/ProfilingResultsApi.md#profilingresultslist) | **GET** /api/v1/profiling-results | Returns the list of generated profiling results.
*RootApi* | [**RootFrontPage**](docs/RootApi.md#rootfrontpage) | **GET** /frontpage | 
*RootApi* | [**RootGetAdmins**](docs/RootApi.md#rootgetadmins) | **GET** /admins | Returns the server's configured administrative users.
*RootApi* | [**RootGetInfo**](docs/RootApi.md#rootgetinfo) | **GET** /info | 
*RootApi* | [**RootIsAdmin**](docs/RootApi.md#rootisadmin) | **GET** /isadmin | Return if the user is an admin and authentication is required.
*StatsApi* | [**StatsGenerateTestData**](docs/StatsApi.md#statsgeneratetestdata) | **GET** /datasets/generatetestdata | Generates fake stat data for testing.
*StatsApi* | [**StatsGet**](docs/StatsApi.md#statsget) | **GET** /datasets/get | /// Returns Eco.WebServer.Web.Controllers.StatsController.MaximumSamples data points between dayStart and dayEnd of the selected data.             If there are more than Eco.WebServer.Web.Controllers.StatsController.MaximumSamples samples, it will be averaged out to contain exactly Eco.WebServer.Web.Controllers.StatsController.MaximumSamples.///.
*StatsApi* | [**StatsGetFlatList**](docs/StatsApi.md#statsgetflatlist) | **GET** /datasets/flatlist | /// Returns all stat infos that contain data, formatted as a list, where each key is a list of strings. ///.
*StatsApi* | [**StatsGetList**](docs/StatsApi.md#statsgetlist) | **GET** /datasets/getlist | Returns a \"package\" of multiple statistics in the order of their request.
*StatsApi* | [**StatsGetTimeRange**](docs/StatsApi.md#statsgettimerange) | **GET** /datasets/timerange | /// Returns the timerange of the simulation, in days///.
*StatsApi* | [**StatsGetTreeList**](docs/StatsApi.md#statsgettreelist) | **GET** /datasets/treelist | Returns all dataset keys, formatted as a tree. ///.
*StatsApi* | [**StatsGraphs**](docs/StatsApi.md#statsgraphs) | **GET** /datasets/graphs | Returns the list of premade graphs to be displayed on the front page.
*UsersApi* | [**UsersGetUsers**](docs/UsersApi.md#usersgetusers) | **GET** /api/v1/users | 
*WorldLayerApi* | [**WorldLayerAreaDescription**](docs/WorldLayerApi.md#worldlayerareadescription) | **GET** /api/v1/worldlayers/relationships/areadescription | Describes the area selected with a string.
*WorldLayerApi* | [**WorldLayerListLayers**](docs/WorldLayerApi.md#worldlayerlistlayers) | **GET** /api/v1/worldlayers/layers | Enumerates every world layer in the simulation.
*WorldLayerApi* | [**WorldLayerListRelevantLayers**](docs/WorldLayerApi.md#worldlayerlistrelevantlayers) | **GET** /api/v1/worldlayers/layers/{focusLayer} | Enumerates the layers that should be displayed when the user is focused on a particular layer and world area.
*WorldLayerApi* | [**WorldLayerListRelevantRelationships**](docs/WorldLayerApi.md#worldlayerlistrelevantrelationships) | **GET** /api/v1/worldlayers/relationships/{focusLayer} | Enumerates the layer relationships that should be displayed when the user is focused on a particular layer and world area.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.EcoGameplayCivicsElectionsChoiceResults](docs/EcoGameplayCivicsElectionsChoiceResults.md)
 - [Model.EcoSharedItemsProposableState](docs/EcoSharedItemsProposableState.md)
 - [Model.EcoSharedLocalizationLocString](docs/EcoSharedLocalizationLocString.md)
 - [Model.EcoSharedMathRay](docs/EcoSharedMathRay.md)
 - [Model.EcoSharedMathVector2i](docs/EcoSharedMathVector2i.md)
 - [Model.EcoSharedMathVector3i](docs/EcoSharedMathVector3i.md)
 - [Model.EcoSharedNetworkingServerInfo](docs/EcoSharedNetworkingServerInfo.md)
 - [Model.EcoSharedNetworkingSkillSpecializationSetting](docs/EcoSharedNetworkingSkillSpecializationSetting.md)
 - [Model.EcoSharedStatesServerCategory](docs/EcoSharedStatesServerCategory.md)
 - [Model.EcoStatsGraph](docs/EcoStatsGraph.md)
 - [Model.EcoStatsKey](docs/EcoStatsKey.md)
 - [Model.EcoStatsNamedGraph](docs/EcoStatsNamedGraph.md)
 - [Model.EcoStatsStatCategory](docs/EcoStatsStatCategory.md)
 - [Model.EcoStatsStatInfo](docs/EcoStatsStatInfo.md)
 - [Model.EcoWebServerDataTransferObjectsChatMessageDTO](docs/EcoWebServerDataTransferObjectsChatMessageDTO.md)
 - [Model.EcoWebServerDataTransferObjectsCivicActionDTO](docs/EcoWebServerDataTransferObjectsCivicActionDTO.md)
 - [Model.EcoWebServerDataTransferObjectsCommandResultDTO](docs/EcoWebServerDataTransferObjectsCommandResultDTO.md)
 - [Model.EcoWebServerDataTransferObjectsDistrictDTO](docs/EcoWebServerDataTransferObjectsDistrictDTO.md)
 - [Model.EcoWebServerDataTransferObjectsDistrictMapDTO](docs/EcoWebServerDataTransferObjectsDistrictMapDTO.md)
 - [Model.EcoWebServerDataTransferObjectsElectedTitleDTO](docs/EcoWebServerDataTransferObjectsElectedTitleDTO.md)
 - [Model.EcoWebServerDataTransferObjectsElectionChoiceDTO](docs/EcoWebServerDataTransferObjectsElectionChoiceDTO.md)
 - [Model.EcoWebServerDataTransferObjectsElectionCommentDTO](docs/EcoWebServerDataTransferObjectsElectionCommentDTO.md)
 - [Model.EcoWebServerDataTransferObjectsElectionDTO](docs/EcoWebServerDataTransferObjectsElectionDTO.md)
 - [Model.EcoWebServerDataTransferObjectsElectionProcessDTO](docs/EcoWebServerDataTransferObjectsElectionProcessDTO.md)
 - [Model.EcoWebServerDataTransferObjectsElectionResultsDTO](docs/EcoWebServerDataTransferObjectsElectionResultsDTO.md)
 - [Model.EcoWebServerDataTransferObjectsEntityDTO](docs/EcoWebServerDataTransferObjectsEntityDTO.md)
 - [Model.EcoWebServerDataTransferObjectsExecuteCommandDTO](docs/EcoWebServerDataTransferObjectsExecuteCommandDTO.md)
 - [Model.EcoWebServerDataTransferObjectsFrontPage](docs/EcoWebServerDataTransferObjectsFrontPage.md)
 - [Model.EcoWebServerDataTransferObjectsLawDTO](docs/EcoWebServerDataTransferObjectsLawDTO.md)
 - [Model.EcoWebServerDataTransferObjectsMapDTO](docs/EcoWebServerDataTransferObjectsMapDTO.md)
 - [Model.EcoWebServerDataTransferObjectsMapStats](docs/EcoWebServerDataTransferObjectsMapStats.md)
 - [Model.EcoWebServerDataTransferObjectsPluginInfo](docs/EcoWebServerDataTransferObjectsPluginInfo.md)
 - [Model.EcoWebServerDataTransferObjectsProfilingResultDTO](docs/EcoWebServerDataTransferObjectsProfilingResultDTO.md)
 - [Model.EcoWebServerDataTransferObjectsRunoffVoteDTO](docs/EcoWebServerDataTransferObjectsRunoffVoteDTO.md)
 - [Model.EcoWebServerDataTransferObjectsUserDTO](docs/EcoWebServerDataTransferObjectsUserDTO.md)
 - [Model.EcoWebServerDataTransferObjectsVector3DTO](docs/EcoWebServerDataTransferObjectsVector3DTO.md)
 - [Model.EcoWebServerDataTransferObjectsWorldLayersLayerRelationshipDTO](docs/EcoWebServerDataTransferObjectsWorldLayersLayerRelationshipDTO.md)
 - [Model.EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO](docs/EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO.md)
 - [Model.EcoWebServerDataTransferObjectsWorldLayersWorldLayerGroupDTO](docs/EcoWebServerDataTransferObjectsWorldLayersWorldLayerGroupDTO.md)
 - [Model.EcoWebServerWebControllersStatReturn](docs/EcoWebServerWebControllersStatReturn.md)
 - [Model.EcoWebServerWebModelsAction](docs/EcoWebServerWebModelsAction.md)
 - [Model.EcoWebServerWebModelsAdminReturnModel](docs/EcoWebServerWebModelsAdminReturnModel.md)
 - [Model.EcoWebServerWebModelsExportGameModel](docs/EcoWebServerWebModelsExportGameModel.md)
 - [Model.NewtonsoftJsonLinqJToken](docs/NewtonsoftJsonLinqJToken.md)
 - [Model.SystemNumericsVector3](docs/SystemNumericsVector3.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="authtoken"></a>
### authtoken

- **Type**: API key
- **API key parameter name**: authtoken
- **Location**: URL query string

<a name="authtokentype"></a>
### authtokentype

- **Type**: API key
- **API key parameter name**: authtokentype
- **Location**: URL query string

