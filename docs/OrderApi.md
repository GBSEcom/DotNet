# Org.OpenAPITools.Api.OrderApi

All URIs are relative to *https://cert.api.firstdata.com/gateway/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderInquiry**](OrderApi.md#orderinquiry) | **GET** /orders/{order-id} | Retrieve the state of an order.
[**SubmitSecondaryTransactionFromOrder**](OrderApi.md#submitsecondarytransactionfromorder) | **POST** /orders/{order-id} | Perform return or postAuth secondary transactions.


<a name="orderinquiry"></a>
# **OrderInquiry**
> OrderResponse OrderInquiry (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, string messageSignature, string region, string storeId)

Retrieve the state of an order.

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
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app. (optional) 

            try
            {
                // Retrieve the state of an order.
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
 **contentType** | **string**| Content type. | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**| Key given to merchant after boarding associating their requests with the appropriate app in Apigee. | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app. | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitsecondarytransactionfromorder"></a>
# **SubmitSecondaryTransactionFromOrder**
> TransactionResponse SubmitSecondaryTransactionFromOrder (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, SecondaryTransaction secondaryTransaction, string messageSignature, string region)

Perform return or postAuth secondary transactions.

Use this to perform a postAuth or return secondary transaction using order ID. Partial postAuths and returns are allowed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubmitSecondaryTransactionFromOrderExample
    {
        public void main()
        {
            
            var apiInstance = new OrderApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId.
            var secondaryTransaction = new SecondaryTransaction(); // SecondaryTransaction | Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 

            try
            {
                // Perform return or postAuth secondary transactions.
                TransactionResponse result = apiInstance.SubmitSecondaryTransactionFromOrder(contentType, clientRequestId, apiKey, timestamp, orderId, secondaryTransaction, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.SubmitSecondaryTransactionFromOrder: " + e.Message );
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
 **orderId** | **string**| Gateway order identifier as returned in the parameter orderId. | 
 **secondaryTransaction** | [**SecondaryTransaction**](SecondaryTransaction.md)| Accepted request types: PostAuthTransaction, VoidTransaction, and ReturnTransaction. | 
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

