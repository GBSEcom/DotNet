# Org.OpenAPITools.Model.PaymentSchedulesErrorResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | Echoes back the value in the request header for tracking. | [optional] 
**ApiTraceId** | **string** | Request identifier in API, can be used to request logs from the support team. | [optional] 
**ResponseType** | [**ResponseType**](ResponseType.md) |  | [optional] 
**RequestStatus** | **string** | Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details. | [optional] 
**OrderId** | **string** | Client order ID if supplied by client, otherwise the order ID. | [optional] 
**TransactionResponse** | [**TransactionResponse**](TransactionResponse.md) |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

