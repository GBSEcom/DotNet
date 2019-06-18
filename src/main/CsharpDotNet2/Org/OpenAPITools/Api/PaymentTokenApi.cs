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
    public interface IPaymentTokenApi
    {
        /// <summary>
        /// Create a payment token from a payment card. Use this to create a payment token from a payment card.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="paymentTokenizationRequest">Accepted request types: PaymentCardPaymentTokenizationRequest and ReferencedOrderPaymentTokenizationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="authorization">The access token previously generated with the access-tokens call. Use the format &#39;Bearer {access-token}&#39;.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <returns>PaymentTokenizationResponse</returns>
        ApiResponse CreatePaymentToken (string contentType, string clientRequestId, string apiKey, long? timestamp, PaymentTokenizationRequest paymentTokenizationRequest, string messageSignature, string authorization, string region);
        /// <summary>
        /// Delete a payment token. Use this to delete a payment token.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="tokenId">Identifies a payment token.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="authorization">The access token previously generated with the access-tokens call. Use the format &#39;Bearer {access-token}&#39;.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <param name="storeId"></param>
        /// <returns>PaymentTokenizationResponse</returns>
        ApiResponse DeletePaymentToken (string contentType, string clientRequestId, string apiKey, long? timestamp, string tokenId, string messageSignature, string authorization, string region, string storeId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentTokenApi : IPaymentTokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentTokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentTokenApi(String basePath)
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
        /// Create a payment token from a payment card. Use this to create a payment token from a payment card.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="paymentTokenizationRequest">Accepted request types: PaymentCardPaymentTokenizationRequest and ReferencedOrderPaymentTokenizationRequest.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="authorization">The access token previously generated with the access-tokens call. Use the format &#39;Bearer {access-token}&#39;.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <returns>PaymentTokenizationResponse</returns>            
        public ApiResponse CreatePaymentToken (string contentType, string clientRequestId, string apiKey, long? timestamp, PaymentTokenizationRequest paymentTokenizationRequest, string messageSignature, string authorization, string region)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreatePaymentToken");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling CreatePaymentToken");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling CreatePaymentToken");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling CreatePaymentToken");
            
            // verify the required parameter 'paymentTokenizationRequest' is set
            if (paymentTokenizationRequest == null) throw new ApiException(400, "Missing required parameter 'paymentTokenizationRequest' when calling CreatePaymentToken");
            
    
            var path = "/payment-tokens";
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
            if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
            postBody = ApiClient.Serialize(paymentTokenizationRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Delete a payment token. Use this to delete a payment token.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="tokenId">Identifies a payment token.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="authorization">The access token previously generated with the access-tokens call. Use the format &#39;Bearer {access-token}&#39;.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <param name="storeId"></param> 
        /// <returns>PaymentTokenizationResponse</returns>            
        public ApiResponse DeletePaymentToken (string contentType, string clientRequestId, string apiKey, long? timestamp, string tokenId, string messageSignature, string authorization, string region, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeletePaymentToken");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling DeletePaymentToken");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling DeletePaymentToken");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling DeletePaymentToken");
            
            // verify the required parameter 'tokenId' is set
            if (tokenId == null) throw new ApiException(400, "Missing required parameter 'tokenId' when calling DeletePaymentToken");
            
    
            var path = "/payment-tokens/{token-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "token-id" + "}", ApiClient.ParameterToString(tokenId));
    
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
            if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            return BuildApiResponse(response);
        }

        private ApiResponse BuildApiResponse(IRestResponse response)
        {
            if ((int)response.StatusCode >= 400)
            {
                ErrorResponse parsedResponse = (ErrorResponse)ApiClient.Deserialize(response.Content, typeof(ErrorResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            if ((int)response.StatusCode < 400)
            {
                PaymentTokenizationResponse parsedResponse = (PaymentTokenizationResponse)ApiClient.Deserialize(response.Content, typeof(PaymentTokenizationResponse), response.Headers);
                return new ApiResponse((int)response.StatusCode, parsedResponse, response.Headers);
            }
            throw new ApiException((int)response.StatusCode, "Error parsing API response status code: " + response.ErrorMessage, response.ErrorMessage);
        }
    
    }
}
