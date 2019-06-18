# Org.OpenAPITools.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionState** | **string** | The state of the transaction. | [optional] 
**IpgTransactionId** | **string** | The transaction ID. | [optional] 
**OrderId** | **string** | Client order ID if supplied by client. | [optional] 
**TransactionType** | [**TransactionType**](TransactionType.md) |  | [optional] 
**PaymentMethodDetails** | [**PaymentMethodDetails**](PaymentMethodDetails.md) |  | [optional] 
**TransactionAmount** | [**Amount**](Amount.md) |  | [optional] 
**SubmissionComponent** | **string** | The submission component. | [optional] 
**PayerSecurityLevel** | **string** | The payer security level. | [optional] 
**TransactionTime** | **long?** | The transaction time in seconds since epoch. | [optional] 
**StoreId** | **string** | Store ID number. | [optional] 
**UserId** | **string** | The user ID. | [optional] 
**Processor** | [**ProcessorData**](ProcessorData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

