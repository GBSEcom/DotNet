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
    public interface IPaymentApi
    {
        /// <summary>
        /// Use this to capture/complete a transaction. Partial postauths are allowed. This can be used for postauth and partial postauths.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param>
        /// <param name="payload"></param>
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, SecondaryTransaction payload, string storeId);
        /// <summary>
        /// Generate a primary transaction Use this to originate a financial transaction, like a sale, preauthorization, or credit.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="payload">Primary Transaction request</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse PrimaryPaymentTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, PrimaryTransaction payload);
        /// <summary>
        /// Return/refund a transaction. Use this to return/refund an existing transaction.  Partial returns are allowed.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param>
        /// <param name="payload"></param>
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, SecondaryTransaction payload, string storeId);
        /// <summary>
        /// Retrieve the state of a transaction Use this query to get the current state of an existing transaction.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param>
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse TransactionInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, string storeId);
        /// <summary>
        /// Reverse a previous action on an existing transaction Use this to reverse a postauth/completion, credit, preauth, or sale.
        /// </summary>
        /// <param name="contentType">content type</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey"></param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param>
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse VoidTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, string storeId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentApi : IPaymentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentApi(String basePath)
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
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param> 
        /// <param name="payload"></param> 
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, SecondaryTransaction payload, string storeId)
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
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling PerformPaymentPostAuthorisation");
            
            // verify the required parameter 'payload' is set
            if (payload == null) throw new ApiException(400, "Missing required parameter 'payload' when calling PerformPaymentPostAuthorisation");
            
    
            var path = "/v1/payments/{transaction-id}/postauth";
            if (storeId != null)
                path = path + "?storeId=" + storeId;
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "transaction-id" + "}", ApiClient.ParameterToString(transactionId));
    
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
        /// Generate a primary transaction Use this to originate a financial transaction, like a sale, preauthorization, or credit.
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="payload">Primary Transaction request</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse PrimaryPaymentTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, PrimaryTransaction payload)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling PrimaryPaymentTransaction");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling PrimaryPaymentTransaction");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling PrimaryPaymentTransaction");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling PrimaryPaymentTransaction");
            
            // verify the required parameter 'messageSignature' is set
            if (messageSignature == null) throw new ApiException(400, "Missing required parameter 'messageSignature' when calling PrimaryPaymentTransaction");
            
            // verify the required parameter 'payload' is set
            if (payload == null) throw new ApiException(400, "Missing required parameter 'payload' when calling PrimaryPaymentTransaction");
            
    
            var path = "/v1/payments";
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
                postBody = ApiClient.Serialize(payload); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Return/refund a transaction. Use this to return/refund an existing transaction.  Partial returns are allowed.
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param> 
        /// <param name="payload"></param> 
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, SecondaryTransaction payload, string storeId)
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
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling ReturnTransaction");
            
            // verify the required parameter 'payload' is set
            if (payload == null) throw new ApiException(400, "Missing required parameter 'payload' when calling ReturnTransaction");
            
    
            var path = "/v1/payments/{transaction-id}/return";
            if (storeId != null)
                path = path + "?storeId=" + storeId;
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "transaction-id" + "}", ApiClient.ParameterToString(transactionId));
    
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
        /// Retrieve the state of a transaction Use this query to get the current state of an existing transaction.
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param> 
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse TransactionInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling TransactionInquiry");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling TransactionInquiry");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling TransactionInquiry");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling TransactionInquiry");
            
            // verify the required parameter 'messageSignature' is set
            if (messageSignature == null) throw new ApiException(400, "Missing required parameter 'messageSignature' when calling TransactionInquiry");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionInquiry");
            
    
            var path = "/v1/payments/{transaction-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "transaction-id" + "}", ApiClient.ParameterToString(transactionId));
    
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
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Reverse a previous action on an existing transaction Use this to reverse a postauth/completion, credit, preauth, or sale.
        /// </summary>
        /// <param name="contentType">content type</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey"></param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId</param> 
        /// <param name="storeId">an optional outlet id for clients that support multiple store in the same developer app</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse VoidTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling VoidTransaction");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling VoidTransaction");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling VoidTransaction");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling VoidTransaction");
            
            // verify the required parameter 'messageSignature' is set
            if (messageSignature == null) throw new ApiException(400, "Missing required parameter 'messageSignature' when calling VoidTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling VoidTransaction");
            
    
            var path = "/v1/payments/{transaction-id}/void";
            if (storeId != null)
                path = path + "?storeId=" + storeId;
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "transaction-id" + "}", ApiClient.ParameterToString(transactionId));
    
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
    
            return BuildApiResponse(response);
        }

        private ApiResponse BuildApiResponse(IRestResponse response){
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
