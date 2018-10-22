# IO.Swagger.Model.PaymentCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Payment card number | 
**ExpiryDate** | [**Expiration**](Expiration.md) |  | [optional] 
**SecurityCode** | **string** | CVV | [optional] 
**CardFunction** | **string** |  | [optional] [default to CardFunctionEnum.CREDITEnum]
**CardholderName** | **string** |  | [optional] 
**AuthenticationRequest** | [**PaymentCardAuthenticationRequest**](PaymentCardAuthenticationRequest.md) |  | [optional] 
**AuthenticationResult** | [**PaymentCardAuthenticationResult**](PaymentCardAuthenticationResult.md) |  | [optional] 
**Brand** | **string** | Optional, required only if using dual branded card | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

