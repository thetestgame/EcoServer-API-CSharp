/* 
 * Eco Game API
 *
 * First API draft for Eco. Heavy work in progress and subject to changes.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using EcoServer-API.Client;
using EcoServer-API.Model;

namespace EcoServer-API.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilingResultsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns></returns>
        void ProfilingResultsDownload (string filename, string authtoken, string authtokentype);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProfilingResultsDownloadWithHttpInfo (string filename, string authtoken, string authtokentype);
        /// <summary>
        /// Returns the list of generated profiling results.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;</returns>
        List<EcoWebServerDataTransferObjectsProfilingResultDTO> ProfilingResultsList (string authtoken, string authtokentype);

        /// <summary>
        /// Returns the list of generated profiling results.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>ApiResponse of List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;</returns>
        ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>> ProfilingResultsListWithHttpInfo (string authtoken, string authtokentype);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProfilingResultsDownloadAsync (string filename, string authtoken, string authtokentype);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProfilingResultsDownloadAsyncWithHttpInfo (string filename, string authtoken, string authtokentype);
        /// <summary>
        /// Returns the list of generated profiling results.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;</returns>
        System.Threading.Tasks.Task<List<EcoWebServerDataTransferObjectsProfilingResultDTO>> ProfilingResultsListAsync (string authtoken, string authtokentype);

        /// <summary>
        /// Returns the list of generated profiling results.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of ApiResponse (List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>>> ProfilingResultsListAsyncWithHttpInfo (string authtoken, string authtokentype);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProfilingResultsApi : IProfilingResultsApi
    {
        private EcoServer-API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingResultsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfilingResultsApi(String basePath)
        {
            this.Configuration = new EcoServer-API.Client.Configuration { BasePath = basePath };

            ExceptionFactory = EcoServer-API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingResultsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProfilingResultsApi(EcoServer-API.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = EcoServer-API.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = EcoServer-API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public EcoServer-API.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public EcoServer-API.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns></returns>
        public void ProfilingResultsDownload (string filename, string authtoken, string authtokentype)
        {
             ProfilingResultsDownloadWithHttpInfo(filename, authtoken, authtokentype);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProfilingResultsDownloadWithHttpInfo (string filename, string authtoken, string authtokentype)
        {
            // verify the required parameter 'filename' is set
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling ProfilingResultsApi->ProfilingResultsDownload");
            // verify the required parameter 'authtoken' is set
            if (authtoken == null)
                throw new ApiException(400, "Missing required parameter 'authtoken' when calling ProfilingResultsApi->ProfilingResultsDownload");
            // verify the required parameter 'authtokentype' is set
            if (authtokentype == null)
                throw new ApiException(400, "Missing required parameter 'authtokentype' when calling ProfilingResultsApi->ProfilingResultsDownload");

            var localVarPath = "/api/v1/profiling-results/{filename}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (filename != null) localVarPathParams.Add("filename", this.Configuration.ApiClient.ParameterToString(filename)); // path parameter
            if (authtoken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", authtoken)); // query parameter
            if (authtokentype != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", authtokentype)); // query parameter

            // authentication (authtoken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtoken")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", this.Configuration.GetApiKeyWithPrefix("authtoken")));
            }
            // authentication (authtokentype) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtokentype")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", this.Configuration.GetApiKeyWithPrefix("authtokentype")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProfilingResultsDownload", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProfilingResultsDownloadAsync (string filename, string authtoken, string authtokentype)
        {
             await ProfilingResultsDownloadAsyncWithHttpInfo(filename, authtoken, authtokentype);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filename"></param>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProfilingResultsDownloadAsyncWithHttpInfo (string filename, string authtoken, string authtokentype)
        {
            // verify the required parameter 'filename' is set
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling ProfilingResultsApi->ProfilingResultsDownload");
            // verify the required parameter 'authtoken' is set
            if (authtoken == null)
                throw new ApiException(400, "Missing required parameter 'authtoken' when calling ProfilingResultsApi->ProfilingResultsDownload");
            // verify the required parameter 'authtokentype' is set
            if (authtokentype == null)
                throw new ApiException(400, "Missing required parameter 'authtokentype' when calling ProfilingResultsApi->ProfilingResultsDownload");

            var localVarPath = "/api/v1/profiling-results/{filename}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (filename != null) localVarPathParams.Add("filename", this.Configuration.ApiClient.ParameterToString(filename)); // path parameter
            if (authtoken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", authtoken)); // query parameter
            if (authtokentype != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", authtokentype)); // query parameter

            // authentication (authtoken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtoken")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", this.Configuration.GetApiKeyWithPrefix("authtoken")));
            }
            // authentication (authtokentype) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtokentype")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", this.Configuration.GetApiKeyWithPrefix("authtokentype")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProfilingResultsDownload", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Returns the list of generated profiling results. 
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;</returns>
        public List<EcoWebServerDataTransferObjectsProfilingResultDTO> ProfilingResultsList (string authtoken, string authtokentype)
        {
             ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>> localVarResponse = ProfilingResultsListWithHttpInfo(authtoken, authtokentype);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the list of generated profiling results. 
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>ApiResponse of List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;</returns>
        public ApiResponse< List<EcoWebServerDataTransferObjectsProfilingResultDTO> > ProfilingResultsListWithHttpInfo (string authtoken, string authtokentype)
        {
            // verify the required parameter 'authtoken' is set
            if (authtoken == null)
                throw new ApiException(400, "Missing required parameter 'authtoken' when calling ProfilingResultsApi->ProfilingResultsList");
            // verify the required parameter 'authtokentype' is set
            if (authtokentype == null)
                throw new ApiException(400, "Missing required parameter 'authtokentype' when calling ProfilingResultsApi->ProfilingResultsList");

            var localVarPath = "/api/v1/profiling-results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authtoken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", authtoken)); // query parameter
            if (authtokentype != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", authtokentype)); // query parameter

            // authentication (authtoken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtoken")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", this.Configuration.GetApiKeyWithPrefix("authtoken")));
            }
            // authentication (authtokentype) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtokentype")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", this.Configuration.GetApiKeyWithPrefix("authtokentype")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProfilingResultsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EcoWebServerDataTransferObjectsProfilingResultDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EcoWebServerDataTransferObjectsProfilingResultDTO>)));
        }

        /// <summary>
        /// Returns the list of generated profiling results. 
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<EcoWebServerDataTransferObjectsProfilingResultDTO>> ProfilingResultsListAsync (string authtoken, string authtokentype)
        {
             ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>> localVarResponse = await ProfilingResultsListAsyncWithHttpInfo(authtoken, authtokentype);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the list of generated profiling results. 
        /// </summary>
        /// <exception cref="EcoServer-API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authtoken">Eco user authentication token.</param>
        /// <param name="authtokentype">Eco user authentication token type.</param>
        /// <returns>Task of ApiResponse (List&lt;EcoWebServerDataTransferObjectsProfilingResultDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>>> ProfilingResultsListAsyncWithHttpInfo (string authtoken, string authtokentype)
        {
            // verify the required parameter 'authtoken' is set
            if (authtoken == null)
                throw new ApiException(400, "Missing required parameter 'authtoken' when calling ProfilingResultsApi->ProfilingResultsList");
            // verify the required parameter 'authtokentype' is set
            if (authtokentype == null)
                throw new ApiException(400, "Missing required parameter 'authtokentype' when calling ProfilingResultsApi->ProfilingResultsList");

            var localVarPath = "/api/v1/profiling-results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authtoken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", authtoken)); // query parameter
            if (authtokentype != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", authtokentype)); // query parameter

            // authentication (authtoken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtoken")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtoken", this.Configuration.GetApiKeyWithPrefix("authtoken")));
            }
            // authentication (authtokentype) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("authtokentype")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "authtokentype", this.Configuration.GetApiKeyWithPrefix("authtokentype")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProfilingResultsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<EcoWebServerDataTransferObjectsProfilingResultDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EcoWebServerDataTransferObjectsProfilingResultDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EcoWebServerDataTransferObjectsProfilingResultDTO>)));
        }

    }
}
