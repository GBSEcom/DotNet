# Org.OpenAPITools.Model.PaymentSchedulesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Object name of the payment schedules request. | 
**StoreId** | **string** | Store ID number. | [optional] 
**StartDate** | **DateTime?** | Date of mandate signature. | 
**NumberOfPayments** | **int?** | Number of times the recurring payment will process. | [optional] 
**MaximumFailures** | **int?** | Number of failures that can be encountered before re-tries cease. | [optional] 
**InvoiceNumber** | **string** | Invoice number. | [optional] 
**PurchaseOrderNumber** | **string** | Purchase order number. | [optional] 
**TransactionOrigin** | [**TransactionOrigin**](TransactionOrigin.md) |  | [optional] 
**DynamicMerchantName** | **string** | Dynamic merchant name for the cardholder&#39;s statement. | [optional] 
**Frequency** | [**Frequency**](Frequency.md) |  | 
**TransactionAmount** | [**Amount**](Amount.md) |  | 
**ClientLocale** | [**ClientLocale**](ClientLocale.md) |  | [optional] 
**OrderId** | **string** | Client order ID if supplied by client. | [optional] 
**Billing** | [**Billing**](Billing.md) |  | [optional] 
**Shipping** | [**Shipping**](Shipping.md) |  | [optional] 
**Comments** | **string** | User supplied comments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

