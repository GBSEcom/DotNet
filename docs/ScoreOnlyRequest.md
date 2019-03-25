# Org.OpenAPITools.Model.ScoreOnlyRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantRef** | **string** | Merchant reference code. Used by FirstAPI and reflected in settlement records and Webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction. | [optional] 
**TransactionType** | **string** | Type of transaction merchant wants to process. | 
**OriginalTransactionType** | **string** | Defines the type of the original transaction that is being evaluated for the Fraud Score. | 
**OriginalTransactionId** | **string** | The unique ID of this transaction. Must be unique for the entire system (not just within a specific merchant or industry). Subsequent requests related to the same transaction must have the same transactionId (e.g. transaction/deposit or   transaction/authorization-reversal). This field is used formatching transactions with settlement and chargeback information. If there is no such ID available you may wish to compose one from fields available in both systems. Consider including backend, issuer, merchant id, date and time, amount, etc. as necessary. | 
**Amount** | **string** | The amount processed for the original transaction. | 
**CurrencyCode** | **string** | The currency of the original transaction. | 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**BillingAddress** | [**BillingAddress**](BillingAddress.md) |  | [optional] 
**Device** | [**Device**](Device.md) |  | [optional] 
**Loyalty** | [**Loyalty**](Loyalty.md) |  | [optional] 
**Payment** | [**Payment**](Payment.md) |  | 
**Merchant** | [**Merchant**](Merchant.md) |  | 
**Order** | [**FraudOrder**](FraudOrder.md) |  | [optional] 
**UserDefined** | [**Object**](.md) | A JSON object that can carry any additional information that might be helpful for fraud detection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

