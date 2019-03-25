# Org.OpenAPITools.Model.PaymentUrlResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestStatus** | **string** | Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details. | [optional] 
**OrderId** | **string** | Client Order ID if supplied by client, otherwise the Order ID. | [optional] 
**PaymentUrl** | **string** | URL for embedded payment link | [optional] 
**TransactionId** | **string** | ID code from the transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

