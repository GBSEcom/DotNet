# IO.Swagger.Model.TransactionErrorResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseType** | [**ResponseType**](ResponseType.md) | The schema type returned in the response. | [optional] 
**ClientRequestId** | **string** | Echoes back the value in the Request header | [optional] 
**ApiTraceId** | **string** | Echoes back the value in the Request header | [optional] 
**IpgTransactionId** | **string** | The Response Transaction ID | [optional] 
**OrderId** | **string** | Client Order ID if supplied by client, otherwise the Order ID | [optional] 
**TransactionType** | [**TransactionType**](TransactionType.md) |  | [optional] 
**AuthorizationCode** | **string** | The processor approval code for compliance. | [optional] 
**AvsResponse** | **string** | The processor address validation response for compliance. | [optional] 
**SecurityCodeResponse** | **string** | The processor card verification validation response for compliance. | [optional] 
**Brand** | **string** | Card brand of the payment instrument | [optional] 
**Country** | **string** | Country of the card issuer | [optional] 
**TerminalId** | **string** | The terminal that is processing the transaction | [optional] 
**ClientTransactionId** | **string** | The unique client Transaction ID from the Request header, if supplied | [optional] 
**TransactionTime** | **long?** | The transaction time in seconds since Epoch | [optional] 
**ApprovedAmount** | [**Amount**](Amount.md) |  | [optional] 
**TransactionStatus** | **string** | The status of the transaction. APPROVED/WAITING are returned by the endpoints.  VALIDATION_FAILED/DECLINED are errors. See ErrorResponse object for details. | [optional] 
**TransactionState** | **string** | The state of the transaction. | [optional] 
**AuthenticationRedirect** | [**TransactionResponseAuthenticationRedirect**](TransactionResponseAuthenticationRedirect.md) |  | [optional] 
**SchemeTransactionId** | **string** | The transaction id received from schemes for the initial transaction, returned for the transactions marked as \&quot;FIRST\&quot; | [optional] 
**Processor** | [**ProcessorData**](ProcessorData.md) |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

