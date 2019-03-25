# Org.OpenAPITools.Api.OrderApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderInquiry**](OrderApi.md#orderinquiry) | **GET** /v1/orders/{order-id} | Retrieve the state of an order
[**OrderPostAuth**](OrderApi.md#orderpostauth) | **POST** /v1/orders/{order-id}/postauth | Capture/complete an already existing order.
[**OrderReturnTransaction**](OrderApi.md#orderreturntransaction) | **POST** /v1/orders/{order-id}/return | Return/refund an order.


<a name="orderinquiry"></a>
# **OrderInquiry**
> OrderResponse OrderInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, string messageSignature, string region, string storeId)

Retrieve the state of an order

Use this query to get the current state of an existing order.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderInquiryExample
    {
        public void main()
        {
            
            var apiInstance = new OrderApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

            try
            {
                // Retrieve the state of an order
                OrderResponse result = apiInstance.OrderInquiry(contentType, clientRequestId, apiKey, timestamp, orderId, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderInquiry: " + e.Message );
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
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderpostauth"></a>
# **OrderPostAuth**
> TransactionResponse OrderPostAuth (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId)

Capture/complete an already existing order.

Use this to capture/complete an order. Postauths and partial postauths are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderPostAuthExample
    {
        public void main()
        {
            
            var apiInstance = new OrderApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId
            var secondaryTransaction = new SecondaryTransaction(); // SecondaryTransaction | 
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

            try
            {
                // Capture/complete an already existing order.
                TransactionResponse result = apiInstance.OrderPostAuth(contentType, clientRequestId, apiKey, timestamp, orderId, secondaryTransaction, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderPostAuth: " + e.Message );
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
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId | 
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

<a name="orderreturntransaction"></a>
# **OrderReturnTransaction**
> TransactionResponse OrderReturnTransaction (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, SecondaryTransaction secondaryTransaction, string messageSignature, string region, string storeId)

Return/refund an order.

Use this for Returns of an existing order. Partial Returns are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderReturnTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new OrderApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId
            var secondaryTransaction = new SecondaryTransaction(); // SecondaryTransaction | 
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app (optional) 

            try
            {
                // Return/refund an order.
                TransactionResponse result = apiInstance.OrderReturnTransaction(contentType, clientRequestId, apiKey, timestamp, orderId, secondaryTransaction, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderReturnTransaction: " + e.Message );
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
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId | 
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

