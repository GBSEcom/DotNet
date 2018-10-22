# IO.Swagger.Model.StoredCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sequence** | **string** | Indicates if the transaction is first or subsequent. Valid values are &#39;FIRST&#39; and &#39;SUBSEQUENT&#39; | 
**Scheduled** | **bool?** | Indicates if the transaction is scheduled or part of a installment | 
**ReferencedSchemeTransactionId** | **string** | The transaction id received from schemes for the initial transaction. Required if sequence is &#39;SUBSEQUENT&#39; | [optional] 
**Initiator** | **string** | Indicates whether it is a merchant initiated or explicitly consented by card holder. Valid values are &#39;MERCHANT&#39; and &#39;CARDHOLDER&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

