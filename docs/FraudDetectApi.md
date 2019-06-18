# Org.OpenAPITools.Api.FraudDetectApi

All URIs are relative to *https://cert.api.firstdata.com/gateway/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScoreOnly**](FraudDetectApi.md#scoreonly) | **POST** /fraud/score-only | Score a transaction for fraud.


<a name="scoreonly"></a>
# **ScoreOnly**
> ScoreOnlyResponse ScoreOnly (string contentType, string clientRequestId, string apiKey, long? timestamp, ScoreOnlyRequest scoreOnlyRequest, string messageSignature, string region)

Score a transaction for fraud.

Use this to obtain a fraud score for a transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScoreOnlyExample
    {
        public void main()
        {
            
            var apiInstance = new FraudDetectApi();
            var contentType = contentType_example;  // string | Content type. (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | Key given to merchant after boarding associating their requests with the appropriate app in Apigee.
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var scoreOnlyRequest = new ScoreOnlyRequest(); // ScoreOnlyRequest | Accepted request type: ScoreOnlyRequest.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional) 

            try
            {
                // Score a transaction for fraud.
                ScoreOnlyResponse result = apiInstance.ScoreOnly(contentType, clientRequestId, apiKey, timestamp, scoreOnlyRequest, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FraudDetectApi.ScoreOnly: " + e.Message );
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
 **scoreOnlyRequest** | [**ScoreOnlyRequest**](ScoreOnlyRequest.md)| Accepted request type: ScoreOnlyRequest. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. | [optional] 

### Return type

[**ScoreOnlyResponse**](ScoreOnlyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

