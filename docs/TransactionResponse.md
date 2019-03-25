# Org.OpenAPITools.Model.TransactionResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpgTransactionId** | **string** | The Response Transaction ID | [optional] 
**OrderId** | **string** | Client Order ID if supplied by client, otherwise the Order ID | [optional] 
**TransactionType** | [**TransactionType**](TransactionType.md) |  | [optional] 
**PaymentToken** | [**PaymentTokenization**](PaymentTokenization.md) |  | [optional] 
**TransactionOrigin** | [**TransactionOrigin**](TransactionOrigin.md) |  | [optional] 
**PaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**Country** | **string** | Country of the card issuer | [optional] 
**TerminalId** | **string** | The terminal that is processing the transaction | [optional] 
**MerchantTransactionId** | **string** | The unique merchant Transaction ID from the Request header, if supplied | [optional] 
**TransactionTime** | **long?** | The transaction time in seconds since Epoch | [optional] 
**ApprovedAmount** | [**Amount**](Amount.md) |  | [optional] 
**TransactionStatus** | **string** | The status of the transaction. APPROVED/WAITING are returned by the endpoints.  VALIDATION_FAILED/DECLINED are errors. See ErrorResponse object for details. | [optional] 
**TransactionState** | **string** | The state of the transaction. | [optional] 
**Secure3dResponse** | [**Secure3dResponse**](Secure3dResponse.md) |  | [optional] 
**RedirectURL** | **string** | The endpoint redirection URL. | [optional] 
**AuthenticationRedirect** | **Object** |  | [optional] 
**SchemeTransactionId** | **string** | The transaction ID received from schemes for the initial transaction of card on file flows. | [optional] 
**Processor** | [**ProcessorData**](ProcessorData.md) |  | [optional] 
**AdditionalDetails** | [**AdditionalTransactionDetails**](AdditionalTransactionDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

