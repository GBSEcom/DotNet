# Org.OpenAPITools.Model.OrderResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpgTransactionId** | **string** | The response transaction ID | [optional] 
**OrderId** | **string** | Client order ID if supplied by client, otherwise the order ID | [optional] 
**TransactionTime** | **long?** | The transaction time in seconds since Epoch | [optional] 
**Billing** | [**Billing**](Billing.md) |  | [optional] 
**Shipping** | [**Shipping**](Shipping.md) |  | [optional] 
**Mandate** | [**SepaMandate**](SepaMandate.md) |  | [optional] 
**Transactions** | [**List<Transaction>**](Transaction.md) | Required for some payment methods (for example, Klarna) | [optional] 
**Processor** | [**ProcessorData**](ProcessorData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

