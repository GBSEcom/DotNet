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
    public interface IPaymentApi
    {
        /// <summary>
        /// Update a 3DSecure or UnionPay payment and continue processing. Use this to handle a 3DSecure redirect response or UnionPay authentication, updating the transaction and continuing processing.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId.</param>
        /// <param name="authenticationVerificationRequest">Accepted request types: Secure3dAuthenticationVerificationRequest and UnionPayAuthenticationVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse FinalizeSecureTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, AuthenticationVerificationRequest authenticationVerificationRequest, string messageSignature, string region);
        /// <summary>
        /// Generate a primary transaction. Use this to originate a financial transaction like a sale, preauthorization, or credit.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="primaryTransaction">Accepted request types: AliPaySaleTransaction, ChinaPnRSaleTransaction, PaymentCardCreditTransaction, PaymentCardForcedTicketTransaction, PaymentCardSaleTransaction, PaymentCardPreAuthTransaction, PaymentCardPayerAuthTransaction, PaymentTokenCreditTransaction, PaymentTokenPreAuthTransaction, PaymentTokenSaleTransaction, PaypalCreditTransaction, and SepaSaleTransaction.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse SubmitPrimaryTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, PrimaryTransaction primaryTransaction, string messageSignature, string region);
        /// <summary>
        /// Perform a secondary transaction. Use this to perform a void, postAuth or return secondary transaction. Partial postAuths and returns are allowed.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId.</param>
        /// <param name="secondaryTransaction">Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app.</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse SubmitSecondaryTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId);
        /// <summary>
        /// Retrieve the state of a transaction. Use this query to get the current state of an existing transaction.
        /// </summary>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app.</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse TransactionInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, string messageSignature, string region, string storeId);
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
        /// Update a 3DSecure or UnionPay payment and continue processing. Use this to handle a 3DSecure redirect response or UnionPay authentication, updating the transaction and continuing processing.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId.</param> 
        /// <param name="authenticationVerificationRequest">Accepted request types: Secure3dAuthenticationVerificationRequest and UnionPayAuthenticationVerificationRequest.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse FinalizeSecureTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, AuthenticationVerificationRequest authenticationVerificationRequest, string messageSignature, string region)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling FinalizeSecureTransaction");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling FinalizeSecureTransaction");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling FinalizeSecureTransaction");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling FinalizeSecureTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling FinalizeSecureTransaction");
            
            // verify the required parameter 'authenticationVerificationRequest' is set
            if (authenticationVerificationRequest == null) throw new ApiException(400, "Missing required parameter 'authenticationVerificationRequest' when calling FinalizeSecureTransaction");
            
    
            var path = "/payments/{transaction-id}";
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
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
            postBody = ApiClient.Serialize(authenticationVerificationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
       
            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Generate a primary transaction. Use this to originate a financial transaction like a sale, preauthorization, or credit.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="primaryTransaction">Accepted request types: AliPaySaleTransaction, ChinaPnRSaleTransaction, PaymentCardCreditTransaction, PaymentCardForcedTicketTransaction, PaymentCardSaleTransaction, PaymentCardPreAuthTransaction, PaymentCardPayerAuthTransaction, PaymentTokenCreditTransaction, PaymentTokenPreAuthTransaction, PaymentTokenSaleTransaction, PaypalCreditTransaction, and SepaSaleTransaction.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse SubmitPrimaryTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, PrimaryTransaction primaryTransaction, string messageSignature, string region)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling SubmitPrimaryTransaction");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling SubmitPrimaryTransaction");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling SubmitPrimaryTransaction");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling SubmitPrimaryTransaction");
            
            // verify the required parameter 'primaryTransaction' is set
            if (primaryTransaction == null) throw new ApiException(400, "Missing required parameter 'primaryTransaction' when calling SubmitPrimaryTransaction");
            
    
            var path = "/payments";
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
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
            postBody = ApiClient.Serialize(primaryTransaction); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Perform a secondary transaction. Use this to perform a void, postAuth or return secondary transaction. Partial postAuths and returns are allowed.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId.</param> 
        /// <param name="secondaryTransaction">Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app.</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse SubmitSecondaryTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling SubmitSecondaryTransaction");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling SubmitSecondaryTransaction");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling SubmitSecondaryTransaction");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling SubmitSecondaryTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling SubmitSecondaryTransaction");
            
            // verify the required parameter 'secondaryTransaction' is set
            if (secondaryTransaction == null) throw new ApiException(400, "Missing required parameter 'secondaryTransaction' when calling SubmitSecondaryTransaction");
            
    
            var path = "/payments/{transaction-id}";
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
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
            postBody = ApiClient.Serialize(secondaryTransaction); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            return BuildApiResponse(response);
        }
    
        /// <summary>
        /// Retrieve the state of a transaction. Use this query to get the current state of an existing transaction.
        /// </summary>
        /// <param name="contentType">Content type.</param> 
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param> 
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param> 
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param> 
        /// <param name="transactionId">Gateway transaction identifier as returned in the parameter ipgTransactionId.</param> 
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.</param> 
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing.</param> 
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app.</param> 
        /// <returns>TransactionResponse</returns>            
        public ApiResponse TransactionInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, string messageSignature, string region, string storeId)
        {
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling TransactionInquiry");
            
            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null) throw new ApiException(400, "Missing required parameter 'clientRequestId' when calling TransactionInquiry");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling TransactionInquiry");
            
            // verify the required parameter 'timestamp' is set
            if (timestamp == null) throw new ApiException(400, "Missing required parameter 'timestamp' when calling TransactionInquiry");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionInquiry");
            
    
            var path = "/payments/{transaction-id}";
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
            if (region != null) headerParams.Add("Region", ApiClient.ParameterToString(region)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

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
