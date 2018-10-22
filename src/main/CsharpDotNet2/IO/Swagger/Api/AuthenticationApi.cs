using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi
    {
        /// <summary>
        /// Generate an access token for user authentication This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests. 
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <returns>AccessTokenResponse</returns>
        AccessTokenResponse V1AuthenticationAccessTokensPost (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationApi : IAuthenticationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Generate an access token for user authentication This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests. 
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <returns>AccessTokenResponse</returns>            
        public AccessTokenResponse V1AuthenticationAccessTokensPost (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling V1AuthenticationAccessTokensPost");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling V1AuthenticationAccessTokensPost");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling V1AuthenticationAccessTokensPost");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling V1AuthenticationAccessTokensPost");
            
            // verify the required parameter 'messageSignature' is set
            if (messageSignature == null) throw new ApiException(400, "Missing required parameter 'messageSignature' when calling V1AuthenticationAccessTokensPost");
            
    
            var path = "/v1/authentication/access-tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
 if (clientRequestId != null) headerParams.Add("Client-Request-Id", ApiClient.ParameterToString(clientRequestId)); // header parameter
 if (apiKey != null) headerParams.Add("Api-Key", ApiClient.ParameterToString(apiKey)); // header parameter
 if (timestamp != null) headerParams.Add("Timestamp", ApiClient.ParameterToString(timestamp)); // header parameter
 if (messageSignature != null) headerParams.Add("Message-Signature", ApiClient.ParameterToString(messageSignature)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1AuthenticationAccessTokensPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1AuthenticationAccessTokensPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessTokenResponse) ApiClient.Deserialize(response.Content, typeof(AccessTokenResponse), response.Headers);
        }
    
    }
}
