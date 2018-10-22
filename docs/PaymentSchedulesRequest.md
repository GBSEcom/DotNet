# IO.Swagger.Model.PaymentSchedulesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** | Store ID number. | [optional] 
**ReferenceOrderId** | **string** | Order ID used to create recurring payment from existing transaction. | [optional] 
**StartDate** | **DateTime?** | Date of mandate signature. | [optional] 
**NumberOfPayments** | **int?** | Number of times the recurring payment will process. | [optional] 
**MaximumFailures** | **int?** | Number of failures that can be encountered before re-tries cease. | [optional] 
**InvoiceNumber** | **string** | Invoice number. | [optional] 
**PoNumber** | **string** | Purchase order number. | [optional] 
**TransactionOrigin** | **string** | The source of the transaction. The possible values are ECI (if the order was received via email or Internet), MOTO (mail order / telephone order) and RETAIL (face to face). | [optional] 
**DynamicMerchantName** | **string** | Dynamic merchant name for the cardholder‘s statement. | [optional] 
**Frequency** | [**Frequency**](Frequency.md) |  | [optional] 
**PaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**Amount** | [**Amount**](Amount.md) |  | [optional] 
**ClientLocale** | [**ClientLocale**](ClientLocale.md) |  | [optional] 
**OrderId** | **string** | Client Order ID if supplied by client. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

