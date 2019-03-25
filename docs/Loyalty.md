# Org.OpenAPITools.Model.Loyalty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique ID associated with the loyalty program account. Must be unique within the merchants system. Depending on loyalty programs the account might also serve as a credit/bank account. If this is the case the ID must be not be the PAN. | [optional] 
**Program** | **string** | A string that identifies the program in which the customer is enrolled if the merchant supports several programs or levels. | [optional] 
**Balance** | **decimal?** | The balance of the loyalty program account in a program specific currency (e.g. points). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

