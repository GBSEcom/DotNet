# IO.Swagger.Model.PaymentSchedulesResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | Echoes back the value in the Request header for tracking. | 
**ApiTraceId** | **string** | Request identifier in API, can be used to request logs from the support. | 
**TransactionStatus** | **string** | Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details. | 
**OrderId** | **string** | Client Order ID if supplied by client, otherwise the Order ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

