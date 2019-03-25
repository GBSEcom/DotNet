# Org.OpenAPITools.Api.PaymentApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FinalizeSecureTransaction**](PaymentApi.md#finalizesecuretransaction) | **PATCH** /v1/payments/{transaction-id} | Update a 3DSecure or UnionPay payment and continue processing.
[**PerformPaymentPostAuthorisation**](PaymentApi.md#performpaymentpostauthorisation) | **POST** /v1/payments/{transaction-id}/postauth | Capture/complete a transaction.
[**PrimaryPaymentTransaction**](PaymentApi.md#primarypaymenttransaction) | **POST** /v1/payments | Generate a primary transaction.
[**ReturnTransaction**](PaymentApi.md#returntransaction) | **POST** /v1/payments/{transaction-id}/return | Return/refund a transaction.
[**TransactionInquiry**](PaymentApi.md#transactioninquiry) | **GET** /v1/payments/{transaction-id} | Retrieve the state of a transaction.
[**VoidTransaction**](PaymentApi.md#voidtransaction) | **POST** /v1/payments/{transaction-id}/void | Reverse a previous action on an existing transaction.


<a name="finalizesecuretransaction"></a>
# **FinalizeSecureTransaction**
> TransactionResponse FinalizeSecureTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, AuthenticationResponseVerificationRequest authenticationResponseVerificationRequest, string messageSignature, string region)

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
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var authenticationResponseVerificationRequest = new AuthenticationResponseVerificationRequest(); // AuthenticationResponseVerificationRequest | 
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 

            try
            {
                // Update a 3DSecure or UnionPay payment and continue processing.
                TransactionResponse result = apiInstance.FinalizeSecureTransaction(contentType, clientRequestId, apiKey, timestamp, transactionId, authenticationResponseVerificationRequest, messageSignature, region);
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
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **authenticationResponseVerificationRequest** | [**AuthenticationResponseVerificationRequest**](AuthenticationResponseVerificationRequest.md)|  | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performpaymentpostauthorisation"></a>
# **PerformPaymentPostAuthorisation**
> TransactionResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId)

Capture/complete a transaction.

Used to capture/complete an existing transaction. Partial postauths are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PerformPaymentPostAuthorisationExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var secondaryTransaction = new SecondaryTransaction(); // SecondaryTransaction | 
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

            try
            {
                // Capture/complete a transaction.
                TransactionResponse result = apiInstance.PerformPaymentPostAuthorisation(contentType, clientRequestId, apiKey, timestamp, transactionId, secondaryTransaction, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PerformPaymentPostAuthorisation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **secondaryTransaction** | [**SecondaryTransaction**](SecondaryTransaction.md)|  | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="primarypaymenttransaction"></a>
# **PrimaryPaymentTransaction**
> TransactionResponse PrimaryPaymentTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, PrimaryTransaction primaryTransaction, string messageSignature, string region)

Generate a primary transaction.

Use this to originate a financial transaction, like a sale, preauthorization, or credit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PrimaryPaymentTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var primaryTransaction = new PrimaryTransaction(); // PrimaryTransaction | Primary Transaction request
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 

            try
            {
                // Generate a primary transaction.
                TransactionResponse result = apiInstance.PrimaryPaymentTransaction(contentType, clientRequestId, apiKey, timestamp, primaryTransaction, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.PrimaryPaymentTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **primaryTransaction** | [**PrimaryTransaction**](PrimaryTransaction.md)| Primary Transaction request | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returntransaction"></a>
# **ReturnTransaction**
> TransactionResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId)

Return/refund a transaction.

Use this to return/refund an existing transaction.  Partial returns are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReturnTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var secondaryTransaction = new SecondaryTransaction(); // SecondaryTransaction | 
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

            try
            {
                // Return/refund a transaction.
                TransactionResponse result = apiInstance.ReturnTransaction(contentType, clientRequestId, apiKey, timestamp, transactionId, secondaryTransaction, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.ReturnTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **secondaryTransaction** | [**SecondaryTransaction**](SecondaryTransaction.md)|  | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app | [optional] 

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
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

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
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidtransaction"></a>
# **VoidTransaction**
> TransactionResponse VoidTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string transactionId, string messageSignature, string region, string storeId)

Reverse a previous action on an existing transaction.

Use this to reverse a postauth/completion, credit, preauth, or sale.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VoidTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

            try
            {
                // Reverse a previous action on an existing transaction.
                TransactionResponse result = apiInstance.VoidTransaction(contentType, clientRequestId, apiKey, timestamp, transactionId, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.VoidTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

