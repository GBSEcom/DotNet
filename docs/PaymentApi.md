# IO.Swagger.Api.PaymentApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PerformPaymentPostAuthorisation**](PaymentApi.md#performpaymentpostauthorisation) | **POST** /v1/payments/{transaction-id}/postauth | Use this to capture/complete a transaction. Partial postauths are allowed.
[**PrimaryPaymentTransaction**](PaymentApi.md#primarypaymenttransaction) | **POST** /v1/payments | Generate a primary transaction
[**ReturnTransaction**](PaymentApi.md#returntransaction) | **POST** /v1/payments/{transaction-id}/return | Return/refund a transaction.
[**TransactionInquiry**](PaymentApi.md#transactioninquiry) | **GET** /v1/payments/{transaction-id} | Retrieve the state of a transaction
[**VoidTransaction**](PaymentApi.md#voidtransaction) | **POST** /v1/payments/{transaction-id}/void | Reverse a previous action on an existing transaction


<a name="performpaymentpostauthorisation"></a>
# **PerformPaymentPostAuthorisation**
> TransactionResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, SecondaryTransaction payload, string storeId)

Use this to capture/complete a transaction. Partial postauths are allowed.

This can be used for postauth and partial postauths.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var payload = new SecondaryTransaction(); // SecondaryTransaction | 
            var storeId = storeId_example;  // string | an optional outlet id for clients that support multiple store in the same developer app (optional) 

            try
            {
                // Use this to capture/complete a transaction. Partial postauths are allowed.
                TransactionResponse result = apiInstance.PerformPaymentPostAuthorisation(contentType, clientRequestId, apiKey, timestamp, messageSignature, transactionId, payload, storeId);
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
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **payload** | [**SecondaryTransaction**](SecondaryTransaction.md)|  | 
 **storeId** | **string**| an optional outlet id for clients that support multiple store in the same developer app | [optional] 

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
> TransactionResponse PrimaryPaymentTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, PrimaryTransaction payload)

Generate a primary transaction

Use this to originate a financial transaction, like a sale, preauthorization, or credit.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var payload = new PrimaryTransaction(); // PrimaryTransaction | Primary Transaction request

            try
            {
                // Generate a primary transaction
                TransactionResponse result = apiInstance.PrimaryPaymentTransaction(contentType, clientRequestId, apiKey, timestamp, messageSignature, payload);
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
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | 
 **payload** | [**PrimaryTransaction**](PrimaryTransaction.md)| Primary Transaction request | 

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
> TransactionResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, SecondaryTransaction payload, string storeId)

Return/refund a transaction.

Use this to return/refund an existing transaction.  Partial returns are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var payload = new SecondaryTransaction(); // SecondaryTransaction | 
            var storeId = storeId_example;  // string | an optional outlet id for clients that support multiple store in the same developer app (optional) 

            try
            {
                // Return/refund a transaction.
                TransactionResponse result = apiInstance.ReturnTransaction(contentType, clientRequestId, apiKey, timestamp, messageSignature, transactionId, payload, storeId);
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
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **payload** | [**SecondaryTransaction**](SecondaryTransaction.md)|  | 
 **storeId** | **string**| an optional outlet id for clients that support multiple store in the same developer app | [optional] 

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
> TransactionResponse TransactionInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, string storeId)

Retrieve the state of a transaction

Use this query to get the current state of an existing transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var storeId = storeId_example;  // string | an optional outlet id for clients that support multiple store in the same developer app (optional) 

            try
            {
                // Retrieve the state of a transaction
                TransactionResponse result = apiInstance.TransactionInquiry(contentType, clientRequestId, apiKey, timestamp, messageSignature, transactionId, storeId);
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
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **storeId** | **string**| an optional outlet id for clients that support multiple store in the same developer app | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidtransaction"></a>
# **VoidTransaction**
> TransactionResponse VoidTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string transactionId, string storeId)

Reverse a previous action on an existing transaction

Use this to reverse a postauth/completion, credit, preauth, or sale.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var transactionId = transactionId_example;  // string | Gateway transaction identifier as returned in the parameter ipgTransactionId
            var storeId = storeId_example;  // string | an optional outlet id for clients that support multiple store in the same developer app (optional) 

            try
            {
                // Reverse a previous action on an existing transaction
                TransactionResponse result = apiInstance.VoidTransaction(contentType, clientRequestId, apiKey, timestamp, messageSignature, transactionId, storeId);
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
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | 
 **transactionId** | **string**| Gateway transaction identifier as returned in the parameter ipgTransactionId | 
 **storeId** | **string**| an optional outlet id for clients that support multiple store in the same developer app | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

