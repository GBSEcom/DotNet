# Org.OpenAPITools.Api.PaymentApi

All URIs are relative to *https://cert.api.firstdata.com/gateway/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FinalizeSecureTransaction**](PaymentApi.md#finalizesecuretransaction) | **PATCH** /payments/{transaction-id} | Update a 3DSecure or UnionPay payment and continue processing.
[**SubmitPrimaryTransaction**](PaymentApi.md#submitprimarytransaction) | **POST** /payments | Generate a primary transaction.
[**SubmitSecondaryTransaction**](PaymentApi.md#submitsecondarytransaction) | **POST** /payments/{transaction-id} | Perform a secondary transaction.
[**TransactionInquiry**](PaymentApi.md#transactioninquiry) | **GET** /payments/{transaction-id} | Retrieve the state of a transaction.


<a name="finalizesecuretransaction"></a>
# **FinalizeSecureTransaction**
> TransactionResponse FinalizeSecureTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, AuthenticationVerificationRequest authenticationVerificationRequest, string messageSignature, string region)

Update a 3DSecure or UnionPay payment and continue processing.

Use this to handle a 3DSecure redirect response or UnionPay authentication, updating the transaction and continuing processing.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FinalizeSecureTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId.
            var authenticationVerificationRequest = new AuthenticationVerificationRequest(); // AuthenticationVerificationRequest | Accepted request types: Secure3dAuthenticationVerificationRequest and UnionPayAuthenticationVerificationRequest.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 

            try
            {
                // Update a 3DSecure or UnionPay payment and continue processing.
                TransactionResponse result = apiInstance.FinalizeSecureTransaction(contentType, clientRequestId, apiKey, timestamp, transactionId, authenticationVerificationRequest, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.FinalizeSecureTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| Content type. | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**| Key given to merchant after boarding associating their requests with the appropriate app in Apigee. | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId. | 
 **authenticationVerificationRequest** | [**AuthenticationVerificationRequest**](AuthenticationVerificationRequest.md)| Accepted request types: Secure3dAuthenticationVerificationRequest and UnionPayAuthenticationVerificationRequest. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitprimarytransaction"></a>
# **SubmitPrimaryTransaction**
> TransactionResponse SubmitPrimaryTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, PrimaryTransaction primaryTransaction, string messageSignature, string region)

Generate a primary transaction.

Use this to originate a financial transaction like a sale, preauthorization, or credit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubmitPrimaryTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var primaryTransaction = new PrimaryTransaction(); // PrimaryTransaction | Accepted request types: AliPaySaleTransaction, ChinaPnRSaleTransaction, PaymentCardCreditTransaction, PaymentCardForcedTicketTransaction, PaymentCardSaleTransaction, PaymentCardPreAuthTransaction, PaymentCardPayerAuthTransaction, PaymentTokenCreditTransaction, PaymentTokenPreAuthTransaction, PaymentTokenSaleTransaction, PaypalCreditTransaction, and SepaSaleTransaction.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 

            try
            {
                // Generate a primary transaction.
                TransactionResponse result = apiInstance.SubmitPrimaryTransaction(contentType, clientRequestId, apiKey, timestamp, primaryTransaction, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.SubmitPrimaryTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| Content type. | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**| Key given to merchant after boarding associating their requests with the appropriate app in Apigee. | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **primaryTransaction** | [**PrimaryTransaction**](PrimaryTransaction.md)| Accepted request types: AliPaySaleTransaction, ChinaPnRSaleTransaction, PaymentCardCreditTransaction, PaymentCardForcedTicketTransaction, PaymentCardSaleTransaction, PaymentCardPreAuthTransaction, PaymentCardPayerAuthTransaction, PaymentTokenCreditTransaction, PaymentTokenPreAuthTransaction, PaymentTokenSaleTransaction, PaypalCreditTransaction, and SepaSaleTransaction. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitsecondarytransaction"></a>
# **SubmitSecondaryTransaction**
> TransactionResponse SubmitSecondaryTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId)

Perform a secondary transaction.

Use this to perform a void, postAuth or return secondary transaction. Partial postAuths and returns are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubmitSecondaryTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId.
            var secondaryTransaction = new SecondaryTransaction(); // SecondaryTransaction | Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app. (optional) 

            try
            {
                // Perform a secondary transaction.
                TransactionResponse result = apiInstance.SubmitSecondaryTransaction(contentType, clientRequestId, apiKey, timestamp, transactionId, secondaryTransaction, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.SubmitSecondaryTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| Content type. | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**| Key given to merchant after boarding associating their requests with the appropriate app in Apigee. | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId. | 
 **secondaryTransaction** | [**SecondaryTransaction**](SecondaryTransaction.md)| Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app. | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactioninquiry"></a>
# **TransactionInquiry**
> TransactionResponse TransactionInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, string messageSignature, string region, string storeId)

Retrieve the state of a transaction.

Use this query to get the current state of an existing transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransactionInquiryExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app. (optional) 

            try
            {
                // Retrieve the state of a transaction.
                TransactionResponse result = apiInstance.TransactionInquiry(contentType, clientRequestId, apiKey, timestamp, transactionId, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.TransactionInquiry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| Content type. | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**| Key given to merchant after boarding associating their requests with the appropriate app in Apigee. | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app. | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

