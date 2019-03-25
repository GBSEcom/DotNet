# Org.OpenAPITools.Model.PaymentCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Payment card number | [optional] 
**ExpiryDate** | [**Expiration**](Expiration.md) |  | [optional] 
**SecurityCode** | **string** | Card Verification Value/Number | [optional] 
**PaymentTokenization** | [**PaymentTokenization**](PaymentTokenization.md) |  | [optional] 
**CardFunction** | **string** | Card function. Optional, valid values are CREDIT or DEBIT. | [optional] 
**CardholderName** | **string** | Name of the cardholder on the card | [optional] 
**AuthenticationRequest** | [**AuthenticationRequest**](AuthenticationRequest.md) |  | [optional] 
**AuthenticationResult** | [**PaymentCardAuthenticationResult**](PaymentCardAuthenticationResult.md) |  | [optional] 
**Bin** | **string** | The payment card BIN | [optional] 
**Last4** | **string** | The last 4 payment card numbers | [optional] 
**Brand** | **string** | Optional, required only if using dual branded card | [optional] 
**IssuingCountry** | **string** | The issuing country | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

