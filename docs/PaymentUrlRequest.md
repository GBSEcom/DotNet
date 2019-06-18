# Org.OpenAPITools.Model.PaymentUrlRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** | An optional Outlet ID for clients that support multiple stores in the same developer app. | [optional] 
**ClientLocale** | [**ClientLocale**](ClientLocale.md) |  | [optional] 
**TransactionAmount** | [**Amount**](Amount.md) |  | [optional] 
**TransactionType** | [**TransactionType**](TransactionType.md) |  | 
**OrderId** | **string** | Client order ID if supplied by client, otherwise the order ID. | [optional] 
**Billing** | [**Billing**](Billing.md) |  | [optional] 
**Shipping** | [**Shipping**](Shipping.md) |  | [optional] 
**TransactionNotificationURL** | **string** | URL for notifying merchant of payment result. | [optional] 
**Expiration** | **long?** | Time until payment URL expires. | [optional] 
**AuthenticateTransaction** | **bool?** | If 3D secure should be applied. | [optional] 
**DynamicMerchantName** | **string** | Dynamic merchant name for the cardholder&#39;s statement. | [optional] 
**InvoiceNumber** | **string** | Invoice number. | [optional] 
**PurchaseOrderNumber** | **string** | Purchase order number. | [optional] 
**Ip** | **string** | IPv4 or IPv6 network address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

