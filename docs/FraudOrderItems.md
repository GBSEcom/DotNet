# Org.OpenAPITools.Model.FraudOrderItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique ID associated with the product. Must be unique within the merchant&#39;s system. | [optional] 
**Name** | **string** | A name or short description of the product. | [optional] 
**Quantity** | **string** | The unit in which the product is sold (e.g. litre, kilogram, etc). Leave empty if the product is sold as a complete unit. | [optional] 
**Unit** | **decimal?** | The number of units sold. Set to 1 if there is only one unit of the item. Leave empty if the quantity is unknown at the time of the request. | [optional] 
**UnitPrice** | **string** | The price per unit. | [optional] 
**Categories** | **string** | The categories that this product belongs to. | [optional] 
**DetailsUrl** | **string** | The URL to the merchant&#39;s management system, for reporting and analysis. | [optional] 
**UserDefined** | [**Object**](.md) | A JSON object that can carry any additional information about the order that might be helpful for fraud detection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

