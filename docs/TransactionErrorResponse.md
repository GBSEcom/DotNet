# Org.OpenAPITools.Model.TransactionErrorResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | Echoes back the value in the request header for tracking. | [optional] 
**ApiTraceId** | **string** | Request identifier in API, can be used to request logs from the support team. | [optional] 
**ResponseType** | [**ResponseType**](ResponseType.md) |  | [optional] 
**IpgTransactionId** | **string** | The response transaction ID. | [optional] 
**OrderId** | **string** | Client order ID if supplied by client, otherwise the order ID. | [optional] 
**TransactionType** | [**TransactionType**](TransactionType.md) |  | [optional] 
**PaymentToken** | [**PaymentTokenDetails**](PaymentTokenDetails.md) |  | [optional] 
**TransactionOrigin** | [**TransactionOrigin**](TransactionOrigin.md) |  | [optional] 
**PaymentMethodDetails** | [**PaymentMethodDetails**](PaymentMethodDetails.md) |  | [optional] 
**Country** | **string** | Country of the card issuer. | [optional] 
**TerminalId** | **string** | The terminal that is processing the transaction. | [optional] 
**MerchantTransactionId** | **string** | The unique merchant transaction ID from the request header, if supplied. | [optional] 
**TransactionTime** | **long?** | The transaction time in seconds since epoch. | [optional] 
**ApprovedAmount** | [**Amount**](Amount.md) |  | [optional] 
**TransactionStatus** | **string** | The status of the transaction. APPROVED/WAITING are returned by the endpoints.  VALIDATION_FAILED/DECLINED are errors. See ErrorResponse object for details. | [optional] 
**TransactionState** | **string** | The state of the transaction. | [optional] 
**Secure3dResponse** | [**Secure3dResponse**](Secure3dResponse.md) |  | [optional] 
**RedirectURL** | **string** | The endpoint redirection URL. | [optional] 
**AuthenticationRedirect** | [**AuthenticationRedirect**](AuthenticationRedirect.md) |  | [optional] 
**SchemeTransactionId** | **string** | The transaction ID received from schemes for the initial transaction of card on file flows. | [optional] 
**Processor** | [**ProcessorData**](ProcessorData.md) |  | [optional] 
**AdditionalDetails** | [**AdditionalTransactionDetails**](AdditionalTransactionDetails.md) |  | [optional] 
**AccountUpdaterResponse** | [**AccountUpdaterResponse**](AccountUpdaterResponse.md) |  | [optional] 
**Error** | [**Error**](Error.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

