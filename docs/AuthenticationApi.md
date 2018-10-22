# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AuthenticationAccessTokensPost**](AuthenticationApi.md#v1authenticationaccesstokenspost) | **POST** /v1/authentication/access-tokens | Generate an access token for user authentication


<a name="v1authenticationaccesstokenspost"></a>
# **V1AuthenticationAccessTokensPost**
> AccessTokenResponse V1AuthenticationAccessTokensPost (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature)

Generate an access token for user authentication

This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AuthenticationAccessTokensPostExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal.

            try
            {
                // Generate an access token for user authentication
                AccessTokenResponse result = apiInstance.V1AuthenticationAccessTokensPost(contentType, clientRequestId, apiKey, timestamp, messageSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.V1AuthenticationAccessTokensPost: " + e.Message );
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

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

