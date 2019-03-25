# Org.OpenAPITools.Model.Merchant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mcc** | **string** | The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction. | [optional] 
**MerchantUniqueId** | **string** | The unique ID of this merchant. Must be unique for the entire system (not just within a specific industry). | 
**Location** | [**MerchantLocation**](MerchantLocation.md) |  | [optional] 
**UserDefined** | [**Object**](.md) | A JSON object that can carry any additional information about the merchant that might be helpful for fraud detection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

