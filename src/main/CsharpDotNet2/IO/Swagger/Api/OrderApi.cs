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
    public interface IOrderApi
    {
        /// <summary>
        /// Use this to capture/complete a transaction. Partial postauths are allowed. This can be used for postauth and partial postauths.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId</param>
        /// <param name="payload"></param>
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string orderId, SecondaryTransaction payload, string storeId);
        /// <summary>
        /// Use this to return/refund on the order. Partial returns are allowed. This can be used for Returns and Partial Returns.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId</param>
        /// <param name="payload"></param>
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string orderId, SecondaryTransaction payload, string storeId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderApi : IOrderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(String basePath)
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
        /// Use this to capture/complete a transaction. Partial postauths are allowed. This can be used for postauth and partial postauths.
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId</param> 
        /// <param name="payload"></param> 
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string orderId, SecondaryTransaction payload, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'messageSignature' is set
            if (messageSignature == null) throw new ApiException(400, "Missing required parameter 'messageSignature' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'payload' is set
            if (payload == null) throw new ApiException(400, "Missing required parameter 'payload' when calling PerformPaymentPostAuthorisation");
            
    
            var path = "/v1/orders/{order-id}/postauth";
            if (storeId != null)
                path = path + "?storeId=" + storeId;
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order-id" + "}", ApiClient.ParameterToString(orderId));
    
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
                postBody = ApiClient.Serialize(payload); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Use this to return/refund on the order. Partial returns are allowed. This can be used for Returns and Partial Returns.
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId</param> 
        /// <param name="payload"></param> 
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string orderId, SecondaryTransaction payload, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling ReturnTransaction");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling ReturnTransaction");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling ReturnTransaction");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling ReturnTransaction");
            
            // verify the required parameter 'messageSignature' is set
            if (messageSignature == null) throw new ApiException(400, "Missing required parameter 'messageSignature' when calling ReturnTransaction");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling ReturnTransaction");
            
            // verify the required parameter 'payload' is set
            if (payload == null) throw new ApiException(400, "Missing required parameter 'payload' when calling ReturnTransaction");
            
    
            var path = "/v1/orders/{order-id}/return";
            if (storeId != null)
                path = path + "?storeId=" + storeId;
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order-id" + "}", ApiClient.ParameterToString(orderId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            //if (storeId != null) queryParams.Add("storeId", ApiClient.ParameterToString(storeId)); // query parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            if (clientRequestId != null) headerParams.Add("Client-Request-Id", ApiClient.ParameterToString(clientRequestId)); // header parameter
            if (apiKey != null) headerParams.Add("Api-Key", ApiClient.ParameterToString(apiKey)); // header parameter
            if (timestamp != null) headerParams.Add("Timestamp", ApiClient.ParameterToString(timestamp)); // header parameter
            if (messageSignature != null) headerParams.Add("Message-Signature", ApiClient.ParameterToString(messageSignature)); // header parameter
                postBody = ApiClient.Serialize(payload); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            return BuildApiResponse(response);
        }
    
        private ApiResponse BuildApiResponse(IRestResponse response)
        {
            if (((int)response.StatusCode) >= 400)
            {
                TransactionErrorResponse parsedResponse = (TransactionErrorResponse)ApiClient.Deserialize(response.Content, typeof(TransactionErrorResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TransactionInquiry: " + response.ErrorMessage, response.ErrorMessage);
            else
            {
                TransactionResponse parsedResponse = (TransactionResponse)ApiClient.Deserialize(response.Content, typeof(TransactionResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
        }
    }
}
