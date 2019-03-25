# Org.OpenAPITools.Model.PaymentTokenizationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestStatus** | **string** | The status of the request | [optional] 
**ClientRequestId** | **string** | Echoes back the value in the request header for tracking. | [optional] 
**ApiTraceId** | **string** | Echoes back the value in the request header. | [optional] 
**RequestTime** | **string** | Time of the request | [optional] 
**AvsResponse** | [**AVSResponse**](AVSResponse.md) |  | [optional] 
**SecurityCodeResponse** | **string** | Optional security code check response | [optional] 
**Brand** | **string** | Card brand | [optional] 
**Country** | **string** | Country of the card issued | [optional] 
**PaymentToken** | [**PaymentTokenization**](PaymentTokenization.md) |  | [optional] 
**PaymentCard** | [**PaymentCard**](PaymentCard.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

