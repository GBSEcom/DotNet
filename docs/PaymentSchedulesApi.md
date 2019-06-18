# Org.OpenAPITools.Api.PaymentSchedulesApi

All URIs are relative to *https://cert.api.firstdata.com/gateway/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPaymentSchedule**](PaymentSchedulesApi.md#cancelpaymentschedule) | **DELETE** /payment-schedules/{order-id} | Cancel a gateway payment schedule.
[**CreatePaymentSchedule**](PaymentSchedulesApi.md#createpaymentschedule) | **POST** /payment-schedules | Create gateway payment schedule.
[**InquiryPaymentSchedule**](PaymentSchedulesApi.md#inquirypaymentschedule) | **GET** /payment-schedules/{order-id} | View a gateway payment schedule.
[**UpdatePaymentSchedule**](PaymentSchedulesApi.md#updatepaymentschedule) | **PATCH** /payment-schedules/{order-id} | Update a gateway payment schedule.


<a name="cancelpaymentschedule"></a>
# **CancelPaymentSchedule**
> PaymentSchedulesResponse CancelPaymentSchedule (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, string messageSignature, string region, string storeId)

Cancel a gateway payment schedule.

Use this to cancel an existing gateway payment schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CancelPaymentScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentSchedulesApi();
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
                // Cancel a gateway payment schedule.
                PaymentSchedulesResponse result = apiInstance.CancelPaymentSchedule(contentType, clientRequestId, apiKey, timestamp, orderId, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.CancelPaymentSchedule: " + e.Message );
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

[**PaymentSchedulesResponse**](PaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpaymentschedule"></a>
# **CreatePaymentSchedule**
> PaymentSchedulesResponse CreatePaymentSchedule (string contentType, string clientRequestId, string apiKey, long? timestamp, PaymentSchedulesRequest paymentSchedulesRequest, string messageSignature, string region)

Create gateway payment schedule.

Use this to create a gateway payment schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePaymentScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentSchedulesApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var paymentSchedulesRequest = new PaymentSchedulesRequest(); // PaymentSchedulesRequest | Accepted request types: PaymentMethodPaymentSchedulesRequest and ReferencedOrderPaymentSchedulesRequest.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 

            try
            {
                // Create gateway payment schedule.
                PaymentSchedulesResponse result = apiInstance.CreatePaymentSchedule(contentType, clientRequestId, apiKey, timestamp, paymentSchedulesRequest, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.CreatePaymentSchedule: " + e.Message );
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
 **paymentSchedulesRequest** | [**PaymentSchedulesRequest**](PaymentSchedulesRequest.md)| Accepted request types: PaymentMethodPaymentSchedulesRequest and ReferencedOrderPaymentSchedulesRequest. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 

### Return type

[**PaymentSchedulesResponse**](PaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inquirypaymentschedule"></a>
# **InquiryPaymentSchedule**
> RecurringPaymentDetailsResponse InquiryPaymentSchedule (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, string messageSignature, string region, string storeId)

View a gateway payment schedule.

Use this to view an existing gateway payment schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InquiryPaymentScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentSchedulesApi();
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
                // View a gateway payment schedule.
                RecurringPaymentDetailsResponse result = apiInstance.InquiryPaymentSchedule(contentType, clientRequestId, apiKey, timestamp, orderId, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.InquiryPaymentSchedule: " + e.Message );
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

[**RecurringPaymentDetailsResponse**](RecurringPaymentDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentschedule"></a>
# **UpdatePaymentSchedule**
> PaymentSchedulesResponse UpdatePaymentSchedule (string contentType, string clientRequestId, string apiKey, long? timestamp, string orderId, PaymentSchedulesRequest paymentSchedulesRequest, string messageSignature, string region, string storeId)

Update a gateway payment schedule.

Use this to update a gateway payment schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePaymentScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentSchedulesApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var orderId = orderId_example;  // string | Gateway order identifier as returned in the parameter orderId.
            var paymentSchedulesRequest = new PaymentSchedulesRequest(); // PaymentSchedulesRequest | Accepted request types: PaymentMethodPaymentSchedulesRequest and ReferencedOrderPaymentSchedulesRequest.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 
            var storeId = storeId_example;  // string | An optional outlet ID for clients that support multiple stores in the same developer app. (optional) 

            try
            {
                // Update a gateway payment schedule.
                PaymentSchedulesResponse result = apiInstance.UpdatePaymentSchedule(contentType, clientRequestId, apiKey, timestamp, orderId, paymentSchedulesRequest, messageSignature, region, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.UpdatePaymentSchedule: " + e.Message );
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
 **paymentSchedulesRequest** | [**PaymentSchedulesRequest**](PaymentSchedulesRequest.md)| Accepted request types: PaymentMethodPaymentSchedulesRequest and ReferencedOrderPaymentSchedulesRequest. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 
 **storeId** | **string**| An optional outlet ID for clients that support multiple stores in the same developer app. | [optional] 

### Return type

[**PaymentSchedulesResponse**](PaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

