# Org.OpenAPITools.Model.RecurringPaymentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** | Store ID number. | [optional] 
**PurchaseOrderNumber** | **string** | Purchase order number. | [optional] 
**InvoiceNumber** | **string** | Invoice number. | [optional] 
**CreationDate** | **string** | Date recurring payment was created. | [optional] 
**StartDate** | **string** | Date of mandate signature. | [optional] 
**NextAttemptDate** | **string** | Date of next transaction process attempt. | [optional] 
**TransactionAmount** | [**Amount**](Amount.md) |  | [optional] 
**PaymentMethodDetails** | [**PaymentMethodDetails**](PaymentMethodDetails.md) |  | [optional] 
**Frequency** | [**Frequency**](Frequency.md) |  | [optional] 
**NumberOfPayments** | **int?** | Number of times the recurring payment will process. | [optional] 
**RunCount** | **int?** | Times the recurring payment has already run. | [optional] 
**State** | **string** | State of the recurring payment. | [optional] 
**Comments** | **string** | User supplied comments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

