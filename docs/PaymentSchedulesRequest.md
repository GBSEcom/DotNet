# Org.OpenAPITools.Model.PaymentSchedulesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** | Store ID number. | [optional] 
**ReferencedOrderId** | **string** | Order ID used to create recurring payment from existing transaction. | [optional] 
**StartDate** | **DateTime?** | Date of mandate signature. | [optional] 
**NumberOfPayments** | **int?** | Number of times the recurring pament will process. | [optional] 
**MaximumFailures** | **int?** | Number of failures that can be encountered before re-tries cease. | [optional] 
**InvoiceNumber** | **string** | Invoice number. | [optional] 
**PurchaseOrderNumber** | **string** | Purchase order number. | [optional] 
**TransactionOrigin** | **TransactionOrigin** |  | [optional] 
**DynamicMerchantName** | **string** | Dynamic merchant name for the cardholder&#39;s statement. | [optional] 
**Frequency** | [**Frequency**](Frequency.md) |  | [optional] 
**PaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**Amount** | [**Amount**](Amount.md) |  | [optional] 
**ClientLocale** | [**ClientLocale**](ClientLocale.md) |  | [optional] 
**OrderId** | **string** | Client order ID if supplied by client. | [optional] 
**Billing** | [**Billing**](Billing.md) |  | [optional] 
**Shipping** | [**Shipping**](Shipping.md) |  | [optional] 
**Comments** | **string** | User supplied comments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

