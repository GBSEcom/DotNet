# Org.OpenAPITools.Model.PaymentTokenDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | Client-supplied payment token value. Only applicable for DataVault tokenization scheme. | [optional] 
**Reusable** | **bool?** | If the token is reusable. | [optional] [default to true]
**DeclineDuplicates** | **bool?** | Decline duplicate payment info if client token is supplied. | [optional] [default to false]
**Last4** | **string** | The last 4 numbers of a payment card. | [optional] 
**Brand** | **string** | Card brand, only for tokenization with payment. | [optional] 
**AccountVerification** | **bool?** | If the account the token was created from has been verified. | [optional] 
**Type** | **string** | Inidcates the type of tokenization source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

