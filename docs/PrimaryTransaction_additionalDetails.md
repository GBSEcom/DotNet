# Org.OpenAPITools.Model.PrimaryTransactionAdditionalDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceNumber** | **string** | For FORCED_TICKET only. Stores the six digit reference number you have received as the result of a successful external authorization (e.g. by phone). The Gateway needs this number for uniquely mapping a ForcedTicket transaction to a previously performed external authorization.]  | [optional] 
**Comments** | **string** | Comments for the payment | [optional] 
**DynamicMerchantName** | **string** | The name of sub-merchant for the payment facilitator | [optional] 
**InvoiceNumber** | **string** | Invoice number | [optional] 
**PurchaseOrderNumber** | **string** | Purchase order number | [optional] 
**RecurringType** | **string** | Valid values are &#39;FIRST&#39;, &#39;REPEAT&#39; and &#39;STANDING_INSTRUCTION&#39;. | [optional] 
**InstallmentOptions** | [**InstallmentOptions**](InstallmentOptions.md) |  | [optional] 
**Mcc** | **string** | Use this field to override merchant configured MCC value | [optional] 
**Dcc** | [**Dcc**](Dcc.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

