# Org.OpenAPITools.Api.PaymentTokenApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentToken**](PaymentTokenApi.md#createpaymenttoken) | **POST** /v1/payment-tokens | Create a payment token from a payment card.
[**DeletePaymentToken**](PaymentTokenApi.md#deletepaymenttoken) | **DELETE** /v1/payment-tokens/{token-id} | Delete a payment token.


<a name="createpaymenttoken"></a>
# **CreatePaymentToken**
> PaymentTokenizationResponse CreatePaymentToken (string contentType, string clientRequestId, string apiKey, long? timestamp, PaymentTokenizationRequest paymentTokenizationRequest, string messageSignature, string authorization, string region)

Create a payment token from a payment card.

Use this to create a payment token from a payment card.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentTokenExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentTokenApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var paymentTokenizationRequest = new PaymentTokenizationRequest(); // PaymentTokenizationRequest | 
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var authorization = authorization_example;  // string | The access token previously generated with the access-tokens call. Use the format 'Bearer {access-token}'. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 

            try
            {
                // Create a payment token from a payment card.
                PaymentTokenizationResponse result = apiInstance.CreatePaymentToken(contentType, clientRequestId, apiKey, timestamp, paymentTokenizationRequest, messageSignature, authorization, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentTokenApi.CreatePaymentToken: " + e.Message );
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
 **paymentTokenizationRequest** | [**PaymentTokenizationRequest**](PaymentTokenizationRequest.md)|  | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **authorization** | **string**| The access token previously generated with the access-tokens call. Use the format &#39;Bearer {access-token}&#39;. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 

### Return type

[**PaymentTokenizationResponse**](PaymentTokenizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymenttoken"></a>
# **DeletePaymentToken**
> PaymentTokenizationResponse DeletePaymentToken (string contentType, string clientRequestId, string apiKey, long? timestamp, string tokenId, string messageSignature, string authorization, string region, string storeId)

Delete a payment token.

Use this to delete a payment token.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeletePaymentTokenExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentTokenApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var tokenId = tokenId_example;  // string | Identifies a payment token
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var authorization = authorization_example;  // string | The access token previously generated with the access-tokens call. Use the format 'Bearer {access-token}'. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 
            var storeId = storeId_example;  // string |  (optional) 

            try
            {
                // Delete a payment token.
                PaymentTokenizationResponse result = apiInstance.DeletePaymentToken(contentType, clientRequestId, apiKey, timestamp, tokenId, messageSignature, authorization, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentTokenApi.DeletePaymentToken: " + e.Message );
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
 **tokenId** | **string**| Identifies a payment token | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **authorization** | **string**| The access token previously generated with the access-tokens call. Use the format &#39;Bearer {access-token}&#39;. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 
 **storeId** | **string**|  | [optional] 

### Return type

[**PaymentTokenizationResponse**](PaymentTokenizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

