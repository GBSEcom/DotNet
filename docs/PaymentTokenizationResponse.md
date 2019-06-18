# Org.OpenAPITools.Model.PaymentTokenizationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | Echoes back the value in the request header for tracking. | [optional] 
**ApiTraceId** | **string** | Request identifier in API, can be used to request logs from the support team. | [optional] 
**ResponseType** | [**ResponseType**](ResponseType.md) |  | [optional] 
**RequestStatus** | **string** | The status of the request. | [optional] 
**RequestTime** | **long?** | Time of the request. | [optional] 
**AvsResponse** | [**AVSResponse**](AVSResponse.md) |  | [optional] 
**SecurityCodeResponse** | **string** | Security code check response. | [optional] 
**Brand** | **string** | Card brand. | [optional] 
**Country** | **string** | Country of the card issued. | [optional] 
**PaymentToken** | [**PaymentTokenDetails**](PaymentTokenDetails.md) |  | [optional] 
**PaymentCard** | [**PaymentCard**](PaymentCard.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

