using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderApi
    {
        /// <summary>
        /// Retrieve the state of an order. Use this query to get the current state of an existing order.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app.</param>
        /// <returns>OrderResponse</returns>
        ApiResponse OrderInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, string messageSignature, string region, string storeId);
        /// <summary>
        /// Perform return or postAuth secondary transactions. Use this to perform a postAuth or return secondary transaction using order ID. Partial postAuths and returns are allowed.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId.</param>
        /// <param name="secondaryTransaction">Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse SubmitSecondaryTransactionFromOrder (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, SecondaryTransaction secondaryTransaction, string messageSignature, string region);
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
        /// Retrieve the state of an order. Use this query to get the current state of an existing order.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app.</param> 
        /// <returns>OrderResponse</returns>            
        public ApiResponse OrderInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, string messageSignature, string region, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling OrderInquiry");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling OrderInquiry");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling OrderInquiry");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling OrderInquiry");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling OrderInquiry");
            
    
            var path = "/orders/{order-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order-id" + "}", ApiClient.ParameterToString(orderId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            if (storeId != null) queryParams.Add("storeId", ApiClient.ParameterToString(storeId)); // query parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            if (clientRequestId != null) headerParams.Add("Client-Request-Id", ApiClient.ParameterToString(clientRequestId)); // header parameter
            if (apiKey != null) headerParams.Add("Api-Key", ApiClient.ParameterToString(apiKey)); // header parameter
            if (timestamp != null) headerParams.Add("Timestamp", ApiClient.ParameterToString(timestamp)); // header parameter
            if (messageSignature != null) headerParams.Add("Message-Signature", ApiClient.ParameterToString(messageSignature)); // header parameter
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if ((int)response.StatusCode < 400)
            {
                OrderResponse parsedResponse = (OrderResponse)ApiClient.Deserialize(response.Content, typeof(OrderResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            if ((int)response.StatusCode == 0)
            {
                throw new ApiException((int)response.StatusCode, "Error parsing API response status code: " + response.ErrorMessage, response.ErrorMessage);
            }
            else
            {
                ErrorResponse parsedResponse = (ErrorResponse)ApiClient.Deserialize(response.Content, typeof(ErrorResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
        }
    
        /// <summary>
        /// Perform return or postAuth secondary transactions. Use this to perform a postAuth or return secondary transaction using order ID. Partial postAuths and returns are allowed.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="orderId">Gateway order identifier as returned in the parameter orderId.</param> 
        /// <param name="secondaryTransaction">Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse SubmitSecondaryTransactionFromOrder (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, SecondaryTransaction secondaryTransaction, string messageSignature, string region)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling SubmitSecondaryTransactionFromOrder");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling SubmitSecondaryTransactionFromOrder");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling SubmitSecondaryTransactionFromOrder");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling SubmitSecondaryTransactionFromOrder");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling SubmitSecondaryTransactionFromOrder");
            
            // verify the required parameter 'secondaryTransaction' is set
            if (secondaryTransaction == null) throw new ApiException(400, "Missing required parameter 'secondaryTransaction' when calling SubmitSecondaryTransactionFromOrder");
            
    
            var path = "/orders/{order-id}";
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
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
            postBody = ApiClient.Serialize(secondaryTransaction); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            return BuildApiResponse(response);
        }

        private ApiResponse BuildApiResponse(IRestResponse response)
        {
            if ((int)response.StatusCode < 400)
            {
                TransactionResponse parsedResponse = (TransactionResponse)ApiClient.Deserialize(response.Content, typeof(TransactionResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            if ((int)response.StatusCode == 409 || (int)response.StatusCode == 422)
            {
                TransactionErrorResponse parsedResponse = (TransactionErrorResponse)ApiClient.Deserialize(response.Content, typeof(TransactionErrorResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            if ((int)response.StatusCode >= 400)
            {
                ErrorResponse parsedResponse = (ErrorResponse)ApiClient.Deserialize(response.Content, typeof(ErrorResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            throw new ApiException((int)response.StatusCode, "Error parsing API response status code: " + response.ErrorMessage, response.ErrorMessage);
        }
    }
}
