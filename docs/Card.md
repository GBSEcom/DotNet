# Org.OpenAPITools.Model.Card
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaToken** | **string** | TransArmor token value. Either the token fields or card number field must contain a value. | [optional] 
**TaTokenKey** | **string** | TransArmor token key to identify the merchant. | [optional] 
**CardholderName** | **string** | The cardholder name as it appears on the card. | [optional] 
**CardNumber** | **string** | Use this field to send clear PAN or tokens other than TransArmor Token. | [optional] 
**ExpDate** | **string** | Payment method expiration date. Format is MMYYYY. | [optional] 
**Cvv** | **string** | CVV present indicator. | [optional] 
**Issuer** | **string** | The company (usually a bank) that issued the card. | [optional] 
**CardReissuedNumber** | **string** | A number that distinguishes between two plastic cards with the same card number in the event of the card being re-issued. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

