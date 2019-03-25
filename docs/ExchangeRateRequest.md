# Org.OpenAPITools.Model.ExchangeRateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of exchange rate inquiry. Valid values are &#39;DCC&#39; and &#39;DYNAMIC_PRICING&#39;. | 
**StoreId** | **string** | An optional Outlet ID for clients that support multiple stores in the same app. | [optional] 
**Bin** | **string** | A bank identification number (BIN) of the card to be used for DCC. | [optional] 
**BaseAmount** | **decimal?** | The original amount of the merchant currency for calculation. | 
**ForeignCurrency** | **string** | The currency code to convert for Dynamic Pricing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

