# Org.OpenAPITools.Model.RecurringPaymentDetailsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | Echoes back the value in the request header for tracking. | [optional] 
**ApiTraceId** | **string** | Request identifier in API, can be used to request logs from the support team. | [optional] 
**ResponseType** | [**ResponseType**](ResponseType.md) |  | [optional] 
**OrderId** | **string** | Client order ID if supplied by client, otherwise the order ID. | [optional] 
**TransactionTime** | **long?** | The transaction time in seconds since epoch. | [optional] 
**Billing** | [**Billing**](Billing.md) |  | [optional] 
**Shipping** | [**Shipping**](Shipping.md) |  | [optional] 
**Mandate** | [**SepaMandate**](SepaMandate.md) |  | [optional] 
**Transactions** | [**List<Transaction>**](Transaction.md) | Required for some payment methods (for example, Klarna). | [optional] 
**Processor** | [**ProcessorData**](ProcessorData.md) |  | [optional] 
**RecurringPaymentDetails** | [**RecurringPaymentDetails**](RecurringPaymentDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

