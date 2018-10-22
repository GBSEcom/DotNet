# IO.Swagger.Api.OrderApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PerformPaymentPostAuthorisation**](OrderApi.md#performpaymentpostauthorisation) | **POST** /v1/orders/{order-id}/postauth | Use this to capture/complete a transaction. Partial postauths are allowed.
[**ReturnTransaction**](OrderApi.md#returntransaction) | **POST** /v1/orders/{order-id}/return | Use this to return/refund on the order. Partial returns are allowed.


<a name="performpaymentpostauthorisation"></a>
# **PerformPaymentPostAuthorisation**
> TransactionResponse PerformPaymentPostAuthorisation (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string orderId, SecondaryTransaction payload, string storeId)

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
            
            var apiInstance = new OrderApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId
            var payload = new SecondaryTransaction(); // SecondaryTransaction | 
            var storeId = storeId_example;  // string | an optional outlet id for clients that support multiple store in the same developer app (optional) 

            try
            {
                // Use this to capture/complete a transaction. Partial postauths are allowed.
                TransactionResponse result = apiInstance.PerformPaymentPostAuthorisation(contentType, clientRequestId, apiKey, timestamp, messageSignature, orderId, payload, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.PerformPaymentPostAuthorisation: " + e.Message );
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
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId | 
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

<a name="returntransaction"></a>
# **ReturnTransaction**
> TransactionResponse ReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature, string orderId, SecondaryTransaction payload, string storeId)

Use this to return/refund on the order. Partial returns are allowed.

This can be used for Returns and Partial Returns.

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
            
            var apiInstance = new OrderApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId
            var payload = new SecondaryTransaction(); // SecondaryTransaction | 
            var storeId = storeId_example;  // string | an optional outlet id for clients that support multiple store in the same developer app (optional) 

            try
            {
                // Use this to return/refund on the order. Partial returns are allowed.
                TransactionResponse result = apiInstance.ReturnTransaction(contentType, clientRequestId, apiKey, timestamp, messageSignature, orderId, payload, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ReturnTransaction: " + e.Message );
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
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId | 
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

